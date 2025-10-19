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
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
            Themes();
            
            comboBox1.SelectedIndex = Properties.Settings.Default.Theme;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Триггер на выбор тем
        {
            switch (comboBox1.SelectedIndex)
            {

                case 0:
                    Properties.Settings.Default.Theme = 0; //Светлая тема
                    break;


                case 1:
                    Properties.Settings.Default.Theme = 1; //Тёмная тема
                    break;
            }
            Properties.Settings.Default.Save();
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
                        label2.BackColor = Color.FromArgb(255, 255, 255);
                        label2.ForeColor = Color.FromArgb(33, 33, 33);
                        label3.BackColor = Color.FromArgb(245, 245, 245);
                        label3.ForeColor = Color.FromArgb(33, 33, 33);
                        textBox1.BackColor = Color.FromArgb(255, 255, 255);
                        textBox1.ForeColor = Color.FromArgb(33, 33, 33);
                        button1.BackColor = Color.FromArgb(255, 255, 255);
                        button1.ForeColor = Color.FromArgb(33, 33, 33);
                        comboBox1.BackColor = Color.FromArgb(255, 255, 255);
                        comboBox1.ForeColor = Color.FromArgb(33, 33, 33);
                        pictureBox1.BackColor = Color.FromArgb(245, 245, 245);


                        break;
                    }

                case 1: // Тёмная тема (40, 40, 40) (33, 33, 33)
                    {
                        this.BackColor = Color.FromArgb(33, 33, 33);
                        label1.BackColor = Color.FromArgb(33, 33, 33);
                        label1.ForeColor = Color.FromArgb(255, 255, 255);
                        label2.BackColor = Color.FromArgb(33, 33, 33);
                        label2.ForeColor = Color.FromArgb(255, 255, 255);
                        label3.BackColor = Color.FromArgb(40, 40, 40);
                        label3.ForeColor = Color.FromArgb(255, 255, 255);
                        textBox1.BackColor = Color.FromArgb(40, 40, 40);
                        textBox1.ForeColor = Color.FromArgb(255, 255, 255);
                        button1.BackColor = Color.FromArgb(40, 40, 40);
                        button1.ForeColor = Color.FromArgb(255, 255, 255);
                        comboBox1.BackColor = Color.FromArgb(40, 40, 40);
                        comboBox1.ForeColor = Color.FromArgb(255, 255, 255);
                        pictureBox1.BackColor = Color.FromArgb(40, 40, 40);

                        

                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Iteration = int.Parse(textBox1.Text);
            Properties.Settings.Default.Save();


        }
    }
}
