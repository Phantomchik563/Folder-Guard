using System;
using System.Drawing;
using System.Windows.Forms;

namespace Folder_Guard
{
    public partial class FormCreateStorage : Form
    {
        public FormCreateStorage()
        {
            InitializeComponent();
            Themes();
            // Только крестик
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = true;

            // Центр родительской формы
            this.StartPosition = FormStartPosition.CenterParent;

            // Убираем мигание главной формы
            this.ShowInTaskbar = false;
        }

        // Принудительное закрытие формы при клике на крестик
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (this.DialogResult == DialogResult.None)
                this.DialogResult = DialogResult.Cancel;
        }


        void Themes()
        {
            switch (Properties.Settings.Default.Theme)
            {
                case 0: // Светлая тема
                    {
                        this.BackColor = Color.FromArgb(250, 250, 250);
                        button3.BackColor = Color.FromArgb(250, 250, 250);
                        button3.ForeColor = Color.FromArgb(33, 33, 33);
                        buttonDelStorage.BackColor = Color.FromArgb(250, 250, 250);
                        buttonDelStorage.ForeColor = Color.FromArgb(33, 33, 33);
                        textBox1.BackColor = Color.FromArgb(255, 255, 255);
                        textBox1.ForeColor = Color.FromArgb(33, 33, 33);
                        textBox2.BackColor = Color.FromArgb(255, 255, 255);
                        textBox2.ForeColor = Color.FromArgb(33, 33, 33);
                        label4.BackColor = Color.FromArgb(250, 250, 250);
                        label4.ForeColor = Color.FromArgb(33, 33, 33);
                        label3.BackColor = Color.FromArgb(250, 250, 250);
                        label3.ForeColor = Color.FromArgb(33, 33, 33);
                        

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
