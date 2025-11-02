using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public static class General
    {
        public static int checkNameForEx(string name) // Приватный метод для проверки имени на правильность
        {
            char[] exeptionChars = { '\\', '|', '/', '?', '\'', '*', ':', '<', '>', '"', '\0' }; // Список недопустимых символов
            string[] exeptionNames = { "con", "prn", "aux", "nul", "com0", "com1", "com2", "com3", "com4", "com5", "com6", "com7", "com8", "com9", "lpt0", "lpt1", "lpt2", "lpt3", "lpt4", "lpt5", "lpt6", "lpt7", "lpt8", "lpt9" }; // Список недопустимых имен
            foreach (char c in name)
            {
                if (exeptionChars.Contains(c)) return 1; // Проверка на недопустимые символы
            }
            for (int i = 0; i < exeptionNames.Length; i++)
            {
                if (name == exeptionNames[i]) return 2; // Проверка на недопустимые имена
            }
            if (name[0] == '~' && name[1] == '$') return 3; // Проверка на ~$ в начале
            else return 0;
        }
    }
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
            int exCode = General.checkNameForEx(vaultName); // --------- > Проверка на правильность имени
            if (exCode == 1) return 1; //         Недопустимые символы   |
            else if (exCode == 2) return 2; //         Недопустимое имя  |
            else if (exCode == 3) return 3; //         ~$ в начале имени |

            List<string> vaults = GetVaults();
            if (vaults.Contains(vaultName)) return 4; // Проверка на повторяющиеся хранилища

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
            FileInfo fileInfo = new FileInfo(@"Vaults\\" + vaultName + @"\\meta.dat");
            fileInfo.Attributes |= FileAttributes.Hidden;

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

        public static List<string> GetMeta(string vaultName) // Выдает массив с данными метафайла
        {
            using (BinaryReader reader = new BinaryReader(File.Open(@"Vaults\\" + vaultName + @"\\meta.dat", FileMode.Open)))
            {
                string salt = reader.ReadString();
                int iterationCount = reader.ReadInt32();
                string version = reader.ReadString();
                string hmac = reader.ReadString();

                List<string> outMetaInfo = new List<string>();
                outMetaInfo.Add(salt);
                outMetaInfo.Add(iterationCount.ToString());
                outMetaInfo.Add(version);
                return outMetaInfo; // соль, количество итераций, версия
            }
        }

        public static int VaultDelete(string vaultName) // Удаление хранилища со всем содержимым
        {
            if (Directory.Exists(@"Vaults\" + vaultName))
            {
                Directory.Delete(@"Vaults\" + vaultName);
                return 0;
            }
            else return 1;
        }

        public static int VaultRename(string vaultName, string newVaultName) // Переименование хранилища
        {
            if (Directory.Exists(@"Vaults\" + vaultName))
            {
                int exCode = General.checkNameForEx(newVaultName); // ------ > Проверка на правильность имени
                if (exCode == 1) return 1; //         Недопустимые символы   |
                else if (exCode == 2) return 2; //         Недопустимое имя  |
                else if (exCode == 3) return 3; //         ~$ в начале имени |
                Directory.Move(@"Vaults\" + vaultName, @"Vaults\" + newVaultName);
                return 0;
            }
            else return 4;
        }

        public static int VaultExport(string vaultName, string outputPath) // Экспорт хранилища в формате .zip
        {
            if (Directory.Exists(@"Vaults\" + vaultName))
            {
                ZipFile.CreateFromDirectory(@"Vaults\" + vaultName, outputPath);
                return 0;
            }
            else return 1;
        }

        public static int VaultImport(string inputPath) // Импорт хранилища из .zip файла
        {
            if (File.Exists(inputPath) && inputPath.EndsWith(".zip"))
            {
                string[] pathParts = inputPath.Split('\\');
                string name = pathParts[pathParts.Length - 1].Substring(0, pathParts[pathParts.Length - 1].Length - 4);
                ZipFile.ExtractToDirectory(inputPath, @"Vaults\" + name);
                return 0;
            }
            else return 1;
        }
    }


    public static class VaultFile
    {
        public static int FileRename(string vaultName, string fileName, string newName) // Переименоване файла в хранилище
        {
            if (File.Exists(@"Vaults\" + vaultName + '\\' + fileName))
            {
                int exCode = General.checkNameForEx(newName); // ------ > Проверка на правильность имени
                if (exCode == 1) return 1; //         Недопустимые символы   |
                else if (exCode == 2) return 2; //         Недопустимое имя  |
                else if (exCode == 3) return 3; //         ~$ в начале имени |

                string[] filenameParts = fileName.Split('.');
                string outName = newName + '.' + filenameParts[filenameParts.Length - 2] + '.' + filenameParts[filenameParts.Length - 1];
                File.Move(@"Vaults\" + vaultName + '\\' + fileName, @"Vaults\" + vaultName + '\\' + outName);
                return 0;
            }
            else return 4;
        }

        public static int FileDelete(string vaultName, string fileName) // Удаление файла из хранилища
        {
            if (File.Exists(@"Vaults\" + vaultName + '\\' + fileName))
            {
                File.Delete(@"Vaults\" + vaultName + '\\' + fileName);
                return 0;
            }
            else return 1;
        }
    }
}
