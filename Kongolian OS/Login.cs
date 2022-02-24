using System;
using System.IO;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string Username, Password, bools, encryption;
        public bool varfirsttime;
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var ft = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\FirstTime.ID");
            bools = ft.ReadLine();
            ft.Close();


            this.Cursor = new Cursor(Properties.Resources.monkiclickercursordark_1.GetHicon());


        }

        private void button1_Click(object sender, EventArgs e)
        {





            try
            {

                if (TBUsername.Text != "" && TBPass.Text != "")
                {
                    var sr = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + TBUsername.Text + "\\.SysData\\Login.ID");
                    Username = sr.ReadLine();
                    //Password = sr.ReadLine();
                    encryption = sr.ReadLine();
                    sr.Close();

                    Password = Encoding.Unicode.GetString(Convert.FromBase64String(encryption));



                }
                else
                {
                    //MessageBox.Show("Please Enter Username or password !", "Login Error!");
                }


                // CU = current user
                System.IO.Directory.CreateDirectory("C:\\KongolianOS\\Sys4");
                var CU = new System.IO.StreamWriter("C:\\KongolianOS\\Sys4\\Current_User.ID");
                CU.Write(TBUsername.Text);
                CU.Close();




                if (Username == TBUsername.Text && Password == TBPass.Text)
                {

                    if (TBUsername.Text == "Temp")
                    {
                        MessageBox.Show("First Time Using Kongolian OS? Go into settings and create a new user!", "Hello!");
                    }

                    OS OpSystem = new OS();
                    OpSystem.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is Incorrect!", "Login Error!");
                    TBPass.Text = "";


                }




            }

            catch (System.IO.DirectoryNotFoundException)
            {   


                MessageBox.Show("Username not found", "Error!");
                TBUsername.Text = "";
                TBPass.Text = "";

            }
        }


        //REMEMBER IF YOU EDIT ABOVE MAKE SURE YOU EDIT THE BELOW TOO!!!!

        private void TBPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {

                    if (TBUsername.Text != "" && TBPass.Text != "")
                    {
                        var sr = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + TBUsername.Text + "\\.SysData\\Login.ID");
                        Username = sr.ReadLine();
                        //Password = sr.ReadLine();
                        encryption = sr.ReadLine();
                        sr.Close();

                        Password = Encoding.Unicode.GetString(Convert.FromBase64String(encryption));



                    }
                    else
                    {
                        //MessageBox.Show("Please Enter Username or password !", "Login Error!");
                    }


                    // CU = current user
                    System.IO.Directory.CreateDirectory("C:\\KongolianOS\\Sys4");
                    var CU = new System.IO.StreamWriter("C:\\KongolianOS\\Sys4\\Current_User.ID");
                    CU.Write(TBUsername.Text);
                    CU.Close();




                    if (Username == TBUsername.Text && Password == TBPass.Text)
                    {

                        if (TBUsername.Text == "Temp")
                        {
                            MessageBox.Show("First Time Using Kongolian OS? Go into settings and create a new user!", "Hello!");
                        }

                        OS OpSystem = new OS();
                        OpSystem.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is Incorrect!", "Login Error!");
                        TBPass.Text = "";

                    }




                }

                catch (System.IO.DirectoryNotFoundException)
                {


                    MessageBox.Show("Username not found", "Error!");
                    TBUsername.Text = "";
                    TBPass.Text = "";


                }
            }
        }




        private void FirstTime_Click(object sender, EventArgs e)
        {
            //pictureBox1.BackgroundImage = Properties.Resources.Cool;
            //pictureBox1.BackgroundImage = "C:\\KongolianOS\\Sys4\\micon.png";



            MessageBox.Show("Username - Temp   Password - Pass123 ", "Help");

            

        }
        // moving the panel

        int mX = 0, mY = 0;
        bool mousedown;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                mX = MousePosition.X - 200;
                mY = MousePosition.Y - 13;

                this.SetDesktopLocation(mX, mY);

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;

        }








    }
}

