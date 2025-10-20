using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Folder_Guard
{
    public partial class FormCode : Form
    {
        public string SelectedItemName { get; set; }
        public FormCode()
        {
            InitializeComponent();
            Themes();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddStorage_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int shifrovka = FileManager.Vault.GetAccessToVault(SelectedItemName, textBoxCode.Text);

            switch (shifrovka)
            {
                case 1:
                    MessageBox.Show("Неверный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Отсутствие Metafile хранилища!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 0: MessageBox.Show("Хранилище открыто(временный мессаж бокс богдан удали потом)"); break;
            }
            this.Close();
        }

    }
}

