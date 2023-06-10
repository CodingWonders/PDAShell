using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDAShell.Main
{
    public partial class MainForm : Form
    {

        public string ownerName;
        public string ownerCompany;
        public string ownerAddress;
        public string ownerPhone;
        public string ownerEmail;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("HH:mm");
            dateLbl.Text = DateTime.Now.ToLongDateString();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("HH:mm");
            dateLbl.Text = DateTime.Now.ToLongDateString();
        }

        private void shellBtn_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(shellBtn, new Point(0, shellBtn.Height));
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeBtn.Visible = true;
            startScreen.Visible = false;
            settingsPanel.Visible = true;
            titleLabel.Text = "Settings";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (closeBtn.Tag.ToString() == "ok")
            {
                closeBtn.Image = Properties.Resources.close;
                closeBtn.Tag = "close";
                // Apply settings
                ApplySettings();
                // Hide secondary screens
                ownerInfoSettings.Visible = false;
            }
            else if (closeBtn.Tag.ToString() == "close")
            {
                settingsPanel.Visible = false;
                startScreen.Visible = true;
                closeBtn.Visible = false;
                titleLabel.Text = "Start";
            }
        }

        public void ApplySettings()
        {
            // Set initial variables. Since this is volatile (for now), these settings aren't saved
            ownerName = nameBox.Text;
            ownerCompany = companyBox.Text;
            ownerAddress = addressBox.Text;
            ownerPhone = phoneBox.Text;
            ownerEmail = emailBox.Text;
            // Make settings noticeable
            if (ownerName != "") { label1.Text = ownerName + " (" + ownerPhone + ")"; } else { label1.Text = "Tap or click here to set owner information"; }
        }

        public void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1) 
            { 
                switch (listView1.FocusedItem.Index)
                {
                    case 0:
                        ownerInfoSettings.Visible = true;
                        closeBtn.Image = Properties.Resources.ok;
                        closeBtn.Tag = "ok";
                        break;
                    default:
                        break;
                }
            }

        }

        private void ownerInfoChanged(object sender, EventArgs e)
        {
            usrName.Text = nameBox.Text;
            usrCompany.Text = "I work for" + (companyBox.Text != "" ? " " + companyBox.Text : "...");
            usrAddress.Text = "I live in" + (addressBox.Text != "" ? " " + addressBox.Text : "...");
            usrPhone.Text = "Contact me at" + (phoneBox.Text != "" ? " " + phoneBox.Text : "...");
            usrEMail.Text = "Send e-mails to" + (emailBox.Text != "" ? " " + emailBox.Text : "...");
        }
    }
}
