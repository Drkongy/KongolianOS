
namespace Kongolian_OS
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.Windowbar = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Zero = new System.Windows.Forms.Button();
            this.DecPoint = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.takeaway = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Times = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.Operation = new System.Windows.Forms.Label();
            this.FirstNumber = new System.Windows.Forms.Label();
            this.Windowbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // Windowbar
            // 
            this.Windowbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Windowbar.Controls.Add(this.BtnExit);
            this.Windowbar.Controls.Add(this.label1);
            this.Windowbar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Windowbar.Location = new System.Drawing.Point(0, 0);
            this.Windowbar.Name = "Windowbar";
            this.Windowbar.Size = new System.Drawing.Size(300, 25);
            this.Windowbar.TabIndex = 17;
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
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Calculator";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(298, 448);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zero.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Zero.ForeColor = System.Drawing.Color.White;
            this.Zero.Location = new System.Drawing.Point(12, 371);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(134, 63);
            this.Zero.TabIndex = 20;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Writenum);
            // 
            // DecPoint
            // 
            this.DecPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.DecPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecPoint.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.DecPoint.ForeColor = System.Drawing.Color.White;
            this.DecPoint.Location = new System.Drawing.Point(153, 371);
            this.DecPoint.Name = "DecPoint";
            this.DecPoint.Size = new System.Drawing.Size(63, 63);
            this.DecPoint.TabIndex = 21;
            this.DecPoint.Text = ".";
            this.DecPoint.UseVisualStyleBackColor = false;
            this.DecPoint.Click += new System.EventHandler(this.Writenum);
            // 
            // Equals
            // 
            this.Equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Equals.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Equals.ForeColor = System.Drawing.Color.White;
            this.Equals.Location = new System.Drawing.Point(224, 371);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(63, 63);
            this.Equals.TabIndex = 22;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = false;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(224, 302);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(63, 63);
            this.Add.TabIndex = 26;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.WriteOperators);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Three.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Three.ForeColor = System.Drawing.Color.White;
            this.Three.Location = new System.Drawing.Point(153, 302);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(63, 63);
            this.Three.TabIndex = 25;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.Writenum);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Two.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Two.ForeColor = System.Drawing.Color.White;
            this.Two.Location = new System.Drawing.Point(83, 302);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(63, 63);
            this.Two.TabIndex = 24;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.Writenum);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.One.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.One.ForeColor = System.Drawing.Color.White;
            this.One.Location = new System.Drawing.Point(13, 302);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(63, 63);
            this.One.TabIndex = 23;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.Writenum);
            // 
            // takeaway
            // 
            this.takeaway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.takeaway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeaway.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.takeaway.ForeColor = System.Drawing.Color.White;
            this.takeaway.Location = new System.Drawing.Point(224, 233);
            this.takeaway.Name = "takeaway";
            this.takeaway.Size = new System.Drawing.Size(63, 63);
            this.takeaway.TabIndex = 30;
            this.takeaway.Text = "-";
            this.takeaway.UseVisualStyleBackColor = false;
            this.takeaway.Click += new System.EventHandler(this.WriteOperators);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Six.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Six.ForeColor = System.Drawing.Color.White;
            this.Six.Location = new System.Drawing.Point(153, 233);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(63, 63);
            this.Six.TabIndex = 29;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Writenum);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Five.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Five.ForeColor = System.Drawing.Color.White;
            this.Five.Location = new System.Drawing.Point(83, 233);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(63, 63);
            this.Five.TabIndex = 28;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.Writenum);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Four.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Four.ForeColor = System.Drawing.Color.White;
            this.Four.Location = new System.Drawing.Point(13, 233);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(63, 63);
            this.Four.TabIndex = 27;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.Writenum);
            // 
            // Times
            // 
            this.Times.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Times.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Times.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Times.ForeColor = System.Drawing.Color.White;
            this.Times.Location = new System.Drawing.Point(224, 164);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(63, 63);
            this.Times.TabIndex = 34;
            this.Times.Text = "*";
            this.Times.UseVisualStyleBackColor = false;
            this.Times.Click += new System.EventHandler(this.WriteOperators);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nine.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Nine.ForeColor = System.Drawing.Color.White;
            this.Nine.Location = new System.Drawing.Point(153, 164);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(63, 63);
            this.Nine.TabIndex = 33;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.Writenum);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eight.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Eight.ForeColor = System.Drawing.Color.White;
            this.Eight.Location = new System.Drawing.Point(83, 164);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(63, 63);
            this.Eight.TabIndex = 32;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.Writenum);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seven.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Seven.ForeColor = System.Drawing.Color.White;
            this.Seven.Location = new System.Drawing.Point(13, 164);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(63, 63);
            this.Seven.TabIndex = 31;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Writenum);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divide.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Divide.ForeColor = System.Drawing.Color.White;
            this.Divide.Location = new System.Drawing.Point(224, 93);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(63, 63);
            this.Divide.TabIndex = 38;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.WriteOperators);
            // 
            // Percent
            // 
            this.Percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Percent.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Percent.ForeColor = System.Drawing.Color.White;
            this.Percent.Location = new System.Drawing.Point(153, 93);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(63, 63);
            this.Percent.TabIndex = 37;
            this.Percent.Text = "%";
            this.Percent.UseVisualStyleBackColor = false;
            this.Percent.Click += new System.EventHandler(this.WriteOperators);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(83, 93);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(63, 63);
            this.Delete.TabIndex = 36;
            this.Delete.Text = "←";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(13, 93);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(63, 63);
            this.Clear.TabIndex = 35;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Display.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.Display.ForeColor = System.Drawing.Color.White;
            this.Display.Location = new System.Drawing.Point(14, 51);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(274, 30);
            this.Display.TabIndex = 39;
            // 
            // Operation
            // 
            this.Operation.AutoSize = true;
            this.Operation.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.Operation.ForeColor = System.Drawing.Color.White;
            this.Operation.Location = new System.Drawing.Point(268, 31);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(0, 19);
            this.Operation.TabIndex = 40;
            // 
            // FirstNumber
            // 
            this.FirstNumber.AutoSize = true;
            this.FirstNumber.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.FirstNumber.ForeColor = System.Drawing.Color.White;
            this.FirstNumber.Location = new System.Drawing.Point(18, 31);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(0, 19);
            this.FirstNumber.TabIndex = 41;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.FirstNumber);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.takeaway);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.DecPoint);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Windowbar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.Windowbar.ResumeLayout(false);
            this.Windowbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Windowbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button DecPoint;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button takeaway;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Times;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Label Operation;
        private System.Windows.Forms.Label FirstNumber;
        private System.Windows.Forms.PictureBox BtnExit;
    }
}