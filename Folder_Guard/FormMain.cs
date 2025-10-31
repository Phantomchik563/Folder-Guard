using FileManager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Folder_Guard
{
    public partial class FormMain : Form
    {

        public string password = null;
        public string openedVault = null;

        private Timer fadeTimer;
        private Control[] uiElements;

        // Выбранный файл
        private string selectedFilePath = "";

        public FormMain()
        {
            InitializeComponent();
            Themes();
            UpdateListViewStorage(FileManager.Vault.GetVaults());

            

            // Список элементов, которые будут плавно появлятьс
            buttonCode.Enabled = false;
            buttonCode.BackgroundImage = Properties.Resources.logo_open_alt1;
            buttonAddStorage.Enabled = false;
            buttonAddStorage.BackgroundImage = Properties.Resources.file_add_alt1;
            buttonUnCode.Enabled = false;
            buttonUnCode.BackgroundImage = Properties.Resources.file_deshifrovat_alt1;
            button6.Enabled = false;
            button6.BackgroundImage = Properties.Resources.file_rename_alt1;
            buttonDelStorage.Enabled = false;
            buttonDelStorage.BackgroundImage = Properties.Resources.file_delete_alt1;

            button3.Enabled = false;
            button3.BackgroundImage = Properties.Resources.logo_delte_alt1;
            button5.Enabled = false;
            button5.BackgroundImage = Properties.Resources.logo_ecsport_alt1;
            buttonCreateStorage.Enabled = false;
            buttonCreateStorage.BackgroundImage = Properties.Resources.logo_rename_alt3;

            uiElements = new Control[]
            {
                buttonCreateStorage,
                buttonAddStorage,
                buttonCode,
                buttonDelStorage,
                panelFiles,

            };

            foreach (var c in uiElements)
                c.Visible = false;

            this.Opacity = 0;
            this.Load += FormMain_Load;




        }

        

        private void FormMain_Load(object sender, EventArgs e)
        {
            fadeTimer = new Timer();
            fadeTimer.Interval = 20;
            int steps = 30;
            int currentStep = 0;

            fadeTimer.Tick += (s, ev) =>
            {
                currentStep++;
                float progress = currentStep / (float)steps;
                float ease = (float)(progress < 0.5
                    ? 2 * progress * progress
                    : -1 + (4 - 2 * progress) * progress);

                this.Opacity = ease;

                foreach (var c in uiElements)
                    if (!c.Visible) c.Visible = true;

                if (currentStep >= steps)
                    fadeTimer.Stop();
            };

            fadeTimer.Start();

            toolTip1.AutoPopDelay = 5000;   // Время отображения (мс)
            toolTip1.InitialDelay = 500;    // Задержка перед показом
            toolTip1.ReshowDelay = 200;     // Время между повторными показами
            toolTip1.ShowAlways = true;     // Показывать даже если форма неактивна

            toolTip1.SetToolTip(buttonCreateStorage, "Переименовать хранилище");
            toolTip1.SetToolTip(button2, "Создать хранилище");
            toolTip1.SetToolTip(button3, "Удалить хранилище");
            toolTip1.SetToolTip(button4, "Импортировать хранилище");
            toolTip1.SetToolTip(button5, "Экспортировать хранилище");

            toolTip1.SetToolTip(buttonCode, "Открыть хранилище");
            toolTip1.SetToolTip(button6, "Переименовать файл");
            toolTip1.SetToolTip(buttonDelStorage, "Удалить файл");
            toolTip1.SetToolTip(buttonAddStorage, "Импортировать файл");
            toolTip1.SetToolTip(buttonUnCode, "Экспортировать файл");
            toolTip1.SetToolTip(buttonSetting, "Настройки");
            toolTip1.SetToolTip(buttonHelp, "Помощь");
            toolTip1.SetToolTip(button1, "О программе");
        }

        // =========================
        // Кнопка "Открыть хранилище"
        // =========================
        private void buttonCode_Click(object sender, EventArgs e)
        {

            using (var form = new FormCode(this))
            {
                if (listViewStorage.SelectedItems.Count > 0)
                {
                    form.StartPosition = FormStartPosition.CenterParent;
                    var selectedItem = listViewStorage.SelectedItems[0];
                    form.SelectedItemName = selectedItem.Text;
                    DialogResult dialogResult = form.ShowDialog(this);
                    if (openedVault == listViewStorage.SelectedItems[0].Text) 
                        checkAccessesToVault(listViewStorage.SelectedItems[0].Text);
                }
            }
        }

        // =========================
        // Создание хранилища
        // =========================
        private void buttonCreateStoragebutton_Click(object sender, EventArgs e)
        {

        }




        // =========================
        // Метод для обновления listViewStorage
        // =========================
        public void UpdateListViewStorage(List<string> items)
        {
            // Очищаем текущие элементы
            listViewStorage.Items.Clear();

            // Добавляем новые элементы
            foreach (var item in items)
            {
                ListViewItem listItem = new ListViewItem(item);
                listViewStorage.Items.Add(listItem);
            }
        }

        public void UpdateListViewStorageFiles(List<string> items)
        {
            listViewStorageFiles.Items.Clear();
            foreach (var item in items)
            {
                ListViewItem listItem = new ListViewItem(item);
                listViewStorageFiles.Items.Add(listItem);
            }
        }
        // =========================
        // Пример вызова метода из другого модуля
        // =========================



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listViewStorage.SelectedItems.Count > 0)
            {

                buttonCode.Enabled = true;
            }
            else
            {
                buttonCode.Enabled = false;
            }
        }





        void Themes()
        {
            switch (Properties.Settings.Default.Theme)
            {
                case 0: // Светлая тема
                    {
                        this.BackColor = Color.FromArgb(250, 250, 250);




                        pictureBox1.BackColor = Color.FromArgb(245, 245, 245);
                        buttonCreateStorage.BackColor = Color.FromArgb(255, 255, 255);
                        buttonCreateStorage.BackColor = Color.FromArgb(255, 255, 255);//Временная кнопка
                        buttonCreateStorage.ForeColor = Color.FromArgb(33, 33, 33);
                        buttonCode.BackColor = Color.FromArgb(255, 255, 255);
                        buttonCode.ForeColor = Color.FromArgb(33, 33, 33);

                        button1.BackColor = Color.FromArgb(255, 255, 255);
                        button1.ForeColor = Color.FromArgb(33, 33, 33);
                        button2.BackColor = Color.FromArgb(255, 255, 255);
                        button2.ForeColor = Color.FromArgb(33, 33, 33);
                        button3.BackColor = Color.FromArgb(255, 255, 255);
                        button3.ForeColor = Color.FromArgb(33, 33, 33);
                        button4.BackColor = Color.FromArgb(255, 255, 255);
                        button4.ForeColor = Color.FromArgb(33, 33, 33);
                        button5.BackColor = Color.FromArgb(255, 255, 255);
                        button5.ForeColor = Color.FromArgb(33, 33, 33);
                        button6.BackColor = Color.FromArgb(255, 255, 255);
                        button6.ForeColor = Color.FromArgb(33, 33, 33);

                        buttonAddStorage.BackColor = Color.FromArgb(255, 255, 255);
                        buttonAddStorage.ForeColor = Color.FromArgb(33, 33, 33);
                        buttonUnCode.BackColor = Color.FromArgb(255, 255, 255);
                        buttonUnCode.ForeColor = Color.FromArgb(33, 33, 33);
                        buttonDelStorage.BackColor = Color.FromArgb(255, 255, 255);
                        buttonDelStorage.ForeColor = Color.FromArgb(33, 33, 33);
                        buttonSetting.BackColor = Color.FromArgb(255, 255, 255);
                        buttonSetting.ForeColor = Color.FromArgb(33, 33, 33);
                        buttonHelp.BackColor = Color.FromArgb(255, 255, 255);
                        buttonHelp.ForeColor = Color.FromArgb(33, 33, 33);
                        listViewStorage.BackColor = Color.FromArgb(255, 255, 255);
                        listViewStorage.ForeColor = Color.FromArgb(33, 33, 33);
                        listViewStorageFiles.BackColor = Color.FromArgb(255, 255, 255);
                        listViewStorageFiles.ForeColor = Color.FromArgb(33, 33, 33);

                        
                        panelFiles.BackColor = Color.FromArgb(240, 240, 240);

                        break;
                    }

                case 1: // Тёмная тема
                    {


                        this.BackColor = Color.FromArgb(33, 33, 33);
                        pictureBox1.BackColor = Color.FromArgb(40, 40, 40); ; //(40, 40, 40)
                        buttonCreateStorage.BackColor = Color.FromArgb(33, 33, 33);

                        buttonCreateStorage.ForeColor = Color.FromArgb(255, 255, 255);
                        buttonCode.BackColor = Color.FromArgb(33, 33, 33);
                        buttonCode.ForeColor = Color.FromArgb(255, 255, 255);
                        buttonAddStorage.BackColor = Color.FromArgb(33, 33, 33);
                        buttonAddStorage.ForeColor = Color.FromArgb(255, 255, 255);
                        buttonUnCode.BackColor = Color.FromArgb(33, 33, 33);
                        buttonUnCode.ForeColor = Color.FromArgb(255, 255, 255);
                        buttonDelStorage.BackColor = Color.FromArgb(33, 33, 33);
                        buttonDelStorage.ForeColor = Color.FromArgb(255, 255, 255);
                        buttonSetting.BackColor = Color.FromArgb(33, 33, 33);
                        buttonSetting.ForeColor = Color.FromArgb(255, 255, 255);
                        buttonHelp.BackColor = Color.FromArgb(33, 33, 33);
                        buttonHelp.ForeColor = Color.FromArgb(255, 255, 255);
                        listViewStorage.BackColor = Color.FromArgb(33, 33, 33);
                        listViewStorage.ForeColor = Color.FromArgb(255, 255, 255);
                        listViewStorageFiles.BackColor = Color.FromArgb(33, 33, 33);
                        listViewStorageFiles.ForeColor = Color.FromArgb(255, 255, 255);

                        button1.BackColor = Color.FromArgb(33, 33, 33);
                        button1.ForeColor = Color.FromArgb(255, 255, 255);
                        button2.BackColor = Color.FromArgb(33, 33, 33);
                        button2.ForeColor = Color.FromArgb(255, 255, 255);
                        button3.BackColor = Color.FromArgb(33, 33, 33);
                        button3.ForeColor = Color.FromArgb(255, 255, 255);
                        button4.BackColor = Color.FromArgb(33, 33, 33);
                        button4.ForeColor = Color.FromArgb(255, 255, 255);
                        button5.BackColor = Color.FromArgb(33, 33, 33);
                        button5.ForeColor = Color.FromArgb(255, 255, 255);
                        button6.BackColor = Color.FromArgb(33, 33, 33);
                        button6.ForeColor = Color.FromArgb(255, 255, 255);

                        
                        panelFiles.BackColor = Color.FromArgb(40, 40, 40);

                        break;
                    }


            }
        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }

        private void panelFiles_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            using (var form = new FormCreateStorage(this))
            {
                form.ShowDialog(this); // 👈 Обязательно передаём "this" (главную форму)
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            using (var form = new FormRenameFiles())
            {
                form.ShowDialog(this); // 👈 Обязательно передаём "this" (главную форму)
            }
        }

        private void listViewStorageFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStorageFiles.SelectedItems.Count > 0)
            {
                {
                    button6.Enabled = true;
                }
            }
            else { button6.Enabled = false; }
        }

        private void listViewStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStorage.SelectedItems.Count > 0)
            {
                checkAccessesToVault(listViewStorage.SelectedItems[0].Text);
            }
        }
        private void checkAccessesToVault(string vault) // Проверка доступов к хранилищу и включение/выключение кнопок в зависимости от доступа
        {
            if (vault == openedVault) // Если хранилище ОТКРЫТО
            {
                buttonCode.Enabled = false;
                buttonCode.BackgroundImage = Properties.Resources.logo_open_alt1;
                buttonAddStorage.Enabled = true;
                buttonAddStorage.BackgroundImage = Properties.Resources.file_add;
                buttonUnCode.Enabled = true;
                buttonUnCode.BackgroundImage = Properties.Resources.file_deshifrovat;
                button6.Enabled = true;
                button6.BackgroundImage = Properties.Resources.file_ren;
                buttonDelStorage.Enabled = true;
                buttonDelStorage.BackgroundImage = Properties.Resources.file_delete;

                button3.Enabled = true;
                button3.BackgroundImage = Properties.Resources.logo_delte;
                button5.Enabled = true;
                button5.BackgroundImage = Properties.Resources.logo_ecsport;
                buttonCreateStorage.Enabled = true;
                buttonCreateStorage.BackgroundImage = Properties.Resources.logo_rename;
            }
            else // Если хранилище ЗАКРЫТО
            {
                buttonCode.Enabled = true;
                buttonCode.BackgroundImage = Properties.Resources.logo_open;
                buttonAddStorage.Enabled = false;
                buttonAddStorage.BackgroundImage = Properties.Resources.file_add_alt1;
                buttonUnCode.Enabled = false;
                buttonUnCode.BackgroundImage = Properties.Resources.file_deshifrovat_alt1;
                button6.Enabled = false;
                button6.BackgroundImage = Properties.Resources.file_rename_alt1;
                buttonDelStorage.Enabled = false;
                buttonDelStorage.BackgroundImage = Properties.Resources.file_delete_alt1;

                button3.Enabled = false;
                button3.BackgroundImage = Properties.Resources.logo_delte_alt1;
                button5.Enabled = false;
                button5.BackgroundImage = Properties.Resources.logo_ecsport_alt1;
                buttonCreateStorage.Enabled = false;
                buttonCreateStorage.BackgroundImage = Properties.Resources.logo_rename_alt3;
                openedVault = null;
                password = null;
            }
        }

        private void buttonAddStorage_Click(object sender, EventArgs e)
        {
            string path = "";//Путь файла
            string pathFile = ""; // Имя файла
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Выберите файл для добавления";
                ofd.InitialDirectory = @"C:\"; // Можно указать стартовую папку
                ofd.Filter = "Все файлы (*.*)|*.*"; // Можно ограничить типы файлов

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Сохраняем выбранный путь
                    path = ofd.FileName;
                    pathFile = Path.GetFileName(ofd.FileName);
                    string[] pathParts = path.Split('\\');
                    UpdateListViewStorageFiles(FileManager.Vault.GetVaultFiles(openedVault));
                    List<string> meta = FileManager.Vault.GetMeta(openedVault);
                    int encrCode = EncryptionModule.Encryption.EncryptFile(path, @"Vaults\" + openedVault + '\\' + pathParts[pathParts.Length - 1] + ".sf", meta[0], int.Parse(meta[1]), password);
                    switch (encrCode)
                    {
                        case 1:
                            MessageBox.Show("Ошибка чтения или записи файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 2:
                            MessageBox.Show("Ошибка шифрования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 3:
                            MessageBox.Show("Неизвестная ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
            UpdateListViewStorageFiles(FileManager.Vault.GetVaultFiles(openedVault));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new FormAbout())
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        private void buttonUnCode_Click(object sender, EventArgs e) //Расшифровка файла
        {
            string outPath = "";      // Путь к выбранной папке
            string outPathFile = "";  // Имя файла (можно позже задать своё)

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Выберите папку, куда расшифровать файл";
                fbd.ShowNewFolderButton = true;

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    // Путь к папке
                    outPath = fbd.SelectedPath;

                    // Пример: можно задать имя файла вручную или взять из другой переменной
                    // (например, если ты расшифровываешь "secret.enc", то создаёшь "secret.txt")
                    outPathFile = Path.Combine(outPath, "Расшифрованный_файл.txt");

                    MessageBox.Show(
                        $"Папка: {outPath}\nИмя файла: {Path.GetFileName(outPathFile)}",
                        "Путь для расшифровки:"
                    );
                }
            }
        }

        private void buttonDelStorage_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли элемент в listViewStorageFiles
            if (listViewStorageFiles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите файл для удаления.", "Удаление файла", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Берем путь к файлу 
            string filePath = "";

            // Если путь не задан — сообщаем
            if (string.IsNullOrEmpty(filePath) || !System.IO.File.Exists(filePath))
            {
                MessageBox.Show("Файл не найден или путь не указан.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Спрашиваем подтверждение
            DialogResult result = MessageBox.Show(
                $"Вы действительно хотите удалить файл:\n{Path.GetFileName(filePath)}?",
                "Подтверждение удаления",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            // Если пользователь подтвердил — удаляем
            if (result == DialogResult.OK)
            {
                try
                {
                    System.IO.File.Delete(filePath);

                    // Удаляем элемент из списка
                    listViewStorageFiles.Items.Remove(listViewStorageFiles.SelectedItems[0]);

                    MessageBox.Show("Файл успешно удалён!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listViewStorage.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите хранилище для удаления.", "Удаление хранилища",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем выбранный элемент
            var selectedItem = listViewStorage.SelectedItems[0];
            string storageName = selectedItem.Text;

            // ⚙️ Если путь к хранилищу хранится в Tag — берём его тоже путь найди
            string storagePath = "";//selectedItem.Tag?.ToString();

            // Спрашиваем подтверждение
            DialogResult result = MessageBox.Show(
                $"Вы действительно хотите удалить хранилище:\n«{storageName}»?",
                "Подтверждение удаления",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.OK)
            {
                try
                {
                    // 🔹 Удаляем физически (если путь есть)
                    if (!string.IsNullOrEmpty(storagePath) && Directory.Exists(storagePath))
                    {
                        Directory.Delete(storagePath, true); // true — удалить со всем содержимым
                    }

                    // 🔹 Удаляем из списка
                    listViewStorage.Items.Remove(selectedItem);

                    MessageBox.Show("Хранилище успешно удалено!", "Готово",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении хранилища:\n{ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Выберите хранилище для импорта";
                ofd.Filter = "Файлы хранилищ (*.vault;*.zip)|*.vault;*.zip|Все файлы (*.*)|*.*";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 📁 Путь к выбранному файлу
                        string selectedFile = ofd.FileName;
                        string fileName = Path.GetFileName(selectedFile);

                        // 📦 Папка, куда будут импортироваться хранилища
                        string vaultsDirectory = Path.Combine(Application.StartupPath, "Vaults");

                        // Если папки нет — создаём
                        if (!Directory.Exists(vaultsDirectory))
                            Directory.CreateDirectory(vaultsDirectory);

                        // 📂 Куда копируем
                        string destinationPath = Path.Combine(vaultsDirectory, fileName);

                        // Проверяем, нет ли уже такого файла
                        if (System.IO.File.Exists(destinationPath))
                        {
                            DialogResult overwrite = MessageBox.Show(
                                $"Хранилище с именем «{fileName}» уже существует.\nЗаменить его?",
                                "Подтверждение импорта",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (overwrite == DialogResult.No)
                                return;

                            System.IO.File.Delete(destinationPath);
                        }

                        // 🚀 Копируем файл
                        System.IO.File.Copy(selectedFile, destinationPath, true);

                        // ✅ Добавляем в listViewStorage
                        ListViewItem item = new ListViewItem(fileName);
                        item.Tag = destinationPath;
                        listViewStorage.Items.Add(item);

                        MessageBox.Show($"Хранилище «{fileName}» успешно импортировано!",
                            "Импорт завершён", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при импорте хранилища:\n{ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрано ли хранилище
            if (listViewStorage.SelectedItems.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите хранилище для экспорта.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем выбранный элемент
            var selectedItem = listViewStorage.SelectedItems[0];
            string fileName = selectedItem.Text;

            // Определяем, где хранится оригинал (найди верный путь)
            string vaultsDirectory = Path.Combine(Application.StartupPath, "Vaults");
            string sourcePath = Path.Combine(vaultsDirectory, fileName);

            // Проверяем, существует ли файл
            if (!System.IO.File.Exists(sourcePath))
            {
                MessageBox.Show("Файл хранилища не найден. Возможно, он был удалён или перемещён.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Диалог для выбора пути сохранения
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Выберите, куда сохранить хранилище";
                sfd.FileName = fileName; // имя по умолчанию
                sfd.Filter = "Файлы хранилищ (*.vault;*.zip)|*.vault;*.zip|Все файлы (*.*)|*.*";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Копируем файл в выбранное место
                        System.IO.File.Copy(sourcePath, sfd.FileName, true);

                        MessageBox.Show($"Хранилище «{fileName}» успешно экспортировано!",
                            "Экспорт завершён", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при экспорте хранилища:\n{ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        //Коды ошибок для шифровки модуля Encryption



        //Коды ошибок для расшифровки модуля Encryption
        //switch (Переменная)
        //    {
        //        case 1:
        //            MessageBox.Show("HMAC не совпал (Неверный пароль, поврежденный файл)!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //            break;
        //        case 2:
        //            MessageBox.Show("Ошибка во время дешифрования!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //            break;
        //        case 3:
        //            MessageBox.Show("Ошибка чтения или записи!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Eror);
        //            break;
        //        case 4:
        //            MessageBox.Show("Неизвестная ошибка!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Eror);
        //            break;
        //        case 5:
        //            MessageBox.Show("Ошибка в структуре файла!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Eror);
        //            break;
        //    }                                                                                                                 
        //    this.Close();

    }




}
