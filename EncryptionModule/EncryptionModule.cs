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
            const int keySize = 32; //Размер ключа 32 байта (256 бит)
            int iterations = int.Parse(metaIterations);

            //=============================== Создание ключа =========================================
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
            {
                key = pbkdf2.GetBytes(32); //AES-256 ключ
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
        }
        public static string getSalt()
        {
            byte[] salt = new byte[16]; //Массив для хранения соли
            RandomNumberGenerator.Fill(salt); //Заполнение соли
            return Convert.ToBase64String(salt); //Возвращает соль в виде строки
        }
    }
}