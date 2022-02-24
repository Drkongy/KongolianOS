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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }



        public string Username, Password, current_user, Themes;
        public string[] validation;



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        private void BtnRegister_Click_1(object sender, EventArgs e)
        {

    
            try
            {
                if (TBUsername.Text != "" && TBPass.Text != "")
                {


                    String[] Nameusers = File.ReadAllLines("C:\\KongolianOS\\Users\\" + "Users.ID");
                    for (int i = 0; i < Nameusers.Length; i++)
                    {
                        if (Nameusers[i] != TBUsername.Text)
                        {

                            var sr2 = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + TBUsername.Text + "\\.SysData\\Login.ID");
                            Username = sr2.ReadLine();
                            Password = sr2.ReadLine();
                            sr2.Close();



                            if (TBUsername.Text != Username && TBPass.Text != Password)
                            {
                                var sw = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + TBUsername.Text + "\\.SysData\\Login.ID");
                                sw.Write(TBUsername.Text + "\n" + TBPass.Text);
                                sw.Close();
                            }




                        }
                        //else
                            //MessageBox.Show("This Username has already beed used!");
                    }


                    var sr = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + TBUsername.Text + "\\.SysData\\Login.ID");
                    Username = sr.ReadLine();
                    Password = sr.ReadLine();
                    sr.Close();


                    if (Username != TBUsername.Text)
                    {
                        using (StreamWriter w = File.AppendText("C:\\KongolianOS\\Users\\" + "\\Users.ID"))
                        {
                            w.WriteLine(TBUsername.Text);

                        }
                    }
                    else
                        MessageBox.Show("User: " + TBUsername.Text + " Already Exsists!");




                }
                else
                    MessageBox.Show("Please Enter A Valid Username and password!");











                //var sw2 = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + "\\Users.ID");
                //sw2.Write("test" + "\n");
                //sw2.Write("test" + "\n");
                //sw2.Write("test" + "\n");
                //sw2.Close();









            }
            catch (System.IO.DirectoryNotFoundException)
            {
                String encryption;

                
                System.IO.Directory.CreateDirectory("C:\\KongolianOS\\Users\\" + TBUsername.Text + "\\Documents");
                System.IO.Directory.CreateDirectory("C:\\KongolianOS\\Users\\" + TBUsername.Text + "\\.SysData");

                encryption = Convert.ToBase64String(Encoding.Unicode.GetBytes(TBPass.Text));
                var sw = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + TBUsername.Text + "\\.SysData\\Login.ID");
                sw.Write(TBUsername.Text + "\n" + encryption);
                sw.Close();
                MessageBox.Show("New User Created: " + TBUsername.Text, "Registration complete!");












                if (TBUsername.Text != "" && TBPass.Text != "")
                {
                    using (StreamWriter w = File.AppendText("C:\\KongolianOS\\Users\\" + "Users.ID"))
                    {
                        w.WriteLine(TBUsername.Text);
                    }
                }




               //var S = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + TBUsername.Text + "\\Documents\\Sample.txt");
                using (StreamWriter Sample = File.AppendText("C:\\KongolianOS\\Users\\" + TBUsername.Text + "\\Documents\\Sample.txt"))
                {
                    Sample.WriteLine("This is sample text!");
                    Sample.WriteLine("Bananas are cool, They are underated");
                    Sample.WriteLine("");
                    Sample.WriteLine("");
                    Sample.WriteLine("Want to be my friend?");
                }


            }



            int counter = 0;
            string line;


            LBUsers.Items.Clear();
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + "Users.ID");
            while ((line = file.ReadLine()) != null)
            {
                LBUsers.Items.Add(line);
                counter++;
            }
            file.Close();


        }





        private void Users_Load(object sender, EventArgs e)
        {


            int counter = 0;
            string line;


            LBUsers.Items.Clear();
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + "Users.ID");
            while ((line = file.ReadLine()) != null)
            {
                LBUsers.Items.Add(line);
                counter++;
            }
            file.Close();


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


                panel1.BackColor = Color.FromArgb(128, 128, 128);
                LBUsers.BackColor = Color.FromArgb(128, 128, 128);
                LBUsers.ForeColor = Color.Black;


                TBPass.BackColor = Color.FromArgb(128, 128, 128);
                TBPass.ForeColor = Color.Black;
                TBUsername.BackColor = Color.FromArgb(128, 128, 128);
                TBUsername.ForeColor = Color.Black;

                // Text


                label1.ForeColor = Color.Black;
                LblRegistration.ForeColor = Color.Black;
                LblPass.ForeColor = Color.Black;
                lblNewUsername.ForeColor = Color.Black;
                



                //buttons
                BtnRegister.BackColor = Color.FromArgb(128, 128, 128);


                //Butten text
                BtnRegister.ForeColor = Color.Black;



                //Icons / images

                //PbIcon.BackgroundImage = Properties.Resources.darktheme_icon;



                //background

                this.BackColor = Color.FromArgb(221, 234, 255);

            }
            else
            {

            }


        }







        // form movement and interations

        int mX = 0, mY = 0;
        bool mousedown;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                mX = MousePosition.X - 325;
                mY = MousePosition.Y - 13;

                this.SetDesktopLocation(mX, mY);

            }
        }
    }





    }

