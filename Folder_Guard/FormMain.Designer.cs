using System;

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
            this.panelFiles = new System.Windows.Forms.Panel();
            this.buttonUnCode = new System.Windows.Forms.Button();
            this.buttonCreateStorage = new System.Windows.Forms.Button();
            this.buttonDelStorage = new System.Windows.Forms.Button();
            this.buttonAddStorage = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeViewProvodnik = new System.Windows.Forms.TreeView();
            this.treeViewStorage = new System.Windows.Forms.TreeView();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.panelFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCode
            // 
            this.buttonCode.BackColor = System.Drawing.Color.DimGray;
            this.buttonCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCode.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCode.Location = new System.Drawing.Point(6, 53);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(219, 29);
            this.buttonCode.TabIndex = 1;
            this.buttonCode.Text = "Открыть хранилище";
            this.buttonCode.UseVisualStyleBackColor = false;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // panelFiles
            // 
            this.panelFiles.BackColor = System.Drawing.Color.Transparent;
            this.panelFiles.Controls.Add(this.buttonUnCode);
            this.panelFiles.Controls.Add(this.buttonCreateStorage);
            this.panelFiles.Controls.Add(this.buttonDelStorage);
            this.panelFiles.Controls.Add(this.buttonAddStorage);
            this.panelFiles.Controls.Add(this.buttonCode);
            this.panelFiles.Location = new System.Drawing.Point(10, 7);
            this.panelFiles.Margin = new System.Windows.Forms.Padding(2);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(247, 617);
            this.panelFiles.TabIndex = 12;
            // 
            // buttonUnCode
            // 
            this.buttonUnCode.BackColor = System.Drawing.Color.DimGray;
            this.buttonUnCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUnCode.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUnCode.Location = new System.Drawing.Point(6, 144);
            this.buttonUnCode.Name = "buttonUnCode";
            this.buttonUnCode.Size = new System.Drawing.Size(219, 29);
            this.buttonUnCode.TabIndex = 16;
            this.buttonUnCode.Text = "Дешифровать";
            this.buttonUnCode.UseVisualStyleBackColor = false;
            // 
            // buttonCreateStorage
            // 
            this.buttonCreateStorage.BackColor = System.Drawing.Color.DimGray;
            this.buttonCreateStorage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateStorage.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateStorage.Location = new System.Drawing.Point(6, 9);
            this.buttonCreateStorage.Name = "buttonCreateStorage";
            this.buttonCreateStorage.Size = new System.Drawing.Size(219, 29);
            this.buttonCreateStorage.TabIndex = 15;
            this.buttonCreateStorage.Text = "Создать хранилище";
            this.buttonCreateStorage.UseVisualStyleBackColor = false;
            this.buttonCreateStorage.Click += new System.EventHandler(this.buttonCreateStoragebutton_Click);
            // 
            // buttonDelStorage
            // 
            this.buttonDelStorage.BackColor = System.Drawing.Color.DimGray;
            this.buttonDelStorage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelStorage.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelStorage.Location = new System.Drawing.Point(6, 197);
            this.buttonDelStorage.Name = "buttonDelStorage";
            this.buttonDelStorage.Size = new System.Drawing.Size(216, 29);
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
            this.buttonAddStorage.Location = new System.Drawing.Point(6, 96);
            this.buttonAddStorage.Name = "buttonAddStorage";
            this.buttonAddStorage.Size = new System.Drawing.Size(216, 29);
            this.buttonAddStorage.TabIndex = 13;
            this.buttonAddStorage.Text = "Зашифровать";
            this.buttonAddStorage.UseVisualStyleBackColor = false;
            this.buttonAddStorage.Click += new System.EventHandler(this.AddStorage_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.DimGray;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHelp.Location = new System.Drawing.Point(748, 7);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(113, 29);
            this.buttonHelp.TabIndex = 16;
            this.buttonHelp.Text = "Помощь";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(269, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Список хранилищ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(579, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ваш проводник:";
            // 
            // treeViewProvodnik
            // 
            this.treeViewProvodnik.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.treeViewProvodnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewProvodnik.Location = new System.Drawing.Point(584, 103);
            this.treeViewProvodnik.Name = "treeViewProvodnik";
            this.treeViewProvodnik.Size = new System.Drawing.Size(277, 504);
            this.treeViewProvodnik.TabIndex = 20;
            // 
            // treeViewStorage
            // 
            this.treeViewStorage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.treeViewStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewStorage.Location = new System.Drawing.Point(274, 103);
            this.treeViewStorage.Name = "treeViewStorage";
            this.treeViewStorage.Size = new System.Drawing.Size(266, 504);
            this.treeViewStorage.TabIndex = 21;
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.Color.DimGray;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetting.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSetting.Location = new System.Drawing.Point(615, 7);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(113, 29);
            this.buttonSetting.TabIndex = 22;
            this.buttonSetting.Text = "Настройки";
            this.buttonSetting.UseVisualStyleBackColor = false;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Folder_Guard.Properties.Resources.dark_square;
            this.ClientSize = new System.Drawing.Size(901, 635);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.treeViewStorage);
            this.Controls.Add(this.treeViewProvodnik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.panelFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolderGuard";
            this.panelFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AddStorage_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.Panel panelFiles;
        private System.Windows.Forms.Button buttonAddStorage;
        private System.Windows.Forms.Button buttonCreateStorage;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonUnCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelStorage;
        private System.Windows.Forms.TreeView treeViewProvodnik;
        private System.Windows.Forms.TreeView treeViewStorage;
        private System.Windows.Forms.Button buttonSetting;
    }
}

