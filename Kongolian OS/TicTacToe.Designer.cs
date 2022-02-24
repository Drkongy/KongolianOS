
namespace Kongolian_OS
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.Windowbar = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.LblAutoClicker = new System.Windows.Forms.Label();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.PnlPlayAgain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnPlayAgain = new System.Windows.Forms.Button();
            this.LblWinner = new System.Windows.Forms.Label();
            this.Lbl0Points = new System.Windows.Forms.Label();
            this.LblXPoints = new System.Windows.Forms.Label();
            this.LblDesc = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.PBLOGO = new System.Windows.Forms.PictureBox();
            this.Btn2player = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn1Player = new System.Windows.Forms.Button();
            this.Windowbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.PnlMain.SuspendLayout();
            this.PnlPlayAgain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // Windowbar
            // 
            this.Windowbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Windowbar.Controls.Add(this.BtnExit);
            this.Windowbar.Controls.Add(this.LblAutoClicker);
            this.Windowbar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Windowbar.Location = new System.Drawing.Point(0, 0);
            this.Windowbar.Name = "Windowbar";
            this.Windowbar.Size = new System.Drawing.Size(180, 25);
            this.Windowbar.TabIndex = 19;
            this.Windowbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Windowbar_MouseDown);
            this.Windowbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Windowbar_MouseMove);
            this.Windowbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Windowbar_MouseUp);
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Location = new System.Drawing.Point(153, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(23, 23);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblAutoClicker
            // 
            this.LblAutoClicker.AutoSize = true;
            this.LblAutoClicker.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.LblAutoClicker.ForeColor = System.Drawing.SystemColors.Control;
            this.LblAutoClicker.Location = new System.Drawing.Point(8, 2);
            this.LblAutoClicker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAutoClicker.Name = "LblAutoClicker";
            this.LblAutoClicker.Size = new System.Drawing.Size(88, 19);
            this.LblAutoClicker.TabIndex = 5;
            this.LblAutoClicker.Text = "TicTicToe";
            this.LblAutoClicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblAutoClicker_MouseDown);
            this.LblAutoClicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblAutoClicker_MouseMove);
            this.LblAutoClicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LblAutoClicker_MouseUp);
            // 
            // PnlMain
            // 
            this.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMain.Controls.Add(this.PnlPlayAgain);
            this.PnlMain.Controls.Add(this.Lbl0Points);
            this.PnlMain.Controls.Add(this.LblXPoints);
            this.PnlMain.Controls.Add(this.LblDesc);
            this.PnlMain.Controls.Add(this.button9);
            this.PnlMain.Controls.Add(this.button8);
            this.PnlMain.Controls.Add(this.button7);
            this.PnlMain.Controls.Add(this.button6);
            this.PnlMain.Controls.Add(this.button5);
            this.PnlMain.Controls.Add(this.button4);
            this.PnlMain.Controls.Add(this.button3);
            this.PnlMain.Controls.Add(this.button2);
            this.PnlMain.Controls.Add(this.button1);
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(180, 249);
            this.PnlMain.TabIndex = 20;
            // 
            // PnlPlayAgain
            // 
            this.PnlPlayAgain.Controls.Add(this.pictureBox1);
            this.PnlPlayAgain.Controls.Add(this.BtnPlayAgain);
            this.PnlPlayAgain.Controls.Add(this.LblWinner);
            this.PnlPlayAgain.Location = new System.Drawing.Point(3, 53);
            this.PnlPlayAgain.Name = "PnlPlayAgain";
            this.PnlPlayAgain.Size = new System.Drawing.Size(172, 191);
            this.PnlPlayAgain.TabIndex = 42;
            this.PnlPlayAgain.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Kongolian_OS.Properties.Resources.tictactoeicon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(47, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // BtnPlayAgain
            // 
            this.BtnPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.BtnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayAgain.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.BtnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.BtnPlayAgain.Location = new System.Drawing.Point(12, 145);
            this.BtnPlayAgain.Name = "BtnPlayAgain";
            this.BtnPlayAgain.Size = new System.Drawing.Size(150, 34);
            this.BtnPlayAgain.TabIndex = 44;
            this.BtnPlayAgain.Text = "Play Again";
            this.BtnPlayAgain.UseVisualStyleBackColor = false;
            this.BtnPlayAgain.Click += new System.EventHandler(this.BtnPlayAgain_Click);
            // 
            // LblWinner
            // 
            this.LblWinner.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.LblWinner.ForeColor = System.Drawing.Color.White;
            this.LblWinner.Location = new System.Drawing.Point(12, 113);
            this.LblWinner.Name = "LblWinner";
            this.LblWinner.Size = new System.Drawing.Size(150, 23);
            this.LblWinner.TabIndex = 43;
            this.LblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl0Points
            // 
            this.Lbl0Points.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.Lbl0Points.ForeColor = System.Drawing.Color.White;
            this.Lbl0Points.Location = new System.Drawing.Point(134, 27);
            this.Lbl0Points.Name = "Lbl0Points";
            this.Lbl0Points.Size = new System.Drawing.Size(37, 23);
            this.Lbl0Points.TabIndex = 41;
            this.Lbl0Points.Text = "0";
            this.Lbl0Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblXPoints
            // 
            this.LblXPoints.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.LblXPoints.ForeColor = System.Drawing.Color.White;
            this.LblXPoints.Location = new System.Drawing.Point(11, 27);
            this.LblXPoints.Name = "LblXPoints";
            this.LblXPoints.Size = new System.Drawing.Size(37, 23);
            this.LblXPoints.TabIndex = 40;
            this.LblXPoints.Text = "0";
            this.LblXPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDesc
            // 
            this.LblDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblDesc.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.LblDesc.ForeColor = System.Drawing.Color.White;
            this.LblDesc.Location = new System.Drawing.Point(0, 224);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(178, 23);
            this.LblDesc.TabIndex = 39;
            this.LblDesc.Text = "X\'s Turn";
            this.LblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(121, 166);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 38;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(65, 166);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 37;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(9, 166);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 36;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(121, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 35;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(65, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 34;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(9, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 33;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(121, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 32;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(65, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlMenu
            // 
            this.PnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMenu.Controls.Add(this.PBLOGO);
            this.PnlMenu.Controls.Add(this.Btn2player);
            this.PnlMenu.Controls.Add(this.label1);
            this.PnlMenu.Controls.Add(this.Btn1Player);
            this.PnlMenu.Location = new System.Drawing.Point(0, 24);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(180, 225);
            this.PnlMenu.TabIndex = 21;
            // 
            // PBLOGO
            // 
            this.PBLOGO.BackgroundImage = global::Kongolian_OS.Properties.Resources.tictactoeicon;
            this.PBLOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBLOGO.Location = new System.Drawing.Point(50, 45);
            this.PBLOGO.Name = "PBLOGO";
            this.PBLOGO.Size = new System.Drawing.Size(75, 75);
            this.PBLOGO.TabIndex = 37;
            this.PBLOGO.TabStop = false;
            // 
            // Btn2player
            // 
            this.Btn2player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Btn2player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2player.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.Btn2player.ForeColor = System.Drawing.Color.White;
            this.Btn2player.Location = new System.Drawing.Point(13, 177);
            this.Btn2player.Name = "Btn2player";
            this.Btn2player.Size = new System.Drawing.Size(152, 34);
            this.Btn2player.TabIndex = 36;
            this.Btn2player.Text = "2 Player";
            this.Btn2player.UseVisualStyleBackColor = false;
            this.Btn2player.Click += new System.EventHandler(this.Btn2player_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "TicTicToe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn1Player
            // 
            this.Btn1Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Btn1Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1Player.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.Btn1Player.ForeColor = System.Drawing.Color.White;
            this.Btn1Player.Location = new System.Drawing.Point(13, 134);
            this.Btn1Player.Name = "Btn1Player";
            this.Btn1Player.Size = new System.Drawing.Size(152, 34);
            this.Btn1Player.TabIndex = 35;
            this.Btn1Player.Text = "1 Player";
            this.Btn1Player.UseVisualStyleBackColor = false;
            this.Btn1Player.Click += new System.EventHandler(this.Btn1Player_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(180, 250);
            this.Controls.Add(this.Windowbar);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.Windowbar.ResumeLayout(false);
            this.Windowbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.PnlMain.ResumeLayout(false);
            this.PnlPlayAgain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Windowbar;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.Label LblAutoClicker;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Label Lbl0Points;
        private System.Windows.Forms.Label LblXPoints;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.PictureBox PBLOGO;
        private System.Windows.Forms.Button Btn2player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn1Player;
        private System.Windows.Forms.Panel PnlPlayAgain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnPlayAgain;
        private System.Windows.Forms.Label LblWinner;
    }
}