using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kongolian_OS
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public string current_user, Themes;



        private void Calculator_Load(object sender, EventArgs e)
        {
            var CU = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\" + "Current_User.ID");
            current_user = CU.ReadLine();
            CU.Close();

            this.Cursor = new Cursor(Properties.Resources.monkiclickercursordark_1.GetHicon());

            var Theme = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\Theme.ID");
            Themes = Theme.ReadLine();
            Theme.Close();

            if (Themes == "True")
            {
                // panels
                //Windowed Bar
                Windowbar.BackColor = Color.FromArgb(128, 128, 128);
                label1.ForeColor = Color.Black;


                //display
                Display.BackColor = Color.FromArgb(128, 128, 128);
                Display.ForeColor = Color.Black;

                //labels
                FirstNumber.ForeColor = Color.Black;
                Operation.ForeColor = Color.Black;


                //buttons

                Clear.BackColor = Color.FromArgb(128, 128, 128);
                Delete.BackColor = Color.FromArgb(128, 128, 128);
                Percent.BackColor = Color.FromArgb(128, 128, 128);
                Divide.BackColor = Color.FromArgb(128, 128, 128);
                Times.BackColor = Color.FromArgb(128, 128, 128);
                Add.BackColor = Color.FromArgb(128, 128, 128);
                takeaway.BackColor = Color.FromArgb(128, 128, 128);
                Equals.BackColor = Color.FromArgb(128, 128, 128);
                DecPoint.BackColor = Color.FromArgb(128, 128, 128);
                Zero.BackColor = Color.FromArgb(128, 128, 128);
                One.BackColor = Color.FromArgb(128, 128, 128);
                Two.BackColor = Color.FromArgb(128, 128, 128);
                Three.BackColor = Color.FromArgb(128, 128, 128);
                Four.BackColor = Color.FromArgb(128, 128, 128);
                Five.BackColor = Color.FromArgb(128, 128, 128);
                Six.BackColor = Color.FromArgb(128, 128, 128);
                Seven.BackColor = Color.FromArgb(128, 128, 128);
                Eight.BackColor = Color.FromArgb(128, 128, 128);
                Nine.BackColor = Color.FromArgb(128, 128, 128);

                Clear.ForeColor = Color.Black;
                Delete.ForeColor = Color.Black;
                Percent.ForeColor = Color.Black;
                Divide.ForeColor = Color.Black;
                Times.ForeColor = Color.Black;
                Add.ForeColor = Color.Black;
                takeaway.ForeColor = Color.Black;
                Equals.ForeColor = Color.Black;
                DecPoint.ForeColor = Color.Black;
                Zero.ForeColor = Color.Black;
                One.ForeColor = Color.Black;
                Two.ForeColor = Color.Black;
                Three.ForeColor = Color.Black;
                Four.ForeColor = Color.Black;
                Five.ForeColor = Color.Black;
                Six.ForeColor = Color.Black;
                Seven.ForeColor = Color.Black;
                Eight.ForeColor = Color.Black;
                Nine.ForeColor = Color.Black;









                //background

                this.BackColor = Color.FromArgb(221, 234, 255);

            }
            else
            {

            }

        }
        
       

        // form movement

        int mX = 0, mY = 0;
        bool mousedown;
        private void Windowbar_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void Windowbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                mX = MousePosition.X - 150;
                mY = MousePosition.Y - 13;

                this.SetDesktopLocation(mX, mY);

            }
        }



        private void Windowbar_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }





        // main calculator scripts

        float firstnum = 0f;
        float secondnum = 0f;
        string Operator = "";





        private void Writenum(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Display.Text += b.Text;
        }
        
        private void WriteOperators(object sender, EventArgs e)
        {
            if (float.TryParse(Display.Text, out firstnum))
            {
                Button b = (Button)sender;
                if (b.Text == "+") { Operation.Text = "+"; Operator = "+"; }
                if (b.Text == "-") { Operation.Text = "-"; Operator = "-"; }
                if (b.Text == "*") { Operation.Text = "*"; Operator = "x"; }
                if (b.Text == "/") { Operation.Text = "/"; Operator = "÷"; }
                if (b.Text == "%") { Display.Text = (firstnum / 100).ToString(); Operation.Text = "%"; Operator = ""; return; }
                FirstNumber.Text = Display.Text;

                Display.Text = "";

            }

            else
                MessageBox.Show("Please enter valid number", "Error");
        }



        private void Equals_Click(object sender, EventArgs e)
        {
            if (float.TryParse(Display.Text, out secondnum))
            {
                switch (Operator)
                {
                    case "+":
                        Display.Text = (firstnum + secondnum).ToString();
                        break;
                    case "-":
                        Display.Text = (firstnum - secondnum).ToString();
                        break;
                    case "x":
                        Display.Text = (firstnum * secondnum).ToString();
                        break;
                    case "÷":
                        Display.Text = (firstnum / secondnum).ToString();
                        break;

                    default:
                        break;


                }


                FirstNumber.Text = firstnum + " " + Operator + " " + secondnum;


            }

            else
                MessageBox.Show("Please enter valid number", "Error");


            
        }

        
 

        private void Clear_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Operation.Text = "";
            FirstNumber.Text = "";
            firstnum = 0f;
            secondnum = 0f;

        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Delete_Click(object sender, EventArgs e)
        {
            if (Display.Text != "")
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);

            }
        }
    }       

}
