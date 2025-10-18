using FileManager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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

            // Подключаем кнопки
            buttonCode.Click += buttonCode_Click;
            buttonCreateStorage.Click += buttonCreateStoragebutton_Click;


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
        }

        // =========================
        // Кнопка "Открыть хранилище"
        // =========================
        private void buttonCode_Click(object sender, EventArgs e)
        {
            using (var form = new FormCode())
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        // =========================
        // Создание хранилища
        // =========================
        private void buttonCreateStoragebutton_Click(object sender, EventArgs e)
        {
            using (var form = new FormCreateStorage())
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
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

        // =========================
        // Пример вызова метода из другого модуля
        // =========================



        private void timer1_Tick(object sender, EventArgs e)
        {
            var vaults = FileManager.Vault.GetVaults();
            UpdateListViewStorage(vaults);

        }

        void Themes()
        {
            switch (Properties.Settings.Default.Theme)
            {
                case 0: // Светлая тема
                    {

                        break;
                    }

                case 1: // Тёмная тема
                    {

                        break;
                    }


            }
        }
    }




}
