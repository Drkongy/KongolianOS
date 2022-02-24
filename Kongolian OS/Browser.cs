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
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        public string HomeUrl = "https://www.google.com/";



        //movement

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
                mX = MousePosition.X - 400;
                mY = MousePosition.Y - 13;

                this.SetDesktopLocation(mX, mY);

            }
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            UrlRefresh.Stop();
            this.Close();
        }



        private void Windowbar_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }


        public string current_user, Themes;



        // on load
        private void Browser_Load(object sender, EventArgs e)
        {
            WB.Navigate("https://www.google.com/");
            textBox1.Text = "https://www.google.com/";

            this.Cursor = new Cursor(Properties.Resources.monkiclickercursordark_1.GetHicon());
            var CU = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\" + "Current_User.ID");
            current_user = CU.ReadLine();
            CU.Close();



            var Theme = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\Theme.ID");
            Themes = Theme.ReadLine();
            Theme.Close();

            if (Themes == "True")
            {
                // panels
                //Windowed Bar
                Windowbar.BackColor = Color.FromArgb(128, 128, 128);
                label1.ForeColor = Color.Black;


                textBox1.BackColor = Color.FromArgb(128, 128, 128);
                textBox1.ForeColor = Color.Black;


                //display
                WB.BackColor = Color.FromArgb(128, 128, 128);
                WB.ForeColor = Color.Black;


   


                //buttons

                BtnGo.BackColor = Color.FromArgb(128, 128, 128);
                BtnBack.BackColor = Color.FromArgb(128, 128, 128);
                BtnFoward.BackColor = Color.FromArgb(128, 128, 128);
                BtnHome.BackColor = Color.FromArgb(128, 128, 128);
                BtnRefresh.BackColor = Color.FromArgb(128, 128, 128);





                BtnGo.ForeColor = Color.Black;
                BtnBack.ForeColor = Color.Black;
                BtnFoward.ForeColor = Color.Black;
                BtnHome.ForeColor = Color.Black;
                BtnRefresh.ForeColor = Color.Black;









                //background

                this.BackColor = Color.FromArgb(221, 234, 255);

            }
            else
            {

            }






        }

        private void UrlRefresh_Tick(object sender, EventArgs e)
        {
            textBox1.Text = WB.Url.ToString();
        }

        private void BtnFoward_Click(object sender, EventArgs e)
        {
            WB.GoForward();
            textBox1.Text = WB.Url.ToString();

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            WB.Navigate(HomeUrl);
            textBox1.Text = WB.Url.ToString();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //WB.Navigate(HomeUrl);
            WB.Refresh();
           // WB.Navigate(textBox1.Text);
            textBox1.Text = WB.Url.ToString();

            
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            WB.Navigate(textBox1.Text);
            textBox1.Text = WB.Url.ToString();
            UrlRefresh.Start();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            WB.Navigate(textBox1.Text);
            textBox1.Text = WB.Url.ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            UrlRefresh.Stop();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            WB.GoBack();
            textBox1.Text = WB.Url.ToString();
        }


    }
}
