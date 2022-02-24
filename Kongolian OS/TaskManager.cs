using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Kongolian_OS
{
    public partial class TaskManager : Form
    {
        public TaskManager()
        {
            InitializeComponent();
        }
        public string current_user, Themes;


        private void TaskManager_Load(object sender, EventArgs e)
        {




            // loads the themes for the App
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


                Windowbar.BackColor = Color.FromArgb(128, 128, 128);
                PnlApps.BackColor = Color.FromArgb(221, 234, 255);

                PnlPerformance.BackColor = Color.FromArgb(221, 234, 255);
                PnlProcess.BackColor = Color.FromArgb(221, 234, 255);
                LBProcesses.BackColor = Color.FromArgb(221, 234, 255);
                LBProcesses.ForeColor = Color.Black;
                LBApps.BackColor = Color.FromArgb(221, 234, 255);
                LBApps.ForeColor = Color.Black;
                TBApp.BackColor = Color.FromArgb(221, 234, 255);
                TBApp.ForeColor = Color.Black;










                // Text

                lblbtask.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                LblProcessCount.ForeColor = Color.Black;
                LblAppAmnt.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;




                //buttons
                BtnRefresh.BackColor = Color.FromArgb(128, 128, 128);
                BtnOpenApp.BackColor = Color.FromArgb(128, 128, 128);
                BtnRefresh.ForeColor = Color.Black;
                BtnOpenApp.ForeColor = Color.Black;



                BtnApps.ForeColor = Color.Black;
                BtnProcesses.ForeColor = Color.Black;
                BtnPerformance.ForeColor = Color.Black;





                BtnApps.BackColor = Color.LightGray;
                BtnPerformance.BackColor = Color.FromArgb(128, 128, 128);
                BtnProcesses.BackColor = Color.FromArgb(128, 128, 128);






                //background

                this.BackColor = Color.FromArgb(221, 234, 255);

            }
            else
            {
                BtnApps.BackColor = Color.Gray;
                BtnPerformance.BackColor = Color.FromArgb(41, 41, 48);
                BtnProcesses.BackColor = Color.FromArgb(41, 41, 48);
            }










            //Shows the apps panel
            PnlApps.Visible = true;
            PnlPerformance.Visible = false;
            PnlProcess.Visible = false;


            Refresh.Enabled = true; // refreshes the list box.
            RefreshProcess.Enabled = true;
            



            // loads all the data for the applications screen.
            // this is for the apps screen
            LBApps.Items.Clear();

            tskcount = Application.OpenForms.Count;
            Appscount = Application.OpenForms.Count - 2;
            LblAppAmnt.Text = "Apps (" + Appscount.ToString() + ")";

            foreach (Form frm in Application.OpenForms)
            {

                if (frm.Name != "OS" && frm.Name != "SplashScreen")
                {

                    if (frm.Name == "")
                    {
                        // this is for the file explorer that does not want to open.
                        LBApps.Items.Add("File Explorer");

                    }
                    else
                    {
                        LBApps.Items.Add(frm.Name);
                    }

                }


            }



            // this is for processes
            LblProcessCount.Text = "Processes (" + (tskcount + 9).ToString() + ")";
            int i = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "")
                {
                    // this is for the file explorer that does not want to open.
                    LBProcesses.Items.Add("File Explorer");

                }
                else
                {
                    
                    LBProcesses.Items.Add(frm.Name);

                    if (i == 0) { LBProcesses.Items.Add("KongolianOS GUI Render"); i += 1; }
                    if (i == 1) { LBProcesses.Items.Add("Sys4.load"); i += 1; }
                    if (i == 2) { LBProcesses.Items.Add("System StartUp"); i += 1; }
                    if (i == 3) { LBProcesses.Items.Add("System Interrupts"); i += 1; }
                    if (i == 4) { LBProcesses.Items.Add("User Manager"); i += 1; }
                    if (i == 5) { LBProcesses.Items.Add("File Handler"); i += 1; }
                    if (i == 6) { LBProcesses.Items.Add("Drivers"); i += 1; }
                    if (i == 7) { LBProcesses.Items.Add("Hardware Manager"); i += 1; }
                    if (i == 8) { LBProcesses.Items.Add("Counting Bananas"); i += 1; }








                }
            }



           






        }




        private void BtnExit_Click(object sender, EventArgs e)
        {

            this.Close();
            Refresh.Enabled = false;


        }

        //top bar move controls


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





        // top panel buttons

        private void BtnApps_Click(object sender, EventArgs e)
        {
            if (Themes == "True")
            {
                BtnApps.BackColor = Color.LightGray;
                BtnPerformance.BackColor = Color.FromArgb(128, 128, 128);
                BtnProcesses.BackColor = Color.FromArgb(128, 128, 128);
            }
            else
            {
                BtnApps.BackColor = Color.Gray;
                BtnPerformance.BackColor = Color.FromArgb(41, 41, 48);
                BtnProcesses.BackColor = Color.FromArgb(41, 41, 48);
            }
            // makes the panel visable
            PnlApps.Visible = true;
            PnlProcess.Visible = false;
            PnlPerformance.Visible = false;




        }
        private void BtnProcesses_Click(object sender, EventArgs e)
        { 
            // makes the panel visable
            PnlApps.Visible = false;
            PnlPerformance.Visible = false;
            PnlProcess.Visible = true;

            if (Themes == "True")
            {
                BtnApps.BackColor = Color.FromArgb(128, 128, 128);
                BtnPerformance.BackColor = Color.FromArgb(128, 128, 128);
                BtnProcesses.BackColor = Color.LightGray;
            }
            else
            {
                BtnApps.BackColor = Color.FromArgb(41, 41, 48);
                BtnPerformance.BackColor = Color.FromArgb(41, 41, 48);
                BtnProcesses.BackColor = Color.Gray;
            }

        }        
        private void BtnPerformance_Click(object sender, EventArgs e)
        {

            // makes the panel visable
            PnlApps.Visible = false;
            PnlPerformance.Visible = true;
            PnlProcess.Visible = false;


            if (Themes == "True")
            {
                BtnApps.BackColor = Color.FromArgb(128, 128, 128);
                BtnPerformance.BackColor = Color.LightGray;
                BtnProcesses.BackColor = Color.FromArgb(128, 128, 128);
            }
            else
            {
                BtnApps.BackColor = Color.FromArgb(41, 41, 48);
                BtnPerformance.BackColor = Color.Gray;
                BtnProcesses.BackColor = Color.FromArgb(41, 41, 48);


            }



        }













        

        //task manger
        public int tskcount, Appscount;
     


        //allows you to click an item in the listbox
        private void LBApps_SelectedIndexChanged(object sender, EventArgs e)
        {


            //displays the items in a textbox so you can do stuff with it

            try
            {

                if (LBApps.SelectedItem != null)
                {
                    TBApp.Text = LBApps.SelectedItem.ToString();

                }
                else
                {

                }
            }
            catch
            {

                if (LBApps.SelectedItem.ToString() == null)
                {

                    if (MessageBox.Show("Interval Error, Press OK to resolve", "Error!", MessageBoxButtons.OK) == DialogResult.OK)
                    {

                        TBApp.Text = LBApps.SelectedItem.ToString();


                    }




                }
                
            }
            

        }



        private void LBApps_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            if (LBApps.SelectedItem != null)
            {
                


                if (MessageBox.Show(LBApps.SelectedItem.ToString(), "End App?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (LBApps.SelectedItem != null)
                    {
                        TBApp.Text = LBApps.SelectedItem.ToString();

                    }

                    if (TBApp.Text == "Calculator")
                    {


                        List<Form> forms = new List<Form>();

                        // All opened myForm instances
                        foreach (Form f in Application.OpenForms)
                            if (f.Name == "Calculator")
                                forms.Add(f);

                        // Now let's close opened myForm instances
                        foreach (Form f in forms)
                        {
                            f.Close();
                            break;


                        }

                    }
                    else if(TBApp.Text == "Browser")
                    {
                        List<Form> forms = new List<Form>();

                        // All opened myForm instances
                        foreach (Form f in Application.OpenForms)
                            if (f.Name == "Browser")
                                forms.Add(f);

                        // Now let's close opened myForm instances
                        foreach (Form f in forms)
                        {
                            f.Close();
                            break;


                        }

                    }
                    else if (TBApp.Text == "File Explorer")
                    {
                        List<Form> forms = new List<Form>();

                        // All opened myForm instances
                        foreach (Form f in Application.OpenForms)
                            if (f.Name == "")
                                forms.Add(f);

                        // Now let's close opened myForm instances
                        foreach (Form f in forms)
                        {
                            f.Close();
                            break;


                        }

                    }
                    else if (TBApp.Text == "Notepad")
                    {
                        List<Form> forms = new List<Form>();

                        // All opened myForm instances
                        foreach (Form f in Application.OpenForms)
                            if (f.Name == "Notepad")
                                forms.Add(f);

                        // Now let's close opened myForm instances
                        foreach (Form f in forms)
                        {
                            f.Close();
                            break;


                        }

                    }
                    else if (TBApp.Text == "Settings")
                    {
                        List<Form> forms = new List<Form>();

                        // All opened myForm instances
                        foreach (Form f in Application.OpenForms)
                            if (f.Name == "Settings")
                                forms.Add(f);

                        // Now let's close opened myForm instances
                        foreach (Form f in forms)
                        {
                            f.Close();
                            break;


                        }

                    }
                    else if (TBApp.Text == "Users")
                    {
                        List<Form> forms = new List<Form>();

                        // All opened myForm instances
                        foreach (Form f in Application.OpenForms)
                            if (f.Name == "Users")
                                forms.Add(f);

                        // Now let's close opened myForm instances
                        foreach (Form f in forms)
                        {
                            f.Close();
                            break;


                        }

                    }
                    else if (TBApp.Text == "AutoClicker")
                    {
                        List<Form> forms = new List<Form>();

                        // All opened myForm instances
                        foreach (Form f in Application.OpenForms)
                            if (f.Name == "AutoClicker")
                                forms.Add(f);

                        // Now let's close opened myForm instances
                        foreach (Form f in forms)
                        {
                            f.Close();
                            break;


                        }

                    }
                    else if (TBApp.Text == "TicTacToe")
                    {
                        List<Form> forms = new List<Form>();

                        // All opened myForm instances
                        foreach (Form f in Application.OpenForms)
                            if (f.Name == "TicTacToe")
                                forms.Add(f);

                        // Now let's close opened myForm instances
                        foreach (Form f in forms)
                        {
                            f.Close();
                            break;


                        }

                    }
                    else if (TBApp.Text == "BananaClicker")
                    {
                        List<Form> forms = new List<Form>();

                        // All opened myForm instances
                        foreach (Form f in Application.OpenForms)
                            if (f.Name == "BananaClicker")
                                forms.Add(f);

                        // Now let's close opened myForm instances
                        foreach (Form f in forms)
                        {
                            f.Close();
                            break;


                        }

                    }
                    else if (TBApp.Text == "TaskManager")
                    {

                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Looks like you've already closed the instance!", "Error 3");
                    }

                    LBApps.Items.Clear();
                    TBApp.Text = "";
                    tskcount = Application.OpenForms.Count;
                    Appscount = Application.OpenForms.Count - 2;
                    LblAppAmnt.Text = "Apps (" + Appscount.ToString() + ")";

                    foreach (Form frm in Application.OpenForms)
                    {

                        if (frm.Name != "OS" && frm.Name != "SplashScreen")
                        {

                            if (frm.Name == "")
                            {
                                // this is for the file explorer that does not want to open.
                                LBApps.Items.Add("File Explorer");

                            }
                            else
                            {
                                LBApps.Items.Add(frm.Name);
                            }

                        }


                    }




                }

            }


        }



        private void BtnRefresh_Click_1(object sender, EventArgs e)
        {
            tskcount = Application.OpenForms.Count;
            Appscount = Application.OpenForms.Count - 2;
            LblAppAmnt.Text = "Apps (" + Appscount.ToString() + ")";


            LBApps.Items.Clear();




            foreach (Form frm in Application.OpenForms)
            {

                if (frm.Name != "OS" && frm.Name != "SplashScreen")
                {

                    if (frm.Name == "")
                    {
                        // this is for the file explorer that does not want to open.
                        LBApps.Items.Add("File Explorer");

                    }
                    else
                    {
                        LBApps.Items.Add(frm.Name);
                    }

                }


            }
        }


        private void Refresh_Tick(object sender, EventArgs e)
        {
            tskcount = Application.OpenForms.Count;
            Appscount = Application.OpenForms.Count - 2;
            LblAppAmnt.Text = "Apps (" + Appscount.ToString() + ")"; 


            LBApps.Items.Clear();




            foreach (Form frm in Application.OpenForms)
            {

                if (frm.Name != "OS" && frm.Name != "SplashScreen")
                {

                    if (frm.Name == "")
                    {
                        // this is for the file explorer that does not want to open.
                        LBApps.Items.Add("File Explorer");

                    }
                    else
                    {
                        LBApps.Items.Add(frm.Name);
                    }

                }
   

            }


        }


        private void BtnOpenApp_Click(object sender, EventArgs e)
        {
            if(TBApp.Text == "Calculator" || TBApp.Text == "calculator" || TBApp.Text == "CAlculator")
            {
                Calculator calc = new Calculator();
                calc.Show();

            }
            else if (TBApp.Text == "File Explorer" || TBApp.Text == "file Explorer" || TBApp.Text == "FIle Explorer")
            {
                Fileexplorer flex = new Fileexplorer();
                flex.Show();

            }
            else if (TBApp.Text == "Browser" || TBApp.Text == "browser" || TBApp.Text == "BRowser")
            {
                Browser brow = new Browser();
                brow.Show();

            }
            else if (TBApp.Text == "Notepad" || TBApp.Text == "notepad" || TBApp.Text == "NOtepad")
            {
                Notepad notes = new Notepad();
                notes.Show();

            }
            else if (TBApp.Text == "Settings" || TBApp.Text == "settings" || TBApp.Text == "SEttings")
            {
                Settings sett = new Settings();
                sett.Show();

            }
            else if (TBApp.Text == "Users" || TBApp.Text == "users" || TBApp.Text == "USers")
            {
                Users use = new Users();
                use.Show();

            }
            else if (TBApp.Text == "TaskManager" || TBApp.Text == "taskmanager" || TBApp.Text == "taskManager")
            {
                TaskManager tesma = new TaskManager();
                tesma.Show();

            }
            else if (TBApp.Text == "AutoClicker" || TBApp.Text == "Autoclicker" || TBApp.Text == "autoClicker")
            {
                AutoClicker ac = new AutoClicker();
                ac.Show();

            }
            else if (TBApp.Text == "TicTacToe" || TBApp.Text == "tictactoe" || TBApp.Text == "ticTacToe")
            {
                TicTacToe ttt = new TicTacToe();
                ttt.Show();

            }
            else if (TBApp.Text == "BananaClicker" || TBApp.Text == "bananaClicker" || TBApp.Text == "bananaclicker")
            {
                BananaClicker bc = new BananaClicker();
                bc.Show();

            }
            else
            {
                MessageBox.Show("Incorrect App Name. Please use correct name, Remember it's case sensitive!", "Error 2");
            }

            tskcount = Application.OpenForms.Count;
            Appscount = Application.OpenForms.Count - 2;
            LblAppAmnt.Text = "Apps (" + Appscount.ToString() + ")";


            LBApps.Items.Clear();
            TBApp.Text = "";



            foreach (Form frm in Application.OpenForms)
            {

                if (frm.Name != "OS" && frm.Name != "SplashScreen")
                {

                    if (frm.Name == "")
                    {
                        // this is for the file explorer that does not want to open.
                        LBApps.Items.Add("File Explorer");

                    } 
                    else
                    {
                        LBApps.Items.Add(frm.Name);
                    }

                }


            }



        }

        // this is the tick processes.
        private void RefreshProcess_Tick(object sender, EventArgs e)
        {
            LblProcessCount.Text = "Processes (" + (tskcount + 9).ToString() + ")";
            int i = 0;
            LBProcesses.Items.Clear();

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "")
                {
                    // this is for the file explorer that does not want to open.
                    LBProcesses.Items.Add("File Explorer");

                }
                else
                {

                    LBProcesses.Items.Add(frm.Name);

                    if (i == 0) { LBProcesses.Items.Add("KongolianOS GUI Render"); i += 1; }
                    if (i == 1) { LBProcesses.Items.Add("Sys4.load"); i += 1; }
                    if (i == 2) { LBProcesses.Items.Add("System Startup"); i += 1; }
                    if (i == 3) { LBProcesses.Items.Add("System Interrupts"); i += 1; }
                    if (i == 4) { LBProcesses.Items.Add("User Manager"); i += 1; }
                    if (i == 5) { LBProcesses.Items.Add("File Handler"); i += 1; }
                    if (i == 6) { LBProcesses.Items.Add("Drivers"); i += 1; }
                    if (i == 7) { LBProcesses.Items.Add("Hardware Manager"); i += 1; }
                    if (i == 8) { LBProcesses.Items.Add("Counting Bananas"); i += 1; }





                }
            }
        }







    }
}
