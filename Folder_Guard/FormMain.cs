using System;
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

            // Список элементов, которые будут плавно появляться
            uiElements = new Control[]
            {
                buttonCreateStorage,
                buttonAddStorage,
                buttonCode,
                buttonDelStorage,
                panelFiles,
                treeViewProvodnik
            };

            foreach (var c in uiElements)
                c.Visible = false;

            this.Opacity = 0;
            this.Load += FormMain_Load;

            // Подключаем кнопки
            buttonCode.Click += buttonCode_Click;
            buttonCreateStorage.Click += buttonCreateStoragebutton_Click;

            // Инициализируем TreeView
            InitializeTreeView();

            // Кнопки развернуть/свернуть
            InitializeExpandCollapseButtons();
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
        // Инициализация TreeView
        // =========================
        private void InitializeTreeView()
        {
            treeViewProvodnik.Nodes.Clear();

            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode driveNode = new TreeNode(drive.Name) { Tag = drive.RootDirectory.FullName };
                driveNode.Nodes.Add("..."); // заглушка для раскрытия
                treeViewProvodnik.Nodes.Add(driveNode);
            }

            // Динамическая подгрузка папок
            treeViewProvodnik.BeforeExpand += TreeViewProvodnik_BeforeExpand;

            // Клик по файлу
            treeViewProvodnik.NodeMouseClick += TreeViewProvodnik_NodeMouseClick;
        }

        private void TreeViewProvodnik_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;

            if (node.Nodes.Count == 1 && node.Nodes[0].Text == "...")
            {
                node.Nodes.Clear();
                string path = node.Tag.ToString();
                try
                {
                    // Добавляем папки
                    foreach (var dir in Directory.GetDirectories(path))
                    {
                        TreeNode dirNode = new TreeNode(Path.GetFileName(dir)) { Tag = dir };
                        dirNode.Nodes.Add("..."); // заглушка
                        node.Nodes.Add(dirNode);
                    }

                    // Добавляем файлы
                    foreach (var file in Directory.GetFiles(path))
                    {
                        TreeNode fileNode = new TreeNode(Path.GetFileName(file)) { Tag = file };
                        node.Nodes.Add(fileNode);
                    }
                }
                catch { /* Игнорируем ошибки доступа */ }
            }
        }

        private void TreeViewProvodnik_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            string path = node.Tag.ToString();

            if (File.Exists(path))
            {
                selectedFilePath = path; //Путь файла для шифровки
                MessageBox.Show("Выбран файл: " + selectedFilePath, "Файл выбран");
            }
        }

        // =========================
        // Кнопки "Развернуть все / Свернуть все"
        // =========================
        private void InitializeExpandCollapseButtons()
        {
            Button expandAllBtn = new Button
            {
                Text = "Развернуть все",
                Width = 200,
                Height = 50,
                Top = 10,
                Left = 10,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            expandAllBtn.Click += (s, e) => treeViewProvodnik.ExpandAll();
            this.Controls.Add(expandAllBtn);

            Button collapseAllBtn = new Button
            {
                Text = "Свернуть все",
                Width = 200,
                Height = 50,
                Top = 70,
                Left = 10,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            collapseAllBtn.Click += (s, e) => treeViewProvodnik.CollapseAll();
            this.Controls.Add(collapseAllBtn);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            using (var form = new FormHelp())
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            using (var form = new FormSetting())
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }
    }
}
