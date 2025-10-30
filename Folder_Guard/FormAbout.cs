using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folder_Guard
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            Themes();
        }

        void Themes()
        {
            switch (Properties.Settings.Default.Theme)
            {
                case 0: // Светлая тема
                    {
                        this.BackColor = Color.FromArgb(255, 255, 255);
                        label1.BackColor = Color.FromArgb(255, 255, 255);
                        label1.ForeColor = Color.FromArgb(33, 33, 33);
                        label4.BackColor = Color.FromArgb(255, 255, 255);
                        label4.ForeColor = Color.FromArgb(33, 33, 33);
                        label2.BackColor = Color.FromArgb(245, 245, 245);
                        label2.ForeColor = Color.FromArgb(33, 33, 33);
                        button3.BackColor = Color.FromArgb(245, 245, 245);
                        button3.ForeColor = Color.FromArgb(33, 33, 33);
                        pictureBox1.BackColor = Color.FromArgb(245, 245, 245);
                        break;
                    }

                case 1: // Тёмная тема (40, 40, 40) (33, 33, 33)
                    {

                        this.BackColor = Color.FromArgb(33, 33, 33);
                        label1.BackColor = Color.FromArgb(33, 33, 33);
                        label1.ForeColor = Color.FromArgb(255, 255, 255);
                        label4.BackColor = Color.FromArgb(33, 33, 33);
                        label4.ForeColor = Color.FromArgb(255, 255, 255);
                        label2.BackColor = Color.FromArgb(40, 40, 40);
                        label2.ForeColor = Color.FromArgb(255, 255, 255);
                        button3.BackColor = Color.FromArgb(40, 40, 40);
                        button3.ForeColor = Color.FromArgb(255, 255, 255);
                        pictureBox1.BackColor = Color.FromArgb(40, 40, 40);

                        break;
                    }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
