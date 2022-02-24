
namespace Kongolian_OS
{
    partial class TaskManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManager));
            this.Windowbar = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.lblbtask = new System.Windows.Forms.Label();
            this.LblAppAmnt = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Timer(this.components);
            this.LBApps = new System.Windows.Forms.ListBox();
            this.BtnApps = new System.Windows.Forms.Button();
            this.BtnProcesses = new System.Windows.Forms.Button();
            this.BtnPerformance = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlApps = new System.Windows.Forms.Panel();
            this.TBApp = new System.Windows.Forms.TextBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnOpenApp = new System.Windows.Forms.Button();
            this.PnlPerformance = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlProcess = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LBProcesses = new System.Windows.Forms.ListBox();
            this.LblProcessCount = new System.Windows.Forms.Label();
            this.RefreshProcess = new System.Windows.Forms.Timer(this.components);
            this.Windowbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.PnlApps.SuspendLayout();
            this.PnlPerformance.SuspendLayout();
            this.PnlProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // Windowbar
            // 
            this.Windowbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Windowbar.Controls.Add(this.BtnExit);
            this.Windowbar.Controls.Add(this.lblbtask);
            this.Windowbar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Windowbar.Location = new System.Drawing.Point(0, 0);
            this.Windowbar.Name = "Windowbar";
            this.Windowbar.Size = new System.Drawing.Size(300, 25);
            this.Windowbar.TabIndex = 18;
            this.Windowbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Windowbar_MouseDown);
            this.Windowbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Windowbar_MouseMove);
            this.Windowbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Windowbar_MouseUp);
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Location = new System.Drawing.Point(275, 1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(23, 23);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblbtask
            // 
            this.lblbtask.AutoSize = true;
            this.lblbtask.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblbtask.ForeColor = System.Drawing.SystemColors.Control;
            this.lblbtask.Location = new System.Drawing.Point(8, 3);
            this.lblbtask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbtask.Name = "lblbtask";
            this.lblbtask.Size = new System.Drawing.Size(122, 19);
            this.lblbtask.TabIndex = 5;
            this.lblbtask.Text = "Task Manager";
            // 
            // LblAppAmnt
            // 
            this.LblAppAmnt.AutoSize = true;
            this.LblAppAmnt.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.LblAppAmnt.ForeColor = System.Drawing.SystemColors.Control;
            this.LblAppAmnt.Location = new System.Drawing.Point(12, 3);
            this.LblAppAmnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAppAmnt.Name = "LblAppAmnt";
            this.LblAppAmnt.Size = new System.Drawing.Size(78, 19);
            this.LblAppAmnt.TabIndex = 19;
            this.LblAppAmnt.Text = "Apps(0)";
            // 
            // Refresh
            // 
            this.Refresh.Interval = 5000;
            this.Refresh.Tick += new System.EventHandler(this.Refresh_Tick);
            // 
            // LBApps
            // 
            this.LBApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.LBApps.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.LBApps.ForeColor = System.Drawing.Color.White;
            this.LBApps.FormattingEnabled = true;
            this.LBApps.ItemHeight = 15;
            this.LBApps.Location = new System.Drawing.Point(8, 29);
            this.LBApps.Name = "LBApps";
            this.LBApps.Size = new System.Drawing.Size(276, 304);
            this.LBApps.TabIndex = 20;
            this.LBApps.SelectedIndexChanged += new System.EventHandler(this.LBApps_SelectedIndexChanged);
            this.LBApps.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LBApps_MouseDoubleClick);
            // 
            // BtnApps
            // 
            this.BtnApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.BtnApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApps.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.BtnApps.ForeColor = System.Drawing.Color.White;
            this.BtnApps.Location = new System.Drawing.Point(12, 16);
            this.BtnApps.Name = "BtnApps";
            this.BtnApps.Size = new System.Drawing.Size(85, 23);
            this.BtnApps.TabIndex = 21;
            this.BtnApps.Text = "Apps";
            this.BtnApps.UseVisualStyleBackColor = false;
            this.BtnApps.Click += new System.EventHandler(this.BtnApps_Click);
            // 
            // BtnProcesses
            // 
            this.BtnProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.BtnProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcesses.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.BtnProcesses.ForeColor = System.Drawing.Color.White;
            this.BtnProcesses.Location = new System.Drawing.Point(103, 16);
            this.BtnProcesses.Name = "BtnProcesses";
            this.BtnProcesses.Size = new System.Drawing.Size(82, 23);
            this.BtnProcesses.TabIndex = 22;
            this.BtnProcesses.Text = "Processes";
            this.BtnProcesses.UseVisualStyleBackColor = false;
            this.BtnProcesses.Click += new System.EventHandler(this.BtnProcesses_Click);
            // 
            // BtnPerformance
            // 
            this.BtnPerformance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.BtnPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPerformance.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.BtnPerformance.ForeColor = System.Drawing.Color.White;
            this.BtnPerformance.Location = new System.Drawing.Point(191, 16);
            this.BtnPerformance.Name = "BtnPerformance";
            this.BtnPerformance.Size = new System.Drawing.Size(97, 23);
            this.BtnPerformance.TabIndex = 23;
            this.BtnPerformance.Text = "Performance";
            this.BtnPerformance.UseVisualStyleBackColor = false;
            this.BtnPerformance.Click += new System.EventHandler(this.BtnPerformance_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnPerformance);
            this.panel1.Controls.Add(this.BtnProcesses);
            this.panel1.Controls.Add(this.BtnApps);
            this.panel1.Controls.Add(this.PnlApps);
            this.panel1.Controls.Add(this.PnlPerformance);
            this.panel1.Controls.Add(this.PnlProcess);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 438);
            this.panel1.TabIndex = 24;
            // 
            // PnlApps
            // 
            this.PnlApps.Controls.Add(this.TBApp);
            this.PnlApps.Controls.Add(this.BtnRefresh);
            this.PnlApps.Controls.Add(this.BtnOpenApp);
            this.PnlApps.Controls.Add(this.LBApps);
            this.PnlApps.Controls.Add(this.LblAppAmnt);
            this.PnlApps.Location = new System.Drawing.Point(3, 44);
            this.PnlApps.Name = "PnlApps";
            this.PnlApps.Size = new System.Drawing.Size(292, 382);
            this.PnlApps.TabIndex = 24;
            // 
            // TBApp
            // 
            this.TBApp.AutoCompleteCustomSource.AddRange(new string[] {
            "Task Manager",
            "Calculator",
            "Browser",
            "File Explorer",
            "Users",
            "Settings",
            "Notepad",
            "AutoClicker",
            "TicTacToe"});
            this.TBApp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TBApp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TBApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.TBApp.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.TBApp.ForeColor = System.Drawing.Color.White;
            this.TBApp.Location = new System.Drawing.Point(9, 334);
            this.TBApp.Name = "TBApp";
            this.TBApp.Size = new System.Drawing.Size(275, 20);
            this.TBApp.TabIndex = 29;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Location = new System.Drawing.Point(151, 356);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(133, 23);
            this.BtnRefresh.TabIndex = 28;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click_1);
            // 
            // BtnOpenApp
            // 
            this.BtnOpenApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.BtnOpenApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenApp.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.BtnOpenApp.ForeColor = System.Drawing.Color.White;
            this.BtnOpenApp.Location = new System.Drawing.Point(9, 356);
            this.BtnOpenApp.Name = "BtnOpenApp";
            this.BtnOpenApp.Size = new System.Drawing.Size(133, 23);
            this.BtnOpenApp.TabIndex = 27;
            this.BtnOpenApp.Text = "New App";
            this.BtnOpenApp.UseVisualStyleBackColor = false;
            this.BtnOpenApp.Click += new System.EventHandler(this.BtnOpenApp_Click);
            // 
            // PnlPerformance
            // 
            this.PnlPerformance.Controls.Add(this.label1);
            this.PnlPerformance.Location = new System.Drawing.Point(3, 44);
            this.PnlPerformance.Name = "PnlPerformance";
            this.PnlPerformance.Size = new System.Drawing.Size(292, 382);
            this.PnlPerformance.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Work In Progress";
            // 
            // PnlProcess
            // 
            this.PnlProcess.Controls.Add(this.label2);
            this.PnlProcess.Controls.Add(this.LBProcesses);
            this.PnlProcess.Controls.Add(this.LblProcessCount);
            this.PnlProcess.Location = new System.Drawing.Point(3, 44);
            this.PnlProcess.Name = "PnlProcess";
            this.PnlProcess.Size = new System.Drawing.Size(292, 382);
            this.PnlProcess.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(38, 356);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Processes can\'t be stopped";
            // 
            // LBProcesses
            // 
            this.LBProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.LBProcesses.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.LBProcesses.ForeColor = System.Drawing.Color.White;
            this.LBProcesses.FormattingEnabled = true;
            this.LBProcesses.ItemHeight = 15;
            this.LBProcesses.Location = new System.Drawing.Point(8, 29);
            this.LBProcesses.Name = "LBProcesses";
            this.LBProcesses.Size = new System.Drawing.Size(276, 319);
            this.LBProcesses.TabIndex = 20;
            // 
            // LblProcessCount
            // 
            this.LblProcessCount.AutoSize = true;
            this.LblProcessCount.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.LblProcessCount.ForeColor = System.Drawing.SystemColors.Control;
            this.LblProcessCount.Location = new System.Drawing.Point(9, 3);
            this.LblProcessCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProcessCount.Name = "LblProcessCount";
            this.LblProcessCount.Size = new System.Drawing.Size(113, 19);
            this.LblProcessCount.TabIndex = 19;
            this.LblProcessCount.Text = "Processes(0)";
            // 
            // RefreshProcess
            // 
            this.RefreshProcess.Interval = 250;
            this.RefreshProcess.Tick += new System.EventHandler(this.RefreshProcess_Tick);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.Windowbar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskManager";
            this.Text = "TaskManager";
            this.Load += new System.EventHandler(this.TaskManager_Load);
            this.Windowbar.ResumeLayout(false);
            this.Windowbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.PnlApps.ResumeLayout(false);
            this.PnlApps.PerformLayout();
            this.PnlPerformance.ResumeLayout(false);
            this.PnlPerformance.PerformLayout();
            this.PnlProcess.ResumeLayout(false);
            this.PnlProcess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Windowbar;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.Label lblbtask;
        private System.Windows.Forms.Label LblAppAmnt;
        private System.Windows.Forms.Timer Refresh;
        private System.Windows.Forms.ListBox LBApps;
        private System.Windows.Forms.Button BtnApps;
        private System.Windows.Forms.Button BtnProcesses;
        private System.Windows.Forms.Button BtnPerformance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlApps;
        private System.Windows.Forms.Panel PnlProcess;
        private System.Windows.Forms.ListBox LBProcesses;
        private System.Windows.Forms.Label LblProcessCount;
        private System.Windows.Forms.Panel PnlPerformance;
        private System.Windows.Forms.TextBox TBApp;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnOpenApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer RefreshProcess;
        private System.Windows.Forms.Label label1;
    }
}