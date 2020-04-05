using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace DeadLineApp
{
     
    public partial class FormDeadLine : Form
    {
        string[] mas;
        int year = 2001;
        int month = 02;
        int day = 25;
        int hours = 10;
        int minutes = 10;
        DateTime datetime;
        List<string> Hours = new List<string>();
        List<string> Minutes = new List<string>();
        List<string> Dates = new List<string>();
        int i = 0;
        private FormAdd frm2;
        public FormDeadLine()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (frm2.textBoxDate.Text != "" || frm2.textBoxHours.Text != "" || frm2.textBoxMinutes.Text != "")
                {
                    Dates.Add(frm2.textBoxDate.Text);
                    Hours.Add(frm2.textBoxHours.Text);
                    Minutes.Add(frm2.textBoxMinutes.Text);
                    mas = Dates[i].Split();
                    datetime = new DateTime(Convert.ToInt32(mas[2]), Convert.ToInt32(mas[1]), Convert.ToInt32(mas[0]));
                    monthCalendar1.AddBoldedDate(datetime);
                    monthCalendar1.UpdateBoldedDates();
                    listBoxDeadLine.Items.Add(frm2.textBoxDate.Text + " " + frm2.textBoxHours.Text + ":" + frm2.textBoxMinutes.Text);
                    frm2.Close();
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Введите дату правильно!");
                Dates.RemoveAt(i);
                Hours.RemoveAt(i);
                Minutes.RemoveAt(i);        
                frm2.Close();
            }         
        }

        private void buttonWindowAdd_Click(object sender, EventArgs e)
        {
            frm2 = new FormAdd();
            frm2.Show();
        }

        private void FormDeadLine_Load(object sender, EventArgs e)
        {           
            monthCalendar1.TrailingForeColor = System.Drawing.Color.Red;
            timerDeadLine.Enabled = true;
            labelTIme.Hide();
        }

        private void timerDeadLine_Tick(object sender, EventArgs e)
        {
            DateTime b = new DateTime(year: year, month: month, day: day, hour:hours, minute: minutes, second : 0);
            TimeSpan kek = b - DateTime.Now;
            String.Format("{0:00}:{1:00}:{2:00}:{3:00}", kek.Days, kek.Hours, kek.Minutes, kek.Seconds);
            labelTIme.Text = "Осталось: " + String.Format("{0:00} Дней {1:00} Часов {2:00} Минут ", kek.Days, kek.Hours, kek.Minutes);
        }
        private void listBoxDeadLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = listBoxDeadLine.SelectedIndex;
            mas = Dates[i].Split();
            year = Convert.ToInt32(mas[2]);
            month = Convert.ToInt32(mas[1]);
            day = Convert.ToInt32(mas[0]);
            hours = Convert.ToInt32(Hours[i]);
            minutes = Convert.ToInt32(Minutes[i]);
            labelTIme.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для того чтобы добавить дату и время дедлайна в список нажмите кнопку \"Открыть Окно Добавления\".\nПосле этого откроется окно в котором необходимо ввести дату и время дедлайна и после этого нажать кнопку \"Добавить Этап\",этап добавится и дата выделится в календаре.\nПри клике на дату в списке будет выводиться обратный отсчет до этапа дедлайна.\nВводить дату нужно через пробел!");
        }
    }
}
