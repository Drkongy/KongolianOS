
namespace Kongolian_OS
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.LblKongo = new System.Windows.Forms.Label();
            this.PnlOverlay = new System.Windows.Forms.Panel();
            this.TimePB = new System.Windows.Forms.Timer(this.components);
            this.LblPercentage = new System.Windows.Forms.Label();
            this.PnlProgress = new System.Windows.Forms.Panel();
            this.LblDesc = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB1
            // 
            this.PB1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB1.BackgroundImage")));
            this.PB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB1.Location = new System.Drawing.Point(24, 28);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(203, 181);
            this.PB1.TabIndex = 0;
            this.PB1.TabStop = false;
            this.PB1.Click += new System.EventHandler(this.PB1_Click);
            // 
            // LblKongo
            // 
            this.LblKongo.AutoSize = true;
            this.LblKongo.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.LblKongo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblKongo.Location = new System.Drawing.Point(27, 224);
            this.LblKongo.Name = "LblKongo";
            this.LblKongo.Size = new System.Drawing.Size(200, 31);
            this.LblKongo.TabIndex = 1;
            this.LblKongo.Text = "Kongolian OS";
            // 
            // PnlOverlay
            // 
            this.PnlOverlay.BackColor = System.Drawing.Color.Gray;
            this.PnlOverlay.ForeColor = System.Drawing.Color.White;
            this.PnlOverlay.Location = new System.Drawing.Point(0, 353);
            this.PnlOverlay.Name = "PnlOverlay";
            this.PnlOverlay.Size = new System.Drawing.Size(256, 26);
            this.PnlOverlay.TabIndex = 3;
            // 
            // TimePB
            // 
            this.TimePB.Tick += new System.EventHandler(this.TimePB_Tick);
            // 
            // LblPercentage
            // 
            this.LblPercentage.AutoSize = true;
            this.LblPercentage.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPercentage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPercentage.Location = new System.Drawing.Point(9, 333);
            this.LblPercentage.Name = "LblPercentage";
            this.LblPercentage.Size = new System.Drawing.Size(17, 17);
            this.LblPercentage.TabIndex = 4;
            this.LblPercentage.Text = "0";
            this.LblPercentage.Click += new System.EventHandler(this.LblPercentage_Click);
            // 
            // PnlProgress
            // 
            this.PnlProgress.BackColor = System.Drawing.Color.White;
            this.PnlProgress.ForeColor = System.Drawing.Color.White;
            this.PnlProgress.Location = new System.Drawing.Point(0, 353);
            this.PnlProgress.Name = "PnlProgress";
            this.PnlProgress.Size = new System.Drawing.Size(69, 26);
            this.PnlProgress.TabIndex = 4;
            // 
            // LblDesc
            // 
            this.LblDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDesc.AutoSize = true;
            this.LblDesc.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblDesc.Location = new System.Drawing.Point(12, 277);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(21, 21);
            this.LblDesc.TabIndex = 5;
            this.LblDesc.Text = "0";
            this.LblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.LblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblID.Location = new System.Drawing.Point(21, 6);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(60, 16);
            this.LblID.TabIndex = 6;
            this.LblID.Text = "xxx.xxx";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(255, 378);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblDesc);
            this.Controls.Add(this.PnlProgress);
            this.Controls.Add(this.LblPercentage);
            this.Controls.Add(this.PnlOverlay);
            this.Controls.Add(this.LblKongo);
            this.Controls.Add(this.PB1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.Label LblKongo;
        private System.Windows.Forms.Panel PnlOverlay;
        private System.Windows.Forms.Timer TimePB;
        private System.Windows.Forms.Label LblPercentage;
        private System.Windows.Forms.Panel PnlProgress;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.Label LblID;
    }
}