using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folder_Guard
{

    internal static class Program
    {
        private static readonly HttpClient httpClient = new HttpClient();
        public static void ShowTextProgress(int percentage, string operation = "Загрузка")
        {
            string progressBar = $"[{new string('█', percentage / 5)}{new string('░', 20 - percentage / 5)}]";
            MessageBox.Show($"{operation}\n{progressBar} {percentage}%", "Прогресс",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static async Task<bool> InternetСheck()
        {
            HttpClient httpClient = new HttpClient();
            string[] checkURLs = {
            "http://www.gstatic.com/generate_204",  
            "http://www.microsoft.com/en-us/",     
            "http://www.cloudflare.com/",         
            "http://www.apple.com/library/test/success.html", 
            "http://captive.apple.com/hotspot-detect.html"    
            };

            foreach (var url in checkURLs)
            {
                try
                {
                    var response = await httpClient.GetAsync(url);
                    return true; // Любой ответ = интернет есть
                }
                catch
                {
                    continue; // Пробуем следующий
                }
            }
            return false;
        }
        static void CreateSimpleUpdateBat(string zipPath, string appPath, string currentExe)
        {
            string batContent = $@"
@echo off
chcp 65001 > nul

echo Ожидаем закрытия приложения...
:wait
tasklist | find ""{Path.GetFileName(currentExe)}"" > nul
if %errorlevel% == 0 (
    timeout /t 1 /nobreak > nul
    goto wait
)

echo Распаковываем обновление...
powershell -command ""Expand-Archive -Path '{zipPath}' -DestinationPath '{appPath}' -Force""

echo Запускаем новую версию...
start """" ""{Path.Combine(appPath, Path.GetFileName(currentExe))}""

echo Удаляем временные файлы...
del ""{zipPath}"" > nul 2>&1
del ""%~f0"" > nul 2>&1
";

            File.WriteAllText("update.bat", batContent, new UTF8Encoding(false));
        }

        static async void Update()
        {
            try
            {
                string tempPath = "updateTmp" + ".zip";
                string appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string currentExe = Assembly.GetExecutingAssembly().Location;

                using (var response = await httpClient.GetAsync("https://folder-guard.24hdm.ru/Program/Download/Update/Update.zip"))
                using (var contentStream = await response.Content.ReadAsStreamAsync())
                using (var fileStream = File.Create(tempPath))
                {
                    await contentStream.CopyToAsync(fileStream);
                }
                //DeleteOldFiles(appPath);
                //ZipFile.ExtractToDirectory(tempPath, appPath);
                //ExtractWithOverwrite(tempPath, appPath);
                //File.Delete(tempPath);

                // Создаем BAT файл для замены EXE
                CreateSimpleUpdateBat(tempPath, appPath, currentExe);

                // Запускаем BAT и закрываем приложение
                Process.Start(new ProcessStartInfo
                {
                    FileName = "update.bat",
                    WindowStyle = ProcessWindowStyle.Hidden
                });

                Application.Exit();

                //Application.Restart();
                //Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}\n\nПопробуйте обновить приложение вручную.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static async void checkUpdate()
        {
            if (await InternetСheck())
            {
                WebClient webClient = new WebClient();
                Version localVersion = Assembly.GetExecutingAssembly().GetName().Version;
                Version serverVersion = Version.Parse(webClient.DownloadString("https://folder-guard.24hdm.ru/Program/Download/Update/Version.txt"));

                if (serverVersion > localVersion)
                {
                    string serverVer = serverVersion.ToString();
                    serverVer = serverVer.Substring(0, serverVer.Length - 2);
                    string localVer = localVersion.ToString();
                    localVer = localVer.Substring(0, localVer.Length - 2);

                    var result = MessageBox.Show
                    (
                        $"Доступна версия {serverVer} (у вас {localVer}).\n\nЗагрузить обновление?",
                        "Доступно обновление",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                    if(result == DialogResult.Yes)
                    {
                        Update();
                    }
                }
            }
        }

        
        /// <summary>
        /// Главная точка входа для приложения
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            checkUpdate();

            Application.Run(new FormMain());
        }
    }
}
