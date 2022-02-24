
namespace Kongolian_OS
{
    partial class OS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OS));
            this.PnlTop = new System.Windows.Forms.Panel();
            this.LblDate = new System.Windows.Forms.Label();
            this.BtnNotifs = new System.Windows.Forms.Panel();
            this.BtnSettings = new System.Windows.Forms.Panel();
            this.BtnShutDown = new System.Windows.Forms.Panel();
            this.LblTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblCurrentUser = new System.Windows.Forms.Label();
            this.TB = new System.Windows.Forms.Panel();
            this.Internet = new System.Windows.Forms.Panel();
            this.MoreApps = new System.Windows.Forms.Panel();
            this.Calculator = new System.Windows.Forms.Panel();
            this.NotePad = new System.Windows.Forms.Panel();
            this.FileManager = new System.Windows.Forms.Panel();
            this.LblPowerOptions = new System.Windows.Forms.Label();
            this.PbIcon = new System.Windows.Forms.PictureBox();
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.PnlNotifications = new System.Windows.Forms.Panel();
            this.LblNotifs = new System.Windows.Forms.Label();
            this.PnlDateTimeAdv = new System.Windows.Forms.Panel();
            this.LblDateAdv = new System.Windows.Forms.Label();
            this.LblTimeAdv = new System.Windows.Forms.Label();
            this.PnlMoreApps = new System.Windows.Forms.Panel();
            this.BtnBananaClicker = new System.Windows.Forms.Panel();
            this.BtnTicTacToe = new System.Windows.Forms.Panel();
            this.BtnAutoClicker = new System.Windows.Forms.Panel();
            this.BtnTskMangr = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInternet2 = new System.Windows.Forms.Panel();
            this.BtnFile2 = new System.Windows.Forms.Panel();
            this.Btncalculator2 = new System.Windows.Forms.Panel();
            this.BtnNotepad2 = new System.Windows.Forms.Panel();
            this.PnlPower = new System.Windows.Forms.Panel();
            this.ShutdownIco = new System.Windows.Forms.PictureBox();
            this.RestartICo = new System.Windows.Forms.PictureBox();
            this.LockIco = new System.Windows.Forms.PictureBox();
            this.Lock = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Label();
            this.ShutDown = new System.Windows.Forms.Label();
            this.PowerOptions = new System.Windows.Forms.Timer(this.components);
            this.PnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).BeginInit();
            this.PnlNotifications.SuspendLayout();
            this.PnlDateTimeAdv.SuspendLayout();
            this.PnlMoreApps.SuspendLayout();
            this.PnlPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShutdownIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestartICo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockIco)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.PnlTop.Controls.Add(this.LblDate);
            this.PnlTop.Controls.Add(this.BtnNotifs);
            this.PnlTop.Controls.Add(this.BtnSettings);
            this.PnlTop.Controls.Add(this.BtnShutDown);
            this.PnlTop.Controls.Add(this.LblTime);
            this.PnlTop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.PnlTop.Location = new System.Drawing.Point(0, -1);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1000, 40);
            this.PnlTop.TabIndex = 3;
            this.PnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            this.PnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseMove);
            this.PnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseUp);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblDate.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.LblDate.ForeColor = System.Drawing.Color.White;
            this.LblDate.Location = new System.Drawing.Point(5, 23);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(39, 16);
            this.LblDate.TabIndex = 7;
            this.LblDate.Text = "Date";
            this.LblDate.Click += new System.EventHandler(this.LblDate_Click);
            // 
            // BtnNotifs
            // 
            this.BtnNotifs.BackColor = System.Drawing.Color.Transparent;
            this.BtnNotifs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNotifs.BackgroundImage")));
            this.BtnNotifs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNotifs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNotifs.Location = new System.Drawing.Point(880, 2);
            this.BtnNotifs.Name = "BtnNotifs";
            this.BtnNotifs.Size = new System.Drawing.Size(35, 35);
            this.BtnNotifs.TabIndex = 6;
            this.BtnNotifs.Click += new System.EventHandler(this.BtnNotifs_Click);
            this.BtnNotifs.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnNotifs_Paint);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.Transparent;
            this.BtnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSettings.BackgroundImage")));
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSettings.Location = new System.Drawing.Point(921, 3);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(35, 35);
            this.BtnSettings.TabIndex = 5;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click_1);
            // 
            // BtnShutDown
            // 
            this.BtnShutDown.BackColor = System.Drawing.Color.Transparent;
            this.BtnShutDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnShutDown.BackgroundImage")));
            this.BtnShutDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnShutDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShutDown.Location = new System.Drawing.Point(962, 3);
            this.BtnShutDown.Name = "BtnShutDown";
            this.BtnShutDown.Size = new System.Drawing.Size(35, 35);
            this.BtnShutDown.TabIndex = 4;
            this.BtnShutDown.Click += new System.EventHandler(this.BtnShutDown_Click);
            this.BtnShutDown.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnShutDown_Paint);
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblTime.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.LblTime.ForeColor = System.Drawing.Color.White;
            this.LblTime.Location = new System.Drawing.Point(5, 5);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(43, 16);
            this.LblTime.TabIndex = 3;
            this.LblTime.Text = "Time";
            this.LblTime.Click += new System.EventHandler(this.LblDateTime_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.LblCurrentUser);
            this.panel1.Controls.Add(this.TB);
            this.panel1.Controls.Add(this.LblPowerOptions);
            this.panel1.Location = new System.Drawing.Point(0, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 124);
            this.panel1.TabIndex = 5;
            // 
            // LblCurrentUser
            // 
            this.LblCurrentUser.AutoSize = true;
            this.LblCurrentUser.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.LblCurrentUser.ForeColor = System.Drawing.Color.White;
            this.LblCurrentUser.Location = new System.Drawing.Point(24, 88);
            this.LblCurrentUser.Name = "LblCurrentUser";
            this.LblCurrentUser.Size = new System.Drawing.Size(67, 23);
            this.LblCurrentUser.TabIndex = 6;
            this.LblCurrentUser.Text = "Temp";
            this.LblCurrentUser.Click += new System.EventHandler(this.LblCurrentUser_Click);
            // 
            // TB
            // 
            this.TB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TB.BackgroundImage")));
            this.TB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TB.Controls.Add(this.Internet);
            this.TB.Controls.Add(this.MoreApps);
            this.TB.Controls.Add(this.Calculator);
            this.TB.Controls.Add(this.NotePad);
            this.TB.Controls.Add(this.FileManager);
            this.TB.Location = new System.Drawing.Point(279, 7);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(459, 104);
            this.TB.TabIndex = 5;
            // 
            // Internet
            // 
            this.Internet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Internet.BackgroundImage")));
            this.Internet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Internet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Internet.Location = new System.Drawing.Point(269, 13);
            this.Internet.Name = "Internet";
            this.Internet.Size = new System.Drawing.Size(86, 68);
            this.Internet.TabIndex = 8;
            this.Internet.Click += new System.EventHandler(this.Internet_Click);
            // 
            // MoreApps
            // 
            this.MoreApps.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoreApps.BackgroundImage")));
            this.MoreApps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoreApps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoreApps.Location = new System.Drawing.Point(357, 14);
            this.MoreApps.Name = "MoreApps";
            this.MoreApps.Size = new System.Drawing.Size(85, 71);
            this.MoreApps.TabIndex = 7;
            this.MoreApps.Click += new System.EventHandler(this.MoreApps_Click);
            // 
            // Calculator
            // 
            this.Calculator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calculator.BackgroundImage")));
            this.Calculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Calculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculator.Location = new System.Drawing.Point(186, 14);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(85, 71);
            this.Calculator.TabIndex = 7;
            this.Calculator.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // NotePad
            // 
            this.NotePad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NotePad.BackgroundImage")));
            this.NotePad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NotePad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotePad.Location = new System.Drawing.Point(101, 14);
            this.NotePad.Name = "NotePad";
            this.NotePad.Size = new System.Drawing.Size(79, 71);
            this.NotePad.TabIndex = 1;
            this.NotePad.Click += new System.EventHandler(this.NotePad_Click);
            // 
            // FileManager
            // 
            this.FileManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FileManager.BackgroundImage")));
            this.FileManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FileManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileManager.Location = new System.Drawing.Point(17, 14);
            this.FileManager.Name = "FileManager";
            this.FileManager.Size = new System.Drawing.Size(78, 71);
            this.FileManager.TabIndex = 0;
            this.FileManager.Click += new System.EventHandler(this.FileManager_Click);
            // 
            // LblPowerOptions
            // 
            this.LblPowerOptions.AutoSize = true;
            this.LblPowerOptions.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.LblPowerOptions.ForeColor = System.Drawing.Color.White;
            this.LblPowerOptions.Location = new System.Drawing.Point(749, 80);
            this.LblPowerOptions.Name = "LblPowerOptions";
            this.LblPowerOptions.Size = new System.Drawing.Size(111, 27);
            this.LblPowerOptions.TabIndex = 10;
            this.LblPowerOptions.Text = "Locking";
            this.LblPowerOptions.Visible = false;
            // 
            // PbIcon
            // 
            this.PbIcon.BackColor = System.Drawing.Color.Transparent;
            this.PbIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbIcon.BackgroundImage")));
            this.PbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbIcon.Location = new System.Drawing.Point(9, 45);
            this.PbIcon.Name = "PbIcon";
            this.PbIcon.Size = new System.Drawing.Size(120, 120);
            this.PbIcon.TabIndex = 6;
            this.PbIcon.TabStop = false;
            // 
            // DateTimeTimer
            // 
            this.DateTimeTimer.Interval = 1000;
            this.DateTimeTimer.Tick += new System.EventHandler(this.DateTime_Tick);
            // 
            // PnlNotifications
            // 
            this.PnlNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.PnlNotifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlNotifications.Controls.Add(this.LblNotifs);
            this.PnlNotifications.Location = new System.Drawing.Point(661, 45);
            this.PnlNotifications.Name = "PnlNotifications";
            this.PnlNotifications.Size = new System.Drawing.Size(335, 120);
            this.PnlNotifications.TabIndex = 7;
            this.PnlNotifications.Visible = false;
            // 
            // LblNotifs
            // 
            this.LblNotifs.AutoSize = true;
            this.LblNotifs.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.LblNotifs.ForeColor = System.Drawing.Color.White;
            this.LblNotifs.Location = new System.Drawing.Point(12, 9);
            this.LblNotifs.Name = "LblNotifs";
            this.LblNotifs.Size = new System.Drawing.Size(161, 57);
            this.LblNotifs.TabIndex = 0;
            this.LblNotifs.Text = "> You are cool\r\n> Bananas are wild\r\n> bussin bussin";
            // 
            // PnlDateTimeAdv
            // 
            this.PnlDateTimeAdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.PnlDateTimeAdv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDateTimeAdv.Controls.Add(this.LblDateAdv);
            this.PnlDateTimeAdv.Controls.Add(this.LblTimeAdv);
            this.PnlDateTimeAdv.Location = new System.Drawing.Point(4, 43);
            this.PnlDateTimeAdv.Name = "PnlDateTimeAdv";
            this.PnlDateTimeAdv.Size = new System.Drawing.Size(278, 87);
            this.PnlDateTimeAdv.TabIndex = 8;
            this.PnlDateTimeAdv.Visible = false;
            // 
            // LblDateAdv
            // 
            this.LblDateAdv.AutoSize = true;
            this.LblDateAdv.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.LblDateAdv.ForeColor = System.Drawing.Color.White;
            this.LblDateAdv.Location = new System.Drawing.Point(10, 53);
            this.LblDateAdv.Name = "LblDateAdv";
            this.LblDateAdv.Size = new System.Drawing.Size(57, 23);
            this.LblDateAdv.TabIndex = 1;
            this.LblDateAdv.Text = "Date";
            // 
            // LblTimeAdv
            // 
            this.LblTimeAdv.AutoSize = true;
            this.LblTimeAdv.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.LblTimeAdv.ForeColor = System.Drawing.Color.White;
            this.LblTimeAdv.Location = new System.Drawing.Point(8, 11);
            this.LblTimeAdv.Name = "LblTimeAdv";
            this.LblTimeAdv.Size = new System.Drawing.Size(83, 31);
            this.LblTimeAdv.TabIndex = 0;
            this.LblTimeAdv.Text = "Time";
            // 
            // PnlMoreApps
            // 
            this.PnlMoreApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.PnlMoreApps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMoreApps.Controls.Add(this.BtnBananaClicker);
            this.PnlMoreApps.Controls.Add(this.BtnTicTacToe);
            this.PnlMoreApps.Controls.Add(this.BtnAutoClicker);
            this.PnlMoreApps.Controls.Add(this.BtnTskMangr);
            this.PnlMoreApps.Controls.Add(this.label1);
            this.PnlMoreApps.Controls.Add(this.BtnInternet2);
            this.PnlMoreApps.Controls.Add(this.BtnFile2);
            this.PnlMoreApps.Controls.Add(this.Btncalculator2);
            this.PnlMoreApps.Controls.Add(this.BtnNotepad2);
            this.PnlMoreApps.Location = new System.Drawing.Point(320, 235);
            this.PnlMoreApps.Name = "PnlMoreApps";
            this.PnlMoreApps.Size = new System.Drawing.Size(377, 246);
            this.PnlMoreApps.TabIndex = 9;
            this.PnlMoreApps.Visible = false;
            // 
            // BtnBananaClicker
            // 
            this.BtnBananaClicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBananaClicker.BackgroundImage")));
            this.BtnBananaClicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBananaClicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBananaClicker.Location = new System.Drawing.Point(275, 126);
            this.BtnBananaClicker.Name = "BtnBananaClicker";
            this.BtnBananaClicker.Size = new System.Drawing.Size(88, 71);
            this.BtnBananaClicker.TabIndex = 13;
            this.BtnBananaClicker.Click += new System.EventHandler(this.BtnBananaClicker_Click);
            // 
            // BtnTicTacToe
            // 
            this.BtnTicTacToe.BackgroundImage = global::Kongolian_OS.Properties.Resources.tictactoeicon;
            this.BtnTicTacToe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTicTacToe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTicTacToe.Location = new System.Drawing.Point(184, 126);
            this.BtnTicTacToe.Name = "BtnTicTacToe";
            this.BtnTicTacToe.Size = new System.Drawing.Size(85, 71);
            this.BtnTicTacToe.TabIndex = 12;
            this.BtnTicTacToe.Click += new System.EventHandler(this.BtnTicTacToe_Click);
            // 
            // BtnAutoClicker
            // 
            this.BtnAutoClicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAutoClicker.BackgroundImage")));
            this.BtnAutoClicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAutoClicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAutoClicker.Location = new System.Drawing.Point(99, 126);
            this.BtnAutoClicker.Name = "BtnAutoClicker";
            this.BtnAutoClicker.Size = new System.Drawing.Size(79, 71);
            this.BtnAutoClicker.TabIndex = 11;
            this.BtnAutoClicker.Click += new System.EventHandler(this.BtnAutoClicker_Click);
            // 
            // BtnTskMangr
            // 
            this.BtnTskMangr.BackgroundImage = global::Kongolian_OS.Properties.Resources.taskmngricon;
            this.BtnTskMangr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTskMangr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTskMangr.Location = new System.Drawing.Point(15, 125);
            this.BtnTskMangr.Name = "BtnTskMangr";
            this.BtnTskMangr.Size = new System.Drawing.Size(78, 72);
            this.BtnTskMangr.TabIndex = 13;
            this.BtnTskMangr.Click += new System.EventHandler(this.BtnTskMangr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Apps (8)";
            // 
            // BtnInternet2
            // 
            this.BtnInternet2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnInternet2.BackgroundImage")));
            this.BtnInternet2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnInternet2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInternet2.Location = new System.Drawing.Point(277, 47);
            this.BtnInternet2.Name = "BtnInternet2";
            this.BtnInternet2.Size = new System.Drawing.Size(86, 72);
            this.BtnInternet2.TabIndex = 12;
            this.BtnInternet2.Click += new System.EventHandler(this.BtnInternet2_Click);
            // 
            // BtnFile2
            // 
            this.BtnFile2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFile2.BackgroundImage")));
            this.BtnFile2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFile2.Location = new System.Drawing.Point(15, 48);
            this.BtnFile2.Name = "BtnFile2";
            this.BtnFile2.Size = new System.Drawing.Size(78, 71);
            this.BtnFile2.TabIndex = 9;
            this.BtnFile2.Click += new System.EventHandler(this.BtnFile2_Click);
            // 
            // Btncalculator2
            // 
            this.Btncalculator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btncalculator2.BackgroundImage")));
            this.Btncalculator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btncalculator2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btncalculator2.Location = new System.Drawing.Point(184, 48);
            this.Btncalculator2.Name = "Btncalculator2";
            this.Btncalculator2.Size = new System.Drawing.Size(85, 71);
            this.Btncalculator2.TabIndex = 11;
            this.Btncalculator2.Click += new System.EventHandler(this.Btncalculator2_Click);
            // 
            // BtnNotepad2
            // 
            this.BtnNotepad2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNotepad2.BackgroundImage")));
            this.BtnNotepad2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNotepad2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNotepad2.Location = new System.Drawing.Point(99, 48);
            this.BtnNotepad2.Name = "BtnNotepad2";
            this.BtnNotepad2.Size = new System.Drawing.Size(79, 71);
            this.BtnNotepad2.TabIndex = 10;
            this.BtnNotepad2.Click += new System.EventHandler(this.BtnNotepad2_Click);
            // 
            // PnlPower
            // 
            this.PnlPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.PnlPower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPower.Controls.Add(this.ShutdownIco);
            this.PnlPower.Controls.Add(this.RestartICo);
            this.PnlPower.Controls.Add(this.LockIco);
            this.PnlPower.Controls.Add(this.Lock);
            this.PnlPower.Controls.Add(this.Restart);
            this.PnlPower.Controls.Add(this.ShutDown);
            this.PnlPower.Location = new System.Drawing.Point(855, 46);
            this.PnlPower.Name = "PnlPower";
            this.PnlPower.Size = new System.Drawing.Size(140, 119);
            this.PnlPower.TabIndex = 9;
            this.PnlPower.Visible = false;
            // 
            // ShutdownIco
            // 
            this.ShutdownIco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShutdownIco.BackgroundImage")));
            this.ShutdownIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShutdownIco.Location = new System.Drawing.Point(3, 82);
            this.ShutdownIco.Name = "ShutdownIco";
            this.ShutdownIco.Size = new System.Drawing.Size(28, 28);
            this.ShutdownIco.TabIndex = 5;
            this.ShutdownIco.TabStop = false;
            this.ShutdownIco.Click += new System.EventHandler(this.ShutDown_Click_1);
            // 
            // RestartICo
            // 
            this.RestartICo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RestartICo.BackgroundImage")));
            this.RestartICo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RestartICo.Location = new System.Drawing.Point(3, 45);
            this.RestartICo.Name = "RestartICo";
            this.RestartICo.Size = new System.Drawing.Size(30, 30);
            this.RestartICo.TabIndex = 4;
            this.RestartICo.TabStop = false;
            this.RestartICo.Click += new System.EventHandler(this.Restart_Click_1);
            // 
            // LockIco
            // 
            this.LockIco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LockIco.BackgroundImage")));
            this.LockIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LockIco.Location = new System.Drawing.Point(3, 9);
            this.LockIco.Name = "LockIco";
            this.LockIco.Size = new System.Drawing.Size(30, 30);
            this.LockIco.TabIndex = 3;
            this.LockIco.TabStop = false;
            this.LockIco.Click += new System.EventHandler(this.Lock_Click_1);
            // 
            // Lock
            // 
            this.Lock.AutoSize = true;
            this.Lock.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.Lock.ForeColor = System.Drawing.Color.White;
            this.Lock.Location = new System.Drawing.Point(39, 15);
            this.Lock.Name = "Lock";
            this.Lock.Size = new System.Drawing.Size(49, 19);
            this.Lock.TabIndex = 2;
            this.Lock.Text = "Lock";
            this.Lock.Click += new System.EventHandler(this.Lock_Click_1);
            // 
            // Restart
            // 
            this.Restart.AutoSize = true;
            this.Restart.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.Restart.ForeColor = System.Drawing.Color.White;
            this.Restart.Location = new System.Drawing.Point(39, 51);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(69, 19);
            this.Restart.TabIndex = 1;
            this.Restart.Text = "Restart";
            this.Restart.Click += new System.EventHandler(this.Restart_Click_1);
            // 
            // ShutDown
            // 
            this.ShutDown.AutoSize = true;
            this.ShutDown.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.ShutDown.ForeColor = System.Drawing.Color.White;
            this.ShutDown.Location = new System.Drawing.Point(39, 86);
            this.ShutDown.Name = "ShutDown";
            this.ShutDown.Size = new System.Drawing.Size(95, 19);
            this.ShutDown.TabIndex = 0;
            this.ShutDown.Text = "Shutdown";
            this.ShutDown.Click += new System.EventHandler(this.ShutDown_Click_1);
            // 
            // PowerOptions
            // 
            this.PowerOptions.Interval = 1000;
            this.PowerOptions.Tick += new System.EventHandler(this.PowerOptions_Tick);
            // 
            // OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.PnlPower);
            this.Controls.Add(this.PnlMoreApps);
            this.Controls.Add(this.PnlNotifications);
            this.Controls.Add(this.PnlDateTimeAdv);
            this.Controls.Add(this.PnlTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PbIcon);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OS";
            this.Load += new System.EventHandler(this.OS_Load);
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).EndInit();
            this.PnlNotifications.ResumeLayout(false);
            this.PnlNotifications.PerformLayout();
            this.PnlDateTimeAdv.ResumeLayout(false);
            this.PnlDateTimeAdv.PerformLayout();
            this.PnlMoreApps.ResumeLayout(false);
            this.PnlMoreApps.PerformLayout();
            this.PnlPower.ResumeLayout(false);
            this.PnlPower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShutdownIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestartICo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockIco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbIcon;
        private System.Windows.Forms.Panel TB;
        private System.Windows.Forms.Panel MoreApps;
        private System.Windows.Forms.Panel Calculator;
        private System.Windows.Forms.Panel NotePad;
        private System.Windows.Forms.Panel FileManager;
        private System.Windows.Forms.Panel BtnShutDown;
        private System.Windows.Forms.Panel BtnSettings;
        private System.Windows.Forms.Panel Internet;
        private System.Windows.Forms.Panel BtnNotifs;
        private System.Windows.Forms.Timer DateTimeTimer;
        private System.Windows.Forms.Panel PnlNotifications;
        private System.Windows.Forms.Label LblNotifs;
        private System.Windows.Forms.Panel PnlDateTimeAdv;
        private System.Windows.Forms.Label LblTimeAdv;
        private System.Windows.Forms.Label LblDateAdv;
        private System.Windows.Forms.Panel PnlMoreApps;
        private System.Windows.Forms.Panel BtnInternet2;
        private System.Windows.Forms.Panel BtnFile2;
        private System.Windows.Forms.Panel Btncalculator2;
        private System.Windows.Forms.Panel BtnNotepad2;
        private System.Windows.Forms.Panel PnlPower;
        private System.Windows.Forms.Label Lock;
        private System.Windows.Forms.Label Restart;
        private System.Windows.Forms.Label ShutDown;
        private System.Windows.Forms.PictureBox RestartICo;
        private System.Windows.Forms.PictureBox LockIco;
        private System.Windows.Forms.PictureBox ShutdownIco;
        private System.Windows.Forms.Label LblPowerOptions;
        private System.Windows.Forms.Timer PowerOptions;
        private System.Windows.Forms.Label LblCurrentUser;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Panel BtnTskMangr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BtnAutoClicker;
        private System.Windows.Forms.Panel BtnTicTacToe;
        private System.Windows.Forms.Panel BtnBananaClicker;
    }
}