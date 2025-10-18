namespace Folder_Guard
{
    partial class FormCreateStorage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateStorage));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddStorage = new System.Windows.Forms.Button();
            this.buttonDelStorage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(17, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 31);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(17, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 31);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите название хранилища";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите пароль для хранилища";
            // 
            // buttonAddStorage
            // 
            this.buttonAddStorage.BackColor = System.Drawing.Color.DimGray;
            this.buttonAddStorage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddStorage.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddStorage.Location = new System.Drawing.Point(17, 198);
            this.buttonAddStorage.Name = "buttonAddStorage";
            this.buttonAddStorage.Size = new System.Drawing.Size(101, 29);
            this.buttonAddStorage.TabIndex = 14;
            this.buttonAddStorage.Text = "Отмена";
            this.buttonAddStorage.UseVisualStyleBackColor = false;
            this.buttonAddStorage.Click += new System.EventHandler(this.buttonAddStorage_Click);
            // 
            // buttonDelStorage
            // 
            this.buttonDelStorage.BackColor = System.Drawing.Color.DimGray;
            this.buttonDelStorage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelStorage.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelStorage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelStorage.Location = new System.Drawing.Point(224, 198);
            this.buttonDelStorage.Name = "buttonDelStorage";
            this.buttonDelStorage.Size = new System.Drawing.Size(101, 29);
            this.buttonDelStorage.TabIndex = 15;
            this.buttonDelStorage.Text = "Ввести";
            this.buttonDelStorage.UseVisualStyleBackColor = false;
            // 
            // FormCreateStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Folder_Guard.Properties.Resources.dark_square;
            this.ClientSize = new System.Drawing.Size(343, 250);
            this.Controls.Add(this.buttonDelStorage);
            this.Controls.Add(this.buttonAddStorage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateStorage";
            this.Text = "FolderGuard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddStorage;
        private System.Windows.Forms.Button buttonDelStorage;
    }
}