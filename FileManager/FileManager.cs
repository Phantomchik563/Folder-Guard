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
            public string version;

            public MetaFile(string salt, int iterationCount, string version) : this()
            {
                this.salt = salt;
                this.iterationCount = iterationCount;
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
            string[] vaultFiles = Directory.GetDirectories(@"Vaults\" + vault);
            foreach (string file in vaultFiles)
            {
                string[] fileParts = file.Split('.');
                if (fileParts[fileParts.Length - 1] == ".sf") files.Add(file);
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
            MetaFile metaFile = new MetaFile(salt, iterationCount, ver);
            using (BinaryWriter binWriter = new BinaryWriter(File.Open(@"Vaults\\" + vaultName + @"\\meta.dat", FileMode.OpenOrCreate)))
            {
                binWriter.Write(metaFile.salt);
                binWriter.Write(metaFile.iterationCount);
                binWriter.Write(metaFile.version);
            }

            return 0;
        }
        public static int ImportToVault(string vaultName, string filePath, int iterationCount) // 
        {
            

            return 0;
        }
    }
}
