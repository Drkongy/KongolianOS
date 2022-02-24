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
    public partial class OS : Form
    {

  


        
        
        public OS()
        {
            InitializeComponent();
           

        }






        public String bckset, bckfrm, current_user, time, date, Themes;
        public int R, G, B;




        


        private void OS_Load(object sender, EventArgs e)
        {

            
            DateTimeTimer.Enabled = true;
            var CU = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\" + "Current_User.ID");
            current_user = CU.ReadLine();
            CU.Close();
             

            this.Cursor = new Cursor(Properties.Resources.monkiclickercursordark_1.GetHicon());

            LblCurrentUser.Text = current_user;

            //background shit

            try
            {


                //background
                var bgs = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndSet.ID");
                bckset = bgs.ReadLine();
                bgs.Close();

                //background format
                var bfs = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrdFormat.ID");
                bckfrm = bfs.ReadLine();
                bfs.Close();

                //date time
                var t = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\TimeDate.ID");
                time = t.ReadLine();
                date = t.ReadLine();
                t.Close();

                string SR, SG, SB;


                //background colour reading
                var bcs = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndColour.ID");
                SR = bcs.ReadLine();
                SG = bcs.ReadLine();
                SB = bcs.ReadLine();
                bcs.Close();


                //THEME
                var Theme = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\Theme.ID");
                Themes = Theme.ReadLine();
                Theme.Close();



                if (Themes == "True")
                {
                    // panels
                    PnlTop.BackColor = Color.FromArgb(128, 128, 128);
                    PnlDateTimeAdv.BackColor = Color.FromArgb(128, 128, 128);
                    PnlNotifications.BackColor = Color.FromArgb(128, 128, 128);
                    PnlPower.BackColor = Color.FromArgb(128, 128, 128);
                    PnlMoreApps.BackColor = Color.FromArgb(128, 128, 128);

                    // Text

                    LblCurrentUser.ForeColor = Color.Black;
                    LblDate.ForeColor = Color.Black;
                    LblDateAdv.ForeColor = Color.Black;
                    LblPowerOptions.ForeColor = Color.Black;
                    LblTime.ForeColor = Color.Black;
                    LblTimeAdv.ForeColor = Color.Black;
                    Lock.ForeColor = Color.Black;
                    Restart.ForeColor = Color.Black;
                    ShutDown.ForeColor = Color.Black;
                    LblNotifs.ForeColor = Color.Black;
                    label1.ForeColor = Color.Black;






                    //Icons / images
                    PbIcon.BackgroundImage = Properties.Resources.darktheme_icon;
                    TB.BackgroundImage = Properties.Resources.white_with_gradint_taskbar;
                    LockIco.BackgroundImage = Properties.Resources.blacklockicon;
                    RestartICo.BackgroundImage = Properties.Resources.blackrestarticon;
                    ShutdownIco.BackgroundImage = Properties.Resources.shutdown_Light_theme;
                    

                    //background

                    this.BackColor = Color.FromArgb(221, 234, 255);
                    this.BackgroundImage = Properties.Resources.Icon4lite;
                    this.BackgroundImageLayout = ImageLayout.Center;

                }
                else
                {

                }


                // converitn to int
                R = Int32.Parse(SR);
                G = Int32.Parse(SG);
                B = Int32.Parse(SB);

                //setting background colour
                this.BackColor = Color.FromArgb(R, G, B);

                
                if (bckset == "1" && Themes == "False")
                {
                    this.BackgroundImage = Properties.Resources.Sample;
                }


                if (bckset == "2")
                {
                    this.BackgroundImage = Properties.Resources.Sample_2;
                }


                if (bckset == "3")
                {
                    this.BackgroundImage = Properties.Resources.sample_3;
                }


                if (bckset == "4")
                {
                    this.BackgroundImage = Properties.Resources.sample_4;
                }

                if (bckset == "5")
                {
                    this.BackgroundImage = Properties.Resources.Icon4lite;
                }


                //format
                if (bckfrm == "1")
                {
                    this.BackgroundImageLayout = ImageLayout.Tile;
                }

                if (bckfrm == "2")
                {
                    this.BackgroundImageLayout = ImageLayout.Center;
                }

                if (bckfrm == "3")
                {
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                }

                if (bckfrm == "4")
                {
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }



                //THEME SETTINGS SET

                // if true Theme = light theme
                // Else, it's default
               










            }

            // if directory is not found
            catch (System.IO.DirectoryNotFoundException)
            {
                //creates directory for .sysdata

                System.IO.Directory.CreateDirectory("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets");

                // if it's the first time it will use this catch, other than that, they will go into settings,
                // and set their own background, once that is done this is no longer needed.
                var t = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\TimeDate.ID");
                t.WriteLine("1");
                t.WriteLine("2");
                t.Close();


                var bgs = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndSet.ID");
                var bgf = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrdFormat.ID");
                var bgc = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndColour.ID");
                bgc.WriteLine("22");
                bgc.WriteLine("34");
                bgc.WriteLine("48");
                bgc.Close();

                var T = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\Theme.ID");
                T.WriteLine("False");
                T.Close();



            }
            // if file is not found
            catch (System.IO.FileNotFoundException)
            {
                //creates directory for .sysdata
                System.IO.Directory.CreateDirectory("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets");

                // if it's the first time it will use this catch, other than that, they will go into settings,
                // and set their own background, once that is done this is no longer needed.
                var t = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\TimeDate.ID");
                t.WriteLine("1");
                t.WriteLine("2");
                t.Close();


                var bgs = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndSet.ID");
                var bgf = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrdFormat.ID");
                var bgc = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndColour.ID");
                bgc.WriteLine("22");
                bgc.WriteLine("34");
                bgc.WriteLine("48");
                bgc.Close();

                var T = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\Theme.ID");
                T.WriteLine("False");
                T.Close();


            }



            // for temp users

            if (current_user == "Temp")
            {

                TB.Visible = false;
                FileManager.Visible = false;
                NotePad.Visible = false;
                Calculator.Visible = false;
                Internet.Visible = false;
                MoreApps.Visible = false;
                BtnNotifs.Visible = false;
                BtnSettings.Visible = false;


                LblCurrentUser.Text = "Click Here To Create New User!";

                // make this hide everything
                // make notifications say sign up for a user or some shit
                // make it so that this acc can't do anything.
            }


            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "OS" || Application.OpenForms[i].Name == "SplashScreen" || Application.OpenForms[i].Name == "Login")
                {
                

                    //this is a test

                }
                else
                {
                    Application.OpenForms[i].Show();

                }

            }




        }





        private void BtnSettings_Click_1(object sender, EventArgs e)
        {
            Settings CntrlSett = new Settings();
            CntrlSett.Show();
        }



        //for panel that makes everything move.

        int mX = 0, mY = 0;
        bool mousedown;






        private void PnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void PnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }







        // shutdown lock and restart panels.

        private void BtnShutDown_Click(object sender, EventArgs e)
        {
            PnlPower.Visible = !PnlPower.Visible;
            if ((PnlNotifications.Visible == true) && (PnlPower.Visible == true))
            {
                PnlNotifications.Visible = false;

            }

        }



        public int powertime;
        public string State;
        public int Option;



        private void ShutDown_Click_1(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "OS")
                    Application.OpenForms[i].Hide();

            }



            PnlPower.Visible = false;
            PnlNotifications.Visible = false;
            PnlMoreApps.Visible = false;
            PnlDateTimeAdv.Visible = false;
            PnlTop.Visible = false;
            TB.Visible = false;
            LblCurrentUser.Visible = false;
            powertime = 0;
            State = "Shutting Down";
            PowerOptions.Start();
            Option = 1;







            





        }




        private void Restart_Click_1(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
     
                    if (Application.OpenForms[i].Name != "OS")
                        Application.OpenForms[i].Hide();

               
            }

            PnlPower.Visible = false;
            PnlNotifications.Visible = false;
            PnlMoreApps.Visible = false;
            PnlDateTimeAdv.Visible = false;
            PnlTop.Visible = false;
            TB.Visible = false;
            LblCurrentUser.Visible = false;
            powertime = 0;
            State = "Restarting";
            PowerOptions.Start();
            Option = 2;



         

 

        }

        private void Lock_Click_1(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "OS")
                    Application.OpenForms[i].Hide();
            }

            PnlPower.Visible = false;
            PnlNotifications.Visible = false;
            PnlMoreApps.Visible = false;
            PnlDateTimeAdv.Visible = false;
            PnlTop.Visible = false;
            TB.Visible = false;
            LblCurrentUser.Visible = false;
            powertime = 0;
            State = "Locking";
            PowerOptions.Start();
            Option = 3;



           






        }

        //shutting down restart and locking stuff

        private void PowerOptions_Tick(object sender, EventArgs e)
        {
            LblPowerOptions.Visible = true;
            
            powertime += 1000;
            if (powertime >= 0 && powertime <= 1000)
            {
                LblPowerOptions.Text = State + " ";
            }


            if (powertime >= 1001 && powertime <= 2000)
            {
                LblPowerOptions.Text = State + " .";
            }

            if (powertime >= 2001 && powertime <= 3000)
            {
                LblPowerOptions.Text = State + " ..";
            }

            if (powertime >= 3001 && powertime <= 4000)
            {
                LblPowerOptions.Text = State + " ...";
            }

            if (powertime >= 4001 && powertime <= 5000)
            {
                LblPowerOptions.Text = State + "";
            }


            if (powertime == 5000)
            {
                if (Option == 1)
                {
                    PowerOptions.Enabled = false;
                    Application.Exit();
                }

                if (Option == 2)
                {

                    Application.Restart();

                }

                if (Option == 3)
                {
                    Login userlogin = new Login();
                    userlogin.Show();
                    
                    this.Close();
                }



            }

        }


        ////////Times
        private void DateTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            ///time

            if (time == "1")
            {
                LblTime.Text = dt.ToShortTimeString();
            }
            if (time == "2")
            {
                LblTime.Text = dt.ToString("hh:mm tt");


            }

            if (time == "0" || time == null)
            {
                LblTime.Text = dt.ToShortTimeString();

            }


            /// date
            if (date == "1")
            {
                LblDate.Text = dt.ToString("dddd dd MMMM yyyy ");
            }
            if (date == "2")
            {
                LblDate.Text = dt.ToShortDateString();


            }

            if (date == "3")
            {
                LblDate.Text = dt.ToLongDateString();


            }

            if (date == "0" || date == null)
            {
                LblDate.Text = dt.ToShortDateString();

            }

            LblTimeAdv.Text = dt.ToLongTimeString();
            LblDateAdv.Text = dt.ToString("dddd dd MMMM yyyy ");
        }

        // temp users
        private void LblCurrentUser_Click(object sender, EventArgs e)
        {
            if (LblCurrentUser.Text == "Click Here To Create New User!")
            {
                Users usr = new Users();
                usr.Show();
                
            }
        }

        //buttons that open panels or apps
        private void BtnNotifs_Click(object sender, EventArgs e)
        {
            PnlNotifications.Visible = !PnlNotifications.Visible;
   


            if ((PnlPower.Visible == true) && (PnlNotifications.Visible == true))
            {
                PnlPower.Visible = false;

            }
        }

        private void LblDateTime_Click(object sender, EventArgs e)
        {
            PnlDateTimeAdv.Visible = !PnlDateTimeAdv.Visible;
            if (PnlPower.Visible == true)
            {
                PnlPower.Visible = false;

            }
        }

        private void LblDate_Click(object sender, EventArgs e)
        {
            PnlDateTimeAdv.Visible = !PnlDateTimeAdv.Visible;
            if (PnlPower.Visible == true)
            {
                PnlPower.Visible = false;

            }
        }

        private void MoreApps_Click(object sender, EventArgs e)
        {
            PnlMoreApps.Visible = !PnlMoreApps.Visible;
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            Calculator Calc = new Calculator();
            Calc.Show();
        }

        private void Btncalculator2_Click(object sender, EventArgs e)
        {
            Calculator Calc = new Calculator();
            Calc.Show();
        }

        private void BtnTskMangr_Click(object sender, EventArgs e)
        {
            TaskManager tskmanager = new TaskManager();
            tskmanager.Show();
        }

        private void BtnAutoClicker_Click(object sender, EventArgs e)
        {
            AutoClicker ac= new AutoClicker();
            ac.Show();
        }

        private void BtnTicTacToe_Click(object sender, EventArgs e)
        {
            TicTacToe ttt = new TicTacToe();

            ttt.Show();
        }

        private void BtnBananaClicker_Click(object sender, EventArgs e)
        {
            BananaClicker bc = new BananaClicker();
            bc.Show();
        }

        private void BtnShutDown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FileManager_Click(object sender, EventArgs e)
        {
           Fileexplorer filesexpl = new Fileexplorer();
            filesexpl.Show();
        }

        private void BtnFile2_Click(object sender, EventArgs e)
        {
            Fileexplorer filesexpl = new Fileexplorer();
            filesexpl.Show();
        }

        private void NotePad_Click(object sender, EventArgs e)
        {
            Notepad notes= new Notepad();
            notes.Show();
        }



        private void BtnNotepad2_Click(object sender, EventArgs e)
        {
            Notepad notes = new Notepad();
            notes.Show();
        }

        private void Internet_Click(object sender, EventArgs e)
        {
            Browser internet = new Browser();
            internet.Show();
        }

        private void BtnInternet2_Click(object sender, EventArgs e)
        {
            Browser internet = new Browser();
            internet.Show();
        }

        private void BtnNotifs_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void PnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                mX = MousePosition.X - 500;
                mY = MousePosition.Y - 20;

                this.SetDesktopLocation(mX, mY);

            }
        }
    }
}
