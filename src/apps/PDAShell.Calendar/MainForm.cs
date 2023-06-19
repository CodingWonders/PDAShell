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
        public static bool isInEditMode { get; set; }
        public static string prevEventName { get; set; }

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
            listView1.Items.Clear();
            // Iterate through the event list
            foreach (Event calEvent in events)
            {
                if (calEvent.Date == monthCalendar1.SelectionRange.Start)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { calEvent.AllDay ? "ALL DAY" : "", calEvent.Name + (calEvent.Scheduled ? "(scheduled)" : "")}));
                }
            }
            timer1.Enabled = true;
            //// Create test events
            //Event test = new Event();
            //test.Name = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. This is a long text test, designed to test automatic control resizes";
            //test.Date = DateTime.Today;
            //test.AllDay = true;
            //test.Description = "";
            //events.Add(test);
            //Event test2 = new Event();
            //test2.Name = "Shorter test";
            //test2.Date = DateTime.Today;
            //test2.AllDay = true;
            //test2.Description = "";
            //events.Add(test2);
            // Add start and end time entries
            for (int i = 0; i < 24 * 4; i++)
            {
                TimeSpan ts = TimeSpan.FromMinutes(i * 15);
                comboBox1.Items.Add(ts);
                comboBox2.Items.Add(ts);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("HH:mm");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (eventView.Visible)
            {
                eventView.Visible = false;
                calendarView.Visible = true;
            }
            else if (calendarView.Visible)
            {
                Environment.Exit(0);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateLbl.Text = e.Start.ToLongDateString().ToUpper();
            listView1.Items.Clear();
            // Iterate through the event list
            foreach (Event calEvent in events)
            {
                if (calEvent.Date.Date == e.Start)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { calEvent.AllDay ? "ALL DAY" : (calEvent.StartTime.ToString("HH:mm") + " - " + calEvent.EndTime.ToString("HH:mm")), calEvent.Name + (calEvent.Scheduled ? "(scheduled)" : "")}));
                }
            }
        }

        private void prevYear_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = new DateTime(monthCalendar1.SelectionStart.Year - 1, monthCalendar1.SelectionStart.Month, monthCalendar1.SelectionStart.Day);
        }

        private void prevMonth_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.SelectionStart.Month == 1)
            {
                monthCalendar1.SelectionStart = new DateTime(monthCalendar1.SelectionStart.Year - 1, 12, monthCalendar1.SelectionStart.Day);
            }
            else
            {
                monthCalendar1.SelectionStart = new DateTime(monthCalendar1.SelectionStart.Year, monthCalendar1.SelectionStart.Month - 1, monthCalendar1.SelectionStart.Day);
            }

        }

        private void todayPic_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = DateTime.Today;
        }

        private void nextMonth_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.SelectionStart.Month == 12)
            {
                monthCalendar1.SelectionStart = new DateTime(monthCalendar1.SelectionStart.Year + 1, 1, monthCalendar1.SelectionStart.Day);
            }
            else
            {
                monthCalendar1.SelectionStart = new DateTime(monthCalendar1.SelectionStart.Year, monthCalendar1.SelectionStart.Month + 1, monthCalendar1.SelectionStart.Day);
            }
        }

        private void nextYear_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = new DateTime(monthCalendar1.SelectionStart.Year + 1, monthCalendar1.SelectionStart.Month, monthCalendar1.SelectionStart.Day);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                evtTitle.Text = listView1.FocusedItem.SubItems[1].Text;
                // Iterate through the event list to find the desired one
                foreach (Event calEvent in events)
                {
                    if (calEvent.Name == listView1.FocusedItem.SubItems[1].Text)
                    {
                        evtDescriptionText.Text = calEvent.Description;
                        dateTimePicker1.Value = calEvent.Date;
                        checkBox1.Checked = calEvent.AllDay;
                        startTimeLbl.Text = calEvent.AllDay ? "(all day)" : calEvent.StartTime.ToString();
                        endTimeLbl.Text = calEvent.AllDay ? "(all day)" : calEvent.EndTime.ToString();
                        scheduleStatus.Text = calEvent.Schedule ? "This event is scheduled" : "This event is not scheduled";
                        if (calEvent.Schedule)
                        {
                            switch (calEvent.ScheduleMode)
                            {
                                case 0:
                                    scheduleStatus.Text += " to repeat daily";
                                    break;
                                case 1:
                                    scheduleStatus.Text += " to repeat weekly";
                                    break;
                                case 2:
                                    scheduleStatus.Text += " to repeat monthly";
                                    break;
                                case 3:
                                    scheduleStatus.Text += " to repeat yearly";
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                calendarView.Visible = false;
                eventView.Visible = true;
            }
        }

        private void evtTitle_TextChanged(object sender, EventArgs e)
        {
            Size sz = new Size(evtTitle.Width, Int32.MaxValue);
            sz = TextRenderer.MeasureText(evtTitle.Text, evtTitle.Font, sz, TextFormatFlags.WordBreak);
            evtTitle.Height = sz.Height;
        }

        private void wrapToggle_CheckedChanged(object sender, EventArgs e)
        {
            evtDescriptionText.WordWrap = wrapToggle.Checked;
        }

        private void newAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prevEventName = "";
            calendarView.Visible = false;
            editEvt.Visible = true;
        }

        private void ok_Btn_Click(object sender, EventArgs e)
        {
            Event changedEvent = new Event();
            changedEvent.Name = evtNameText.Text;
            changedEvent.Description = evtDescText.Text;
            changedEvent.Date = dateTimePicker2.Value;
            changedEvent.AllDay = checkBox2.Checked;
            if (changedEvent.AllDay)
            {
                changedEvent.StartTime = new TimeSpan(0, 0, 0);
                changedEvent.EndTime = new TimeSpan(0, 0, 0);
            }
            else
            {
                changedEvent.StartTime = new TimeSpan(0, 0, 0);
                changedEvent.EndTime = new TimeSpan(0, 0, 0);
            }
            changedEvent.Schedule = radioButton2.Checked;
            if (changedEvent.Schedule)
            {
                changedEvent.ScheduleMode = comboBox3.SelectedIndex;
            }
            if (isInEditMode)
            {
                // Iterate through the events
                foreach (Event calEvent in events)
                {
                    if (calEvent.Name == prevEventName)
                    {
                        events[events.IndexOf(calEvent)] = changedEvent;
                        break;
                    }
                }
            }
            else
            {
                events.Add(changedEvent);
            }
            editEvt.Visible = false;
            calendarView.Visible = true;
        }
    }
}
