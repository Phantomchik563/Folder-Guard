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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonCode = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.labelFileCount = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelSelectedFile = new System.Windows.Forms.Label();
            this.buttonUnCode = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCode
            // 
            this.buttonCode.BackgroundImage = global::Folder_Guard.Properties.Resources.dark_background_image;
            this.buttonCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCode.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCode.Location = new System.Drawing.Point(116, 4);
            this.buttonCode.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(191, 36);
            this.buttonCode.TabIndex = 1;
            this.buttonCode.Text = "Зашифровать";
            this.buttonCode.UseVisualStyleBackColor = true;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFile.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFile.Image = global::Folder_Guard.Properties.Resources.dark_background_image;
            this.buttonFile.Location = new System.Drawing.Point(4, 4);
            this.buttonFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(87, 36);
            this.buttonFile.TabIndex = 2;
            this.buttonFile.Text = "Файл";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // labelFileCount
            // 
            this.labelFileCount.AutoSize = true;
            this.labelFileCount.BackColor = System.Drawing.Color.Transparent;
            this.labelFileCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFileCount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelFileCount.Location = new System.Drawing.Point(22, 397);
            this.labelFileCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileCount.Name = "labelFileCount";
            this.labelFileCount.Size = new System.Drawing.Size(274, 29);
            this.labelFileCount.TabIndex = 3;
            this.labelFileCount.Text = "Информация о файле:";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.BackColor = System.Drawing.Color.Transparent;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPath.Location = new System.Drawing.Point(22, 344);
            this.labelPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(169, 29);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Полный путь:";
            // 
            // labelSelectedFile
            // 
            this.labelSelectedFile.AutoSize = true;
            this.labelSelectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSelectedFile.Image = global::Folder_Guard.Properties.Resources.dark_square;
            this.labelSelectedFile.Location = new System.Drawing.Point(22, 449);
            this.labelSelectedFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectedFile.Name = "labelSelectedFile";
            this.labelSelectedFile.Size = new System.Drawing.Size(179, 29);
            this.labelSelectedFile.TabIndex = 8;
            this.labelSelectedFile.Text = "Выбран файл: ";
            this.labelSelectedFile.Click += new System.EventHandler(this.labelSelectedFile_Click);
            // 
            // buttonUnCode
            // 
            this.buttonUnCode.BackgroundImage = global::Folder_Guard.Properties.Resources.dark_background_image;
            this.buttonUnCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUnCode.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUnCode.Location = new System.Drawing.Point(331, 4);
            this.buttonUnCode.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnCode.Name = "buttonUnCode";
            this.buttonUnCode.Size = new System.Drawing.Size(205, 36);
            this.buttonUnCode.TabIndex = 10;
            this.buttonUnCode.Text = "Расшифровать";
            this.buttonUnCode.UseVisualStyleBackColor = true;
            this.buttonUnCode.Click += new System.EventHandler(this.buttonUnCode_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 16;
            this.listBoxFiles.Location = new System.Drawing.Point(27, 117);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(444, 196);
            this.listBoxFiles.TabIndex = 11;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // panelFiles
            // 
            this.panelFiles.BackColor = System.Drawing.Color.Transparent;
            this.panelFiles.Controls.Add(this.label1);
            this.panelFiles.Controls.Add(this.buttonFile);
            this.panelFiles.Controls.Add(this.labelSelectedFile);
            this.panelFiles.Controls.Add(this.listBoxFiles);
            this.panelFiles.Controls.Add(this.labelPath);
            this.panelFiles.Controls.Add(this.buttonCode);
            this.panelFiles.Controls.Add(this.labelFileCount);
            this.panelFiles.Controls.Add(this.buttonUnCode);
            this.panelFiles.Location = new System.Drawing.Point(13, 9);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(579, 522);
            this.panelFiles.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Статус выбора:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Folder_Guard.Properties.Resources.dark_square;
            this.ClientSize = new System.Drawing.Size(971, 562);
            this.Controls.Add(this.panelFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolderGuard";
            this.panelFiles.ResumeLayout(false);
            this.panelFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Label labelFileCount;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelSelectedFile;
        private System.Windows.Forms.Button buttonUnCode;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Panel panelFiles;
        private System.Windows.Forms.Label label1;
    }
}

