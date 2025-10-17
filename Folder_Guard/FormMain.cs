using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folder_Guard
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCode a = new FormCode();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) { }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Выберите файл .sf или папку";
                fileDialog.Filter = "SF Files (*.sf)|*.sf";
                fileDialog.ValidateNames = false;
                fileDialog.CheckFileExists = false;
                fileDialog.CheckPathExists = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = fileDialog.FileName;
                    string selectedFolder = "";
                    string selectedFile = "";

                    if (Directory.Exists(selectedPath))
                    {
                        selectedFolder = selectedPath;
                        labelFileCount.Text = $"Выбранная папка: {selectedFolder}";
                        buttonCode.Enabled = true;
                        buttonUnCode.Enabled = false;
                        SetEncryptionFolder(selectedFolder);
                    }
                    else if (File.Exists(selectedPath) && Path.GetExtension(selectedPath).ToLower() == ".sf")
                    {
                        selectedFile = selectedPath;
                        labelFileCount.Text = $"Выбранный файл: {Path.GetFileName(selectedFile)}";
                        buttonCode.Enabled = false;
                        buttonUnCode.Enabled = true;
                        SetDecryptionFile(selectedFile);
                    }
                    else if (Directory.Exists(Path.GetDirectoryName(selectedPath)))
                    {
                        selectedFolder = Path.GetDirectoryName(selectedPath);
                        labelFileCount.Text = $"Выбранная папка: {selectedFolder}";
                        buttonCode.Enabled = true;
                        buttonUnCode.Enabled = false;
                        SetEncryptionFolder(selectedFolder);
                    }
                }
            }
        }

        private void SetEncryptionFolder(string folderPath)
        {
            MessageBox.Show($"Папка для шифрования: {folderPath}", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetDecryptionFile(string filePath)
        {
            MessageBox.Show($"Файл для дешифровки: {filePath}", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCode_Click(object sender, EventArgs e)
        {
            FormCode a = new FormCode();
            a.ShowDialog();
        }

        private void buttonUnCode_Click(object sender, EventArgs e)
        {
            FormUnCode b = new FormUnCode();
            b.ShowDialog();
        }

        private void labelSelectedFile_Click(object sender, EventArgs e) { }
        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e) { }

        // 📦 СОЗДАНИЕ ХРАНИЛИЩА (ZIP)
        private void CreateStorage_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Выберите папку для создания хранилища (ZIP)";

                if (folderDialog.ShowDialog() != DialogResult.OK)
                    return;

                string folderPath = folderDialog.SelectedPath;

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Title = "Сохранить ZIP-хранилище";
                    saveDialog.Filter = "ZIP архивы (*.zip)|*.zip";
                    saveDialog.DefaultExt = "zip";
                    saveDialog.FileName = Path.GetFileName(folderPath) + "_Storage.zip";

                    if (saveDialog.ShowDialog() != DialogResult.OK)
                        return;

                    string zipFilePath = saveDialog.FileName;
                    string password = PromptPassword();
                    if (password == null) return;

                    try
                    {
                        CreateZipWithPassword(folderPath, zipFilePath, password);
                        MessageBox.Show($"Хранилище успешно создано!\nФайл: {zipFilePath}",
                            "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при создании архива:\n{ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 🔒 Запрос пароля
        private string PromptPassword()
        {
            using (Form form = new Form())
            {
                form.Text = "Введите пароль для хранилища";
                form.Size = new Size(350, 180);
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterParent;
                form.MaximizeBox = false;
                form.MinimizeBox = false;

                Label label1 = new Label() { Text = "Введите пароль:", Left = 10, Top = 15, Width = 300 };
                TextBox txt1 = new TextBox() { Left = 10, Top = 35, Width = 310, PasswordChar = '*' };

                Label label2 = new Label() { Text = "Подтвердите пароль:", Left = 10, Top = 65, Width = 300 };
                TextBox txt2 = new TextBox() { Left = 10, Top = 85, Width = 310, PasswordChar = '*' };

                Button ok = new Button() { Text = "OK", Left = 150, Top = 115, Width = 80, DialogResult = DialogResult.OK };
                Button cancel = new Button() { Text = "Отмена", Left = 240, Top = 115, Width = 80, DialogResult = DialogResult.Cancel };

                form.Controls.AddRange(new Control[] { label1, txt1, label2, txt2, ok, cancel });
                form.AcceptButton = ok;
                form.CancelButton = cancel;

                ok.Click += (s, e) =>
                {
                    if (txt1.Text.Length < 4)
                    {
                        MessageBox.Show("Пароль должен содержать минимум 4 символа!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        form.DialogResult = DialogResult.None;
                        return;
                    }

                    if (txt1.Text != txt2.Text)
                    {
                        MessageBox.Show("Пароли не совпадают!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        form.DialogResult = DialogResult.None;
                    }
                };

                if (form.ShowDialog() == DialogResult.OK)
                    return txt1.Text;

                return null;
            }
        }

        // 📁 Создание ZIP с паролем
        private void CreateZipWithPassword(string folderPath, string zipFilePath, string password)
        {
            using (FileStream fsOut = File.Create(zipFilePath))
            using (ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipStream = new ICSharpCode.SharpZipLib.Zip.ZipOutputStream(fsOut))
            {
                zipStream.SetLevel(9); // максимальное сжатие
                zipStream.Password = password;

                int folderOffset = folderPath.Length + (folderPath.EndsWith("\\") ? 0 : 1);
                CompressFolder(folderPath, zipStream, folderOffset);

                zipStream.IsStreamOwner = true;
                zipStream.Close();
            }
        }

        // 📦 Рекурсивное добавление файлов в архив
        private void CompressFolder(string path, ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipStream, int folderOffset)
        {
            string[] files = Directory.GetFiles(path);

            foreach (string filename in files)
            {
                FileInfo fi = new FileInfo(filename);
                string entryName = filename.Substring(folderOffset);
                entryName = ICSharpCode.SharpZipLib.Zip.ZipEntry.CleanName(entryName);

                var newEntry = new ICSharpCode.SharpZipLib.Zip.ZipEntry(entryName)
                {
                    DateTime = fi.LastWriteTime,
                    Size = fi.Length
                };

                zipStream.PutNextEntry(newEntry);

                byte[] buffer = new byte[4096];
                using (FileStream streamReader = File.OpenRead(filename))
                {
                    int sourceBytes;
                    do
                    {
                        sourceBytes = streamReader.Read(buffer, 0, buffer.Length);
                        zipStream.Write(buffer, 0, sourceBytes);
                    } while (sourceBytes > 0);
                }
                zipStream.CloseEntry();
            }

            string[] folders = Directory.GetDirectories(path);
            foreach (string folder in folders)
                CompressFolder(folder, zipStream, folderOffset);
        }

        private void AddStorage_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateStoragebutton_Click(object sender, EventArgs e)
        {
            //Обращение к функции Ванечки, которая выведет список в listBoxStorage
        }

        private void labelPath_Click(object sender, EventArgs e)
        {

        }
    }
}
