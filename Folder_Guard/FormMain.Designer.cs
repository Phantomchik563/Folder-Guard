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
            this.buttonSetting = new System.Windows.Forms.Button();
            this.listViewStorageFiles = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonCode = new System.Windows.Forms.Button();
            this.buttonAddStorage = new System.Windows.Forms.Button();
            this.buttonDelStorage = new System.Windows.Forms.Button();
            this.buttonCreateStorage = new System.Windows.Forms.Button();
            this.buttonUnCode = new System.Windows.Forms.Button();
            this.listViewStorage = new System.Windows.Forms.ListView();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.DimGray;
            this.buttonHelp.BackgroundImage = global::Folder_Guard.Properties.Resources.question;
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHelp.Location = new System.Drawing.Point(858, 7);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(36, 36);
            this.buttonHelp.TabIndex = 16;
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.Color.DimGray;
            this.buttonSetting.BackgroundImage = global::Folder_Guard.Properties.Resources.button_setting;
            this.buttonSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSetting.Location = new System.Drawing.Point(812, 7);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(36, 36);
            this.buttonSetting.TabIndex = 22;
            this.buttonSetting.UseVisualStyleBackColor = false;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // listViewStorageFiles
            // 
            this.listViewStorageFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewStorageFiles.HideSelection = false;
            this.listViewStorageFiles.LabelWrap = false;
            this.listViewStorageFiles.Location = new System.Drawing.Point(293, 56);
            this.listViewStorageFiles.Name = "listViewStorageFiles";
            this.listViewStorageFiles.Size = new System.Drawing.Size(609, 622);
            this.listViewStorageFiles.TabIndex = 20;
            this.listViewStorageFiles.UseCompatibleStateImageBehavior = false;
            this.listViewStorageFiles.View = System.Windows.Forms.View.List;
            this.listViewStorageFiles.SelectedIndexChanged += new System.EventHandler(this.listViewStorageFiles_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonCode
            // 
            this.buttonCode.BackColor = System.Drawing.Color.DimGray;
            this.buttonCode.BackgroundImage = global::Folder_Guard.Properties.Resources.logo_open;
            this.buttonCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCode.Enabled = false;
            this.buttonCode.FlatAppearance.BorderSize = 0;
            this.buttonCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCode.Location = new System.Drawing.Point(6, 5);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(274, 45);
            this.buttonCode.TabIndex = 1;
            this.buttonCode.UseVisualStyleBackColor = false;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // buttonAddStorage
            // 
            this.buttonAddStorage.BackColor = System.Drawing.Color.DimGray;
            this.buttonAddStorage.BackgroundImage = global::Folder_Guard.Properties.Resources.file_add;
            this.buttonAddStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddStorage.FlatAppearance.BorderSize = 0;
            this.buttonAddStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStorage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddStorage.Location = new System.Drawing.Point(6, 60);
            this.buttonAddStorage.Name = "buttonAddStorage";
            this.buttonAddStorage.Size = new System.Drawing.Size(63, 44);
            this.buttonAddStorage.TabIndex = 13;
            this.buttonAddStorage.UseVisualStyleBackColor = false;
            this.buttonAddStorage.Click += new System.EventHandler(this.buttonAddStorage_Click);
            // 
            // buttonDelStorage
            // 
            this.buttonDelStorage.BackColor = System.Drawing.Color.DimGray;
            this.buttonDelStorage.BackgroundImage = global::Folder_Guard.Properties.Resources.file_delete;
            this.buttonDelStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelStorage.FlatAppearance.BorderSize = 0;
            this.buttonDelStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelStorage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelStorage.Location = new System.Drawing.Point(217, 61);
            this.buttonDelStorage.Name = "buttonDelStorage";
            this.buttonDelStorage.Size = new System.Drawing.Size(63, 44);
            this.buttonDelStorage.TabIndex = 14;
            this.buttonDelStorage.UseVisualStyleBackColor = false;
            this.buttonDelStorage.Click += new System.EventHandler(this.buttonDelStorage_Click);
            // 
            // buttonCreateStorage
            // 
            this.buttonCreateStorage.BackColor = System.Drawing.Color.DimGray;
            this.buttonCreateStorage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCreateStorage.BackgroundImage")));
            this.buttonCreateStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCreateStorage.FlatAppearance.BorderSize = 0;
            this.buttonCreateStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateStorage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateStorage.Location = new System.Drawing.Point(127, 179);
            this.buttonCreateStorage.Name = "buttonCreateStorage";
            this.buttonCreateStorage.Size = new System.Drawing.Size(26, 28);
            this.buttonCreateStorage.TabIndex = 15;
            this.buttonCreateStorage.UseVisualStyleBackColor = false;
            this.buttonCreateStorage.Click += new System.EventHandler(this.ButtonCreateStoragebutton_Click);
            // 
            // buttonUnCode
            // 
            this.buttonUnCode.BackColor = System.Drawing.Color.DimGray;
            this.buttonUnCode.BackgroundImage = global::Folder_Guard.Properties.Resources.file_deshifrovat;
            this.buttonUnCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUnCode.FlatAppearance.BorderSize = 0;
            this.buttonUnCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnCode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUnCode.Location = new System.Drawing.Point(75, 60);
            this.buttonUnCode.Name = "buttonUnCode";
            this.buttonUnCode.Size = new System.Drawing.Size(63, 44);
            this.buttonUnCode.TabIndex = 16;
            this.buttonUnCode.UseVisualStyleBackColor = false;
            this.buttonUnCode.Click += new System.EventHandler(this.buttonUnCode_Click);
            // 
            // listViewStorage
            // 
            this.listViewStorage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listViewStorage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewStorage.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewStorage.HideSelection = false;
            this.listViewStorage.Location = new System.Drawing.Point(6, 216);
            this.listViewStorage.Name = "listViewStorage";
            this.listViewStorage.Size = new System.Drawing.Size(274, 414);
            this.listViewStorage.TabIndex = 19;
            this.listViewStorage.UseCompatibleStateImageBehavior = false;
            this.listViewStorage.View = System.Windows.Forms.View.List;
            this.listViewStorage.SelectedIndexChanged += new System.EventHandler(this.listViewStorage_SelectedIndexChanged);
            // 
            // panelFiles
            // 
            this.panelFiles.BackColor = System.Drawing.Color.Transparent;
            this.panelFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiles.Controls.Add(this.button6);
            this.panelFiles.Controls.Add(this.button5);
            this.panelFiles.Controls.Add(this.button4);
            this.panelFiles.Controls.Add(this.button3);
            this.panelFiles.Controls.Add(this.button2);
            this.panelFiles.Controls.Add(this.listViewStorage);
            this.panelFiles.Controls.Add(this.buttonUnCode);
            this.panelFiles.Controls.Add(this.buttonCreateStorage);
            this.panelFiles.Controls.Add(this.buttonDelStorage);
            this.panelFiles.Controls.Add(this.buttonAddStorage);
            this.panelFiles.Controls.Add(this.buttonCode);
            this.panelFiles.Controls.Add(this.pictureBox2);
            this.panelFiles.Location = new System.Drawing.Point(0, 50);
            this.panelFiles.Margin = new System.Windows.Forms.Padding(2);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(287, 640);
            this.panelFiles.TabIndex = 12;
            this.panelFiles.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFiles_Paint);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.BackgroundImage = global::Folder_Guard.Properties.Resources.file_ren;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Enabled = false;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(148, 61);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 44);
            this.button6.TabIndex = 31;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.BackgroundImage = global::Folder_Guard.Properties.Resources.logo_ecsport;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(254, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 28);
            this.button5.TabIndex = 30;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(193, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 28);
            this.button4.TabIndex = 29;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.BackgroundImage = global::Folder_Guard.Properties.Resources.logo_delte;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(64, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 28);
            this.button3.TabIndex = 28;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.BackgroundImage = global::Folder_Guard.Properties.Resources.add;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(6, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 28);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 34);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(902, 50);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImage = global::Folder_Guard.Properties.Resources.logo_about;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(767, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(906, 691);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewStorageFiles);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.panelFiles);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolderGuard";
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            this.panelFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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

        private void ButtonCreateStoragebutton_Click(object sender, EventArgs e)
        {
            using (var form = new FormRenameStorage(this))
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        private void ButtonCode_Click(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.ListView listViewStorageFiles;
        private System.Windows.Forms.Timer timer1;
        private Button buttonCode;
        private Button buttonAddStorage;
        private Button buttonDelStorage;
        private Button buttonCreateStorage;
        private Button buttonUnCode;
        private ListView listViewStorage;
        private Panel panelFiles;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private PictureBox pictureBox2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button6;
        private Button button1;
    }
}

