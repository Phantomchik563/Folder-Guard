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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Folder_Guard
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
            Themes();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void Themes()
        {
            switch (Properties.Settings.Default.Theme)
            {
                case 0: // Светлая тема
                    {
                        this.BackColor = Color.FromArgb(255, 255, 255);
                        label1.BackColor = Color.FromArgb(245, 245, 245);
                        label1.ForeColor = Color.FromArgb(33, 33, 33);
                        label5.BackColor = Color.FromArgb(255, 255, 255);
                        label5.ForeColor = Color.FromArgb(33, 33, 33);
                        label9.BackColor = Color.FromArgb(255, 255, 255);
                        label9.ForeColor = Color.FromArgb(33, 33, 33);
                        label2.BackColor = Color.FromArgb(245, 245, 245);
                        label2.ForeColor = Color.FromArgb(33, 33, 33);
                        pictureBox1.BackColor = Color.FromArgb(245, 245, 245);
                        pictureBox3.BackColor = Color.FromArgb(245, 245, 245);


                        break;
                    }

                case 1: // Тёмная тема (40, 40, 40) (33, 33, 33)
                    {

                        this.BackColor = Color.FromArgb(33, 33, 33);
                        label1.BackColor = Color.FromArgb(40, 40, 40);
                        label1.ForeColor = Color.FromArgb(255, 255, 255);
                        label5.BackColor = Color.FromArgb(33, 33, 33);
                        label5.ForeColor = Color.FromArgb(255, 255, 255);
                        label9.BackColor = Color.FromArgb(33, 33, 33);
                        label9.ForeColor = Color.FromArgb(255, 255, 255);
                        label2.BackColor = Color.FromArgb(40, 40, 40);
                        label2.ForeColor = Color.FromArgb(255, 255, 255);
                        pictureBox1.BackColor = Color.FromArgb(40, 40, 40);
                        pictureBox3.BackColor = Color.FromArgb(40, 40, 40);


                        break;
                    }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
