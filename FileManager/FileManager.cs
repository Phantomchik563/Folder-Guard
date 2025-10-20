using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public static class Vault
    {
        struct MetaFile
        {
            public string salt;
            public int iterationCount;
            public string hmac;
            public string version;
            public MetaFile(string salt, int iterationCount, string version, string hmac) : this()
            {
                this.salt = salt;
                this.iterationCount = iterationCount;
                this.hmac = hmac;
                this.version = version;
            }
        }
        public static List<string> GetVaults() // Метод, возвращающий список хранилищ
        {
            List<string> vaults = new List<string>();
            if (Directory.Exists("Vaults") == false) Directory.CreateDirectory(@"Vaults");

            string[] vaultFolders = Directory.GetDirectories(@"Vaults");
            foreach (string dir in vaultFolders)
            {
                string[] dirParts = dir.Split('\\');
                vaults.Add(dirParts[dirParts.Length - 1]);
            }
            return vaults;
        }
        public static List<string> GetVaultFiles(string vault) // Метод, возвращающий список файлов в хранилище
        {

            List<string> files = new List<string>();
            string[] vaultFiles = Directory.GetFiles(@"Vaults\" + vault);
            foreach (string file in vaultFiles)
            {
                string[] fileParts = file.Split('.');
                if (fileParts[fileParts.Length - 1] == "sf")
                {
                    string[] filePathParts = file.Split('\\');
                    files.Add(filePathParts[filePathParts.Length - 1]);
                }
            }
            return files;
        }
        public static int CreateVault(string vaultName, string vaultPassword, int iterationCount) // Метод, создающий хранилище (Возвратные коды: 0 - всё ок; 1 - в названии недопустимые символы; 2 - такое имя уже есть в списке)
        {
            char[] exeptionChars = {'\\', '|', '/', '?', '\'', '*', ':', '<', '>', '"'}; // Список недопустимых символов
            foreach(char c in vaultName)
            {
                if (exeptionChars.Contains(c)) return 1; // Проверка на недопустимые символы
            }
            List<string> vaults = GetVaults();
            if (vaults.Contains(vaultName)) return 2; // Проверка на повторяющиеся хранилища

            Directory.CreateDirectory(@"Vaults\\" + vaultName); // Создание директории хранилища

            string ver = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string salt = EncryptionModule.Encryption.GetSalt();
            string hmac = EncryptionModule.Encryption.GetHmac(salt, iterationCount, vaultPassword);
            MetaFile metaFile = new MetaFile(salt, iterationCount, hmac, ver);
            using (BinaryWriter binWriter = new BinaryWriter(File.Open(@"Vaults\\" + vaultName + @"\\meta.dat", FileMode.OpenOrCreate)))
            {
                binWriter.Write(metaFile.salt);
                binWriter.Write(metaFile.iterationCount);
                binWriter.Write(metaFile.hmac);
                binWriter.Write(metaFile.version);
            }

            return 0;
        }
        public static int GetAccessToVault(string vaultName, string password) // Метод, разрешающий или запрещающий доступ к хранилищу
        {
            if (File.Exists(@"Vaults\\" + vaultName + @"\\meta.dat")) // Проверка на наличие метафайла
            {
                using (BinaryReader reader = new BinaryReader(File.Open(@"Vaults\\" + vaultName + @"\\meta.dat", FileMode.Open)))
                {
                    string salt = reader.ReadString();
                    int iterationCount = reader.ReadInt32();
                    string version = reader.ReadString();
                    string hmac = reader.ReadString();
                    string userHmac = EncryptionModule.Encryption.GetHmac(salt, iterationCount, password);
                    if (userHmac == hmac) return 0; // Сравнение заданного и введенного пароля
                    else return 1;
                }
            }
            else return 2;
        }
        public static int ImportToVault(string vaultName, string filePath, int iterationCount) // 
        {
            

            return 0;
        }
    }
}
