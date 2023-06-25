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
using System.IO;
using System.Diagnostics;
using System.Security.Principal;
using System.Runtime.InteropServices;
using Shellify;

namespace PDAShell.Main
{
    public partial class MainForm : Form
    {

        public static string ownerName { get; set; }
        public static string ownerCompany { get; set; }
        public static string ownerAddress { get; set; }
        public static string ownerPhone { get; set; }
        public static string ownerEmail { get; set; }
        public static bool isAccepted { get; set; }

        public static List<string> shortcutExecutionPaths { get; set; } = new List<string>();
        public static List<string> shortcutWorkingDirectories { get; set; } = new List<string>();
        public static List<string> shortcutArguments { get; set; } = new List<string>();
        public static ImageList shortcutIconList { get; set; } = new ImageList();
        private static ListViewItem appItem { get; set; }

        public class NativeMethods
        {
            [DllImport("shell32.dll", CharSet = CharSet.Auto)]
            public static extern uint ExtractIconEx(string lpszFile, int nIconIndex, [Out] IntPtr[] phiconLarge, [Out] IntPtr[] phiconSmall, [In] uint nIcons);
        }

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
                        if (panelControl is Panel)
                        {
                            foreach (Control subPanelControl in panelControl.Controls)
                            {
                                if (subPanelControl.Name == "okBtn")
                                {
                                    subPanelControl.Visible = showOKBtn;
                                }
                                else if (subPanelControl.Name == "cancelBtn")
                                {
                                    subPanelControl.Visible = showCancelBtn;
                                }
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
            dialogBox.ShowDialog(this);
        }

        private void listView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (listView3.FocusedItem.Index)
            {
                case 0:
                    if (File.Exists(Application.StartupPath + "\\apps\\PDAShell.Calendar\\PDAShell.Calendar.exe"))
                    {
                        Process.Start(Application.StartupPath + "\\apps\\PDAShell.Calendar\\PDAShell.Calendar.exe");
                    }
                    break;
                case 8:
                    showDialog(400, 196, "Other Installed Applications", "We don't know whether these applications can get you distracted.\n\nAre you sure you want to continue?", true, 1, true, true);
                    if (isAccepted)
                    {
                        apps_mainScreen.Visible = false;
                        otherApps.Visible = true;
                        usefulWebsites.Visible = false;
                        listView4.Items.Clear();
                        appListerBW.RunWorkerAsync();
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
            else
            {
                try
                {
                    Process process = new Process();
                    process.StartInfo.FileName = shortcutExecutionPaths[listView4.FocusedItem.Index];
                    if (shortcutWorkingDirectories[listView4.FocusedItem.Index] is null)
                    {
                        process.StartInfo.WorkingDirectory = Path.GetDirectoryName(shortcutExecutionPaths[listView4.FocusedItem.Index]);
                    }
                    else
                    {
                        process.StartInfo.WorkingDirectory = shortcutWorkingDirectories[listView4.FocusedItem.Index];
                    }
                    process.StartInfo.Arguments = shortcutArguments[listView4.FocusedItem.Index];
                    process.Start();
                }
                catch (Exception ex)
                {
                    showDialog(640, 240, "Error launching application", "An error occurred when starting up this application.\n\n" + listView4.FocusedItem.Text + " (" + Path.GetFileName(shortcutExecutionPaths[listView4.FocusedItem.Index]) + ")\n\n" + ex.Message, true, 4, false, true);
                }
            }
        }

        private void appListerBW_DoWork(object sender, DoWorkEventArgs e)
        {
            appListerBW.ReportProgress(0);
            if (shortcutIconList.Images.Count > 0) { shortcutIconList.Images.Clear(); }
            shortcutIconList.ImageSize = new Size(48, 48);
            shortcutIconList.ColorDepth = ColorDepth.Depth32Bit;
            shortcutExecutionPaths.Clear();
            shortcutWorkingDirectories.Clear();
            shortcutArguments.Clear();
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal pri = new WindowsPrincipal(id);
            string lookupPath = "";
            if (pri.IsInRole(WindowsBuiltInRole.Administrator))
            {
                lookupPath = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.Windows)) + "\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs";
            }
            else
            {
                lookupPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs";
            }
            foreach (var item in Directory.GetFiles(lookupPath, "*.lnk", SearchOption.AllDirectories))
            {
                string shortcutPath = "";
                string shortcutWorkingDir = "";
                string shortcutArgs = "";
                try
                {
                    var shortcut = ShellLinkFile.Load(item);
                    shortcutPath = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.Windows)) + shortcut.RelativePath.Replace("..\\", "").Trim();
                    shortcutWorkingDir = shortcut.WorkingDirectory;
                    shortcutArgs = shortcut.Arguments;
                    shortcutExecutionPaths.Add(shortcutPath);
                    shortcutWorkingDirectories.Add(shortcutWorkingDir);
                    shortcutArguments.Add(shortcutArgs);
                    try
                    {
                        if (shortcut.IconLocation is null)
                        {
                            shortcutIconList.Images.Add(Properties.Resources.shortcut);
                        }
                        else if (Path.GetExtension(shortcut.IconLocation) == ".exe")
                        {
                            uint iconCount = NativeMethods.ExtractIconEx(shortcut.IconLocation, -1, null, null, 0);
                            IntPtr[] largeIcons = new IntPtr[iconCount];
                            IntPtr[] smallIcons = new IntPtr[iconCount];
                            NativeMethods.ExtractIconEx(shortcut.IconLocation, 0, largeIcons, smallIcons, iconCount);
                            for (int i = 0; i < iconCount; i++)
                            {
                                Icon icon = Icon.FromHandle(largeIcons[i]);
                                shortcutIconList.Images.Add(icon.ToBitmap());
                            }
                        }
                        else
                        {
                            shortcutIconList.Images.Add(Image.FromFile(shortcut.IconLocation));
                        }
                    }
                    catch (OutOfMemoryException)
                    {
                        shortcutIconList.Images.Add(Properties.Resources.shortcut);
                    }
                    appItem = new ListViewItem(Path.GetFileNameWithoutExtension(item), shortcutIconList.Images.Count - 1);
                    appListerBW.ReportProgress(50);
                }
                catch (Exception)
                {
                    shortcutExecutionPaths.Remove(shortcutPath);
                    shortcutWorkingDirectories.Remove(shortcutWorkingDir);
                    shortcutArguments.Remove(shortcutArgs);
                    continue;
                }
            }
            shortcutIconList.Images.Add(imageList1.Images[17]);
            appListerBW.ReportProgress(90);
        }

        private void appListerBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                closeBtn.Visible = false;
                listView4.Items.Clear();
                listView4.LargeImageList = shortcutIconList;
            }
            else if (e.ProgressPercentage == 90)
            {
                var backItem = new ListViewItem("Back", shortcutIconList.Images.Count - 1);
                listView4.Items.Add(backItem);
            }
            else
            {
                listView4.Items.Add(appItem);
            }
        }

        private void appListerBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            closeBtn.Visible = true;
        }
    }
}
