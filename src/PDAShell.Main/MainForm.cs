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
        public static bool isAccepted { get; set; }

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
            applicationsScreen.Visible = false;
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
                settings_mainScreen.Visible = true;
            }
            else if (closeBtn.Tag.ToString() == "close")
            {
                settingsPanel.Visible = false;
                applicationsScreen.Visible = false;
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
                        settings_mainScreen.Visible = false;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeBtn.Visible = true;
            startScreen.Visible = false;
            settingsPanel.Visible = false;
            applicationsScreen.Visible = true;
            titleLabel.Text = "Applications";
        }

        public void showDialog(int dlgWidth, int dlgHeight, string caption, string message, bool showIcon, int iconType, bool showOKBtn, bool showCancelBtn)
        {
            Form dialogBox = new Dialogs.DialogBox();
            dialogBox.Size = new Size(dlgWidth, dlgHeight);
            foreach (Control control in dialogBox.Controls)
            {
                if (control is Panel)
                {
                    foreach (Control panelControl in control.Controls)
                    {
                        if (panelControl is Label)
                        {
                            if (panelControl.Name == "captionLabel") 
                            {
                                Label captionLabel = (Label)panelControl;
                                captionLabel.Text = caption;
                            }
                        }
                        if (panelControl is PictureBox)
                        {
                            if (panelControl.Name == "okBtn")
                            {
                                panelControl.Visible = showOKBtn;
                            }
                            else if (panelControl.Name == "cancelBtn")
                            {
                                panelControl.Visible = showCancelBtn;
                            }
                        }
                    }
                }
                if (control is TableLayoutPanel)
                {
                    foreach (Control tlpControl in control.Controls)
                    {
                        if (tlpControl is Label)
                        {
                            if (tlpControl.Name == "captionLabel") 
                            {
                                Label captionLabel = (Label)tlpControl;
                                captionLabel.Text = caption;
                            }
                            else if (tlpControl.Name == "messageLabel") 
                            {
                                Label messageLabel = (Label)tlpControl;
                                messageLabel.Text = message;
                            }
                        }
                        if (tlpControl is PictureBox)
                        {
                            if (tlpControl.Name == "iconPicture")
                            {
                                PictureBox icon = (PictureBox)tlpControl;
                                icon.Visible = showIcon;
                                switch (iconType)
                                {
                                    case 0:
                                        icon.Image = Properties.Resources.success;
                                        break;
                                    case 1:
                                        icon.Image = Properties.Resources.question;
                                        break;
                                    case 2:
                                        icon.Image = Properties.Resources.information;
                                        break;
                                    case 3:
                                        icon.Image = Properties.Resources.exclamation;
                                        break;
                                    case 4:
                                        icon.Image = Properties.Resources.error;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            dialogBox.ShowDialog();
        }

        private void listView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (listView3.FocusedItem.Index)
            {
                case 8:
                    showDialog(400, 260, "Other Installed Applications", "We don't know whether these applications can get you distracted.\n\nAre you sure you want to continue?", true, 1, true, true);
                    if (isAccepted)
                    {
                        apps_mainScreen.Visible = false;
                        otherApps.Visible = true;
                        usefulWebsites.Visible = false;
                    }
                    break;
                case 9:
                    apps_mainScreen.Visible = false;
                    otherApps.Visible = false;
                    usefulWebsites.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void listView5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView5.FocusedItem.Index == listView5.Items.Count - 1)
            {
                usefulWebsites.Visible = false;
                apps_mainScreen.Visible = true;
                return;
            }
        }

        private void listView4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView4.FocusedItem.Index == listView4.Items.Count - 1)
            {
                otherApps.Visible = false;
                apps_mainScreen.Visible = true;
                return;
            }
        }
    }
}
