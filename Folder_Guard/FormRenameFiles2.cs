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
        
        public FormRenameFiles(FormMain form)
        {
            InitializeComponent();
            Themes();
            mainForm = form;
        }
        private FormMain mainForm;
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
            string newFileName = textBoxCode.Text.Trim();
            if (string.IsNullOrWhiteSpace(newFileName))
            {
                MessageBox.Show("Имя не может быть пустым или состоять только из символов-разделителей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int renameRes = FileManager.VaultFile.FileRename(mainForm.openedVault, mainForm.selectedFile, newFileName);
                switch (renameRes)
                {
                    case 1:
                        MessageBox.Show("Недопустимые символы в имени файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("Недопустимое имя файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 3:
                        MessageBox.Show("\"~$\" в начале имени файла недопустимо", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 4:
                        MessageBox.Show("Вы пытаетесь переименовать отсутствующий файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 0:
                        {
                            this.Close();
                            break;
                        }
                }
            }
        }
    }
}
