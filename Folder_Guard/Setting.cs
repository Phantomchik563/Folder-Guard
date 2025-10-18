using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
