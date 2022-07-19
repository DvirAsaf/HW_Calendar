using System;
using System.Drawing;
using System.Windows.Forms;
namespace CalendarY
{
    public partial class UserControlDays : UserControl
    {
        public static string StaticDay;
        public static string WeekDay;
        public UserControlDays()
        {
            InitializeComponent();
        }
        // Schedule dates in the calendar
        public void Days(int numDay)
        {
            weekDay.Text = Form1.StaticDayI + "";
            WeekDay = weekDay.Text;
            lbDays.Text = numDay + "";

            // Update the calendar with information from the database
            UpdateCalendarFromDb();
        }

        // Clicked day - handle method
        private void UserControlDays_Click(object sender, EventArgs e)
        {
            StaticDay = lbDays.Text;
            WeekDay = weekDay.Text;
            timer1.Start();
            // The user can enter text in a popup window
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        // When the dataBase is changed, the view is updated
        private void UpdateCalendarFromDb()
        {
            int dayIndex = Convert.ToInt32(weekDay.Text);
            //int dayIndex = Convert.ToInt32(WeekDay);
            string userInputText = lbDays.Text;
            ViewModel.VM.PassUserInput(userInputText);

            if (ViewModel.VM.Flag)
            {
                lbEvent.Text = ViewModel.VM.LbEvent;
                // If the event is on Friday or Saturday, we want the number of the event day to be colored red
                if (dayIndex == 5 || dayIndex == 6)
                {
                    lbDays.ForeColor = Color.Red;
                }
                // Otherwise, we want it to be blue
                else
                {
                    lbDays.ForeColor = Color.Blue;
                }
                // If we enter an empty string, we want the color to return to black 
                if (lbEvent.Text == "")
                {
                    lbDays.ForeColor = Color.Black;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateCalendarFromDb();
        }
    }
}
