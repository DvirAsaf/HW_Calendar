using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalendarY
{
    public partial class Form1 : Form
    {
        int _month, _year;
        public static int StaticMonthI, StaticYearI, StaticDayI;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }
        
        //  Based on the data from DateTime, this method gets the correct month for the current day, month, and year
        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            _month = now.Month;
            _year = now.Year;
            String monthName = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(_month);
            LBDATE.Text = monthName + " " + _year;
            StaticMonthI = _month;
            StaticYearI = _year;
            DateTime startOfTheMonth = new DateTime(_year, _month, 1);
            int days = DateTime.DaysInMonth(_year, _month);
            int daysOfTheWeeks = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            StaticDayI = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            //  According to the month, we make the correct amount of user control blocks 
            for (int i = 1; i < daysOfTheWeeks; i++)
            {
                UserControlBlank ucb = new UserControlBlank();
                DayContainer.Controls.Add(ucb);
            }
            /*
                By setting the user control day to the day number he has,
                we are ensuring that the user's control is correct*/
            for(int i = 1; i <= days; i++)
            {
                UserControlDays ucd = new UserControlDays();
                ucd.Days(i);
                // Checking if the name day of each user control day (like Sunday) is the same as the scheduled day
                StaticDayI++;
                StaticDayI %= 7;
                DayContainer.Controls.Add(ucd);
                // This event's color is purple
                DayContainer.ForeColor  = Color.Purple;
            }
        }
        
        //  When we click the Previous button, we move to the previous month
        private void BtPrevious_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            _month--;
            if (_month < 1)
            {
                _month = 12;
                _year--;
            }
            String monthName = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(_month);
            LBDATE.Text = monthName + " " + _year;
            StaticMonthI = _month;
            StaticYearI = _year;
            DateTime startOfTheMonth = new DateTime(_year, _month, 1);
            StaticDayI = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            int days = DateTime.DaysInMonth(_year, _month);
            int daysOfTheWeeks = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < daysOfTheWeeks; i++)
            {
                UserControlBlank ucb = new UserControlBlank();
                DayContainer.Controls.Add(ucb);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucd = new UserControlDays();
                ucd.Days(i);
                StaticDayI++;
                StaticDayI %= 7;
                DayContainer.Controls.Add(ucd);
                DayContainer.ForeColor = Color.Purple;
            }
        }
        // When we click the Next button, we move to the next month
        private void BtNext_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            _month++;
            if (_month > 12)
            {
                _month = 1;
                _year++;
            }
            String monthName = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(_month);
            LBDATE.Text = monthName + " " + _year;
            StaticMonthI = _month;
            StaticYearI = _year;
            DateTime startOfTheMonth = new DateTime(_year, _month, 1);
            StaticDayI = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            int days = DateTime.DaysInMonth(_year, _month);
            int daysOfTheWeeks = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < daysOfTheWeeks; i++)
            {
                UserControlBlank ucb = new UserControlBlank();
                DayContainer.Controls.Add(ucb);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucd = new UserControlDays();
                ucd.Days(i);
                StaticDayI++;
                StaticDayI %= 7;
                DayContainer.Controls.Add(ucd);
                DayContainer.ForeColor = Color.Purple;
            }
        }
    }
}
