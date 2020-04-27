using System;
using System.Windows.Forms;

namespace DeadLineApp
{
    public partial class FormAdd : Form
    {
        DateTime date = new DateTime();
        public FormAdd()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePickerDate.Value.Date;
            textBoxDate.Text = date.ToShortDateString();
        }
    }
}   
