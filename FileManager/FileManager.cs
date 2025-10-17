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
        public static List<string> getVaults() // Метод, возвращающий список хранилищ
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
        public static int createVault(string vaultName, string vaultPassword) // Метод, создающий хранилище (Возвратные коды: 0 - всё ок; 1 - в названии недопустимые символы; 2 - такое имя уже есть в списке)
        {
            char[] exeptionChars = {'\\', '|', '/', '?', '\'', '*', ':', '<', '>'}; // Список недопустимых символов
            foreach(char c in vaultName)
            {
                if (exeptionChars.Contains(c)) return 1; // Проверка на недопустимые символы
            }
            List<string> vaults = getVaults();
            if (vaults.Contains(vaultName)) return 2; // Проверка на повторяющиеся хранилища

            //Позже реализую создание файлов...

            return 0;
        }
    }
}
