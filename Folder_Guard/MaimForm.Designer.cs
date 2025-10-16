namespace Folder_Guard
{
    partial class MaimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaimForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Folder_Guard.Properties.Resources.dark_background_image;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::Folder_Guard.Properties.Resources.dark_background_image;
            this.button2.Location = new System.Drawing.Point(23, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Файл";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Image = global::Folder_Guard.Properties.Resources.dark_square;
            this.label1.Location = new System.Drawing.Point(222, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = global::Folder_Guard.Properties.Resources.dark_square;
            this.label2.Location = new System.Drawing.Point(364, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата изменения";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = global::Folder_Guard.Properties.Resources.dark_square;
            this.label3.Location = new System.Drawing.Point(549, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(553, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(38, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = global::Folder_Guard.Properties.Resources.dark_square;
            this.label4.Location = new System.Drawing.Point(649, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Размер";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(653, 55);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 20);
            this.textBox4.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Folder_Guard.Properties.Resources.dark_background_image;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(12, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 39);
            this.button3.TabIndex = 10;
            this.button3.Text = "Расшифровать";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MaimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Folder_Guard.Properties.Resources.dark_square;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaimForm";
            this.Text = "FolderGuard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
    }
}

