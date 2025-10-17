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
            this.labelFileCount = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonUnCode = new System.Windows.Forms.Button();
            this.listBoxStorage = new System.Windows.Forms.ListBox();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.buttonDelStorage = new System.Windows.Forms.Button();
            this.buttonAddStorage = new System.Windows.Forms.Button();
            this.buttonCreateStoragebutton = new System.Windows.Forms.Button();
            this.panelFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCode
            // 
            this.buttonCode.BackColor = System.Drawing.Color.DimGray;
            this.buttonCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCode.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCode.Location = new System.Drawing.Point(6, 38);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(143, 29);
            this.buttonCode.TabIndex = 1;
            this.buttonCode.Text = "Зашифровать";
            this.buttonCode.UseVisualStyleBackColor = false;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // labelFileCount
            // 
            this.labelFileCount.AutoSize = true;
            this.labelFileCount.BackColor = System.Drawing.Color.Transparent;
            this.labelFileCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFileCount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelFileCount.Location = new System.Drawing.Point(542, 9);
            this.labelFileCount.Name = "labelFileCount";
            this.labelFileCount.Size = new System.Drawing.Size(216, 24);
            this.labelFileCount.TabIndex = 3;
            this.labelFileCount.Text = "Информация о файлах:";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.BackColor = System.Drawing.Color.Transparent;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPath.Location = new System.Drawing.Point(2, 2);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(58, 24);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Путь:";
            this.labelPath.Click += new System.EventHandler(this.labelPath_Click);
            // 
            // buttonUnCode
            // 
            this.buttonUnCode.BackColor = System.Drawing.Color.DimGray;
            this.buttonUnCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUnCode.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUnCode.Location = new System.Drawing.Point(6, 87);
            this.buttonUnCode.Name = "buttonUnCode";
            this.buttonUnCode.Size = new System.Drawing.Size(154, 29);
            this.buttonUnCode.TabIndex = 10;
            this.buttonUnCode.Text = "Расшифровать";
            this.buttonUnCode.UseVisualStyleBackColor = false;
            this.buttonUnCode.Click += new System.EventHandler(this.buttonUnCode_Click);
            // 
            // listBoxStorage
            // 
            this.listBoxStorage.BackColor = System.Drawing.SystemColors.GrayText;
            this.listBoxStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxStorage.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxStorage.FormattingEnabled = true;
            this.listBoxStorage.ItemHeight = 25;
            this.listBoxStorage.Items.AddRange(new object[] {
            "Яблоко",
            "Апельсин",
            "Груша"});
            this.listBoxStorage.Location = new System.Drawing.Point(6, 239);
            this.listBoxStorage.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxStorage.Name = "listBoxStorage";
            this.listBoxStorage.Size = new System.Drawing.Size(219, 354);
            this.listBoxStorage.TabIndex = 11;
            this.listBoxStorage.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // panelFiles
            // 
            this.panelFiles.BackColor = System.Drawing.Color.Transparent;
            this.panelFiles.Controls.Add(this.buttonCreateStoragebutton);
            this.panelFiles.Controls.Add(this.buttonDelStorage);
            this.panelFiles.Controls.Add(this.buttonAddStorage);
            this.panelFiles.Controls.Add(this.labelPath);
            this.panelFiles.Controls.Add(this.listBoxStorage);
            this.panelFiles.Controls.Add(this.buttonCode);
            this.panelFiles.Controls.Add(this.buttonUnCode);
            this.panelFiles.Location = new System.Drawing.Point(10, 7);
            this.panelFiles.Margin = new System.Windows.Forms.Padding(2);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(247, 617);
            this.panelFiles.TabIndex = 12;
            // 
            // buttonDelStorage
            // 
            this.buttonDelStorage.BackColor = System.Drawing.Color.DimGray;
            this.buttonDelStorage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelStorage.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelStorage.Location = new System.Drawing.Point(124, 179);
            this.buttonDelStorage.Name = "buttonDelStorage";
            this.buttonDelStorage.Size = new System.Drawing.Size(101, 29);
            this.buttonDelStorage.TabIndex = 14;
            this.buttonDelStorage.Text = "Удалить";
            this.buttonDelStorage.UseVisualStyleBackColor = false;
            // 
            // buttonAddStorage
            // 
            this.buttonAddStorage.BackColor = System.Drawing.Color.DimGray;
            this.buttonAddStorage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddStorage.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddStorage.Location = new System.Drawing.Point(6, 179);
            this.buttonAddStorage.Name = "buttonAddStorage";
            this.buttonAddStorage.Size = new System.Drawing.Size(101, 29);
            this.buttonAddStorage.TabIndex = 13;
            this.buttonAddStorage.Text = "Добавить";
            this.buttonAddStorage.UseVisualStyleBackColor = false;
            this.buttonAddStorage.Click += new System.EventHandler(this.AddStorage_Click);
            // 
            // buttonCreateStoragebutton
            // 
            this.buttonCreateStoragebutton.BackColor = System.Drawing.Color.DimGray;
            this.buttonCreateStoragebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateStoragebutton.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateStoragebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateStoragebutton.Location = new System.Drawing.Point(6, 135);
            this.buttonCreateStoragebutton.Name = "buttonCreateStoragebutton";
            this.buttonCreateStoragebutton.Size = new System.Drawing.Size(199, 29);
            this.buttonCreateStoragebutton.TabIndex = 15;
            this.buttonCreateStoragebutton.Text = "Создать хранилище";
            this.buttonCreateStoragebutton.UseVisualStyleBackColor = false;
            this.buttonCreateStoragebutton.Click += new System.EventHandler(this.buttonCreateStoragebutton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Folder_Guard.Properties.Resources.dark_square;
            this.ClientSize = new System.Drawing.Size(829, 635);
            this.Controls.Add(this.panelFiles);
            this.Controls.Add(this.labelFileCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolderGuard";
            this.panelFiles.ResumeLayout(false);
            this.panelFiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.Label labelFileCount;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonUnCode;
        private System.Windows.Forms.ListBox listBoxStorage;
        private System.Windows.Forms.Panel panelFiles;
        private System.Windows.Forms.Button buttonDelStorage;
        private System.Windows.Forms.Button buttonAddStorage;
        private System.Windows.Forms.Button buttonCreateStoragebutton;
    }
}

