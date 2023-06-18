namespace PDAShell.Calendar
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusBar = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clockLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.calendarBody = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.appointmentPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nextYear = new System.Windows.Forms.PictureBox();
            this.nextMonth = new System.Windows.Forms.PictureBox();
            this.todayPic = new System.Windows.Forms.PictureBox();
            this.prevMonth = new System.Windows.Forms.PictureBox();
            this.prevYear = new System.Windows.Forms.PictureBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.shellBtn = new System.Windows.Forms.PictureBox();
            this.statusBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.calendarPanel.SuspendLayout();
            this.calendarBody.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.appointmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Controls.Add(this.titleLabel);
            this.statusBar.Controls.Add(this.panel1);
            this.statusBar.Controls.Add(this.shellBtn);
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.Location = new System.Drawing.Point(0, 0);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1008, 28);
            this.statusBar.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(32, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(820, 28);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Calendar";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.clockLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(852, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 28);
            this.panel1.TabIndex = 1;
            // 
            // clockLabel
            // 
            this.clockLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.Location = new System.Drawing.Point(0, 0);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(121, 28);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "label1";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 27);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.calendarPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.appointmentPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 506);
            this.splitContainer1.SplitterDistance = 366;
            this.splitContainer1.TabIndex = 0;
            // 
            // calendarPanel
            // 
            this.calendarPanel.Controls.Add(this.calendarBody);
            this.calendarPanel.Controls.Add(this.panel2);
            this.calendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarPanel.Location = new System.Drawing.Point(0, 0);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(1008, 366);
            this.calendarPanel.TabIndex = 1;
            // 
            // calendarBody
            // 
            this.calendarBody.BackColor = System.Drawing.Color.White;
            this.calendarBody.Controls.Add(this.monthCalendar1);
            this.calendarBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarBody.Location = new System.Drawing.Point(0, 28);
            this.calendarBody.Name = "calendarBody";
            this.calendarBody.Size = new System.Drawing.Size(1008, 338);
            this.calendarBody.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(5, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(16, 12);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateLbl);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 28);
            this.panel2.TabIndex = 1;
            // 
            // dateLbl
            // 
            this.dateLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(64, 0);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(848, 28);
            this.dateLbl.TabIndex = 2;
            this.dateLbl.Text = "label1";
            this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nextYear);
            this.panel4.Controls.Add(this.nextMonth);
            this.panel4.Controls.Add(this.todayPic);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(912, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 28);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.prevMonth);
            this.panel3.Controls.Add(this.prevYear);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 28);
            this.panel3.TabIndex = 0;
            // 
            // appointmentPanel
            // 
            this.appointmentPanel.Controls.Add(this.listView1);
            this.appointmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentPanel.Location = new System.Drawing.Point(0, 0);
            this.appointmentPanel.Name = "appointmentPanel";
            this.appointmentPanel.Size = new System.Drawing.Size(1008, 136);
            this.appointmentPanel.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1008, 136);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Duration";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Appointment name";
            this.columnHeader2.Width = 912;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nextYear
            // 
            this.nextYear.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextYear.Image = global::PDAShell.Calendar.Properties.Resources.next_year;
            this.nextYear.Location = new System.Drawing.Point(64, 0);
            this.nextYear.Name = "nextYear";
            this.nextYear.Size = new System.Drawing.Size(32, 28);
            this.nextYear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.nextYear.TabIndex = 3;
            this.nextYear.TabStop = false;
            this.nextYear.Click += new System.EventHandler(this.nextYear_Click);
            // 
            // nextMonth
            // 
            this.nextMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextMonth.Image = global::PDAShell.Calendar.Properties.Resources.next_month;
            this.nextMonth.Location = new System.Drawing.Point(32, 0);
            this.nextMonth.Name = "nextMonth";
            this.nextMonth.Size = new System.Drawing.Size(32, 28);
            this.nextMonth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.nextMonth.TabIndex = 2;
            this.nextMonth.TabStop = false;
            this.nextMonth.Click += new System.EventHandler(this.nextMonth_Click);
            // 
            // todayPic
            // 
            this.todayPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.todayPic.Image = global::PDAShell.Calendar.Properties.Resources.today;
            this.todayPic.Location = new System.Drawing.Point(0, 0);
            this.todayPic.Name = "todayPic";
            this.todayPic.Size = new System.Drawing.Size(32, 28);
            this.todayPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.todayPic.TabIndex = 1;
            this.todayPic.TabStop = false;
            this.todayPic.Click += new System.EventHandler(this.todayPic_Click);
            // 
            // prevMonth
            // 
            this.prevMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.prevMonth.Image = global::PDAShell.Calendar.Properties.Resources.prev_month;
            this.prevMonth.Location = new System.Drawing.Point(32, 0);
            this.prevMonth.Name = "prevMonth";
            this.prevMonth.Size = new System.Drawing.Size(32, 28);
            this.prevMonth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.prevMonth.TabIndex = 2;
            this.prevMonth.TabStop = false;
            this.prevMonth.Click += new System.EventHandler(this.prevMonth_Click);
            // 
            // prevYear
            // 
            this.prevYear.Dock = System.Windows.Forms.DockStyle.Left;
            this.prevYear.Image = global::PDAShell.Calendar.Properties.Resources.prev_year;
            this.prevYear.Location = new System.Drawing.Point(0, 0);
            this.prevYear.Name = "prevYear";
            this.prevYear.Size = new System.Drawing.Size(32, 28);
            this.prevYear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.prevYear.TabIndex = 1;
            this.prevYear.TabStop = false;
            this.prevYear.Click += new System.EventHandler(this.prevYear_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentToolStripMenuItem,
            this.noteToolStripMenuItem,
            this.taskToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 21);
            this.toolStripDropDownButton1.Text = "Calendar";
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.noteToolStripMenuItem.Text = "Note";
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.taskToolStripMenuItem.Text = "Task";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(94, 21);
            this.toolStripDropDownButton2.Text = "Appointment";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.ShowDropDownArrow = false;
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(45, 21);
            this.toolStripDropDownButton3.Text = "Tools";
            // 
            // closeBtn
            // 
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.Image = global::PDAShell.Calendar.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(124, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(32, 28);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Tag = "close";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // shellBtn
            // 
            this.shellBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.shellBtn.Image = global::PDAShell.Calendar.Properties.Resources.shell;
            this.shellBtn.Location = new System.Drawing.Point(0, 0);
            this.shellBtn.Name = "shellBtn";
            this.shellBtn.Size = new System.Drawing.Size(32, 28);
            this.shellBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.shellBtn.TabIndex = 0;
            this.shellBtn.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.statusBar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDAShell Calendar Window";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.calendarPanel.ResumeLayout(false);
            this.calendarBody.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.appointmentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shellBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statusBar;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.PictureBox shellBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel calendarPanel;
        private System.Windows.Forms.Panel calendarBody;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel appointmentPanel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox nextYear;
        private System.Windows.Forms.PictureBox nextMonth;
        private System.Windows.Forms.PictureBox todayPic;
        private System.Windows.Forms.PictureBox prevMonth;
        private System.Windows.Forms.PictureBox prevYear;
    }
}

