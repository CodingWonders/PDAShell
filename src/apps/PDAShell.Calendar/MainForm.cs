using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDAShell.Calendar
{
    public partial class MainForm : Form
    {

        List<Event> events = new List<Event>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
            else 
            { 
                FormBorderStyle = FormBorderStyle.None;
            }
            clockLabel.Text = DateTime.Now.ToString("HH:mm");
            dateLbl.Text = DateTime.Now.ToLongDateString().ToUpper();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("HH:mm");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateLbl.Text = e.Start.ToLongDateString().ToUpper();
            listView1.Items.Clear();
            // Iterate through the event list
            foreach (Event calEvent in events)
            {
                if (calEvent.Date == e.Start)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { calEvent.AllDay ? "ALL DAY" : "", calEvent.Name }));
                }
            }
        }

        private void prevYear_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = new DateTime(monthCalendar1.SelectionStart.Year - 1, monthCalendar1.SelectionStart.Month, monthCalendar1.SelectionStart.Day);
        }

        private void prevMonth_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = new DateTime(monthCalendar1.SelectionStart.Year, monthCalendar1.SelectionStart.Month - 1, monthCalendar1.SelectionStart.Day);
        }

        private void todayPic_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = DateTime.Today;
        }

        private void nextMonth_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = new DateTime(monthCalendar1.SelectionStart.Year, monthCalendar1.SelectionStart.Month + 1, monthCalendar1.SelectionStart.Day);
        }

        private void nextYear_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = new DateTime(monthCalendar1.SelectionStart.Year + 1, monthCalendar1.SelectionStart.Month, monthCalendar1.SelectionStart.Day);
        }
    }
}
