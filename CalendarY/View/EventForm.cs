using System;
using System.Windows.Forms;

namespace CalendarY
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            TextDate.Text = Form1.StaticMonthI + "/" + UserControlDays.StaticDay + "/" + Form1.StaticYearI;
        }

        //  Once the user clicks save on the popup message, the event data is inserted into the database
        private void btSave_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=database.db; Version = 3; New = True; Compress = True;";
            ViewModel.VM.Connect = connString;
            String date = TextDate.Text;
            String even = TextEvent.Text;
            var conn = ViewModel.VM.Table();
            ViewModel.VM.Insert(date, even);
            MessageBox.Show("Saved");
            ViewModel.VM.CloseConnection(conn);
        }
    }
}
