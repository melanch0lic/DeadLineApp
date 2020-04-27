using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

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
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.FlatStyle = FlatStyle.Flat;
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
                    mas = Dates[i].Replace('.', ' ').Split();
                    datetime = new DateTime(Convert.ToInt32(mas[2]), Convert.ToInt32(mas[1]), Convert.ToInt32(mas[0]));
                    monthCalendarDeadLine.AddBoldedDate(datetime);
                    monthCalendarDeadLine.UpdateBoldedDates();
                    listBoxDeadLine.Items.Add(frm2.textBoxNameOfStep.Text);
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
            monthCalendarDeadLine.TrailingForeColor = System.Drawing.Color.Red;
            timerDeadLine.Enabled = true;
            labelTIme.Hide();
            labelInfoStep.Hide();
            labelNameEdit.Hide();
            labelDateEdit.Hide();
            labelTimeEdit.Hide();
            labelEd.Hide();
            textBoxDateEdit.Hide();
            textBoxHoursEdit.Hide();
            textBoxMinutesEdit.Hide();
            textBoxNameEdit.Hide();
            buttonEdit.Hide();
            buttonDelete.Hide();
            labelTIme.BackColor = Color.Transparent;
            labelTIme.ForeColor = Color.Snow;
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
            try
            {
                i = listBoxDeadLine.SelectedIndex;
                mas = Dates[i].Replace('.', ' ').Split();
                year = Convert.ToInt32(mas[2]);
                month = Convert.ToInt32(mas[1]);
                day = Convert.ToInt32(mas[0]);
                hours = Convert.ToInt32(Hours[i]);
                minutes = Convert.ToInt32(Minutes[i]);
                labelTIme.Show();
                textBoxHoursEdit.Text = hours.ToString();
                textBoxMinutesEdit.Text = minutes.ToString();
                textBoxNameEdit.Text = listBoxDeadLine.SelectedItem.ToString();
                textBoxDateEdit.Text = day.ToString() + "." + month.ToString() + "." + year.ToString();
                labelInfoStep.Show();
                labelNameEdit.Show();
                labelDateEdit.Show();
                labelTimeEdit.Show();
                labelEd.Show();
                textBoxDateEdit.Show();
                textBoxHoursEdit.Show();
                textBoxMinutesEdit.Show();
                textBoxNameEdit.Show();
                buttonEdit.Show();
                buttonDelete.Show();
            }
            catch
            {
                MessageBox.Show("Вы удалили этап!");
                monthCalendarDeadLine.RemoveBoldedDate(datetime);
                monthCalendarDeadLine.UpdateBoldedDates();
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для того чтобы добавить дату и время дедлайна в список нажмите кнопку \"Открыть Окно Добавления\".\nПосле этого откроется окно в котором необходимо ввести дату и время дедлайна и после этого нажать кнопку \"Добавить Этап\",этап добавится и дата выделится в календаре.\nПри клике на дату в списке будет выводиться обратный отсчет до этапа дедлайна.\nВводить дату нужно через пробел!");
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Dates[i] = textBoxDateEdit.Text;
            Hours[i] = textBoxHoursEdit.Text;
            Minutes[i] = textBoxMinutesEdit.Text;
            listBoxDeadLine.Items[i] = textBoxNameEdit.Text;           
            hours = Convert.ToInt32(Hours[i]);
            minutes = Convert.ToInt32(Minutes[i]);
            labelTIme.Show();        
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Dates.RemoveAt(i);
            Hours.RemoveAt(i);
            Minutes.RemoveAt(i);
            listBoxDeadLine.Items.RemoveAt(i);
        }
    }
}
