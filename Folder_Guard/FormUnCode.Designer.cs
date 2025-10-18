namespace Folder_Guard
{
    partial class FormUnCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnCode));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnterUnCode = new System.Windows.Forms.Button();
            this.textBoxUnCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = global::Folder_Guard.Properties.Resources.dark_square;
            this.label1.Location = new System.Drawing.Point(91, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите код для расшифровки";
            // 
            // buttonEnterUnCode
            // 
            this.buttonEnterUnCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnterUnCode.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnterUnCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEnterUnCode.Image = global::Folder_Guard.Properties.Resources.dark_background_image;
            this.buttonEnterUnCode.Location = new System.Drawing.Point(261, 146);
            this.buttonEnterUnCode.Name = "buttonEnterUnCode";
            this.buttonEnterUnCode.Size = new System.Drawing.Size(97, 46);
            this.buttonEnterUnCode.TabIndex = 4;
            this.buttonEnterUnCode.Text = "Ввести";
            this.buttonEnterUnCode.UseVisualStyleBackColor = true;
            this.buttonEnterUnCode.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxUnCode
            // 
            this.textBoxUnCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUnCode.Location = new System.Drawing.Point(119, 155);
            this.textBoxUnCode.Name = "textBoxUnCode";
            this.textBoxUnCode.Size = new System.Drawing.Size(100, 29);
            this.textBoxUnCode.TabIndex = 5;
            // 
            // FormUnCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Folder_Guard.Properties.Resources.dark_square;
            this.ClientSize = new System.Drawing.Size(462, 294);
            this.Controls.Add(this.textBoxUnCode);
            this.Controls.Add(this.buttonEnterUnCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUnCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolderGuard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnterUnCode;
        private System.Windows.Forms.TextBox textBoxUnCode;
    }
}