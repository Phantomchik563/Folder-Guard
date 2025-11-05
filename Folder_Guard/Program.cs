using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
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

        static async void Update()
        {
            try
            {
                string tempPath = Path.GetTempFileName() + ".zip";
                string appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                var response = await httpClient.GetAsync("https://folder-guard.24hdm.ru/Program/Download/Update/Update.zip");
                var contentStream = await response.Content.ReadAsStreamAsync();
                var fileStream = File.Create(tempPath);

                await contentStream.CopyToAsync(fileStream);

                ZipFile.ExtractToDirectory(tempPath, appPath);
                File.Delete(tempPath);

                Application.Restart();
                Environment.Exit(0);
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
                    var result = MessageBox.Show
                    (
                        $"Доступна версия {serverVersion} (у вас {localVersion}).\n\nЗагрузить обновление?",
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
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            checkUpdate();

            Application.Run(new FormMain());
        }
    }
}
