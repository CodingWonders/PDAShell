using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDAShell.Main;

namespace PDAShell.Main.Dialogs
{
    public partial class DialogBox : Form
    {

        public DialogBox()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            MainForm.isAccepted = true;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MainForm.isAccepted = false;
            Close();
        }
    }
}
