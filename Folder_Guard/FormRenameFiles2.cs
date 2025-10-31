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
    public partial class FormRenameFiles : Form
    {
        public FormRenameFiles()
        {
            InitializeComponent();
            Themes();
        }

        void Themes()
        {
            switch (Properties.Settings.Default.Theme)
            {
                case 0: // Светлая тема
                    {
                        this.BackColor = Color.FromArgb(250, 250, 250);
                        button1.BackColor = Color.FromArgb(250, 250, 250);
                        button1.ForeColor = Color.FromArgb(33, 33, 33);
                        buttonAddStorage.BackColor = Color.FromArgb(255, 255, 255);
                        buttonAddStorage.ForeColor = Color.FromArgb(33, 33, 33);
                        textBoxCode.BackColor = Color.FromArgb(250, 250, 250);
                        textBoxCode.ForeColor = Color.FromArgb(33, 33, 33);
                        label1.BackColor = Color.FromArgb(250, 250, 250);
                        label1.ForeColor = Color.FromArgb(33, 33, 33);


                        break;
                    }

                case 1: // Тёмная тема (40, 40, 40) (33, 33, 33)
                    {
                        this.BackColor = Color.FromArgb(33, 33, 33);
                        button1.BackColor = Color.FromArgb(40, 40, 40);
                        button1.ForeColor = Color.FromArgb(255, 255, 255);
                        buttonAddStorage.BackColor = Color.FromArgb(40, 40, 40);
                        buttonAddStorage.ForeColor = Color.FromArgb(255, 255, 255);
                        textBoxCode.BackColor = Color.FromArgb(33, 33, 33);
                        textBoxCode.ForeColor = Color.FromArgb(255, 255, 255);
                        label1.BackColor = Color.FromArgb(33, 33, 33);
                        label1.ForeColor = Color.FromArgb(255, 255, 255);
                        break;
                    }
                    // Если нужны кнопки внутри формы, обработчики подключаем как обычно
                    // button2 оставляем для другой логики
            }
        }

        private void buttonAddStorage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли файл (Дроч с передачей инфы в listViewStorageFiles)
            //if (listViewStorageFiles.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("Выберите файл для переименования.",
            //        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            // Проверяем, введено ли новое имя
            string newFileName = textBoxCode.Text.Trim();
            if (string.IsNullOrWhiteSpace(newFileName))
            {
                MessageBox.Show("Введите новое имя файла.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Берём выбранный файл (Дроч с передачей инфы в listViewStorageFiles)
            //var selectedItem = listViewStorageFiles.SelectedItems[0];
            //string oldFileName = selectedItem.Text;

            // Путь к хранилищу
            //string storageDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Vaults");
            //string oldPath = Path.Combine(storageDir, oldFileName);

            //// Проверяем существование файла
            //if (!File.Exists(oldPath))
            //{
            //    MessageBox.Show("Файл не найден: " + oldFileName,
            //        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Определяем расширение и сохраняем его
            //string extension = Path.GetExtension(oldFileName);
            //string newPath = Path.Combine(storageDir, newFileName + extension);

            //// Проверяем, не существует ли уже файл с таким именем
            //if (File.Exists(newPath))
            //{
            //    MessageBox.Show("Файл с таким именем уже существует.",
            //        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //try
            //{
            //    // Переименование (с сохранением расширения)
            //    File.Move(oldPath, newPath);

            //    // Обновляем отображение в ListView
            //    selectedItem.Text = newFileName + extension;

            //    MessageBox.Show("Файл успешно переименован!",
            //        "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    // Очищаем поле
            //    textBoxCode.Clear();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ошибка при переименовании:\n" + ex.Message,
            //        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
