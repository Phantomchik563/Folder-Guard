using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Folder_Guard
{
    public partial class FormMain : Form
    {
        private Timer fadeTimer;
        private Control[] uiElements;

        public FormMain()
        {
            InitializeComponent();

            // Список элементов, которые будут плавно появляться
            uiElements = new Control[]
            {
                buttonCreateStorage,
                buttonAddStorage,
                buttonCode,
                buttonUnCode,
                buttonDelStorage,
                listBoxStorage,
                panelFiles
            };

            // Скрываем элементы до появления
            foreach (var c in uiElements)
                c.Visible = false;

            this.Opacity = 0;
            this.Load += FormMain_Load;

            // Привязываем события только здесь, чтобы не было двойного вызова
            buttonCode.Click -= buttonCode_Click;
            buttonCode.Click += buttonCode_Click;

            buttonUnCode.Click -= buttonUnCode_Click;
            buttonUnCode.Click += buttonUnCode_Click;

            buttonCreateStorage.Click -= buttonCreateStoragebutton_Click;
            buttonCreateStorage.Click += buttonCreateStoragebutton_Click;

            buttonAddStorage.Click -= AddStorage_Click;
            buttonAddStorage.Click += AddStorage_Click;

            listBoxStorage.SelectedIndexChanged -= listBoxFiles_SelectedIndexChanged;
            listBoxStorage.SelectedIndexChanged += listBoxFiles_SelectedIndexChanged;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            fadeTimer = new Timer();
            fadeTimer.Interval = 20;

            int steps = 30; // чуть быстрее, раньше было 50
            int currentStep = 0;

            fadeTimer.Tick += (s, ev) =>
            {
                currentStep++;
                float progress = currentStep / (float)steps;

                // Мягкая ease-in-out кривая
                float ease = (float)(progress < 0.5
                    ? 2 * progress * progress
                    : -1 + (4 - 2 * progress) * progress);

                this.Opacity = ease;

                // Делаем элементы видимыми, когда форма начинает появляться
                foreach (var c in uiElements)
                    if (!c.Visible) c.Visible = true;

                if (currentStep >= steps)
                    fadeTimer.Stop();
            };

            fadeTimer.Start();
        }



        // Обработчики кнопок
        private void buttonCode_Click(object sender, EventArgs e)
        {
            using (var form = new FormCode())
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        private void buttonUnCode_Click(object sender, EventArgs e)
        {
            using (var form = new FormUnCode())
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        private void buttonCreateStoragebutton_Click(object sender, EventArgs e)
        {
            // Подсасываю функцию Вано
        }

        private void AddStorage_Click(object sender, EventArgs e)
        {
            // Ваш код добавления хранилища
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ваш код обработки выбора в listBox
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void labelSelectedFile_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        private void buttonFile_Click(object sender, EventArgs e) { }
        private void SetEncryptionFolder(string folderPath) { }
        private void SetDecryptionFile(string filePath) { }
    }
}
