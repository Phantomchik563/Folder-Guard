using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Открывается форма для шифровки
        {
            FormCode a = new FormCode();
            a.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e) //Открывается форма для дешифровки
        {
            

        }



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

                    // Определяем, что было выбрано - папка или файл
                    if (Directory.Exists(selectedPath))
                    {
                        // Выбрана папка
                        selectedFolder = selectedPath;
                        labelFileCount.Text = $"Выбранная папка: {selectedFolder}";

                        // Активируем кнопку шифрования
                        buttonCode.Enabled = true;
                        buttonUnCode.Enabled = false;

                        // Передаем папку в файловый блок для шифрования
                        SetEncryptionFolder(selectedFolder);
                    }
                    else if (File.Exists(selectedPath) && Path.GetExtension(selectedPath).ToLower() == ".sf")
                    {
                        // Выбран файл .sf
                        selectedFile = selectedPath;
                        labelFileCount.Text = $"Выбранный файл: {Path.GetFileName(selectedFile)}";

                        // Активируем кнопку дешифрования
                        buttonCode.Enabled = false;
                        buttonUnCode.Enabled = true;

                        // Передаем файл в блок дешифровки
                        SetDecryptionFile(selectedFile);
                    }
                    else if (Directory.Exists(Path.GetDirectoryName(selectedPath)))
                    {
                        // Выбрана папка через диалог
                        selectedFolder = Path.GetDirectoryName(selectedPath);
                        labelFileCount.Text = $"Выбранная папка: {selectedFolder}";

                        // Активируем кнопку шифрования
                        buttonCode.Enabled = true;
                        buttonUnCode.Enabled = false;

                        // Передаем папку в файловый блок для шифрования
                        SetEncryptionFolder(selectedFolder);
                    }
                }
            }
        }

        // Метод для передачи папки в блок шифрования
        private void SetEncryptionFolder(string folderPath)
        {
            // Здесь реализуйте логику передачи папки в ваш файловый блок
            // Например:
            // encryptionProcessor.SetWorkingFolder(folderPath);
            // или сохраните в переменную класса:
            // this.selectedEncryptionFolder = folderPath;

            MessageBox.Show($"Папка для шифрования: {folderPath}", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Метод для передачи файла в блок дешифровки
        private void SetDecryptionFile(string filePath)
        {
            // Здесь реализуйте логику передачи файла в блок дешифровки
            // Например:
            // decryptionProcessor.SetDecryptionFile(filePath);
            // или сохраните в переменную класса:
            // this.selectedDecryptionFile = filePath;

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

        private void labelSelectedFile_Click(object sender, EventArgs e)
        {

        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
