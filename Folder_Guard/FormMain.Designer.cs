using System;
using System.Windows.Forms;

namespace Folder_Guard
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonHelp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.listViewStorageFiles = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonCode = new System.Windows.Forms.Button();
            this.buttonAddStorage = new System.Windows.Forms.Button();
            this.buttonDelStorage = new System.Windows.Forms.Button();
            this.buttonCreateStorage = new System.Windows.Forms.Button();
            this.buttonUnCode = new System.Windows.Forms.Button();
            this.listViewStorage = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.panelFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.DimGray;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHelp.Location = new System.Drawing.Point(777, 6);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(113, 29);
            this.buttonHelp.TabIndex = 16;
            this.buttonHelp.Text = "Помощь";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(306, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Файлы в хранилище:";
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.Color.DimGray;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetting.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSetting.Location = new System.Drawing.Point(645, 6);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(113, 29);
            this.buttonSetting.TabIndex = 22;
            this.buttonSetting.Text = "Настройки";
            this.buttonSetting.UseVisualStyleBackColor = false;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // listViewStorageFiles
            // 
            this.listViewStorageFiles.HideSelection = false;
            this.listViewStorageFiles.Location = new System.Drawing.Point(311, 145);
            this.listViewStorageFiles.Name = "listViewStorageFiles";
            this.listViewStorageFiles.Size = new System.Drawing.Size(578, 491);
            this.listViewStorageFiles.TabIndex = 20;
            this.listViewStorageFiles.UseCompatibleStateImageBehavior = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonCode
            // 
            this.buttonCode.BackColor = System.Drawing.Color.DimGray;
            this.buttonCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCode.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCode.Location = new System.Drawing.Point(6, 53);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(274, 29);
            this.buttonCode.TabIndex = 1;
            this.buttonCode.Text = "Открыть хранилище";
            this.buttonCode.UseVisualStyleBackColor = false;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // buttonAddStorage
            // 
            this.buttonAddStorage.BackColor = System.Drawing.Color.DimGray;
            this.buttonAddStorage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddStorage.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddStorage.Location = new System.Drawing.Point(6, 96);
            this.buttonAddStorage.Name = "buttonAddStorage";
            this.buttonAddStorage.Size = new System.Drawing.Size(274, 29);
            this.buttonAddStorage.TabIndex = 13;
            this.buttonAddStorage.Text = "Импорт  в хранилище";
            this.buttonAddStorage.UseVisualStyleBackColor = false;
            this.buttonAddStorage.Click += new System.EventHandler(this.AddStorage_Click);
            // 
            // buttonDelStorage
            // 
            this.buttonDelStorage.BackColor = System.Drawing.Color.DimGray;
            this.buttonDelStorage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelStorage.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelStorage.Location = new System.Drawing.Point(6, 193);
            this.buttonDelStorage.Name = "buttonDelStorage";
            this.buttonDelStorage.Size = new System.Drawing.Size(274, 29);
            this.buttonDelStorage.TabIndex = 14;
            this.buttonDelStorage.Text = "Удалить файл";
            this.buttonDelStorage.UseVisualStyleBackColor = false;
            // 
            // buttonCreateStorage
            // 
            this.buttonCreateStorage.BackColor = System.Drawing.Color.DimGray;
            this.buttonCreateStorage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateStorage.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateStorage.Location = new System.Drawing.Point(6, 9);
            this.buttonCreateStorage.Name = "buttonCreateStorage";
            this.buttonCreateStorage.Size = new System.Drawing.Size(274, 29);
            this.buttonCreateStorage.TabIndex = 15;
            this.buttonCreateStorage.Text = "Создать хранилище";
            this.buttonCreateStorage.UseVisualStyleBackColor = false;
            this.buttonCreateStorage.Click += new System.EventHandler(this.buttonCreateStoragebutton_Click);
            // 
            // buttonUnCode
            // 
            this.buttonUnCode.BackColor = System.Drawing.Color.DimGray;
            this.buttonUnCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUnCode.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUnCode.Location = new System.Drawing.Point(6, 144);
            this.buttonUnCode.Name = "buttonUnCode";
            this.buttonUnCode.Size = new System.Drawing.Size(274, 29);
            this.buttonUnCode.TabIndex = 16;
            this.buttonUnCode.Text = "Экспорт из хранилища";
            this.buttonUnCode.UseVisualStyleBackColor = false;
            // 
            // listViewStorage
            // 
            this.listViewStorage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listViewStorage.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewStorage.HideSelection = false;
            this.listViewStorage.Location = new System.Drawing.Point(6, 271);
            this.listViewStorage.Name = "listViewStorage";
            this.listViewStorage.Size = new System.Drawing.Size(274, 364);
            this.listViewStorage.TabIndex = 19;
            this.listViewStorage.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Список Хранилищ:";
            // 
            // panelFiles
            // 
            this.panelFiles.BackColor = System.Drawing.Color.Transparent;
            this.panelFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiles.Controls.Add(this.label1);
            this.panelFiles.Controls.Add(this.listViewStorage);
            this.panelFiles.Controls.Add(this.buttonUnCode);
            this.panelFiles.Controls.Add(this.buttonCreateStorage);
            this.panelFiles.Controls.Add(this.buttonDelStorage);
            this.panelFiles.Controls.Add(this.buttonAddStorage);
            this.panelFiles.Controls.Add(this.buttonCode);
            this.panelFiles.Location = new System.Drawing.Point(0, 0);
            this.panelFiles.Margin = new System.Windows.Forms.Padding(2);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(287, 642);
            this.panelFiles.TabIndex = 12;
            this.panelFiles.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFiles_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(286, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 39);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTest
            // 
            this.buttonTest.BackColor = System.Drawing.Color.Red;
            this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTest.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTest.Location = new System.Drawing.Point(777, 65);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(112, 29);
            this.buttonTest.TabIndex = 25;
            this.buttonTest.Text = "Тест";
            this.buttonTest.UseVisualStyleBackColor = false;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(901, 642);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.listViewStorageFiles);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.panelFiles);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolderGuard";
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            this.panelFiles.ResumeLayout(false);
            this.panelFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            //Шаблон для подключения формы
            using (var form = new FormSetting())
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            //Шаблон для подключения формы
            using (var form = new FormHelp())
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        private void AddStorage_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonCreateStoragebutton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonCode_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.ListView listViewStorageFiles;
        private System.Windows.Forms.Timer timer1;
        private Button buttonCode;
        private Button buttonAddStorage;
        private Button buttonDelStorage;
        private Button buttonCreateStorage;
        private Button buttonUnCode;
        private ListView listViewStorage;
        private Label label1;
        private Panel panelFiles;
        private PictureBox pictureBox1;
        private Button buttonTest;
    }
}

