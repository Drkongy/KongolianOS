
namespace Kongolian_OS
{
    partial class AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            this.Windowbar = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.LblAutoClicker = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.TBIntervel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBClicks = new System.Windows.Forms.TextBox();
            this.Interval = new System.Windows.Forms.Timer(this.components);
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.Windowbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // Windowbar
            // 
            this.Windowbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Windowbar.Controls.Add(this.BtnExit);
            this.Windowbar.Controls.Add(this.LblAutoClicker);
            this.Windowbar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Windowbar.Location = new System.Drawing.Point(-2, 0);
            this.Windowbar.Name = "Windowbar";
            this.Windowbar.Size = new System.Drawing.Size(155, 25);
            this.Windowbar.TabIndex = 18;
            this.Windowbar.Paint += new System.Windows.Forms.PaintEventHandler(this.Windowbar_Paint);
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Location = new System.Drawing.Point(127, 0);
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
            this.LblAutoClicker.Location = new System.Drawing.Point(4, 4);
            this.LblAutoClicker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAutoClicker.Name = "LblAutoClicker";
            this.LblAutoClicker.Size = new System.Drawing.Size(115, 19);
            this.LblAutoClicker.TabIndex = 5;
            this.LblAutoClicker.Text = "Auto Clicker";
            this.LblAutoClicker.Click += new System.EventHandler(this.LblAutoClicker_Click);
            this.LblAutoClicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblAutoClicker_MouseDown);
            this.LblAutoClicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblAutoClicker_MouseMove);
            this.LblAutoClicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LblAutoClicker_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Intervel (MS)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(12, 83);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(126, 31);
            this.BtnConfirm.TabIndex = 33;
            this.BtnConfirm.Text = "Enable";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // TBIntervel
            // 
            this.TBIntervel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.TBIntervel.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.TBIntervel.ForeColor = System.Drawing.Color.White;
            this.TBIntervel.Location = new System.Drawing.Point(10, 57);
            this.TBIntervel.MaxLength = 7;
            this.TBIntervel.Name = "TBIntervel";
            this.TBIntervel.Size = new System.Drawing.Size(128, 21);
            this.TBIntervel.TabIndex = 34;
            this.TBIntervel.Text = "100";
            this.TBIntervel.TextChanged += new System.EventHandler(this.TBIntervel_TextChanged);
            this.TBIntervel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBIntervel_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Clicks:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TBClicks
            // 
            this.TBClicks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.TBClicks.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.TBClicks.ForeColor = System.Drawing.Color.White;
            this.TBClicks.Location = new System.Drawing.Point(10, 142);
            this.TBClicks.Name = "TBClicks";
            this.TBClicks.ReadOnly = true;
            this.TBClicks.Size = new System.Drawing.Size(128, 21);
            this.TBClicks.TabIndex = 37;
            this.TBClicks.TextChanged += new System.EventHandler(this.TBClicks_TextChanged);
            // 
            // Interval
            // 
            this.Interval.Tick += new System.EventHandler(this.Interval_Tick);
            // 
            // Delay
            // 
            this.Delay.Interval = 1000;
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(150, 173);
            this.Controls.Add(this.TBClicks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBIntervel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Windowbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoClicker";
            this.Text = "Enable";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Autoclicker_Load);
            this.Windowbar.ResumeLayout(false);
            this.Windowbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Windowbar;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.Label LblAutoClicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.TextBox TBIntervel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBClicks;
        private System.Windows.Forms.Timer Interval;
        private System.Windows.Forms.Timer Delay;
    }
}