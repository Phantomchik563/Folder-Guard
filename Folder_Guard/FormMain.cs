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

        private Timer fadeTimer;
        private Control[] uiElements;

        // Выбранный файл
        private string selectedFilePath = "";

        public FormMain()
        {
            InitializeComponent();
            Themes();
            UpdateListViewStorage(FileManager.Vault.GetVaults());
            // Список элементов, которые будут плавно появляться
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

                        label2.BackColor = Color.FromArgb(255, 255, 255);
                        label2.ForeColor = Color.FromArgb(33, 33, 33);
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

                        label2.BackColor = Color.FromArgb(33, 33, 33);
                        label2.ForeColor = Color.FromArgb(255, 255, 255);
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



        //Коды ошибок для шифровки модуля Encryption
        //switch (Переменная)
        //    {
        //        case 1:
        //            MessageBox.Show("Ошибка чтения или записи файла!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //            break;
        //        case 2:
        //            MessageBox.Show("Ошибка шифрования.","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //            break;
        //        case 3:
        //            MessageBox.Show("Неизвестная ошибка.","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Eror);
        //            break;
        //    }                                                                                                                 
        //    this.Close();


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
