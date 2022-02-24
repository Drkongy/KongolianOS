using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;




namespace Kongolian_OS
{



    public partial class AutoClicker : Form
    {


        public AutoClicker()
        {

            InitializeComponent();

        }




        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;



       

        private void Autoclicker_Load(object sender, EventArgs e)
        {

            string current_user, Themes;


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
                LblAutoClicker.ForeColor = Color.Black;





                //labels
                label1.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;


                //buttons

                BtnConfirm.BackColor = Color.FromArgb(128, 128, 128);
                BtnConfirm.ForeColor = Color.Black;


                // text boxes

                TBClicks.BackColor = Color.FromArgb(221, 234, 255);
                TBClicks.ForeColor = Color.Black;

                TBIntervel.BackColor = Color.FromArgb(221, 234, 255);
                TBIntervel.ForeColor = Color.Black;






                //background

                this.BackColor = Color.FromArgb(221, 234, 255);

            }
            else
            {

            }





        }
          
               

        



    
    


        public bool Toggle = false;
        int clicks = 0;


        int mX = 0, mY = 0;
        bool mousedown;

        // moves the window
        private void LblAutoClicker_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void LblAutoClicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                mX = MousePosition.X - 75;
                mY = MousePosition.Y - 13;
                this.SetDesktopLocation(mX, mY);
            }
        }

        private void LblAutoClicker_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //autoclicker



        private void TBIntervel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TBIntervel_TextChanged(object sender, EventArgs e)
        {


            if (TBIntervel.Text == "0")
            {
                TBIntervel.Text = "100";
            }

            if (TBIntervel.Text != "")
            {
                Interval.Interval = Int32.Parse(TBIntervel.Text);

                BtnConfirm.Text = "Enable";

                Interval.Enabled = false;
            }
            else
            {
               
                //TBIntervel.Text = "1";
            }








        }


        public int Delaysecs = 0;
        public bool check;



        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //Delay.Enabled = true;


            //if (Toggle == false)
            //{

            //    //this is off

            //    BtnConfirm.Text = "Enable";

            //    Interval.Enabled = false;
            //    //Delay.Enabled = false;


            //}
            //else
            //{

            //    //this is on
            //    BtnConfirm.Text = "Disable";
                
            //    Delay.Enabled = true;




            //}
            ////Toggle = !Toggle;
            ///

            if (Interval.Enabled == true)
            {
                Interval.Enabled = false;
                BtnConfirm.Text = "Enable";
            }
            else
            {
                Delay.Enabled = true;

            }




        } 

        private void Delay_Tick(object sender, EventArgs e)
        {
            Delaysecs += 1000;

            if (Delaysecs == 1000)
            {
                BtnConfirm.Text = "3";
            }
            if (Delaysecs == 2000)
            {
                BtnConfirm.Text = "2";
            }
            if (Delaysecs == 3000)
            {
                BtnConfirm.Text = "1";

            }
            if (Delaysecs > 3000)
            {
                Delay.Enabled = false;
                BtnConfirm.Text = "Disable";
                Interval.Enabled = true;
                Toggle = false;
                Delaysecs = 0;

            }
        }

        private void LblAutoClicker_Click(object sender, EventArgs e)
        {

        }

        private void Windowbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TBClicks_TextChanged(object sender, EventArgs e)
        {

        }

        private void Interval_Tick(object sender, EventArgs e)
        {




            clicks++;
            TBClicks.Text = clicks.ToString();

 

            //Call the imported function with the cursor's current position
            int X = (int)Cursor.Position.X;
            int Y = (int)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);




        }




    }
}
