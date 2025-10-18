using System; using System.IO; using System.Security.Cryptography;

namespace EncryptionModule
{
    public class Encryption
    {
        public void EncryptFile(string inputPath, string outputPath, string metaSalt, string metaIterations, string password)
        {
            //=============================== Обработка входных данных ===============================
            byte[] salt = Convert.FromBase64String(metaSalt);
            byte[] key; //Массив для ключа
            int iterations = int.Parse(metaIterations);
            byte[] hmacKey;

            //=============================== Создание ключей =========================================
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
            {
                key = pbkdf2.GetBytes(32); // AES-256 ключ
                hmacKey = pbkdf2.GetBytes(32); // HMAC-ключ
            }
            //Rfc2898DeriveBytes - класс для реализации PBKDF2 
            //HashAlgorithmName.SHA256 - использование алгоритма SHA-256

            //=============================== Создание AES-объекта ===================================
            using (Aes aes = Aes.Create()) //aes - переменная типа Aes
            {
                aes.KeySize = 256;
                aes.Key = key;
                aes.GenerateIV(); //случайный IV
                aes.Mode = CipherMode.CBC; //Режим шифрования (В CBC каждый блок зависит от предыдущего)
                aes.Padding = PaddingMode.PKCS7; //Увеличение размера блока до 16 байт

                //===========================Шифрование=============================================
                using (FileStream fsInput = new FileStream(inputPath, FileMode.Open, FileAccess.Read))
                using (FileStream fsOutput = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                {
                    fsOutput.Write(aes.IV, 0, aes.IV.Length); //Ввод IV в начало файла
                    using (CryptoStream cryptoStream = new CryptoStream(fsOutput, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        fsInput.CopyTo(cryptoStream); //Копирование содержимого файла в поток шифрования cryptoStream
                    }
                }
            }
            //=========================== Добавляем HMAC =========================================
            using (var hmac = new HMACSHA256(hmacKey))
            using (FileStream fsEncrypted = new FileStream(outputPath, FileMode.Open, FileAccess.ReadWrite))
            {
                byte[] hash = hmac.ComputeHash(fsEncrypted); //Чтение файла
                fsEncrypted.Seek(0, SeekOrigin.End); //Переход в конец файла
                fsEncrypted.Write(hash, 0, hash.Length); //запись HMAC в конец файла
            }
        }
        public static string GetSalt()
        {
            byte[] salt = new byte[16]; //Массив для хранения соли
            RandomNumberGenerator.Fill(salt); //Заполнение соли
            return Convert.ToBase64String(salt); //Возвращает соль в виде строки
        }
    }
}