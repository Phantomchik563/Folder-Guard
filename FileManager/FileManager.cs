using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public static class Vault
    {
        private struct metaFile
        {
            string salt;
            int iterationCount;

        }
        public static List<string> GetVaults() // Метод, возвращающий список хранилищ
        {
            List<string> vaults = new List<string>();
            if (Directory.Exists("Vaults") == false) Directory.CreateDirectory(@"Vaults\");

            string[] vaultFolders = Directory.GetDirectories(@"Vaults\");
            foreach (string dir in vaultFolders)
            {
                vaults.Add(dir);
            }

            return vaults;
        }
        public static int CreateVault(string vaultName, string vaultPassword) // Метод, создающий хранилище (Возвратные коды: 0 - всё ок; 1 - в названии недопустимые символы; 2 - такое имя уже есть в списке)
        {
            char[] exeptionChars = {'\\', '|', '/', '?', '\'', '*', ':', '<', '>'}; // Список недопустимых символов
            foreach(char c in vaultName)
            {
                if (exeptionChars.Contains(c)) return 1; // Проверка на недопустимые символы
            }
            List<string> vaults = GetVaults();
            if (vaults.Contains(vaultName)) return 2; // Проверка на повторяющиеся хранилища

            

            Directory.CreateDirectory(@"Vaults\" + vaultName);
            string salt = EncryptionModule.Encryption.GetSalt();


            return 0;
        }
    }
}
