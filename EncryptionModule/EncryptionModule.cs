using System;
using System.IO; 
using System.Security.Cryptography;

namespace EncryptionModule
{
    public class Encryption
    {
        public static int EncryptFile(string inputPath, string outputPath, string metaSalt, int metaIterations, string password)
        {
            try
            {

                byte[] salt = Convert.FromBase64String(metaSalt);
                byte[] key;
                int iterations = metaIterations;
                byte[] hmacKey;
                string fileName = Path.GetFileName(inputPath);
                byte[] fileNameBytes = System.Text.Encoding.UTF8.GetBytes(fileName);


                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
                {
                    key = pbkdf2.GetBytes(32); // AES-256 ключ
                    hmacKey = pbkdf2.GetBytes(32); // HMAC-ключ
                }
                //Rfc2898DeriveBytes - класс для реализации PBKDF2 
                //HashAlgorithmName.SHA256 - использование алгоритма SHA-256


                using (Aes aes = Aes.Create()) //aes - переменная типа Aes
                {
                    aes.KeySize = 256;
                    aes.Key = key;
                    aes.GenerateIV(); //случайный IV
                    aes.Mode = CipherMode.CBC; //Режим шифрования (В CBC каждый блок зависит от предыдущего)
                    aes.Padding = PaddingMode.PKCS7; //Увеличение размера блока до 16 байт


                    using (FileStream fsInput = new FileStream(inputPath, FileMode.Open, FileAccess.Read))
                    using (FileStream fsOutput = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                    {
                        fsOutput.WriteByte((byte)fileNameBytes.Length); //1 байт для длины имени
                        fsOutput.Write(fileNameBytes, 0, fileNameBytes.Length); //Имя файла
                        fsOutput.Write(aes.IV, 0, aes.IV.Length); //Ввод IV в начало файла
                        using (CryptoStream cryptoStream = new CryptoStream(fsOutput, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            fsInput.CopyTo(cryptoStream); //Копирование содержимого файла в поток шифрования cryptoStream
                            cryptoStream.FlushFinalBlock();
                        }
                    }
                }

                using (var hmac = new HMACSHA256(hmacKey))
                using (FileStream fsEncrypted = new FileStream(outputPath, FileMode.Open, FileAccess.ReadWrite))
                {
                    byte[] hash = hmac.ComputeHash(fsEncrypted); //Чтение файла
                    fsEncrypted.Seek(0, SeekOrigin.End); //Переход в конец файла
                    fsEncrypted.Write(hash, 0, hash.Length); //запись HMAC в конец файла
                }
                return 0; //Файл успешно зашифрован
            }
            catch (IOException)
            {
                return 1; //Ошибка чтения/записи
            }
            catch (CryptographicException)
            {
                return 2; //Ошибка шифрования файла
            }
            catch (Exception)
            {
                return 3; //Неизвестная ошибка
            }
        }
        public static int Decode(string metaSalt, string inputPath, string outputPath, int metaIterations, string password)
        {
            try
            {
                byte[] salt = Convert.FromBase64String(metaSalt);
                byte[] key;
                int iterations = metaIterations;
                byte[] hmacKey;


                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
                {
                    key = pbkdf2.GetBytes(32); // AES-256 ключ
                    hmacKey = pbkdf2.GetBytes(32); // HMAC-ключ
                }

                Console.OutputEncoding = System.Text.Encoding.UTF8;
                System.Windows.Forms.MessageBox.Show("inputPath: " + inputPath);
                System.Windows.Forms.MessageBox.Show("File.Exists: " + File.Exists(inputPath));
                System.Windows.Forms.MessageBox.Show("Full path: " + Path.GetFullPath(inputPath));

                byte[] fileBytes = File.ReadAllBytes(inputPath);
                byte[] storedHmac = new byte[32];
                if (fileBytes.Length < 48) //Проверка длины файла: IV, имя, HMAC
                    return 5; // Файл поврежден
                Array.Copy(fileBytes, fileBytes.Length - 32, storedHmac, 0, 32);


                byte[] encryptedData = new byte[fileBytes.Length - 32];
                Array.Copy(fileBytes, 0, encryptedData, 0, encryptedData.Length);


                using (var hmac = new HMACSHA256(hmacKey))
                {
                    byte[] computedHmac = hmac.ComputeHash(encryptedData);
                    for (int i = 0; i < storedHmac.Length; i++)
                        if (storedHmac[i] != computedHmac[i]) return 1; //HMAC не совпал
                }


                using (MemoryStream ms = new MemoryStream(encryptedData))
                {
                    int nameLength = ms.ReadByte(); //Считать длину имени файла
                    if (nameLength <= 0 || nameLength > 255)
                        return 5; // Ошибка структуры файла
                    byte[] nameBytes = new byte[nameLength];
                    ms.Read(nameBytes, 0, nameLength); //Считать имя файла
                    string originalFileName = System.Text.Encoding.UTF8.GetString(nameBytes); //Хранит имя файла


                    byte[] iv = new byte[16];
                    ms.Read(iv, 0, iv.Length); //Считать IV


                    using (Aes aes = Aes.Create())
                    {
                        aes.KeySize = 256;
                        aes.Key = key;
                        aes.IV = iv;
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.PKCS7;


                        using (CryptoStream cryptoStream = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                        using (FileStream fsOutput = new FileStream(Path.Combine(outputPath, originalFileName), FileMode.Create, FileAccess.Write))
                        {
                            cryptoStream.CopyTo(fsOutput);
                            cryptoStream.FlushFinalBlock();
                        }
                    }
                }


                return 0; //Файл расшифрован
            }
            catch (IOException)
            {
                return 2; //Ошибка чтения/записи
            }
            catch (CryptographicException)
            {
                return 3; //Ошибка дешифрования файла
            }
            catch (Exception)
            {
                return 4; //Неизвестная ошибка
            }
        }
        public static string GetSalt()
        {
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }
        public static string GetHmac(string metaSalt, int metaIterations, string password)
        {
            byte[] salt = Convert.FromBase64String(metaSalt);
            int iterations = metaIterations;
            byte[] hmacKey;
            byte[] hash;

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
            {
                hmacKey = pbkdf2.GetBytes(32); // HMAC-ключ
            }

            using (var hmac = new HMACSHA256(hmacKey))
            {
                hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
            return Convert.ToBase64String(hash);
        }
    }
}