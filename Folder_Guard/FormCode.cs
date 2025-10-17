using System;
using System.Windows.Forms;

namespace Folder_Guard
{
    public partial class FormCode : Form
    {
        public FormCode()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        // Если нужны кнопки внутри формы, обработчики подключаем как обычно
        // button2 оставляем для другой логики
    }
}
