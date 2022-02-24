using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kongolian_OS
{





    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public string version;
        public string bckset, bckform, backcolour, current_user, Themes;




        private void Settings_Load(object sender, EventArgs e)
        {
            Background_Sample1.BackgroundImage = Properties.Resources.Sample;
            Background_Sample2.BackgroundImage = Properties.Resources.Sample_2;
            Background_Sample3.BackgroundImage = Properties.Resources.sample_3;
            Background_Sample4.BackgroundImage = Properties.Resources.sample_4;

            this.Cursor = new Cursor(Properties.Resources.monkiclickercursordark_1.GetHicon());






            //shows the version of the os
            var V = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\DataSets\\Version.ID");
            version = V.ReadLine();
            V.Close();

            var CU = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\" + "Current_User.ID");
            current_user = CU.ReadLine();
            CU.Close();



            var Theme = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\Theme.ID");
            Themes = Theme.ReadLine();
            Theme.Close();

            if (Themes == "True")
            {
                // panels


                panel1.BackColor = Color.FromArgb(128, 128, 128);
                TBInfo.BackColor = Color.FromArgb(221, 234, 255);
                TBInfo.ForeColor = Color.Black;

                // Text


                label1.ForeColor = Color.Black;
                LblDisplay.ForeColor = Color.Black;
                LblVersion.ForeColor = Color.Black;
                LblDate.ForeColor = Color.Black;
                LblTime.ForeColor = Color.Black;
                LblValidation.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label15.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;
                label17.ForeColor = Color.Black;
                label18.ForeColor = Color.Black;
                label19.ForeColor = Color.Black;


                TBB.BackColor = Color.FromArgb(221, 234, 255);
                TBR.BackColor = Color.FromArgb(221, 234, 255);
                TBG.BackColor = Color.FromArgb(221, 234, 255);

                TBB.ForeColor = Color.Black;
                TBR.ForeColor = Color.Black;
                TBG.ForeColor = Color.Black;



                //buttons
                BtnUserSet.BackColor = Color.FromArgb(128,128,128);
                BtnUpdateLog.BackColor = Color.FromArgb(128, 128, 128);
                BtnTheme.BackColor = Color.FromArgb(128, 128, 128);
                Btn12Hour.BackColor = Color.FromArgb(128, 128, 128);
                Btn24Hour.BackColor = Color.FromArgb(128, 128, 128);
                BtnAboutUs.BackColor = Color.FromArgb(128, 128, 128);
                BtnAboutUs.BackColor = Color.FromArgb(128, 128, 128);
                Btnbackground_changer.BackColor = Color.FromArgb(128, 128, 128);
                BtnBrowse.BackColor = Color.FromArgb(128, 128, 128);
                BtnConfirm.BackColor = Color.FromArgb(128, 128, 128);
                BtnDateNormal.BackColor = Color.FromArgb(128, 128, 128);
                Btndatetime.BackColor = Color.FromArgb(128, 128, 128);
                BtnDefault.BackColor = Color.FromArgb(128, 128, 128);
                BtnDevs.BackColor = Color.FromArgb(128, 128, 128);
                BtnDTFormat.BackColor = Color.FromArgb(128, 128, 128);
                BtnFCenter.BackColor = Color.FromArgb(128, 128, 128);
                BtnFStretch.BackColor = Color.FromArgb(128, 128, 128);
                BtnFTile.BackColor = Color.FromArgb(128, 128, 128);
                BtnFullDate.BackColor = Color.FromArgb(128, 128, 128);
                BtnFutureUpdates.BackColor = Color.FromArgb(128, 128, 128);
                BtnFZoom.BackColor = Color.FromArgb(128, 128, 128);
                BtnSet.BackColor = Color.FromArgb(128, 128, 128);
                BtnSmallDate.BackColor = Color.FromArgb(128, 128, 128);
                BtnTab.BackColor = Color.FromArgb(128, 128, 128);
                BtnTask.BackColor = Color.FromArgb(128, 128, 128);
                BtnTheme.BackColor = Color.FromArgb(128, 128, 128);
                BtnThemeConfirm.BackColor = Color.FromArgb(128, 128, 128);
                BtnUpdateLog.BackColor = Color.FromArgb(128, 128, 128);
                BtnUserSet.BackColor = Color.FromArgb(128, 128, 128);

                //Butten text
                BtnUserSet.ForeColor = Color.Black;;
                BtnUpdateLog.ForeColor = Color.Black;;
                BtnTheme.ForeColor = Color.Black;;
                Btn12Hour.ForeColor = Color.Black;;
                Btn24Hour.ForeColor = Color.Black;;
                BtnAboutUs.ForeColor = Color.Black;;
                BtnAboutUs.ForeColor = Color.Black;;
                Btnbackground_changer.ForeColor = Color.Black;;
                BtnBrowse.ForeColor = Color.Black;;
                BtnConfirm.ForeColor = Color.Black;;
                BtnDateNormal.ForeColor = Color.Black;;
                Btndatetime.ForeColor = Color.Black;;
                BtnDefault.ForeColor = Color.Black;;
                BtnDevs.ForeColor = Color.Black;;
                BtnDTFormat.ForeColor = Color.Black;;
                BtnFCenter.ForeColor = Color.Black;;
                BtnFStretch.ForeColor = Color.Black;;
                BtnFTile.ForeColor = Color.Black;;
                BtnFullDate.ForeColor = Color.Black;;
                BtnFutureUpdates.ForeColor = Color.Black;;
                BtnFZoom.ForeColor = Color.Black;;
                BtnSet.ForeColor = Color.Black;;
                BtnSmallDate.ForeColor = Color.Black;;
                BtnTab.ForeColor = Color.Black;;
                BtnTask.ForeColor = Color.Black;;
                BtnTheme.ForeColor = Color.Black;;
                BtnThemeConfirm.ForeColor = Color.Black;;
                BtnUpdateLog.ForeColor = Color.Black;;
                BtnUserSet.ForeColor = Color.Black;;


                //Icons / images

                //PbIcon.BackgroundImage = Properties.Resources.darktheme_icon;



                //background

                this.BackColor = Color.FromArgb(221, 234, 255);
          
            }
            else
            {

            }

            LblVersion.Text = version;
        }



        // users
        private void BtnUserSet_Click(object sender, EventArgs e)
        {
            Users contrlusers = new Users();
            contrlusers.Show();

        }
        // exit
        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //settings movement

        int mX = 0, mY = 0;
        bool mousedown;

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }



        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                mX = MousePosition.X - 400;
                mY = MousePosition.Y - 13;

                this.SetDesktopLocation(mX, mY);

            }
        }


        // about us, future updates, updatelog display, devs
        public string infodata;
        private void BtnAboutUs_Click(object sender, EventArgs e)
        {

            TBInfo.Visible = true;
            
            
                PnlBackground.Visible = false;
                BtnTab.Visible = false;
                PnlDateTIme.Visible = false;
                PnlColours.Visible = false;

            
            LblDisplay.Text = "About Us";
            System.IO.StreamReader srRead = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\DataSets\\AboutUs.ID");
            string strFileText = "";
            strFileText = srRead.ReadToEnd();
            srRead.Close();
            TBInfo.Text = strFileText;

        }

        private void BtnFutureUpdates_Click(object sender, EventArgs e)
        {

            TBInfo.Visible = true;
           
            
                PnlBackground.Visible = false;
                BtnTab.Visible = false;
                PnlDateTIme.Visible = false;
                PnlColours.Visible = false;


            LblDisplay.Text = "Future Updates";
            System.IO.StreamReader srRead = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\DataSets\\FutureUpdates.ID");
            string strFileText = "";
            strFileText = srRead.ReadToEnd();
            srRead.Close();
            TBInfo.Text = strFileText;
        }




        private void BtnDevs_Click(object sender, EventArgs e)
        {
            TBInfo.Visible = true;
            
            
                PnlBackground.Visible = false;
                BtnTab.Visible = false;
                PnlDateTIme.Visible = false;
                PnlColours.Visible = false;



            LblDisplay.Text = "Developers";
            System.IO.StreamReader srRead = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\DataSets\\Devs.ID");
            string strFileText = "";
            strFileText = srRead.ReadToEnd();
            srRead.Close();
            TBInfo.Text = strFileText;
        }
        private void BtnUpdateLog_Click(object sender, EventArgs e)
        {
            TBInfo.Visible = true;

            
            
                PnlBackground.Visible = false;
                BtnTab.Visible = false;
                PnlDateTIme.Visible = false;
                PnlColours.Visible = false;


            LblDisplay.Text = "Update Log";
            System.IO.StreamReader srRead = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\DataSets\\UpdateLog.ID");
            string strFileText = "";
            strFileText = srRead.ReadToEnd();
            srRead.Close();
            TBInfo.Text = strFileText;
        }


        public string time, date;

        // date time settings and shit
        private void Btndatetime_Click(object sender, EventArgs e)
        {
            PnlDateTIme.Visible = true;
            PnlBackground.Visible = false;
            BtnTab.Visible = false;
            PnlColours.Visible = false;
            TBInfo.Visible = false;
            Datetimer.Enabled = true;
            LblDisplay.Text = "Date & Time";

        }


        private void Datetimer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            ///time

            if(time == "1")
            {
                LblTime.Text = dt.ToShortTimeString();
            }
            if(time == "2")
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

            //LblTime.Text = dt.ToShortTimeString();
            //LblTime.Text = dt.ToLongTimeString();
            //LblDate.Text = dt.ToLongDateString();
        }


        private void Btn24Hour_Click(object sender, EventArgs e)
        {
            time = "1";
            BtnDTFormat.Visible = true;
        }

        private void Btn12Hour_Click(object sender, EventArgs e)
        {
            time = "2";
            BtnDTFormat.Visible = true;

        }

        private void BtnFullDate_Click(object sender, EventArgs e)
        {
            date = "1";
            BtnDTFormat.Visible = true;

        }

        private void BtnSmallDate_Click(object sender, EventArgs e)
        {
            date = "2";
            BtnDTFormat.Visible = true;


        }

        private void BtnDateNormal_Click(object sender, EventArgs e)
        {
            date = "3";
            BtnDTFormat.Visible = true;


        }


        private void BtnDTFormat_Click(object sender, EventArgs e)
        {
            if(date != null && time != null)
            {
                var t = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\TimeDate.ID");
                t.WriteLine(time);
                t.WriteLine(date);
                t.Close();

                if (MessageBox.Show("Restart System For Changes!", "Background Set!", MessageBoxButtons.OK) == DialogResult.OK)
                {

                    

                }
            }
            else
            {
                MessageBox.Show("Please confirm format by clicking the button again");
            }

        }










        private void BtnTab_Click(object sender, EventArgs e)
        {

            PnlColours.Visible = !PnlColours.Visible;
            PnlBackground.Visible = !PnlBackground.Visible;

            if (PnlColours.Visible == true)
            {
                BtnTab.Text = "Background";
                LblDisplay.Text = "Appearence - Colours";

            }
            else
            {
                BtnTab.Text = "Colours";
                LblDisplay.Text = "Appearence - Background";
            }










        }







        //background Load
        public int backstr, formatstr;

        private void Btnbackground_changer_Click(object sender, EventArgs e)
        {

            PnlBackground.Visible = true;
            BtnTab.Visible = true;
            PnlColours.Visible = false;
            
            LblDisplay.Text = "Appearence - Background";
            if ((PnlBackground.Visible == true) && (TBInfo.Visible == true))
            {
                TBInfo.Visible = false;

            }
        }





        //Sample background click events
        private void Background_Sample1_Click(object sender, EventArgs e)
        {
            PBPreview.BackgroundImage = Properties.Resources.Sample;
            backstr = 1;




        }

        private void Background_Sample2_Click(object sender, EventArgs e)
        {
            PBPreview.BackgroundImage = Properties.Resources.Sample_2;
            backstr = 2;

        }

        private void Background_Sample3_Click(object sender, EventArgs e)
        {
            PBPreview.BackgroundImage = Properties.Resources.sample_3;
            backstr = 3;

        }



        private void Background_Sample4_Click(object sender, EventArgs e)
        {
            PBPreview.BackgroundImage = Properties.Resources.sample_4;
            backstr = 4;

        }






        //Background formats
        private void BtnFTile_Click(object sender, EventArgs e)
        {
            PBPreview.BackgroundImageLayout = ImageLayout.Tile;
            formatstr = 1;
 
        }

        private void BtnFCenter_Click(object sender, EventArgs e)
        {
            PBPreview.BackgroundImageLayout = ImageLayout.Center;
            formatstr = 2;

        }



        private void BtnFZoom_Click(object sender, EventArgs e)
        {
            PBPreview.BackgroundImageLayout = ImageLayout.Zoom;
            formatstr = 3;

        }



        private void BtnFStretch_Click(object sender, EventArgs e)
        {
            PBPreview.BackgroundImageLayout = ImageLayout.Stretch;
            formatstr = 4;

        }






        //set background


        private void BtnSet_Click(object sender, EventArgs e)
        {

            try
            {
                if (backstr == 1)
                {
                    var bgs = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndSet.ID");
                    bgs.Write("1");
                    bgs.Close();

                }
                if (backstr == 2)
                {
                    var bgs = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndSet.ID");
                    bgs.Write("2");
                    bgs.Close();

                }
                if (backstr == 3)
                {
                    var bgs = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndSet.ID");
                    bgs.Write("3");
                    bgs.Close();

                }
                if (backstr == 4)
                {
                    var bgs = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndSet.ID");
                    bgs.Write("4");
                    bgs.Close();

                }

                //format

                if (formatstr == 1)
                {
                    var bgf = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrdFormat.ID");
                    bgf.Write("1");
                    bgf.Close();


                }

                if (formatstr == 2)
                {
                    var bgf = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrdFormat.ID");
                    bgf.Write("2");
                    bgf.Close();



                }
                if (formatstr == 3)
                {
                    var bgf = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrdFormat.ID");
                    bgf.Write("3");
                    bgf.Close();



                }
                if (formatstr == 4)
                {
                    var bgf = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrdFormat.ID");
                    bgf.Write("4");
                    bgf.Close();



                }

                if (MessageBox.Show("Restart System For Changes!", "Background Set!", MessageBoxButtons.OK) == DialogResult.OK)

                {

 

                }




            }
            catch(System.IO.DirectoryNotFoundException)
            {

                // this is not needed!

                var bgs = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndSet.ID");
                var bgf = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrdFormat.ID");
                var bgc = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndColour.ID");
                MessageBox.Show("Directories Created","Files Loaded");

            }





            OS OSBACK = new OS();
            OSBACK.BackgroundImage = Properties.Resources.Sample;

            //background



        }

         //browse
        //BROWSE CURRENTLY HIDDEN
        private void BtnBrowse_Click(object sender, EventArgs e)
        {

        }




        //colours!!!

        public int R, G, B;



        public string StrR, StrG, StrB;

  





        // colours click button events
        //matt colours
        private void BtnRed_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 221;
                G = 46;
                B = 68;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }



        private void BtnPurple_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 170;
                G = 142;
                B = 214;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }



        private void BtnGreen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 120;
                G = 177;
                B = 89;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }



        private void BtnBlue_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 85;
                G = 172;
                B = 238;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }



        private void BtnYellow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 254;
                G = 203;
                B = 88;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }

 

        private void BtnOrange_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 243;
                G = 123;
                B = 62;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }



        private void BtnPink_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 245;
                G = 170;
                B = 190;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }




        // normal average colours

        private void BtnPeach_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 255;
                G = 218;
                B = 185;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }



        private void BtnVIolet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 148;
                G = 0;
                B = 221;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }



        private void BtnDarkGreen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 46;
                G = 139;
                B = 87;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }

   

        private void BtnDarkBlue_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 0;
                G = 0;
                B = 192;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }



        private void BtnGold_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 255;
                G = 215;
                B = 0;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }



        private void BtnShit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 128;
                G = 64;
                B = 0;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }



        private void BtnDefault_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 22;
                G = 34;
                B = 48;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }










        // GRAYSCALE COLOUR BUTTONS

        private void BtnWhite_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 255;
                G = 255;
                B = 255;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }



        private void BtnLLGray_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 224;
                G = 244;
                B = 244;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }



        private void BtnLGray_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 192;
                G = 192;
                B = 192;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }
        private void BtnGray_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 150;
                G = 150;
                B = 150;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }

        private void BtnDGray_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 110;
                G = 110;
                B = 110;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }

        private void BtnDDGray_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 60;
                G = 60;
                B = 60;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }

        private void BtnBlack_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                R = 0;
                G = 0;
                B = 0;
                PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                TBR.Text = R.ToString();
                TBG.Text = G.ToString();
                TBB.Text = B.ToString();
            }
        }



        // confirm colours!!!!


        private void BtnConfirm_Click(object sender, EventArgs e)
        {

            File.WriteAllText("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndColour.ID", "");
            using (StreamWriter Colours = File.AppendText("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndColour.ID"))
            {
                Colours.WriteLine("" + R.ToString());
                Colours.WriteLine("" + G.ToString());
                Colours.WriteLine("" + B.ToString());
                Colours.Close();
            }

            if (MessageBox.Show("Restart System For Changes!", "Colour Set!", MessageBoxButtons.OK) == DialogResult.OK)

            {
 
            }
        }





        //RGB VALUE ENTER
        private void TBR_TextChanged(object sender, EventArgs e)
        {



            if (TBR.Text != "")
            {
                if (TBG.Text != "")
                {
                    if (TBB.Text != "")
                    {
                        int SR, SG, SB;
                        SR = Int32.Parse(TBR.Text);
                        SG = Int32.Parse(TBG.Text);
                        SB = Int32.Parse(TBB.Text);

                        
                        
                        


                        if ((SR <= 255) && (SR >= 0))
                        {
                            R = Int32.Parse(TBR.Text);
                            PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                        }
                        else
                        {
                            TBR.Text = "0";
                            LblValidation.Text = ("RGB = 0 - 255!");
                        }

                        if ((SG <= 255) && (SG >= 0))
                        {
                            G = Int32.Parse(TBG.Text);
                            PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                        }
                        else
                        {
                            TBG.Text = "0";
                            LblValidation.Text = ("RGB = 0 - 255!");
                        }

                        if ((SB <= 255) && (SB >= 0))
                        {
                            B = Int32.Parse(TBB.Text);
                            PbColourPreview.BackColor = Color.FromArgb(R, G, B);
                        }
                        else
                        {
                            TBB.Text = "0";
                            LblValidation.Text = ("RGB = 0 - 255!");
                        }
                    }
                }
               

            }
            else
            { 


            }

            }


        //}
        //rgb VALIDATION
        private void TBR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }



    //THEMES DARK LIGHT

    public bool butt = false;

        private void BtnTheme_Click(object sender, EventArgs e)
        {
            BtnThemeConfirm.Visible = true;

            if ( butt == false)
            {
                BtnTheme.Text = "Dark Theme";
                PBThemePreview.BackgroundImage = Properties.Resources.Lightpreview;
            }
            else
            {
                BtnTheme.Text = "Light Theme";
                PBThemePreview.BackgroundImage = Properties.Resources.DarkPreview;
            }
            butt = !butt; 

        }

        private void BtnThemeConfirm_Click(object sender, EventArgs e)
        {
            if ( butt == false)
            {
                //dark theme
                var T = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\Theme.ID");
                T.WriteLine("False");
                T.Close();

                var bgc = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndColour.ID");
                bgc.WriteLine("22");
                bgc.WriteLine("34");
                bgc.WriteLine("48");
                bgc.Close();

                var bgs = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndSet.ID");
                bgs.WriteLine("1");
                bgs.Close();


                var bfs = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrdFormat.ID");
                bfs.WriteLine("2");
                bfs.Close();



            }
            else
            {

                //light theme
                var T = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\Theme.ID");
                T.WriteLine("True");
                T.Close();

                var bgc = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndColour.ID");
                bgc.WriteLine("221");
                bgc.WriteLine("234");
                bgc.WriteLine("255");
                bgc.Close();

                var bgs = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrndSet.ID");
                bgs.WriteLine("5");
                bgs.Close();


                var bfs = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.SysData\\BackSets\\BckGrdFormat.ID");
                bfs.WriteLine("2");
                bfs.Close();
            }



            if (MessageBox.Show("Restart System For Changes!", "Theme Set!", MessageBoxButtons.OK) == DialogResult.OK)

            {
            }
        }








    }
}
