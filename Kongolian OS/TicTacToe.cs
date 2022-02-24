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
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }


        public string current_user, Themes;

        //when the form loads
        private void TicTacToe_Load(object sender, EventArgs e)
        {
            PnlMain.Visible = false;
            PnlMenu.Visible = true;

            this.Name = "TicTacToe";


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





                PnlMain.BackColor = Color.FromArgb(221, 234, 255);
                PnlMenu.BackColor = Color.FromArgb(221, 234, 255);
                PnlPlayAgain.BackColor = Color.FromArgb(221, 234, 255);












                //// Text

                LblAutoClicker.ForeColor = Color.Black;
                Lbl0Points.ForeColor = Color.Black;
                LblDesc.ForeColor = Color.Black;
                LblWinner.ForeColor = Color.Black;
                LblXPoints.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;



                ////buttons
                Btn1Player.BackColor = Color.FromArgb(128, 128, 128);
                Btn2player.BackColor = Color.FromArgb(128, 128, 128);
                BtnPlayAgain.BackColor = Color.FromArgb(128, 128, 128);


                Btn1Player.ForeColor = Color.Black;
                Btn2player.ForeColor = Color.Black;
                BtnPlayAgain.ForeColor = Color.Black;

                button1.BackColor = Color.FromArgb(128, 128, 128);
                button2.BackColor = Color.FromArgb(128, 128, 128);
                button3.BackColor = Color.FromArgb(128, 128, 128);
                button4.BackColor = Color.FromArgb(128, 128, 128);
                button5.BackColor = Color.FromArgb(128, 128, 128);
                button6.BackColor = Color.FromArgb(128, 128, 128);
                button7.BackColor = Color.FromArgb(128, 128, 128);
                button8.BackColor = Color.FromArgb(128, 128, 128);
                button9.BackColor = Color.FromArgb(128, 128, 128);


                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;
                button4.ForeColor = Color.Black;
                button5.ForeColor = Color.Black;
                button6.ForeColor = Color.Black;
                button7.ForeColor = Color.Black;
                button8.ForeColor = Color.Black;
                button9.ForeColor = Color.Black;




                //background

                this.BackColor = Color.FromArgb(221, 234, 255);

            }
            else
            {

            }




        }

        //closes the application
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Windows bar movement

        int mX = 0, mY = 0;
        bool mousedown;
        private void Windowbar_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;

        }

        // Windows bar
        private void Windowbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                mX = MousePosition.X - 90;
                mY = MousePosition.Y - 13;
                this.SetDesktopLocation(mX, mY);
            }
        }

        private void Windowbar_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;

        }

        private void LblAutoClicker_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;

        }

        private void LblAutoClicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                mX = MousePosition.X - 90;
                mY = MousePosition.Y - 13;
                this.SetDesktopLocation(mX, mY);
            }
        }



        private void LblAutoClicker_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        //____________________________________________________________________________






















        // Main Menu

        public bool mode;




        private void Btn1Player_Click(object sender, EventArgs e)
        {

            mode = true;
            PnlMenu.Visible = false;
            PnlMain.Visible = true;
            

        }



        private void Btn2player_Click(object sender, EventArgs e)
        {
            mode = false;
            PnlMenu.Visible = false;
            PnlMain.Visible = true;
        }



        // main game






        string[] gboard = new string[9];
        int currentturn = 0;
        public bool pturnstr = false;
        public int Ai;
        public int xp, OP = 0;

        public string returnsymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "0";
            }
            else
            {
                return "X";

            }
        }



        public void wincheck()
        {
            for (int i = 0; i < 8; i++)
            {
                string combination = "";

                switch (i)
                {
                    case 0:
                        combination = gboard[0] + gboard[4] + gboard[8];
                        break;
                    case 1:
                        combination = gboard[2] + gboard[4] + gboard[6];
                        break;
                    case 2:
                        combination = gboard[0] + gboard[1] + gboard[2];
                        break;
                    case 3:
                        combination = gboard[3] + gboard[4] + gboard[5];
                        break;
                    case 4:
                        combination = gboard[6] + gboard[7] + gboard[8];
                        break;
                    case 5:
                        combination = gboard[0] + gboard[3] + gboard[6];
                        break;
                    case 6:
                        combination = gboard[1] + gboard[4] + gboard[7];
                        break;
                    case 7:
                        combination = gboard[2] + gboard[5] + gboard[8];
                        break;
                }

                if (combination.Equals("000"))
                {
                    reset();
                    PnlPlayAgain.Visible = true;
                    LblWinner.Text = "Player 0 Won!";
                    OP++;
                    Lbl0Points.Text = OP.ToString();
                    pturnstr = true;





                }
                else if (combination.Equals("XXX"))
                {
                    reset();
                    PnlPlayAgain.Visible = true;
                    LblWinner.Text = "Player X Won!";
                    xp++;
                    LblXPoints.Text = xp.ToString();
                    pturnstr = true;

                }

                checkdraw();

            }
        }

        public void checkdraw()
        {
            int counter = 0;
            for (int i = 0; i < gboard.Length; i++)
            {
                if (gboard[i] != null) { counter++; }
                
                if (counter == 9)
                {
                    reset();
                    PnlPlayAgain.Visible = true;
                    LblWinner.Text = "Draw!";
                    pturnstr = true;


                }
            }

        }
        public void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            gboard = new string[9];
            currentturn = 0;
            num = new int[9];
            inc = 0;
            lastgo = false;





    }






        public int pos;
        public int[] num = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int inc = 0;
        public bool lastgo = false;
        public void ainumgen()
        {
            Random random = new Random();
            pos = random.Next(1, 10);
            LblDesc.Text = "Ai Processing";

            int counter = 0;
            for (int i = 0; i < gboard.Length; i++)
            {
                if (gboard[i] != null) { counter++; }

                if (counter == 8)
                {
                    lastgo = true;
                }
            }



            //var exclude = new HashSet<int>() { num[0], num[1], num[2], num[3], num[4], num[5], num[6], num[7], num[8] };
            //var range = Enumerable.Range(0, 10).Where(i => !exclude.Contains(i));

            //var rand = new System.Random();
            //int index = rand.Next(1, 10 - exclude.Count);
            //pos =  range.ElementAt(index);

            //num[inc] = pos;

            //inc++;




        }


        public void ai()
        {
            ainumgen();
            bool L = true;
            LblDesc.Text = "AI Thinking";
            do
            {
                if (pos == 1) { if (button1.Text != "") { ainumgen(); } else { button1.Text = "0"; gboard[0] = "0"; L = false; } };
                if (pos == 2) { if (button2.Text != "") { ainumgen(); } else { button2.Text = "0"; gboard[1] = "0"; L = false; } };
                if (pos == 3) { if (button3.Text != "") { ainumgen(); } else { button3.Text = "0"; gboard[2] = "0"; L = false; } };
                if (pos == 4) { if (button4.Text != "") { ainumgen(); } else { button4.Text = "0"; gboard[3] = "0"; L = false; } };
                if (pos == 5) { if (button5.Text != "") { ainumgen(); } else { button5.Text = "0"; gboard[4] = "0"; L = false; } };
                if (pos == 6) { if (button6.Text != "") { ainumgen(); } else { button6.Text = "0"; gboard[5] = "0"; L = false; } };
                if (pos == 7) { if (button7.Text != "") { ainumgen(); } else { button7.Text = "0"; gboard[6] = "0"; L = false; } };
                if (pos == 8) { if (button8.Text != "") { ainumgen(); } else { button8.Text = "0"; gboard[7] = "0"; L = false; } };
                if (pos == 9) { if (button9.Text != "") { ainumgen(); } else { button9.Text = "0"; gboard[8] = "0"; L = false; } };
            } while (L == true && lastgo == false);




        }


        //-----------------------------------------------------------------


        private void button1_Click(object sender, EventArgs e)
        {
            if (mode == false)
            {
                if (button1.Text == "")
                {
                    currentturn++;
                    gboard[0] = returnsymbol(currentturn);
                    button1.Text = gboard[0];
                    wincheck();
                    if (pturnstr == true)
                    {
                        LblDesc.Text = "X's Turn!";
                        pturnstr = !pturnstr;
                    }
                    else
                    {
                        LblDesc.Text = "0's Turn!";
                        pturnstr = !pturnstr;
                    }

                }
            }
            else if(mode == true)
            {
                if (button1.Text == "")
                {
                    gboard[0] = "X";
                    button1.Text = gboard[0];
                    ai();
                    wincheck();
                    LblDesc.Text = "X's Turn!";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mode == false)
            {
                if (button2.Text == "")
                {
                    currentturn++;
                    gboard[1] = returnsymbol(currentturn);
                    button2.Text = gboard[1];
                    wincheck();
                    if (pturnstr == true)
                    {
                        LblDesc.Text = "X's Turn!";
                        pturnstr = !pturnstr;
                    }
                    else
                    {
                        LblDesc.Text = "0's Turn!";
                        pturnstr = !pturnstr;
                    }
                }

            }
            else if (mode == true)
            {
                if (button2.Text == "")
                {
                    gboard[1] = "X";
                    button2.Text = gboard[1];
                    ai();
                    wincheck();
                    LblDesc.Text = "X's Turn!";
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mode == false)
            {
                if (button3.Text == "")
                {
                    currentturn++;
                    gboard[2] = returnsymbol(currentturn);
                    button3.Text = gboard[2];
                    wincheck();
                    if (pturnstr == true)
                    {
                        LblDesc.Text = "X's Turn!";
                        pturnstr = !pturnstr;
                    }
                    else
                    {
                        LblDesc.Text = "0's Turn!";
                        pturnstr = !pturnstr;
                    }
                }
            }
            else if (mode == true)
            {
                if (button3.Text == "")
                {
                    gboard[2] = "X";
                    button3.Text = gboard[2];
                    ai();
                    wincheck();
                    LblDesc.Text = "X's Turn!";
                }
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (mode == false)
            {
                if (button4.Text == "")
                {
                    currentturn++;
                    gboard[3] = returnsymbol(currentturn);
                    button4.Text = gboard[3];
                    wincheck();
                    if (pturnstr == true)
                    {
                        LblDesc.Text = "X's Turn!";
                        pturnstr = !pturnstr;
                    }
                    else
                    {
                        LblDesc.Text = "0's Turn!";
                        pturnstr = !pturnstr;
                    }
                }

            }
            else if (mode == true)
            {
                if (button4.Text == "")
                {
                    gboard[3] = "X";
                    button4.Text = gboard[3];
                    ai();
                    wincheck();
                    LblDesc.Text = "X's Turn!";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mode == false)
            {
                if (button5.Text == "")
                {
                    currentturn++;
                    gboard[4] = returnsymbol(currentturn);
                    button5.Text = gboard[4];
                    wincheck();
                    if (pturnstr == true)
                    {
                        LblDesc.Text = "X's Turn!";
                        pturnstr = !pturnstr;
                    }
                    else
                    {
                        LblDesc.Text = "0's Turn!";
                        pturnstr = !pturnstr;
                    }
                }

            }
            else if (mode == true)
            {
                if (button5.Text == "")
                {
                    gboard[4] = "X";
                    button5.Text = gboard[4];
                    ai();
                    wincheck();
                    LblDesc.Text = "X's Turn!";
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mode == false)
            {
                if (button6.Text == "")
                {
                    currentturn++;
                    gboard[5] = returnsymbol(currentturn);
                    button6.Text = gboard[5];
                    wincheck();
                    if (pturnstr == true)
                    {
                        LblDesc.Text = "X's Turn!";
                        pturnstr = !pturnstr;
                    }
                    else
                    {
                        LblDesc.Text = "0's Turn!";
                        pturnstr = !pturnstr;
                    }
                }

            }
            else if (mode == true)
            {
                if (button6.Text == "")
                {
                    gboard[5] = "X";
                    button6.Text = gboard[5];
                    ai();
                    wincheck();
                    LblDesc.Text = "X's Turn!";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (mode == false)
            {
                if (button7.Text == "")
                {
                    currentturn++;
                    gboard[6] = returnsymbol(currentturn);
                    button7.Text = gboard[6];
                    wincheck();
                    if (pturnstr == true)
                    {
                        LblDesc.Text = "X's Turn!";
                        pturnstr = !pturnstr;
                    }
                    else
                    {
                        LblDesc.Text = "0's Turn!";
                        pturnstr = !pturnstr;
                    }
                }

            }
            else if (mode == true)
            {
                if (button7.Text == "")
                {
                    gboard[6] = "X";
                    button7.Text = gboard[6];
                    ai();
                    wincheck();
                    LblDesc.Text = "X's Turn!";
                }
            }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            if (mode == false)
            {
                if (button8.Text == "")
                {
                    currentturn++;
                    gboard[7] = returnsymbol(currentturn);
                    button8.Text = gboard[7];
                    wincheck();
                    if (pturnstr == true)
                    {
                        LblDesc.Text = "X's Turn!";
                        pturnstr = !pturnstr;
                    }
                    else
                    {
                        LblDesc.Text = "0's Turn!";
                        pturnstr = !pturnstr;
                    }
                }

            }
            else if (mode == true)
            {
                if (button8.Text == "")
                {
                    gboard[7] = "X";
                    button8.Text = gboard[7];
                    ai();
                    wincheck();
                    LblDesc.Text = "X's Turn!";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (mode == false)
            {
                if (button9.Text == "")
                {
                    currentturn++;
                    gboard[8] = returnsymbol(currentturn);
                    button9.Text = gboard[8];
                    wincheck();
                    if (pturnstr == true)
                    {
                        LblDesc.Text = "X's Turn!";
                        pturnstr = !pturnstr;
                    }
                    else
                    {
                        LblDesc.Text = "0's Turn!";
                        pturnstr = !pturnstr;
                    }
                }

            }
            else if (mode == true)
            {
                if (button9.Text == "")
                {
                    gboard[8] = "X";
                    button9.Text = gboard[8];
                    ai();
                    wincheck();
                    LblDesc.Text = "X's Turn!";
                }
            }

        }




        // playing again


        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            PnlPlayAgain.Visible = false;

        }




    }
}
