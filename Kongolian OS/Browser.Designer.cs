
namespace Kongolian_OS
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.Windowbar = new System.Windows.Forms.Panel();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnFoward = new System.Windows.Forms.Button();
            this.WB = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnGo = new System.Windows.Forms.Button();
            this.UrlRefresh = new System.Windows.Forms.Timer(this.components);
            this.Windowbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // Windowbar
            // 
            this.Windowbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Windowbar.Controls.Add(this.BtnRefresh);
            this.Windowbar.Controls.Add(this.BtnExit);
            this.Windowbar.Controls.Add(this.label1);
            this.Windowbar.Controls.Add(this.BtnHome);
            this.Windowbar.Controls.Add(this.BtnBack);
            this.Windowbar.Controls.Add(this.BtnFoward);
            this.Windowbar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Windowbar.Location = new System.Drawing.Point(1, 1);
            this.Windowbar.Name = "Windowbar";
            this.Windowbar.Size = new System.Drawing.Size(799, 25);
            this.Windowbar.TabIndex = 18;
            this.Windowbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Windowbar_MouseDown);
            this.Windowbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Windowbar_MouseMove);
            this.Windowbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Windowbar_MouseUp);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefresh.Location = new System.Drawing.Point(290, -10);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 45);
            this.BtnRefresh.TabIndex = 20;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Location = new System.Drawing.Point(775, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(23, 23);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Browser";
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.BtnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnHome.Location = new System.Drawing.Point(209, -10);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 45);
            this.BtnHome.TabIndex = 2;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.BtnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBack.Location = new System.Drawing.Point(95, -10);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(51, 45);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "<";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnFoward
            // 
            this.BtnFoward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.BtnFoward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFoward.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.BtnFoward.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFoward.Location = new System.Drawing.Point(152, -10);
            this.BtnFoward.Name = "BtnFoward";
            this.BtnFoward.Size = new System.Drawing.Size(51, 45);
            this.BtnFoward.TabIndex = 1;
            this.BtnFoward.Text = ">";
            this.BtnFoward.UseVisualStyleBackColor = false;
            this.BtnFoward.Click += new System.EventHandler(this.BtnFoward_Click);
            // 
            // WB
            // 
            this.WB.Location = new System.Drawing.Point(0, 59);
            this.WB.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB.Name = "WB";
            this.WB.Size = new System.Drawing.Size(799, 390);
            this.WB.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.textBox1.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(4, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(744, 23);
            this.textBox1.TabIndex = 19;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // BtnGo
            // 
            this.BtnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.BtnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGo.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.BtnGo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGo.Location = new System.Drawing.Point(754, 33);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(44, 23);
            this.BtnGo.TabIndex = 21;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = false;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // UrlRefresh
            // 
            this.UrlRefresh.Tick += new System.EventHandler(this.UrlRefresh_Tick);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.WB);
            this.Controls.Add(this.Windowbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Browser";
            this.Text = "Browser";
            this.Load += new System.EventHandler(this.Browser_Load);
            this.Windowbar.ResumeLayout(false);
            this.Windowbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Windowbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.WebBrowser WB;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnFoward;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Timer UrlRefresh;
    }
}