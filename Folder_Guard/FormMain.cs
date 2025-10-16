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
            FormUnCode b = new FormUnCode();
            b.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e) //Открывается проводник и выбирается файл .sf или папка
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

                    // Если выбрана папка
                    if (Directory.Exists(selectedPath))
                    {
                        // Обновляем Label с путем к папке
                        label1.Text = $"Выбранная папка: {selectedPath}";

                        // Получаем список файлов .sf в выбранной папке
                        string[] sfFiles = Directory.GetFiles(selectedPath, "*.sf");
                        label2.Text = $"Найдено файлов .sf: {sfFiles.Length}";
                    }
                    // Если выбран файл .sf
                    else if (File.Exists(selectedPath) && Path.GetExtension(selectedPath).ToLower() == ".sf")
                    {
                        // Обновляем Label с путем к файлу
                        label1.Text = $"Выбранный файл: {Path.GetFileName(selectedPath)}";
                        label2.Text = $"Полный путь: {selectedPath}";
                    }
                    // Если путь к папке (когда файл не существует, но папка существует)
                    else if (Directory.Exists(Path.GetDirectoryName(selectedPath)))
                    {
                        string folderPath = Path.GetDirectoryName(selectedPath);
                        label1.Text = $"Выбранная папка: {folderPath}";

                        string[] sfFiles = Directory.GetFiles(folderPath, "*.sf");
                        label2.Text = $"Найдено файлов .sf: {sfFiles.Length}";
                    }
                }
            }
        }
    }
}
