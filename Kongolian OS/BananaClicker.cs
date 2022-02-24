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
    public partial class BananaClicker : Form
    {
        public BananaClicker()
        {
            InitializeComponent();

            //initialises all varibles, objecsts and stuff
            BtnBBananaClick.FlatAppearance.MouseOverBackColor = BtnBBananaClick.BackColor;
            BtnBBananaClick.FlatAppearance.MouseDownBackColor = BtnBBananaClick.BackColor;
            this.BackgroundImage = Properties.Resources.forestbackgroundblurred;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Cursor = new Cursor(Properties.Resources.monkiclickercursordark_1.GetHicon());
        }


        public double Bananas, BPC, BPS; // for banana panel


        //for hands
        // increase if more hands are added

        public int[] HandAmount = new int[12];
        public double[] HandCost = new double[12];
        public double[] HandProfit = new double[12];
        public double[] HProfit = new double[12];



        // for Monkis 
        public int[] MonkiAmount = new int[12];
        public double[] MonkiCost = new double[12];
        public double[] MonkiProfit = new double[12];
        public double[] MProfit = new double[12];

        //for upgrades
        public int Upgr_count;
        public double[] Upgr_Price = new double[5];
        public string[] Upgr_Desc = new string[100];


        // this is for the prestige
        public int prestige_no;
        public double Intelligence;
        public double Prestige_Multi = 0.005;
        //other
        public double CostMultiplier = 0.028;
        public string dateTxt;







        // this calculates the idle cash
        public double IdleCash(bool IO, double BananaPS)
        {


            DateTime dt = DateTime.Now;
            DateTime dt2 = new DateTime();

            // when it's true it will refresh the files
            // the else is false which means it will read the file and apply the idle cash to the thingy.

            if (IO == true)
            {
                var t = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Idle.ID");
                t.WriteLine(dt);
                t.Close();
            }
            else
            {
                try
                {
                    var Idle = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Idle.ID");
                    dt2 = DateTime.Parse(Idle.ReadLine());
                    Idle.Close();

                    TimeSpan ts = dt - dt2;
                    Bananas = Bananas + (BPS * ts.TotalSeconds);
                }
                catch (System.IO.FileNotFoundException)
                {
                    var t = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Idle.ID");
                    t.WriteLine(dt);
                    t.Close();
                }
            }

            return BananaPS;

        }


        public void Playtime(bool IO)
        {
            DateTime dt = DateTime.Now;
            DateTime dt2 = new DateTime();

            // true is for the first time users.
            // false is for the refresh and refreshing the label.

            if (IO == true)
            {
                var t = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\PlayTime.ID");
                t.WriteLine(dt);
                t.Close();
            }
            else
            {
                try
                {
                    var Idle = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\PlayTime.ID");
                    dt2 = DateTime.Parse(Idle.ReadLine());
                    Idle.Close();


                    //Main Method


                    TimeSpan ts = dt - dt2;
                    int n = Convert.ToInt32(ts.TotalSeconds);

                    int day = n / (24 * 3600);

                    n = n % (24 * 3600);
                    int hour = n / 3600;

                    n %= 3600;
                    int minutes = n / 60;

                    n %= 60;
                    int seconds = n;

                    LblPlayTime.Text = "PlayTime: " + day + " Days " + hour + " Hours " + minutes + " Minutes " + seconds + " Seconds ";










                }
                catch (System.IO.FileNotFoundException)
                {
                    var t = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\PlayTime.ID");
                    t.WriteLine(dt);
                    t.Close();
                }
            }

           
        }

        // this adds milestones to the shops and gives upgrades to the shops
        public double MilesStonesMulti(int amount, double profit)
        {
            if (amount == 50)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 100)
            {
                profit = profit * 5;
                return (profit);

            }
            if (amount == 150)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 200)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 250)
            {
                profit = profit * 25;
                return (profit);

            }
            if (amount == 300)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 350)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 400)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 450)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 500)
            {
                profit = profit * 25;
                return (profit);

            }
            if (amount == 550)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 600)
            {
                profit = profit * 5;
                return (profit);

            }
            if (amount == 650)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 700)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 750)
            {
                profit = profit * 25;
                return (profit);

            }
            if (amount == 800)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 850)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 900)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 950)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 1000)
            {
                profit = profit * 25;
                return (profit);

            }
            if (amount == 1050)
            {
                profit = profit * 2;
                return (profit);

            }

            if (amount == 1100)
            {
                profit = profit * 5;
                return (profit);

            }
            if (amount == 1150)
            {
                profit = profit * 5;
                return (profit);

            }
            if (amount == 1200)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 1250)
            {
                profit = profit * 10;
                return (profit);

            }
            if (amount == 1300)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 1350)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 1400)
            {
                profit = profit * 5;
                return (profit);

            }
            if (amount == 1450)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 1500)
            {
                profit = profit * 25;
                return (profit);
            }
            if (amount == 1550)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 1600)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 1650)
            {
                profit = profit * 5;
                return (profit);

            }
            if (amount == 1700)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 1750)
            {
                profit = profit * 10;
                return (profit);

            }
            if (amount == 1800)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 1850)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 1900)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 1950)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2000)
            {
                profit = profit * 20;
                return (profit);
            }
            if (amount == 2050)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2100)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2150)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2200)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2250)
            {
                profit = profit * 25;
                return (profit);

            }
            if (amount == 2300)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2350)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2400)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2450)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2500)
            {
                profit = profit * 20;
                return (profit);

            }

            if (amount == 2550)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2600)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2650)
            {
                profit = profit * 5;
                return (profit);

            }
            if (amount == 2700)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2750)
            {
                profit = profit * 25;
                return (profit);

            }
            if (amount == 2800)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2850)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2900)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 2950)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3000)
            {
                profit = profit * 20;
                return (profit);
            }
            if (amount == 3050)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3100)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3150)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3200)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3250)
            {
                profit = profit * 5;
                return (profit);

            }
            if (amount == 3300)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3350)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3400)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3450)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3500)
            {
                profit = profit * 25;
                return (profit);

            }
            if (amount == 3550)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3600)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3650)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3700)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3750)
            {
                profit = profit * 5;
                return (profit);

            }
            if (amount == 3800)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3850)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3900)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 3950)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4000)
            {
                profit = profit * 100;
                return (profit);
            }
            if (amount == 4050)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4100)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4150)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4200)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4250)
            {
                profit = profit * 5;
                return (profit);

            }
            if (amount == 4300)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4350)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4400)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4450)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4500)
            {
                profit = profit * 10;
                return (profit);

            }
            if (amount == 4550)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4600)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4650)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4700)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4750)
            {
                profit = profit * 10;
                return (profit);

            }
            if (amount == 4800)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4850)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4900)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 4950)
            {
                profit = profit * 2;
                return (profit);

            }
            if (amount == 5000)
            {
                profit = profit * 100;
                return (profit);
            }

            return (profit);

        }

        // unlocks the hands sho[s
        public double HandUnlocks(double banana)
        {
            if (HandAmount[0] >= 50)
            {
                FPnlStoneHands.Visible = true;
            }
            if (HandAmount[1] >= 50)

            {
                FpnlCoal.Visible = true;
            }
            if (HandAmount[2] >= 50)
            {
                FPnlIronHands.Visible = true;
            }
            if (HandAmount[3] >= 50)
            {
                FPnlGoldHands.Visible = true;
            }
            if (HandAmount[4] >= 50)
            {
                FPnlDiamondHands.Visible = true;
            }
            if (HandAmount[5] >= 50)
            {
                FPnlEmeralndHands.Visible = true;
            }
            if (HandAmount[6] >= 50)
            {
                FpnlRubyHands.Visible = true;
            }
            if (HandAmount[7] >= 50)
            {
                FpnlSaphire.Visible = true;
            }
            if (HandAmount[8] >= 50)
            {
                FpnlVoid.Visible = true;
            }
            if (HandAmount[9] >= 50)
            {
                FpnlRainbownite.Visible = true;
            }
            if (HandAmount[10] >= 50)
            {
                FpnlBlackStoneHand.Visible = true;
            }


            return banana;

        }
        //unlocks the monki shops
        public double MonkiUnlocks(int amount)
        {
            //if monki amount is greater than 25 show the next shop.

            if (MonkiAmount[0] >= 50)
            {
                FpnlCapuchin.Visible = true;
            }
            if (MonkiAmount[1] >= 50)
            {
                FPnlBonobo.Visible = true;
            }
            if (MonkiAmount[2] >= 50)
            {
                FpnlOrangutan.Visible = true;
            }
            if (MonkiAmount[3] >= 50)
            {
                FpnlBaboon.Visible = true;
            }
            if (MonkiAmount[4] >= 50)
            {
                FpnlChimpanzee.Visible = true;
            }

            if (MonkiAmount[5] >= 50)
            {
                FPnlMandrill.Visible = true;

            }
            if (MonkiAmount[6] >= 50)
            {
                FpnlGelada.Visible = true;
            }
            if (MonkiAmount[7] >= 50)
            {
                FpnlGorilla.Visible = true;
            }
            if (MonkiAmount[8] >= 50)
            {
                FpnlHomoHabilis.Visible = true;
            }
            if (MonkiAmount[9] >= 50)
            {
                FpnlHomoErectus.Visible = true;
            }
            if (MonkiAmount[10] >= 50)
            {
                FpnlHomoSapien.Visible = true;
            }




            return amount;

        }

        //this is for the upgrades tab
        public void Upgr_Unlocks(bool io)
        {
            //initialises all of the descriptions and prices
            Upgr_Desc[1] = "2x Wooden Hands Multiplier";
            Upgr_Desc[2] = "2x Stone Hands Multiplier";
            Upgr_Desc[3] = "2x Coal Hands Multiplier";
            Upgr_Desc[4] = "2x Marmocets Multiplier";
            Upgr_Desc[5] = "2x Iron Hands Multiplier";
            Upgr_Desc[6] = "2x Capuchin Multiplier";
            Upgr_Desc[7] = "2x Gold Hands Multiplier";
            Upgr_Desc[8] = "2x Bonobo Multiplier";
            Upgr_Desc[9] = "2x Diamond Hands Multiplier";
            Upgr_Desc[10] = "2x Orangutan Multiplier";
            Upgr_Desc[11] = "2x Baboon Multiplier";
            Upgr_Desc[12] = "2x All BPS";
            Upgr_Desc[13] = "2x All Monke Profit";
            Upgr_Desc[14] = "2x All BPC";
            Upgr_Desc[15] = "2x All Hands Profit";
            Upgr_Desc[16] = "2x Wooden Hands Multiplier";
            Upgr_Desc[17] = "2x Marmocets Multiplier";
            Upgr_Desc[18] = "2x Stone Hands Multiplier";
            Upgr_Desc[19] = "2x Capuchin Multiplier";
            Upgr_Desc[20] = "2x Coal Hands Multiplier";
            Upgr_Desc[21] = "2x Bonobo Multiplier";
            Upgr_Desc[22] = "2x Iron Hands Multiplier";
            Upgr_Desc[23] = "2x Orangutan Multiplier";
            Upgr_Desc[24] = "2x Gold Hands Multiplier";
            Upgr_Desc[25] = "2x Baboon Multiplier";
            Upgr_Desc[26] = "2x Diamond Hands Multiplier";
            Upgr_Desc[27] = "2x Chimpanzee Multiplier";
            Upgr_Desc[28] = "2x Emerald Hands Multiplier";
            Upgr_Desc[29] = "2x Mandrill Multiplier";
            Upgr_Desc[30] = "2x Ruby Hands Multiplier";
            Upgr_Desc[31] = "2x Gelada Multiplier";
            Upgr_Desc[32] = "2x Saphire Hands Multiplier";
            Upgr_Desc[33] = "3x All BPS";
            Upgr_Desc[34] = "3x All Monke Profit";
            Upgr_Desc[35] = "3x All BPC";
            Upgr_Desc[36] = "3x All Hands Profit";
            Upgr_Desc[37] = "3x Wooden Hands Multiplier";
            Upgr_Desc[38] = "3x Marmocets Multiplier";
            Upgr_Desc[39] = "3x Stone Hands Multiplier";
            Upgr_Desc[40] = "3x Capuchin Multiplier";
            Upgr_Desc[41] = "3x Coal Hands Multiplier";
            Upgr_Desc[42] = "3x Bonobo Multiplier";
            Upgr_Desc[43] = "3x Iron Hands Multiplier";
            Upgr_Desc[44] = "3x Orangutan Multiplier";
            Upgr_Desc[45] = "3x Gold Hands Multiplier";
            Upgr_Desc[46] = "3x Baboon Multiplier";
            Upgr_Desc[47] = "3x Diamond Hands Multiplier";
            Upgr_Desc[48] = "3x Chimpanzee Multiplier";
            Upgr_Desc[49] = "3x Emerald Hands Multiplier";
            Upgr_Desc[50] = "3x Mandrill Multiplier";
            Upgr_Desc[51] = "3x Ruby Hands Multiplier";
            Upgr_Desc[52] = "3x Gelada Multiplier";
            Upgr_Desc[53] = "3x Saphire Hands Multiplier";
            Upgr_Desc[54] = "3x Gorilla Multiplier";
            Upgr_Desc[55] = "3x Void Hands Multiplier";
            Upgr_Desc[56] = "3x Homo Hablis Multiplier";
            Upgr_Desc[57] = "3x Rainbownite Hands Multiplier";
            Upgr_Desc[58] = "3x Homo Erectus Multiplier";
            Upgr_Desc[59] = "3x BlackStone Hands Multiplier";
            Upgr_Desc[60] = "3x Homo Sapien Multiplier";
            Upgr_Desc[61] = "2x All BPS";
            Upgr_Desc[62] = "2x All Monke Profit";
            Upgr_Desc[63] = "2x All BPC";
            Upgr_Desc[64] = "2x All Hands Profit";
            Upgr_Desc[65] = "3x Wooden Hands Multiplier";
            Upgr_Desc[66] = "3x Marmocets Multiplier";
            Upgr_Desc[67] = "3x Stone Hands Multiplier";
            Upgr_Desc[68] = "3x Capuchin Multiplier";
            Upgr_Desc[69] = "3x Coal Hands Multiplier";
            Upgr_Desc[70] = "3x Bonobo Multiplier";
            Upgr_Desc[71] = "3x Iron Hands Multiplier";
            Upgr_Desc[72] = "3x Orangutan Multiplier";
            Upgr_Desc[73] = "3x Gold Hands Multiplier";
            Upgr_Desc[74] = "3x Baboon Multiplier";
            Upgr_Desc[75] = "3x Diamond Hands Multiplier";
            Upgr_Desc[76] = "3x Chimpanzee Multiplier";
            Upgr_Desc[77] = "3x Emerald Hands Multiplier";
            Upgr_Desc[78] = "3x Mandrill Multiplier";
            Upgr_Desc[79] = "3x Ruby Hands Multiplier";
            Upgr_Desc[80] = "3x Gelada Multiplier";
            Upgr_Desc[81] = "3x Saphire Hands Multiplier";
            Upgr_Desc[82] = "3x Gorilla Multiplier";
            Upgr_Desc[83] = "3x Void Hands Multiplier";
            Upgr_Desc[84] = "3x Homo Hablis Multiplier";
            Upgr_Desc[85] = "3x Rainbownite Hands Multiplier";
            Upgr_Desc[86] = "3x Homo Erectus Multiplier";
            Upgr_Desc[87] = "3x BlackStone Hands Multiplier";
            Upgr_Desc[88] = "3x Homo Sapien Multiplier";
            Upgr_Desc[89] = "5x All BPS";
            Upgr_Desc[90] = "5x All Monke Profit";
            Upgr_Desc[91] = "5x All BPC";
            Upgr_Desc[92] = "5x All Hands Profit";



            Upgr_Desc[93] = "More upgrades in the future!";
            Upgr_Desc[94] = "More upgrades in the future!";
            Upgr_Desc[95] = "More upgrades in the future!";
            Upgr_Desc[96] = "More upgrades in the future!";





            // if it's true it means you clicked the button
            if (io == true)
            {
                if (Bananas >= Upgr_Price[0])
                {



                    // do the method here
                    // the methods adds the multipliers to the specific upgrader
                    Bananas = Bananas - Upgr_Price[0];

                    if (Upgr_count == 1) { HandProfit[0] *= 2; }
                    if (Upgr_count == 2) { HandProfit[1] *= 2; }
                    if (Upgr_count == 3) { HandProfit[2] *= 2; }
                    if (Upgr_count == 4) { MonkiProfit[0] *= 2; }
                    if (Upgr_count == 5) { HandProfit[3] *= 2; }
                    if (Upgr_count == 6) { MonkiProfit[1] *= 2; }
                    if (Upgr_count == 7) { HandProfit[4] *= 2; }
                    if (Upgr_count == 8) { MonkiProfit[2] *= 2; }
                    if (Upgr_count == 9) { HandProfit[5] *= 2; }
                    if (Upgr_count == 10) { MonkiProfit[3] *= 2; }
                    if (Upgr_count == 11) { MonkiProfit[4] *= 2; }
                    if (Upgr_count == 12) { BPS *= 2; }
                    if (Upgr_count == 13) { MonkiProfit[0] *= 2; MonkiProfit[1] *= 2; MonkiProfit[2] *= 2; MonkiProfit[3] *= 2; MonkiProfit[4] *= 2; MonkiProfit[5] *= 2; MonkiProfit[6] *= 2; MonkiProfit[7] *= 2; MonkiProfit[8] *= 2; MonkiProfit[9] *= 2; MonkiProfit[10] *= 2; MonkiProfit[11] *= 2; }
                    if (Upgr_count == 14) { BPC *= 2; }
                    if (Upgr_count == 15) { HandProfit[0] *= 2; HandProfit[1] *= 2; HandProfit[2] *= 2; HandProfit[3] *= 2; HandProfit[4] *= 2; HandProfit[5] *= 2; HandProfit[6] *= 2; HandProfit[7] *= 2; HandProfit[8] *= 2; HandProfit[9] *= 2; HandProfit[10] *= 2; HandProfit[11] *= 2; }
                    if (Upgr_count == 16) { HandProfit[0] *= 2; }
                    if (Upgr_count == 17) { MonkiProfit[0] *= 2; }
                    if (Upgr_count == 18) { HandProfit[1] *= 2; }
                    if (Upgr_count == 19) { MonkiProfit[1] *= 2; }
                    if (Upgr_count == 20) { HandProfit[2] *= 2; }
                    if (Upgr_count == 21) { MonkiProfit[2] *= 2; }
                    if (Upgr_count == 22) { HandProfit[3] *= 2; }
                    if (Upgr_count == 23) { MonkiProfit[3] *= 2; }
                    if (Upgr_count == 24) { HandProfit[4] *= 2; }
                    if (Upgr_count == 25) { MonkiProfit[4] *= 2; }
                    if (Upgr_count == 26) { HandProfit[5] *= 2; }
                    if (Upgr_count == 27) { MonkiProfit[6] *= 2; }
                    if (Upgr_count == 28) { HandProfit[6] *= 2; }
                    if (Upgr_count == 29) { MonkiProfit[7] *= 2; }
                    if (Upgr_count == 30) { HandProfit[7] *= 2; }
                    if (Upgr_count == 31) { MonkiProfit[8] *= 2; }
                    if (Upgr_count == 32) { HandProfit[8] *= 2; }
                    if (Upgr_count == 33) { BPS *= 3; }
                    if (Upgr_count == 34) { MonkiProfit[0] *= 3; MonkiProfit[1] *= 3; MonkiProfit[2] *= 3; MonkiProfit[3] *= 3; MonkiProfit[4] *= 3; MonkiProfit[5] *= 3; MonkiProfit[6] *= 3; MonkiProfit[7] *= 3; MonkiProfit[8] *= 3; MonkiProfit[9] *= 3; MonkiProfit[10] *= 3; MonkiProfit[11] *= 3; }
                    if (Upgr_count == 35) { BPC *= 3; }
                    if (Upgr_count == 36) { HandProfit[0] *= 3; HandProfit[1] *= 3; HandProfit[2] *= 3; HandProfit[3] *= 3; HandProfit[4] *= 3; HandProfit[5] *= 3; HandProfit[6] *= 3; HandProfit[7] *= 3; HandProfit[8] *= 3; HandProfit[9] *= 3; HandProfit[10] *= 3; HandProfit[11] *= 3; }
                    if (Upgr_count == 37) { HandProfit[0] *= 3; }
                    if (Upgr_count == 38) { MonkiProfit[0] *= 3; }
                    if (Upgr_count == 39) { HandProfit[1] *= 3; }
                    if (Upgr_count == 40) { MonkiProfit[1] *= 3; }
                    if (Upgr_count == 41) { HandProfit[2] *= 3; }
                    if (Upgr_count == 42) { MonkiProfit[2] *= 3; }
                    if (Upgr_count == 43) { HandProfit[3] *= 3; }
                    if (Upgr_count == 44) { MonkiProfit[3] *= 3; }
                    if (Upgr_count == 45) { HandProfit[4] *= 3; }
                    if (Upgr_count == 46) { MonkiProfit[4] *= 3; }
                    if (Upgr_count == 47) { HandProfit[5] *= 3; }
                    if (Upgr_count == 48) { MonkiProfit[5] *= 3; }
                    if (Upgr_count == 49) { HandProfit[6] *= 3; }
                    if (Upgr_count == 50) { MonkiProfit[6] *= 3; }
                    if (Upgr_count == 51) { HandProfit[7] *= 3; }
                    if (Upgr_count == 52) { MonkiProfit[7] *= 3; }
                    if (Upgr_count == 53) { HandProfit[8] *= 3; }
                    if (Upgr_count == 54) { MonkiProfit[8] *= 3; }
                    if (Upgr_count == 55) { HandProfit[9] *= 3; }
                    if (Upgr_count == 56) { MonkiProfit[9] *= 3; }
                    if (Upgr_count == 57) { HandProfit[10] *= 3; }
                    if (Upgr_count == 58) { MonkiProfit[10] *= 3; }
                    if (Upgr_count == 59) { HandProfit[11] *= 3; }
                    if (Upgr_count == 60) { MonkiProfit[11] *= 3; }
                    if (Upgr_count == 61) { BPS *= 2; }
                    if (Upgr_count == 62) { MonkiProfit[0] *= 2; MonkiProfit[1] *= 2; MonkiProfit[2] *= 2; MonkiProfit[3] *= 2; MonkiProfit[4] *= 2; MonkiProfit[5] *= 2; MonkiProfit[6] *= 2; MonkiProfit[7] *= 2; MonkiProfit[8] *= 2; MonkiProfit[9] *= 2; MonkiProfit[10] *= 2; MonkiProfit[11] *= 2; }
                    if (Upgr_count == 63) { BPC *= 2; }
                    if (Upgr_count == 64) { HandProfit[0] *= 2; HandProfit[1] *= 2; HandProfit[2] *= 2; HandProfit[3] *= 2; HandProfit[4] *= 2; HandProfit[5] *= 2; HandProfit[6] *= 2; HandProfit[7] *= 2; HandProfit[8] *= 2; HandProfit[9] *= 2; HandProfit[10] *= 2; HandProfit[11] *= 2; }
                    if (Upgr_count == 65) { HandProfit[0] *= 5; }
                    if (Upgr_count == 66) { MonkiProfit[0] *= 5; }
                    if (Upgr_count == 67) { HandProfit[1] *= 5; }
                    if (Upgr_count == 68) { MonkiProfit[1] *= 5; }
                    if (Upgr_count == 69) { HandProfit[2] *= 5; }
                    if (Upgr_count == 70) { MonkiProfit[2] *= 5; }
                    if (Upgr_count == 71) { HandProfit[3] *= 5; }
                    if (Upgr_count == 72) { MonkiProfit[3] *= 5; }
                    if (Upgr_count == 73) { HandProfit[4] *= 5; }
                    if (Upgr_count == 74) { MonkiProfit[4] *= 5; }
                    if (Upgr_count == 75) { HandProfit[5] *= 5; }
                    if (Upgr_count == 76) { MonkiProfit[5] *= 5; }
                    if (Upgr_count == 77) { HandProfit[6] *= 5; }
                    if (Upgr_count == 78) { MonkiProfit[6] *= 5; }
                    if (Upgr_count == 79) { HandProfit[7] *= 5; }
                    if (Upgr_count == 80) { MonkiProfit[7] *= 5; }
                    if (Upgr_count == 81) { HandProfit[8] *= 5; }
                    if (Upgr_count == 82) { MonkiProfit[8] *= 5; }
                    if (Upgr_count == 83) { HandProfit[9] *= 5; }
                    if (Upgr_count == 84) { MonkiProfit[9] *= 5; }
                    if (Upgr_count == 85) { HandProfit[10] *= 5; }
                    if (Upgr_count == 86) { MonkiProfit[10] *= 5; }
                    if (Upgr_count == 87) { HandProfit[11] *= 5; }
                    if (Upgr_count == 88) { MonkiProfit[11] *= 5; }
                    if (Upgr_count == 89) { BPS *= 5; }
                    if (Upgr_count == 90) { MonkiProfit[0] *= 5; MonkiProfit[1] *= 5; MonkiProfit[2] *= 5; MonkiProfit[3] *= 5; MonkiProfit[4] *= 5; MonkiProfit[5] *= 5; MonkiProfit[6] *= 5; MonkiProfit[7] *= 5; MonkiProfit[8] *= 5; MonkiProfit[9] *= 5; MonkiProfit[10] *= 5; MonkiProfit[11] *= 5; }
                    if (Upgr_count == 91) { BPC *= 5; }
                    if (Upgr_count == 92) { HandProfit[0] *= 5; HandProfit[1] *= 5; HandProfit[2] *= 5; HandProfit[3] *= 5; HandProfit[4] *= 5; HandProfit[5] *= 5; HandProfit[6] *= 5; HandProfit[7] *= 5; HandProfit[8] *= 5; HandProfit[9] *= 5; HandProfit[10] *= 5; HandProfit[11] *= 5; }










                    //Increases the value by one. MAKE SURE TO CHANGE THE NUM DEPENDING ON THE AMOUNTS OF UPGRADES U HAVE.

                    if (Upgr_count != (93))
                    {
                        Upgr_count = Upgr_count + 1;
                        //sets the new prices
                        Upgr_Price[0] = 1e8 * Math.Pow(10, (Upgr_count));
                        Upgr_Price[1] = 1e8 * Math.Pow(10, (Upgr_count + 1));
                        Upgr_Price[2] = 1e8 * Math.Pow(10, (Upgr_count + 2));
                        Upgr_Price[3] = 1e8 * Math.Pow(10, (Upgr_count + 3));
                    }

                    //refreshes after every click
                    var Data = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Upgr.ID");
                    Data.WriteLine(Upgr_count);
                    Data.Close();


                    // displays the text to the button
                    LblUpgrAmnt1.Text = "Upgrades " + Upgr_count.ToString();
                    LblUpgrDest1.Text = Upgr_Desc[Upgr_count].ToString();
                    LblupgrCost1.Text = "🍌" + ToSuffix(Upgr_Price[0], "0.00", false);

                    LblUpgrAmnt2.Text = "Upgrades " + (Upgr_count + 1).ToString();
                    LblUpgrDest2.Text = Upgr_Desc[Upgr_count + 1].ToString();
                    LblupgrCost2.Text = "🍌" + ToSuffix(Upgr_Price[1], "0.00", false);

                    LblUpgrAmnt3.Text = "Upgrades " + (Upgr_count + 2).ToString();
                    LblUpgrDest3.Text = Upgr_Desc[Upgr_count + 2].ToString();
                    LblupgrCost3.Text = "🍌" + ToSuffix(Upgr_Price[2], "0.00", false);

                    LblUpgrAmnt4.Text = "Upgrades " + (Upgr_count + 3).ToString();
                    LblUpgrDest4.Text = Upgr_Desc[Upgr_count + 3].ToString();
                    LblupgrCost4.Text = "🍌" + ToSuffix(Upgr_Price[3], "0.00", false);





                }
            }
            //if it's not true it would do this, which means this is when the form loads.
            else
            {
                try
                {

                    //reads the data for the current upgr amount you have
                    var c = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Upgr.ID");
                    Upgr_count = int.Parse(c.ReadLine());
                    c.Close();

                    //initialises the prices for the current upgrades whcich the person has
                    Upgr_Price[0] = 1e8 * Math.Pow(10, (Upgr_count));
                    Upgr_Price[1] = 1e8 * Math.Pow(10, (Upgr_count + 1));
                    Upgr_Price[2] = 1e8 * Math.Pow(10, (Upgr_count + 2));
                    Upgr_Price[3] = 1e8 * Math.Pow(10, (Upgr_count + 3));


                    //Populates labels with data.
                    LblUpgrAmnt1.Text = "Upgrades " + Upgr_count.ToString();
                    LblUpgrDest1.Text = Upgr_Desc[Upgr_count].ToString();
                    LblupgrCost1.Text = "🍌" + ToSuffix(Upgr_Price[0], "0.00", false);

                    LblUpgrAmnt2.Text = "Upgrades " + (Upgr_count + 1).ToString();
                    LblUpgrDest2.Text = Upgr_Desc[Upgr_count + 1].ToString();
                    LblupgrCost2.Text = "🍌" + ToSuffix(Upgr_Price[1], "0.00", false);

                    LblUpgrAmnt3.Text = "Upgrades " + (Upgr_count + 2).ToString();
                    LblUpgrDest3.Text = Upgr_Desc[Upgr_count + 2].ToString();
                    LblupgrCost3.Text = "🍌" + ToSuffix(Upgr_Price[2], "0.00", false);

                    LblUpgrAmnt4.Text = "Upgrades " + (Upgr_count + 3).ToString();
                    LblUpgrDest4.Text = Upgr_Desc[Upgr_count + 3].ToString();
                    LblupgrCost4.Text = "🍌" + ToSuffix(Upgr_Price[3], "0.00", false);
                }
                catch (System.IO.FileNotFoundException)
                {

                    // if you are a new user or your data gets deleted this will happen
                    var Data = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Upgr.ID");
                    Data.WriteLine("1");
                    Data.Close();

                    Upgr_count = 1;
                    //initialises the costs
                    Upgr_Price[0] = 1e8 * Math.Pow(2, (Upgr_count));
                    Upgr_Price[1] = 1e8 * Math.Pow(2, (Upgr_count + 1));
                    Upgr_Price[2] = 1e8 * Math.Pow(2, (Upgr_count + 2));
                    Upgr_Price[3] = 1e8 * Math.Pow(2, (Upgr_count + 3));

                    //populates the labels with data
                    LblUpgrAmnt1.Text = "Upgrades " + Upgr_count.ToString();
                    LblUpgrDest1.Text = Upgr_Desc[Upgr_count].ToString();
                    LblupgrCost1.Text = "🍌" + ToSuffix(Upgr_Price[0], "0.00", false);

                    LblUpgrAmnt2.Text = "Upgrades " + (Upgr_count + 1).ToString();
                    LblUpgrDest2.Text = Upgr_Desc[Upgr_count + 1].ToString();
                    LblupgrCost2.Text = "🍌" + ToSuffix(Upgr_Price[1], "0.00", false);

                    LblUpgrAmnt3.Text = "Upgrades " + (Upgr_count + 2).ToString();
                    LblUpgrDest3.Text = Upgr_Desc[Upgr_count + 2].ToString();
                    LblupgrCost3.Text = "🍌" + ToSuffix(Upgr_Price[2], "0.00", false);

                    LblUpgrAmnt4.Text = "Upgrades " + (Upgr_count + 3).ToString();
                    LblUpgrDest4.Text = Upgr_Desc[Upgr_count + 3].ToString();
                    LblupgrCost4.Text = "🍌" + ToSuffix(Upgr_Price[3], "0.00", false);

                    PBUpgrades.BackgroundImage = Properties.Resources.BananaIconSpr;



                }




            }

        }

        //this is for the prestige tab
        public void prestiges(bool i, bool o)
        {
            double Intelligencecalc;

            // this is for when the prestige button is pressed.
            if (i == true)
            {
                //prestige method here
                if (MessageBox.Show("This will remove all progress appart from Intelligence , ARE YOU SURE?", "Prestige!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Intelligence = Intelligence + (Bananas / 1e39);

                    prestige_no += 1;

                    var P = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Prestige.ID");
                    P.WriteLine(prestige_no.ToString());
                    P.WriteLine(Intelligence.ToString());
                    P.Close();


                    System.IO.Directory.CreateDirectory("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\");

                    var Data = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Main.ID");
                    Data.WriteLine("0");
                    Data.WriteLine("1");
                    Data.WriteLine("0");
                    Data.Close();

                    Bananas = 0;
                    BPC = 1;
                    BPS = 0;

                    var HA = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandAmount.ID");
                    HA.WriteLine("1");
                    HA.WriteLine("0");
                    HA.WriteLine("0");
                    HA.WriteLine("0");
                    HA.WriteLine("0");
                    HA.WriteLine("0");
                    HA.WriteLine("0");
                    HA.WriteLine("0");
                    HA.WriteLine("0");
                    HA.WriteLine("0");
                    HA.WriteLine("0");
                    HA.WriteLine("0");
                    HA.Close();

                    HandAmount[0] = 1;
                    HandAmount[1] = 0;
                    HandAmount[2] = 0;
                    HandAmount[3] = 0;
                    HandAmount[4] = 0;
                    HandAmount[5] = 0;
                    HandAmount[6] = 0;
                    HandAmount[7] = 0;
                    HandAmount[8] = 0;
                    HandAmount[9] = 0;
                    HandAmount[10] = 0;
                    HandAmount[11] = 0;




                    var HC = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandCost.ID");
                    HC.WriteLine("15");
                    HC.WriteLine("150");
                    HC.WriteLine("10000");
                    HC.WriteLine("250000");
                    HC.WriteLine("5000000");
                    HC.WriteLine("5e8");
                    HC.WriteLine("1e12");
                    HC.WriteLine("1e15");
                    HC.WriteLine("5e17");
                    HC.WriteLine("1e18");
                    HC.WriteLine("5e21");
                    HC.WriteLine("1e24");
                    HC.Close();

                    HandCost[0] = 15;
                    HandCost[1] = 150;
                    HandCost[2] = 10000;
                    HandCost[3] = 250000;
                    HandCost[4] = 5000000;
                    HandCost[5] = 5e8;
                    HandCost[6] = 1e12;
                    HandCost[7] = 1e15;
                    HandCost[8] = 5e17;
                    HandCost[9] = 1e18;
                    HandCost[10] = 5e21;
                    HandCost[11] = 1e24;



                    var HP = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandProfit.ID");
                    HP.WriteLine("1");
                    HP.WriteLine("10");
                    HP.WriteLine("500");
                    HP.WriteLine("10000");
                    HP.WriteLine("500000");
                    HP.WriteLine("2.5e7");
                    HP.WriteLine("1e9");
                    HP.WriteLine("5e11");
                    HP.WriteLine("2.5e13");
                    HP.WriteLine("1e15");
                    HP.WriteLine("2.5e20");
                    HP.WriteLine("1e22");
                    HP.Close();


                    HandProfit[0] = 1;
                    HandProfit[1] = 10;
                    HandProfit[2] = 500;
                    HandProfit[3] = 10000;
                    HandProfit[4] = 500000;
                    HandProfit[5] = 2.5e7;
                    HandProfit[6] = 1e9;
                    HandProfit[7] = 5e11;
                    HandProfit[8] = 2.5e13;
                    HandProfit[9] = 1e15;
                    HandProfit[10] = 2.5e20;
                    HandProfit[11] = 1e22;



                    var MA = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiAmount.ID");
                    MA.WriteLine("1");
                    MA.WriteLine("0");
                    MA.WriteLine("0");
                    MA.WriteLine("0");
                    MA.WriteLine("0");
                    MA.WriteLine("0");
                    MA.WriteLine("0");
                    MA.WriteLine("0");
                    MA.WriteLine("0");
                    MA.WriteLine("0");
                    MA.WriteLine("0");
                    MA.WriteLine("0");
                    MA.Close();

                    MonkiAmount[0] = 1;
                    MonkiAmount[1] = 0;
                    MonkiAmount[2] = 0;
                    MonkiAmount[3] = 0;
                    MonkiAmount[4] = 0;
                    MonkiAmount[5] = 0;
                    MonkiAmount[6] = 1;
                    MonkiAmount[7] = 0;
                    MonkiAmount[8] = 0;
                    MonkiAmount[9] = 0;
                    MonkiAmount[10] = 0;
                    MonkiAmount[11] = 0;

                    var MC = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiCost.ID");
                    MC.WriteLine("250");
                    MC.WriteLine("10000");
                    MC.WriteLine("2500000");
                    MC.WriteLine("50000000");
                    MC.WriteLine("1e9");
                    MC.WriteLine("5e10");
                    MC.WriteLine("1e12");
                    MC.WriteLine("7.5e14");
                    MC.WriteLine("2.5e17");
                    MC.WriteLine("2.5e20");
                    MC.WriteLine("1e22");
                    MC.WriteLine("1e27");
                    MC.Close();

                    MonkiCost[0] = 250;
                    MonkiCost[1] = 10000;
                    MonkiCost[2] = 2500000;
                    MonkiCost[3] = 50000000;
                    MonkiCost[4] = 1e9;
                    MonkiCost[5] = 5e10;
                    MonkiCost[6] = 1e12;
                    MonkiCost[7] = 7.5e14;
                    MonkiCost[8] = 2.5e17;
                    MonkiCost[9] = 2.5e20;
                    MonkiCost[10] = 1e22;
                    MonkiCost[11] = 1e27;


                    var MP = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiProfit.ID");
                    MP.WriteLine("5");
                    MP.WriteLine("100");
                    MP.WriteLine("10000");
                    MP.WriteLine("500000");
                    MP.WriteLine("50000000");
                    MP.WriteLine("1e9");
                    MP.WriteLine("7.5e10");
                    MP.WriteLine("1e12");
                    MP.WriteLine("1e15");
                    MP.WriteLine("1e17");
                    MP.WriteLine("1e19");
                    MP.WriteLine("1e21");
                    MP.Close();

                    MonkiProfit[0] = 5;
                    MonkiProfit[1] = 100;
                    MonkiProfit[2] = 10000;
                    MonkiProfit[3] = 500000;
                    MonkiProfit[4] = 5e7;
                    MonkiProfit[5] = 1e9;
                    MonkiProfit[6] = 7.5e10;
                    MonkiProfit[7] = 1e12;
                    MonkiProfit[8] = 1e15;
                    MonkiProfit[9] = 1e17;
                    MonkiProfit[10] = 1e19;
                    MonkiProfit[11] = 1e21;



                    var D = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Upgr.ID");
                    D.WriteLine("1");
                    D.Close();

                    Upgr_count = 1;

                    LblUpgrAmnt1.Text = "Upgrades " + Upgr_count.ToString();
                    LblUpgrDest1.Text = Upgr_Desc[Upgr_count].ToString();
                    LblupgrCost1.Text = "🍌" + ToSuffix(Upgr_Price[Upgr_count], "0.00", false);

                    LblUpgrAmnt2.Text = "Upgrades " + (Upgr_count + 1).ToString();
                    LblUpgrDest2.Text = Upgr_Desc[Upgr_count + 1].ToString();
                    LblupgrCost2.Text = "🍌" + ToSuffix(Upgr_Price[Upgr_count + 1], "0.00", false);

                    LblUpgrAmnt3.Text = "Upgrades " + (Upgr_count + 2).ToString();
                    LblUpgrDest3.Text = Upgr_Desc[Upgr_count + 2].ToString();
                    LblupgrCost3.Text = "🍌" + ToSuffix(Upgr_Price[Upgr_count + 2], "0.00", false);

                    LblUpgrAmnt4.Text = "Upgrades " + (Upgr_count + 3).ToString();
                    LblUpgrDest4.Text = Upgr_Desc[Upgr_count + 3].ToString();
                    LblupgrCost4.Text = "🍌" + ToSuffix(Upgr_Price[Upgr_count + 3], "0.00", false);







                    LblWoodenHandsOwned.Text = ToSuffix(HandAmount[0], "0.00", false);
                    LblWoodenHandsPrice.Text = "🍌" + ToSuffix(HandCost[0], "0.00", false);
                    LblWoodenHandProfit.Text = "+ " + ToSuffix(HandProfit[0], "0", false) + " BPC";

                    LblStoneHandsOwned.Text = ToSuffix(HandAmount[1], "0.00", false);
                    LblStoneHandPrice.Text = "🍌" + ToSuffix(HandCost[1], "0.00", false);
                    lblStoneHandProfit.Text = "+ " + ToSuffix(HandProfit[1], "0", false) + " BPC";

                    LblCoalHandsOwned.Text = ToSuffix(HandAmount[2], "0.00", false);
                    LblCoalHandCost.Text = "🍌" + ToSuffix(HandCost[2], "0.00", false);
                    LblCoalHandProfit.Text = "+ " + ToSuffix(HandProfit[2], "0", false) + " BPC";

                    LblIronHandAmount.Text = ToSuffix(HandAmount[3], "0.00", false);
                    LblIronHandCost.Text = "🍌" + ToSuffix(HandCost[3], "0.00", false);
                    LblIronHandProfit.Text = "+ " + ToSuffix(HandProfit[3], "0", false) + " BPC";

                    LblGoldHandsAmount.Text = ToSuffix(HandAmount[4], "0.00", false);
                    LblGoldHandCost.Text = "🍌" + ToSuffix(HandCost[4], "0.00", false);
                    LblGoldHandsProfit.Text = "+ " + ToSuffix(HandProfit[4], "0", false) + " BPC";

                    LblDiamondHandsAmount.Text = ToSuffix(HandAmount[5], "0.00", false);
                    LblDiamondHandPrice.Text = "🍌" + ToSuffix(HandCost[5], "0.00", false);
                    LblDiamondHandProfit.Text = "+ " + ToSuffix(HandProfit[5], "0", false) + " BPC";

                    LblEmeraldHandAmount.Text = ToSuffix(HandAmount[6], "0.00", false);
                    LblEmeraldHandsCost.Text = "🍌" + ToSuffix(HandCost[6], "0.00", false);
                    LblEmeraldHandsProfit.Text = "+ " + ToSuffix(HandProfit[6], "0", false) + " BPC";

                    LblRubyHandsAmount.Text = ToSuffix(HandAmount[7], "0.00", false);
                    LblRubyHandsCost.Text = "🍌" + ToSuffix(HandCost[7], "0.00", false);
                    LblRubyHandsProfit.Text = "+ " + ToSuffix(HandProfit[7], "0", false) + " BPC";

                    LblSaphireHandsAmount.Text = ToSuffix(HandAmount[8], "0.00", false);
                    LblSaphireHandsCost.Text = "🍌" + ToSuffix(HandCost[8], "0.00", false);
                    LblSaphireHandsProfit.Text = "+ " + ToSuffix(HandProfit[8], "0", false) + " BPC";

                    LblVoidHandsAmount.Text = ToSuffix(HandAmount[9], "0.00", false);
                    LblVoidHandCost.Text = "🍌" + ToSuffix(HandCost[9], "0.00", false);
                    LblVOidHandProfit.Text = "+ " + ToSuffix(HandProfit[9], "0", false) + " BPC";

                    LblRainbownitehandsAMount.Text = ToSuffix(HandAmount[10], "0.00", false);
                    LblRainbowniteHandsCost.Text = "🍌" + ToSuffix(HandCost[10], "0.00", false);
                    LblRainbowniteHandsProfit.Text = "+ " + ToSuffix(HandProfit[10], "0", false) + " BPC";

                    LblBlackStoneHandsAmount.Text = ToSuffix(HandAmount[11], "0.00", false);
                    LblBlackStoneHandsCost.Text = "🍌" + ToSuffix(HandCost[11], "0.00", false);
                    LblBlackStoneHandProfit.Text = "+ " + ToSuffix(HandProfit[11], "0", false) + " BPC";


                    // monkis Shop

                    LblMarmocetsAmount.Text = ToSuffix(MonkiAmount[0], "0.00", false);
                    LblMarmocetsCost.Text = "🍌" + ToSuffix(MonkiCost[0], "0.00", false);
                    LblMarmocetsProfit.Text = "+ " + ToSuffix(MonkiProfit[0], "0.00", false) + " BPS";

                    LblCapuchinAmount.Text = ToSuffix(MonkiAmount[1], "0.00", false);
                    LblCapuchinCost.Text = "🍌" + ToSuffix(MonkiCost[1], "0.00", false);
                    LblCapuchinProfit.Text = "+ " + ToSuffix(MonkiProfit[1], "0.00", false) + " BPS";

                    LblBonoboAmount.Text = ToSuffix(MonkiAmount[2], "0.00", false);
                    LblBononoCost.Text = "🍌" + ToSuffix(MonkiCost[2], "0.00", false);
                    LblBonoboProfit.Text = "+ " + ToSuffix(MonkiProfit[2], "0.00", false) + " BPS";

                    LblOrangutanAmount.Text = ToSuffix(MonkiAmount[3], "0.00", false);
                    LblOrangutanCost.Text = "🍌" + ToSuffix(MonkiCost[3], "0.00", false);
                    lblOrangutanProfit.Text = "+ " + ToSuffix(MonkiProfit[3], "0.00", false) + " BPS";

                    LblBaboonAmount.Text = ToSuffix(MonkiAmount[4], "0.00", false);
                    lblBaboonCost.Text = "🍌" + ToSuffix(MonkiCost[4], "0.00", false);
                    LblBaboonProfit.Text = "+ " + ToSuffix(MonkiProfit[4], "0.00", false) + " BPS";

                    LblChimpanzeeAmount.Text = ToSuffix(MonkiAmount[5], "0.00", false);
                    LblChimpanzeeCost.Text = "🍌" + ToSuffix(MonkiCost[5], "0.00", false);
                    LblChimpanzeeProfit.Text = "+ " + ToSuffix(MonkiProfit[5], "0.00", false) + " BPS";

                    LblMandrillAmount.Text = ToSuffix(MonkiAmount[6], "0.00", false);
                    LblMandrillCost.Text = "🍌" + ToSuffix(MonkiCost[6], "0.00", false);
                    LblMandrillProfit.Text = "+ " + ToSuffix(MonkiProfit[6], "0.00", false) + " BPS";

                    LblGeladaAmount.Text = ToSuffix(MonkiAmount[7], "0.00", false);
                    LblGeladaCost.Text = "🍌" + ToSuffix(MonkiCost[7], "0.00", false);
                    LblGeladaProfit.Text = "+ " + ToSuffix(MonkiProfit[7], "0.00", false) + " BPS";

                    LblGorillaAmount.Text = ToSuffix(MonkiAmount[8], "0.00", false);
                    LblGorillaCost.Text = "🍌" + ToSuffix(MonkiCost[8], "0.00", false);
                    LblGorillaProfit.Text = "+ " + ToSuffix(MonkiProfit[8], "0.00", false) + " BPS";

                    LblHomoHabilisAmount.Text = ToSuffix(MonkiAmount[9], "0.00", false);
                    LblHomoHabilisCost.Text = "🍌" + ToSuffix(MonkiCost[9], "0.00", false);
                    LblHomoHabilisProfit.Text = "+ " + ToSuffix(MonkiProfit[9], "0.00", false) + " BPS";

                    LblHomoErectusAmount.Text = ToSuffix(MonkiAmount[10], "0.00", false);
                    LblHomoErectusCost.Text = "🍌" + ToSuffix(MonkiCost[10], "0.00", false);
                    LblHomoErectusProfit.Text = "+ " + ToSuffix(MonkiProfit[10], "0.00", false) + " BPS";

                    LblHomoSapienAmount.Text = ToSuffix(MonkiAmount[11], "0.00", false);
                    LblHomoSapienCost.Text = "🍌" + ToSuffix(MonkiCost[11], "0.00", false);
                    LblHomoSapienProfit.Text = "+ " + ToSuffix(MonkiProfit[11], "0.00", false) + " BPS";

                    PnlPrestige.Visible = false;
                    FPnlMonkiHands.Visible = true;
                    PBMonkiShop.Visible = false;
                    PBUpgrades.Visible = false;
                    // hides all of the panels once you've prestiged

                    FPnlStoneHands.Visible = false;
                    FpnlCoal.Visible = false;
                    FPnlIronHands.Visible = false;
                    FPnlGoldHands.Visible = false;
                    FPnlDiamondHands.Visible = false;
                    FPnlEmeralndHands.Visible = false;
                    FpnlRubyHands.Visible = false;
                    FpnlSaphire.Visible = false;
                    FpnlVoid.Visible = false;
                    FpnlRainbownite.Visible = false;
                    FpnlBlackStoneHand.Visible = false;

                    FpnlCapuchin.Visible = false;
                    FPnlBonobo.Visible = false;
                    FpnlOrangutan.Visible = false;
                    FpnlBaboon.Visible = false;
                    FpnlChimpanzee.Visible = false;
                    FPnlMandrill.Visible = false;
                    FpnlGelada.Visible = false;
                    FpnlGorilla.Visible = false;
                    FpnlHomoHabilis.Visible = false;
                    FpnlHomoErectus.Visible = false;
                    FpnlHomoSapien.Visible = false;
                    //hides the presige button
                    BtnPrestigeNow.Enabled = false;

                }

                if (MessageBox.Show("Please restart to set the new multipliers! (this bug will be fixed soon)", "Post Prestige Data Reset", MessageBoxButtons.OK) == DialogResult.OK    )
                {
                    this.Close();

                }


                //refresh the lables here
                Intelligencecalc = Bananas / 1e39;
                LblIntelligence.Text = "📓" + ToSuffix(Intelligence, "0.00", false);
                LblCurrentPrestige.Text = "You current Prestige is : " + prestige_no.ToString();
                LblPrestigewithintel.Text = "You can prestige with " + ToSuffix(Intelligencecalc, "0.00", false) + " 📓";



            }
            //this is for when the form loads for the first time or it's refreshed can be put into refresh.
            else
            {
                // this if for new user
                if (o == true)
                {
                    try
                    {
                        //reads the data inteligence and prestiges
                        var c = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Prestige.ID");
                        prestige_no = int.Parse(c.ReadLine());
                        Intelligence = double.Parse(c.ReadLine());
                        c.Close();


                        Intelligencecalc = Bananas / 1e39;



                        LblIntelligence.Text = "📓" + ToSuffix(Intelligence, "0.00", false);
                        LblCurrentPrestige.Text = "You current Prestige is : " + prestige_no.ToString();
                        LblPrestigewithintel.Text = "You can prestige with " + ToSuffix(Intelligencecalc, "0.00", false) + " 📓";
                        if (prestige_no >= 1)
                        {
                            LblIntelligence.Visible = true;
                            BtnPrestige.Visible = true;
                        }


                    }
                    catch (System.IO.FileNotFoundException)
                    {
                        // if you are a new user or your data gets deleted this will happen
                        var Data = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Prestige.ID");
                        Data.WriteLine("0");
                        Data.WriteLine("0");
                        Data.Close();

                        Intelligence = 0;
                        prestige_no = 0;
                        Intelligencecalc = 0;


                        LblIntelligence.Text = "📓" + ToSuffix(Intelligence, "0.00", false);
                        LblCurrentPrestige.Text = "You current Prestige is : " + prestige_no.ToString();
                        LblPrestigewithintel.Text = "You can prestige with " + ToSuffix(Intelligencecalc, "0.00", false) + " 📓";
                    }
                }
                // this is for rereshing the counts and stuff.
                else
                {
                    var Data = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Prestige.ID");
                    Data.WriteLine(prestige_no);
                    Data.WriteLine(Intelligence);
                    Data.Close();

                    Intelligencecalc = Bananas / 1e39;
                    if (Bananas >= 1e39) { BtnPrestigeNow.Enabled = true; }


                    LblIntelligence.Text = "📓" + ToSuffix(Intelligence, "0.00", false);
                    LblCurrentPrestige.Text = "You current Prestige is : " + prestige_no.ToString();
                    LblPrestigewithintel.Text = "You can prestige with " + ToSuffix(Intelligencecalc, "0.00", false) + " 📓";
                }



            }

        }




        // number is the thing you want to convert to abbrviation, bool is the type of suffix you want, (true is big, false is small)
        public string ToSuffix(double number, string precision = "0.0", bool bigSuffix = false, string onedigitprecision = "0")
        {
            if (bigSuffix)
            {
                if (number >= 1e306)
                {
                    return ((number / 1e306).ToString(precision + " Uncentillion"));
                }
                if (number >= 1e303)
                {
                    return ((number / 1e303).ToString(precision + " Centillion"));
                }
                if (number >= 1e300)
                {
                    return ((number / 1e300).ToString(precision + " Novemonagintillion"));
                }
                if (number >= 1e297)
                {
                    return ((number / 1e297).ToString(precision + " Octononagintillion"));
                }
                if (number >= 1e294)
                {
                    return ((number / 1e294).ToString(precision + " Septenonagintillion"));
                }
                if (number >= 1e291)
                {
                    return ((number / 1e291).ToString(precision + " Senonagintillion"));
                }
                if (number >= 1e288)
                {
                    return ((number / 1e288).ToString(precision + " Quinnonagintillion"));
                }
                if (number >= 1e285)
                {
                    return ((number / 1e285).ToString(precision + " Trenonagintillion"));
                }
                if (number >= 1e282)
                {
                    return ((number / 1e282).ToString(precision + " Trenonagintillion"));
                }
                if (number >= 1e279)
                {
                    return ((number / 1e279).ToString(precision + " Duononagintillion"));
                }
                if (number >= 1e276)
                {
                    return ((number / 1e276).ToString(precision + " Unnonagintillion"));
                }
                if (number >= 1e273)
                {
                    return ((number / 1e273).ToString(precision + " Nonagintillion"));
                }
                if (number >= 1e270)
                {
                    return ((number / 1e270).ToString(precision + " Novemoctogintillion"));
                }
                if (number >= 1e267)
                {
                    return ((number / 1e267).ToString(precision + " Octooctogintillion"));
                }
                if (number >= 1e264)
                {
                    return ((number / 1e264).ToString(precision + " Septemoctogintillion"));
                }
                if (number >= 1e261)
                {
                    return ((number / 1e261).ToString(precision + " Sexoctogintillion"));
                }
                if (number >= 1e258)
                {
                    return ((number / 1e258).ToString(precision + " Quinoctogintillion"));
                }
                if (number >= 1e255)
                {
                    return ((number / 1e255).ToString(precision + " Quattuoroctogintillion"));
                }
                if (number >= 1e252)
                {
                    return ((number / 1e252).ToString(precision + " Treoctogintillion"));
                }
                if (number >= 1e249)
                {
                    return ((number / 1e249).ToString(precision + " Duooctogintillion"));
                }
                if (number >= 1e246)
                {
                    return ((number / 1e246).ToString(precision + " Unoctogintillion"));
                }
                if (number >= 1e243)
                {
                    return ((number / 1e243).ToString(precision + " Octogintillion"));
                }
                if (number >= 1e240)
                {
                    return ((number / 1e240).ToString(precision + " Novemseptuagintillion"));
                }
                if (number >= 1e237)
                {
                    return ((number / 1e237).ToString(precision + " Octoseptuagintillion"));
                }
                if (number >= 1e234)
                {
                    return ((number / 1e234).ToString(precision + " Septenseptuagintillion"));
                }
                if (number >= 1e231)
                {
                    return ((number / 1e231).ToString(precision + " Seseptuagintillion"));
                }
                if (number >= 1e228)
                {
                    return ((number / 1e228).ToString(precision + " Quinseptuagintillion"));
                }
                if (number >= 1e225)
                {
                    return ((number / 1e225).ToString(precision + " Quattuorseptuagintillion"));
                }
                if (number >= 1e222)
                {
                    return ((number / 1e222).ToString(precision + " Treseptuagintillion"));
                }
                if (number >= 1e219)
                {
                    return ((number / 1e219).ToString(precision + " Duoseptuagintillion"));
                }
                if (number >= 1e216)
                {
                    return ((number / 1e216).ToString(precision + " Unseptuagintillion"));
                }
                if (number >= 1e213)
                {
                    return ((number / 1e213).ToString(precision + " Septuagintillion"));
                }
                if (number >= 1e210)
                {
                    return ((number / 1e210).ToString(precision + " Novemsexagintillion"));
                }
                if (number >= 1e207)
                {
                    return ((number / 1e207).ToString(precision + " Octosexagintillion"));
                }
                if (number >= 1e204)
                {
                    return ((number / 1e204).ToString(precision + " Septensexagintillion"));
                }
                if (number >= 1e201)
                {
                    return ((number / 1e201).ToString(precision + " Sesexagintillion"));
                }
                if (number >= 1e198)
                {
                    return ((number / 1e198).ToString(precision + " Quinsexagintillion"));
                }
                if (number >= 1e195)
                {
                    return ((number / 1e195).ToString(precision + " Quattuorsexagintillion"));
                }
                if (number >= 1e192)
                {
                    return ((number / 1e192).ToString(precision + " Tresexagintillion"));
                }
                if (number >= 1e189)
                {
                    return ((number / 1e189).ToString(precision + " Duosexagintillion"));
                }
                if (number >= 1e186)
                {
                    return ((number / 1e186).ToString(precision + " Unsexagintillion"));
                }
                if (number >= 1e183)
                {
                    return ((number / 1e183).ToString(precision + " Sexagintillion"));
                }
                if (number >= 1e180)
                {
                    return ((number / 1e180).ToString(precision + " Novemquinquagintillion"));
                }
                if (number >= 1e177)
                {
                    return ((number / 1e177).ToString(precision + " Octoquinquagintillion"));
                }
                if (number >= 1e174)
                {
                    return ((number / 1e174).ToString(precision + " Septenquinquagintillion"));
                }
                if (number >= 1e171)
                {
                    return ((number / 1e171).ToString(precision + " Sesquinquagintillion"));
                }
                if (number >= 1e168)
                {
                    return ((number / 1e168).ToString(precision + " Quinquinquagintillion"));
                }
                if (number >= 1e165)
                {
                    return ((number / 1e165).ToString(precision + " Quattuorquinquagintillion"));
                }
                if (number >= 1e162)
                {
                    return ((number / 1e162).ToString(precision + " Tresquinquagintillion"));
                }
                if (number >= 1e159)
                {
                    return ((number / 1e159).ToString(precision + " Duoquinquagintillion"));
                }
                if (number >= 1e156)
                {
                    return ((number / 1e156).ToString(precision + " Unquinquagintillion"));
                }
                if (number >= 1e153)
                {
                    return ((number / 1e153).ToString(precision + " Quinquagintillion"));
                }
                if (number >= 1e150)
                {
                    return ((number / 1e150).ToString(precision + " Novemquadragintillion"));
                }
                if (number >= 1e147)
                {
                    return ((number / 1e147).ToString(precision + " Octoquadragintillion"));
                }
                if (number >= 1e144)
                {
                    return ((number / 1e144).ToString(precision + " Septenquadragintillion"));
                }
                if (number >= 1e141)
                {
                    return ((number / 1e141).ToString(precision + " Sesquadragintillion"));
                }
                if (number >= 1e138)
                {
                    return ((number / 1e138).ToString(precision + " Quinquadragintillion"));
                }
                if (number >= 1e135)
                {
                    return ((number / 1e135).ToString(precision + " Quattuorquadragintillion"));
                }
                if (number >= 1e132)
                {
                    return ((number / 1e132).ToString(precision + " Tresquadragintillion"));
                }
                if (number >= 1e129)
                {
                    return ((number / 1e129).ToString(precision + " Duoquadragintillion"));
                }
                if (number >= 1e126)
                {
                    return ((number / 1e126).ToString(precision + " Unquadragintillion"));
                }
                if (number >= 1e123)
                {
                    return ((number / 1e123).ToString(precision + " Quadragintillion"));
                }
                if (number >= 1e120)
                {
                    return ((number / 1e120).ToString(precision + " Novemtrigintillion"));
                }
                if (number >= 1e117)
                {
                    return ((number / 1e117).ToString(precision + " Octotrigintillion"));
                }
                if (number >= 1e114)
                {
                    return ((number / 1e114).ToString(precision + " Septentrigintillion"));
                }
                if (number >= 1e111)
                {
                    return ((number / 1e111).ToString(precision + " Sestrigintillion"));
                }
                if (number >= 1e108)
                {
                    return ((number / 1e108).ToString(precision + " Quintrigintillion"));
                }
                if (number >= 1e105)
                {
                    return ((number / 1e105).ToString(precision + " Quattuortrigintillion"));
                }
                if (number >= 1e102)
                {
                    return ((number / 1e102).ToString(precision + " Trestrigintillion"));
                }
                if (number >= 1e99)
                {
                    return ((number / 1e99).ToString(precision + " Duotrigintillion"));
                }
                if (number >= 1e96)
                {
                    return ((number / 1e96).ToString(precision + " Untrigintillion"));
                }
                if (number >= 1e93)
                {
                    return ((number / 1e93).ToString(precision + " Trigintillion"));
                }
                if (number >= 1e90)
                {
                    return ((number / 1e90).ToString(precision + " Novemvigintillion"));
                }
                if (number >= 1e87)
                {
                    return ((number / 1e87).ToString(precision + " Octovigintilion"));
                }
                if (number >= 1e84)
                {
                    return ((number / 1e84).ToString(precision + " Septemvigintillion"));
                }
                if (number >= 1e81)
                {
                    return ((number / 1e81).ToString(precision + " Sesvigintillion"));
                }
                if (number >= 1e78)
                {
                    return ((number / 1e78).ToString(precision + " Quinvigintillion"));
                }
                if (number >= 1e75)
                {
                    return ((number / 1e75).ToString(precision + " Quattuorvigintillion	"));
                }
                if (number >= 1e72)
                {
                    return ((number / 1e72).ToString(precision + " Tresvigintillion"));
                }
                if (number >= 1e69)
                {
                    return ((number / 1e69).ToString(precision + " Duovigintillion"));
                }
                if (number >= 1e66)
                {
                    return ((number / 1e66).ToString(precision + " Unvigintillion"));
                }
                if (number >= 1e63)
                {
                    return ((number / 1e63).ToString(precision + " Vigintillion"));
                }
                if (number >= 1e60)
                {
                    return ((number / 1e60).ToString(precision + " Novemdecillion"));
                }
                if (number >= 1e57)
                {
                    return ((number / 1e57).ToString(precision + " Octodecillion"));
                }
                if (number >= 1e54)
                {
                    return ((number / 1e54).ToString(precision + " Septendecillion"));
                }
                if (number >= 1e51)
                {
                    return ((number / 1e51).ToString(precision + " Sedecillion"));
                }
                if (number >= 1e48)
                {
                    return ((number / 1e48).ToString(precision + " Quindecillion"));
                }
                if (number >= 1e45)
                {
                    return ((number / 1e45).ToString(precision + " Quattuordecillion"));
                }
                if (number >= 1e42)
                {
                    return ((number / 1e42).ToString(precision + " Tredecillion"));
                }
                if (number >= 1e39)
                {
                    return ((number / 1e39).ToString(precision + " Duodecillion"));
                }
                if (number >= 1e36)
                {
                    return ((number / 1e36).ToString(precision + " Undecillion"));
                }
                if (number >= 1e33)
                {
                    return ((number / 1e33).ToString(precision + " Decillion"));
                }
                if (number >= 1e30)
                {
                    return ((number / 1e30).ToString(precision + " Nonillion"));
                }
                if (number >= 1e27)
                {
                    return ((number / 1e27).ToString(precision + " Octillion"));
                }
                if (number >= 1e24)
                {
                    return ((number / 1e24).ToString(precision + " Septillion"));
                }
                if (number >= 1e21)
                {
                    return ((number / 1e21).ToString(precision + " Sextillion"));
                }
                if (number >= 1e18)
                {
                    return ((number / 1e18).ToString(precision + " Quintillion"));
                }
                if (number >= 1e15)
                {
                    return ((number / 1e15).ToString(precision + " Quadrillion"));
                }
                if (number >= 1e12)
                {
                    return ((number / 1e12).ToString(precision + " Trillion"));
                }
                if (number >= 1e9)
                {
                    return ((number / 1e9).ToString(precision + " Billion"));
                }
                if (number >= 1e6)
                {
                    return ((number / 1e6).ToString(precision + " Million"));
                }
                if (number >= 1e3)
                {
                    return ((number / 1e3).ToString(precision + " Thousand"));
                }
                else
                {
                    return (number.ToString(onedigitprecision));
                }
            }
            else
            {
                if (number >= 1e306)
                {
                    return ((number / 1e306).ToString(precision + " UNCENT"));
                }
                if (number >= 1e303)
                {
                    return ((number / 1e303).ToString(precision + " CENT"));
                }
                if (number >= 1e300)
                {
                    return ((number / 1e300).ToString(precision + " NONONGNTL"));
                }
                if (number >= 1e297)
                {
                    return ((number / 1e297).ToString(precision + " OTNONGNTL"));
                }
                if (number >= 1e294)
                {
                    return ((number / 1e294).ToString(precision + " SPNONGNTL"));
                }
                if (number >= 1e291)
                {
                    return ((number / 1e291).ToString(precision + " SXNONGNTL"));
                }
                if (number >= 1e288)
                {
                    return ((number / 1e288).ToString(precision + " QNNONGNTL"));
                }
                if (number >= 1e285)
                {
                    return ((number / 1e285).ToString(precision + " QTNONGNTL"));
                }
                if (number >= 1e282)
                {
                    return ((number / 1e282).ToString(precision + " TNONGNTL"));
                }
                if (number >= 1e279)
                {
                    return ((number / 1e279).ToString(precision + " DNONGNTL"));
                }
                if (number >= 1e276)
                {
                    return ((number / 1e276).ToString(precision + " UNONGNTL"));
                }
                if (number >= 1e273)
                {
                    return ((number / 1e273).ToString(precision + " NONGNTL"));
                }
                if (number >= 1e270)
                {
                    return ((number / 1e270).ToString(precision + " NVOTGNTL"));
                }
                if (number >= 1e267)
                {
                    return ((number / 1e267).ToString(precision + " OTOTGNTL"));
                }
                if (number >= 1e264)
                {
                    return ((number / 1e264).ToString(precision + " SPOTGNTL"));
                }
                if (number >= 1e261)
                {
                    return ((number / 1e261).ToString(precision + " SXOTGNTL"));
                }
                if (number >= 1e258)
                {
                    return ((number / 1e258).ToString(precision + " QNOTGNTL"));
                }
                if (number >= 1e255)
                {
                    return ((number / 1e255).ToString(precision + " QTOTGNTL"));
                }
                if (number >= 1e252)
                {
                    return ((number / 1e252).ToString(precision + " TOTGNTL"));
                }
                if (number >= 1e249)
                {
                    return ((number / 1e249).ToString(precision + " DOTGNTL"));
                }
                if (number >= 1e246)
                {
                    return ((number / 1e246).ToString(precision + " UOTGNTL"));
                }
                if (number >= 1e243)
                {
                    return ((number / 1e243).ToString(precision + " OTGNTL"));
                }
                if (number >= 1e240)
                {
                    return ((number / 1e240).ToString(precision + " NVSPTGNTL"));
                }
                if (number >= 1e237)
                {
                    return ((number / 1e237).ToString(precision + " OSPTGNTL"));
                }
                if (number >= 1e234)
                {
                    return ((number / 1e234).ToString(precision + " SPSPTGNTL"));
                }
                if (number >= 1e231)
                {
                    return ((number / 1e231).ToString(precision + " SXSPTGNTL"));
                }
                if (number >= 1e228)
                {
                    return ((number / 1e228).ToString(precision + " QNSPTGNTL"));
                }
                if (number >= 1e225)
                {
                    return ((number / 1e225).ToString(precision + " QTSPTGNTL"));
                }
                if (number >= 1e222)
                {
                    return ((number / 1e222).ToString(precision + " TSPTGNTL"));
                }
                if (number >= 1e219)
                {
                    return ((number / 1e219).ToString(precision + " DSPTGNTL"));
                }
                if (number >= 1e216)
                {
                    return ((number / 1e216).ToString(precision + " USPTGNTL"));
                }
                if (number >= 1e213)
                {
                    return ((number / 1e213).ToString(precision + " SPTGNTL"));
                }
                if (number >= 1e210)
                {
                    return ((number / 1e210).ToString(precision + " NVSXGNTL"));
                }
                if (number >= 1e207)
                {
                    return ((number / 1e207).ToString(precision + " OSXGNTL"));
                }
                if (number >= 1e204)
                {
                    return ((number / 1e204).ToString(precision + " SPSXGNTL"));
                }
                if (number >= 1e201)
                {
                    return ((number / 1e201).ToString(precision + " SXSXGNTL"));
                }
                if (number >= 1e198)
                {
                    return ((number / 1e198).ToString(precision + " QNSXGNTL"));
                }
                if (number >= 1e195)
                {
                    return ((number / 1e195).ToString(precision + " QTSXGNTL"));
                }
                if (number >= 1e192)
                {
                    return ((number / 1e192).ToString(precision + " TSXGNTL"));
                }
                if (number >= 1e189)
                {
                    return ((number / 1e189).ToString(precision + " DSXGNTL"));
                }
                if (number >= 1e186)
                {
                    return ((number / 1e186).ToString(precision + " USXGNTL"));
                }
                if (number >= 1e183)
                {
                    return ((number / 1e183).ToString(precision + " SXGNTL"));
                }
                if (number >= 1e180)
                {
                    return ((number / 1e180).ToString(precision + " NQQGNT"));
                }
                if (number >= 1e177)
                {
                    return ((number / 1e177).ToString(precision + " OQQGNT"));
                }
                if (number >= 1e174)
                {
                    return ((number / 1e174).ToString(precision + " SpQGNT"));
                }
                if (number >= 1e171)
                {
                    return ((number / 1e171).ToString(precision + " sxQGNT"));
                }
                if (number >= 1e168)
                {
                    return ((number / 1e168).ToString(precision + " QnQGNT"));
                }
                if (number >= 1e165)
                {
                    return ((number / 1e165).ToString(precision + " qdQGNT"));
                }
                if (number >= 1e162)
                {
                    return ((number / 1e162).ToString(precision + " tQGNT"));
                }
                if (number >= 1e159)
                {
                    return ((number / 1e159).ToString(precision + " dQGNT"));
                }
                if (number >= 1e156)
                {
                    return ((number / 1e156).ToString(precision + " uQGNT"));
                }
                if (number >= 1e153)
                {
                    return ((number / 1e153).ToString(precision + " qQGNT"));
                }
                if (number >= 1e150)
                {
                    return ((number / 1e150).ToString(precision + " NQDDr"));
                }
                if (number >= 1e147)
                {
                    return ((number / 1e147).ToString(precision + " OQDDr"));
                }
                if (number >= 1e144)
                {
                    return ((number / 1e144).ToString(precision + " SpQDR"));
                }
                if (number >= 1e141)
                {
                    return ((number / 1e141).ToString(precision + " sxQDR"));
                }
                if (number >= 1e138)
                {
                    return ((number / 1e138).ToString(precision + " QnQDR"));
                }
                if (number >= 1e135)
                {
                    return ((number / 1e135).ToString(precision + " qdQDR"));
                }
                if (number >= 1e132)
                {
                    return ((number / 1e132).ToString(precision + " tQDR"));
                }
                if (number >= 1e129)
                {
                    return ((number / 1e129).ToString(precision + " dQDR"));
                }
                if (number >= 1e126)
                {
                    return ((number / 1e126).ToString(precision + " uQDR"));
                }
                if (number >= 1e123)
                {
                    return ((number / 1e123).ToString(precision + " QdDR"));
                }
                if (number >= 1e120)
                {
                    return ((number / 1e120).ToString(precision + " NoTG"));
                }
                if (number >= 1e117)
                {
                    return ((number / 1e117).ToString(precision + " OcTG"));
                }
                if (number >= 1e114)
                {
                    return ((number / 1e114).ToString(precision + " SpTG"));
                }
                if (number >= 1e111)
                {
                    return ((number / 1e111).ToString(precision + " ssTG"));
                }
                if (number >= 1e108)
                {
                    return ((number / 1e108).ToString(precision + " QnTG"));
                }
                if (number >= 1e105)
                {
                    return ((number / 1e105).ToString(precision + " qtTG"));
                }
                if (number >= 1e102)
                {
                    return ((number / 1e102).ToString(precision + " tsTG"));
                }
                if (number >= 1e99)
                {
                    return ((number / 1e99).ToString(precision + " DTG"));
                }
                if (number >= 1e96)
                {
                    return ((number / 1e96).ToString(precision + " UTG"));
                }
                if (number >= 1e93)
                {
                    return ((number / 1e93).ToString(precision + " TGN"));
                }
                if (number >= 1e90)
                {
                    return ((number / 1e90).ToString(precision + " NVG"));
                }
                if (number >= 1e87)
                {
                    return ((number / 1e87).ToString(precision + " OVG"));
                }
                if (number >= 1e84)
                {
                    return ((number / 1e84).ToString(precision + " SPG"));
                }
                if (number >= 1e81)
                {
                    return ((number / 1e81).ToString(precision + " QnV"));
                }
                if (number >= 1e78)
                {
                    return ((number / 1e78).ToString(precision + " QnV"));
                }
                if (number >= 1e75)
                {
                    return ((number / 1e75).ToString(precision + " qtV"));
                }
                if (number >= 1e72)
                {
                    return ((number / 1e72).ToString(precision + " TVg"));
                }
                if (number >= 1e69)
                {
                    return ((number / 1e69).ToString(precision + " DVg"));
                }
                if (number >= 1e66)
                {
                    return ((number / 1e66).ToString(precision + " UVg"));
                }
                if (number >= 1e63)
                {
                    return ((number / 1e63).ToString(precision + " Vgn"));
                }
                if (number >= 1e60)
                {
                    return ((number / 1e60).ToString(precision + " NvD"));
                }
                if (number >= 1e57)
                {
                    return ((number / 1e57).ToString(precision + " OcD"));
                }
                if (number >= 1e54)
                {
                    return ((number / 1e54).ToString(precision + " SpD"));
                }
                if (number >= 1e51)
                {
                    return ((number / 1e51).ToString(precision + " sxD"));
                }
                if (number >= 1e48)
                {
                    return ((number / 1e48).ToString(precision + " QnD"));
                }
                if (number >= 1e45)
                {
                    return ((number / 1e45).ToString(precision + " qdD"));
                }
                if (number >= 1e42)
                {
                    return ((number / 1e42).ToString(precision + " tdD"));
                }
                if (number >= 1e39)
                {
                    return ((number / 1e39).ToString(precision + " DD"));
                }
                if (number >= 1e36)
                {
                    return ((number / 1e36).ToString(precision + " Ud"));
                }
                if (number >= 1e33)
                {
                    return ((number / 1e33).ToString(precision + " De"));
                }
                if (number >= 1e30)
                {
                    return ((number / 1e30).ToString(precision + "N"));
                }
                if (number >= 1e27)
                {
                    return ((number / 1e27).ToString(precision + "O"));
                }
                if (number >= 1e24)
                {
                    return ((number / 1e24).ToString(precision + "Sp"));
                }
                if (number >= 1e21)
                {
                    return ((number / 1e21).ToString(precision + "Sx"));
                }
                if (number >= 1e18)
                {
                    return ((number / 1e18).ToString(precision + "Qn"));
                }
                if (number >= 1e15)
                {
                    return ((number / 1e15).ToString(precision + "Qd"));
                }
                if (number >= 1e12)
                {
                    return ((number / 1e12).ToString(precision + "T"));
                }
                if (number >= 1e9)
                {
                    return ((number / 1e9).ToString(precision + "B"));
                }
                if (number >= 1e6)
                {
                    return ((number / 1e6).ToString(precision + "M"));
                }
                if (number >= 1e3)
                {
                    return ((number / 1e3).ToString(precision + "K"));
                }
                else
                {
                    return (number.ToString(onedigitprecision));
                }
            }
        }
    
   


        



        public string current_user;

        private void BananaClicker_Load(object sender, EventArgs e)
        {


            // loads all of the data
            try
            {



                var CU = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\" + "Current_User.ID");
                current_user = CU.ReadLine();
                CU.Close();


                System.IO.Directory.CreateDirectory("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\");




                var Data = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Main.ID");
                Bananas = double.Parse(Data.ReadLine());
                BPC = double.Parse(Data.ReadLine());
                BPS = double.Parse(Data.ReadLine());
                Data.Close();

                IdleCash(false, BPS);


                var HA = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandAmount.ID");
                HandAmount[0] = int.Parse(HA.ReadLine());
                HandAmount[1] = int.Parse(HA.ReadLine());
                HandAmount[2] = int.Parse(HA.ReadLine());
                HandAmount[3] = int.Parse(HA.ReadLine());
                HandAmount[4] = int.Parse(HA.ReadLine());
                HandAmount[5] = int.Parse(HA.ReadLine());
                HandAmount[6] = int.Parse(HA.ReadLine());
                HandAmount[7] = int.Parse(HA.ReadLine());
                HandAmount[8] = int.Parse(HA.ReadLine());
                HandAmount[9] = int.Parse(HA.ReadLine());
                HandAmount[10] = int.Parse(HA.ReadLine());
                HandAmount[11] = int.Parse(HA.ReadLine());
                HA.Close();


                var HC = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandCost.ID");
                HandCost[0] = double.Parse(HC.ReadLine());
                HandCost[1] = double.Parse(HC.ReadLine());
                HandCost[2] = double.Parse(HC.ReadLine());
                HandCost[3] = double.Parse(HC.ReadLine());
                HandCost[4] = double.Parse(HC.ReadLine());
                HandCost[5] = double.Parse(HC.ReadLine());
                HandCost[6] = double.Parse(HC.ReadLine());
                HandCost[7] = double.Parse(HC.ReadLine());
                HandCost[8] = double.Parse(HC.ReadLine());
                HandCost[9] = double.Parse(HC.ReadLine());
                HandCost[10] = double.Parse(HC.ReadLine());
                HandCost[11] = double.Parse(HC.ReadLine());
                HC.Close();

                var HP = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandProfit.ID");
                HandProfit[0] = double.Parse(HP.ReadLine());
                HandProfit[1] = double.Parse(HP.ReadLine());
                HandProfit[2] = double.Parse(HP.ReadLine());
                HandProfit[3] = double.Parse(HP.ReadLine());
                HandProfit[4] = double.Parse(HP.ReadLine());
                HandProfit[5] = double.Parse(HP.ReadLine());
                HandProfit[6] = double.Parse(HP.ReadLine());
                HandProfit[7] = double.Parse(HP.ReadLine());
                HandProfit[8] = double.Parse(HP.ReadLine());
                HandProfit[9] = double.Parse(HP.ReadLine());
                HandProfit[10] = double.Parse(HP.ReadLine());
                HandProfit[11] = double.Parse(HP.ReadLine());
                HP.Close();


                var MA = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiAmount.ID");
                MonkiAmount[0] = int.Parse(MA.ReadLine());
                MonkiAmount[1] = int.Parse(MA.ReadLine());
                MonkiAmount[2] = int.Parse(MA.ReadLine());
                MonkiAmount[3] = int.Parse(MA.ReadLine());
                MonkiAmount[4] = int.Parse(MA.ReadLine());
                MonkiAmount[5] = int.Parse(MA.ReadLine());
                MonkiAmount[6] = int.Parse(MA.ReadLine());
                MonkiAmount[7] = int.Parse(MA.ReadLine());
                MonkiAmount[8] = int.Parse(MA.ReadLine());
                MonkiAmount[9] = int.Parse(MA.ReadLine());
                MonkiAmount[10] = int.Parse(MA.ReadLine());
                MonkiAmount[11] = int.Parse(MA.ReadLine());
                MA.Close();


                var MC = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiCost.ID");
                MonkiCost[0] = double.Parse(MC.ReadLine());
                MonkiCost[1] = double.Parse(MC.ReadLine());
                MonkiCost[2] = double.Parse(MC.ReadLine());
                MonkiCost[3] = double.Parse(MC.ReadLine());
                MonkiCost[4] = double.Parse(MC.ReadLine());
                MonkiCost[5] = double.Parse(MC.ReadLine());
                MonkiCost[6] = double.Parse(MC.ReadLine());
                MonkiCost[7] = double.Parse(MC.ReadLine());
                MonkiCost[8] = double.Parse(MC.ReadLine());
                MonkiCost[9] = double.Parse(MC.ReadLine());
                MonkiCost[10] = double.Parse(MC.ReadLine());
                MonkiCost[11] = double.Parse(MC.ReadLine());
                MC.Close();


                var MP = new System.IO.StreamReader("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiProfit.ID");
                MonkiProfit[0] = double.Parse(MP.ReadLine());
                MonkiProfit[1] = double.Parse(MP.ReadLine());
                MonkiProfit[2] = double.Parse(MP.ReadLine());
                MonkiProfit[3] = double.Parse(MP.ReadLine());
                MonkiProfit[4] = double.Parse(MP.ReadLine());
                MonkiProfit[5] = double.Parse(MP.ReadLine());
                MonkiProfit[6] = double.Parse(MP.ReadLine());
                MonkiProfit[7] = double.Parse(MP.ReadLine());
                MonkiProfit[8] = double.Parse(MP.ReadLine());
                MonkiProfit[9] = double.Parse(MP.ReadLine());
                MonkiProfit[10] = double.Parse(MP.ReadLine());
                MonkiProfit[11] = double.Parse(MP.ReadLine());
                MP.Close();





            }
            catch (System.IO.FileNotFoundException)
            {


                System.IO.Directory.CreateDirectory("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\");

                var Data = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Main.ID");
                Data.WriteLine("0");
                Data.WriteLine("1");
                Data.WriteLine("0");
                Data.Close();

                Bananas = 0;
                BPC = 1;
                BPS = 0;

                var HA = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandAmount.ID");
                HA.WriteLine("1");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.Close();

                HandAmount[0] = 1;
                HandAmount[1] = 0;
                HandAmount[2] = 0;
                HandAmount[3] = 0;
                HandAmount[4] = 0;
                HandAmount[5] = 0;
                HandAmount[6] = 0;
                HandAmount[7] = 0;
                HandAmount[8] = 0;
                HandAmount[9] = 0;
                HandAmount[10] = 0;
                HandAmount[11] = 0;




                var HC = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandCost.ID");
                HC.WriteLine("15");
                HC.WriteLine("150");
                HC.WriteLine("10000");
                HC.WriteLine("250000");
                HC.WriteLine("5000000");
                HC.WriteLine("5e8");
                HC.WriteLine("1e12");
                HC.WriteLine("1e15");
                HC.WriteLine("5e17");
                HC.WriteLine("1e18");
                HC.WriteLine("5e21");
                HC.WriteLine("1e24");
                HC.Close();

                HandCost[0] = 15;
                HandCost[1] = 150;
                HandCost[2] = 10000;
                HandCost[3] = 250000;
                HandCost[4] = 5000000;
                HandCost[5] = 5e8;
                HandCost[6] = 1e12;
                HandCost[7] = 1e15;
                HandCost[8] = 5e17;
                HandCost[9] = 1e18;
                HandCost[10] = 5e21;
                HandCost[11] = 1e24;



                var HP = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandProfit.ID");
                HP.WriteLine("1");
                HP.WriteLine("10");
                HP.WriteLine("500");
                HP.WriteLine("10000");
                HP.WriteLine("500000");
                HP.WriteLine("2.5e7");
                HP.WriteLine("1e9");
                HP.WriteLine("5e11");
                HP.WriteLine("2.5e13");
                HP.WriteLine("1e15");
                HP.WriteLine("2.5e20");
                HP.WriteLine("1e22");
                HP.Close();


                HandProfit[0] = 1;
                HandProfit[1] = 10;
                HandProfit[2] = 500;
                HandProfit[3] = 10000;
                HandProfit[4] = 500000;
                HandProfit[5] = 2.5e7;
                HandProfit[6] = 1e9;
                HandProfit[7] = 5e11;
                HandProfit[8] = 2.5e13;
                HandProfit[9] = 1e15;
                HandProfit[10] = 2.5e20;
                HandProfit[11] = 1e22;



                var MA = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiAmount.ID");
                MA.WriteLine("1");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.Close();

                MonkiAmount[0] = 1;
                MonkiAmount[1] = 0;
                MonkiAmount[2] = 0;
                MonkiAmount[3] = 0;
                MonkiAmount[4] = 0;
                MonkiAmount[5] = 0;
                MonkiAmount[6] = 1;
                MonkiAmount[7] = 0;
                MonkiAmount[8] = 0;
                MonkiAmount[9] = 0;
                MonkiAmount[10] = 0;
                MonkiAmount[11] = 0;

                var MC = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiCost.ID");
                MC.WriteLine("250");
                MC.WriteLine("10000");
                MC.WriteLine("2500000");
                MC.WriteLine("50000000");
                MC.WriteLine("1e9");
                MC.WriteLine("5e10");
                MC.WriteLine("1e12");
                MC.WriteLine("7.5e14");
                MC.WriteLine("2.5e17");
                MC.WriteLine("2.5e20");
                MC.WriteLine("1e22");
                MC.WriteLine("1e27");
                MC.Close();

                MonkiCost[0] = 250;
                MonkiCost[1] = 10000;
                MonkiCost[2] = 2500000;
                MonkiCost[3] = 50000000;
                MonkiCost[4] = 1e9;
                MonkiCost[5] = 5e10;
                MonkiCost[6] = 1e12;
                MonkiCost[7] = 7.5e14;
                MonkiCost[8] = 2.5e17;
                MonkiCost[9] = 2.5e20;
                MonkiCost[10] = 1e22;
                MonkiCost[11] = 1e27;

                var MP = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiProfit.ID");
                MP.WriteLine("5");
                MP.WriteLine("100");
                MP.WriteLine("10000");
                MP.WriteLine("500000");
                MP.WriteLine("50000000");
                MP.WriteLine("1e9");
                MP.WriteLine("7.5e10");
                MP.WriteLine("1e12");
                MP.WriteLine("1e15");
                MP.WriteLine("1e17");
                MP.WriteLine("1e19");
                MP.WriteLine("1e21");
                MP.Close();

                MonkiProfit[0] = 5;
                MonkiProfit[1] = 100;
                MonkiProfit[2] = 10000;
                MonkiProfit[3] = 500000;
                MonkiProfit[4] = 5e7;
                MonkiProfit[5] = 1e9;
                MonkiProfit[6] = 7.5e10;
                MonkiProfit[7] = 1e12;
                MonkiProfit[8] = 1e15;
                MonkiProfit[9] = 1e17;
                MonkiProfit[10] = 1e19;
                MonkiProfit[11] = 1e21;


                Playtime(true);




            }


            //for hand profit
            HProfit[0] = HandProfit[0] * (1 + (Intelligence * Prestige_Multi));
            HProfit[1] = HandProfit[1] * (1 + (Intelligence * Prestige_Multi));
            HProfit[2] = HandProfit[2] * (1 + (Intelligence * Prestige_Multi));
            HProfit[3] = HandProfit[3] * (1 + (Intelligence * Prestige_Multi));
            HProfit[4] = HandProfit[4] * (1 + (Intelligence * Prestige_Multi));
            HProfit[5] = HandProfit[5] * (1 + (Intelligence * Prestige_Multi));
            HProfit[6] = HandProfit[6] * (1 + (Intelligence * Prestige_Multi));
            HProfit[7] = HandProfit[7] * (1 + (Intelligence * Prestige_Multi));
            HProfit[8] = HandProfit[8] * (1 + (Intelligence * Prestige_Multi));
            HProfit[9] = HandProfit[9] * (1 + (Intelligence * Prestige_Multi));
            HProfit[10] = HandProfit[10] * (1 + (Intelligence * Prestige_Multi));
            HProfit[11] = HandProfit[11] * (1 + (Intelligence * Prestige_Multi));

            // for monkis
            MProfit[0] = MonkiProfit[0] * (1 + (Intelligence * Prestige_Multi));
            MProfit[1] = MonkiProfit[1] * (1 + (Intelligence * Prestige_Multi));
            MProfit[2] = MonkiProfit[2] * (1 + (Intelligence * Prestige_Multi));
            MProfit[3] = MonkiProfit[3] * (1 + (Intelligence * Prestige_Multi));
            MProfit[4] = MonkiProfit[4] * (1 + (Intelligence * Prestige_Multi));
            MProfit[5] = MonkiProfit[5] * (1 + (Intelligence * Prestige_Multi));
            MProfit[6] = MonkiProfit[6] * (1 + (Intelligence * Prestige_Multi));
            MProfit[7] = MonkiProfit[7] * (1 + (Intelligence * Prestige_Multi));
            MProfit[8] = MonkiProfit[8] * (1 + (Intelligence * Prestige_Multi));
            MProfit[9] = MonkiProfit[9] * (1 + (Intelligence * Prestige_Multi));
            MProfit[10] = MonkiProfit[10] * (1 + (Intelligence * Prestige_Multi));
            MProfit[11] = MonkiProfit[11] * (1 + (Intelligence * Prestige_Multi));


            LblWoodenHandsOwned.Text = ToSuffix(HandAmount[0], "0.00", false);
            LblWoodenHandsPrice.Text = "🍌" + ToSuffix(HandCost[0], "0.00", false);
            LblWoodenHandProfit.Text = "+ " + ToSuffix(HProfit[0], "0", false) + " BPC";

            LblStoneHandsOwned.Text = ToSuffix(HandAmount[1], "0.00", false);
            LblStoneHandPrice.Text = "🍌" + ToSuffix(HandCost[1], "0.00", false);
            lblStoneHandProfit.Text = "+ " + ToSuffix(HProfit[1], "0", false) + " BPC";

            LblCoalHandsOwned.Text = ToSuffix(HandAmount[2], "0.00", false);
            LblCoalHandCost.Text = "🍌" + ToSuffix(HandCost[2], "0.00", false);
            LblCoalHandProfit.Text = "+ " + ToSuffix(HProfit[2], "0", false) + " BPC";

            LblIronHandAmount.Text = ToSuffix(HandAmount[3], "0.00", false);
            LblIronHandCost.Text = "🍌" + ToSuffix(HandCost[3], "0.00", false);
            LblIronHandProfit.Text = "+ " + ToSuffix(HProfit[3], "0", false) + " BPC";

            LblGoldHandsAmount.Text = ToSuffix(HandAmount[4], "0.00", false);
            LblGoldHandCost.Text = "🍌" + ToSuffix(HandCost[4], "0.00", false);
            LblGoldHandsProfit.Text = "+ " + ToSuffix(HProfit[4], "0", false) + " BPC";

            LblDiamondHandsAmount.Text = ToSuffix(HandAmount[5], "0.00", false);
            LblDiamondHandPrice.Text = "🍌" + ToSuffix(HandCost[5], "0.00", false);
            LblDiamondHandProfit.Text = "+ " + ToSuffix(HProfit[5], "0", false) + " BPC";

            LblEmeraldHandAmount.Text = ToSuffix(HandAmount[6], "0.00", false);
            LblEmeraldHandsCost.Text = "🍌" + ToSuffix(HandCost[6], "0.00", false);
            LblEmeraldHandsProfit.Text = "+ " + ToSuffix(HProfit[6], "0", false) + " BPC";

            LblRubyHandsAmount.Text = ToSuffix(HandAmount[7], "0.00", false);
            LblRubyHandsCost.Text = "🍌" + ToSuffix(HandCost[7], "0.00", false);
            LblRubyHandsProfit.Text = "+ " + ToSuffix(HProfit[7], "0", false) + " BPC";

            LblSaphireHandsAmount.Text = ToSuffix(HandAmount[8], "0.00", false);
            LblSaphireHandsCost.Text = "🍌" + ToSuffix(HandCost[8], "0.00", false);
            LblSaphireHandsProfit.Text = "+ " + ToSuffix(HProfit[8], "0", false) + " BPC";

            LblVoidHandsAmount.Text = ToSuffix(HandAmount[9], "0.00", false);
            LblVoidHandCost.Text = "🍌" + ToSuffix(HandCost[9], "0.00", false);
            LblVOidHandProfit.Text = "+ " + ToSuffix(HProfit[9], "0", false) + " BPC";

            LblRainbownitehandsAMount.Text = ToSuffix(HandAmount[10], "0.00", false);
            LblRainbowniteHandsCost.Text = "🍌" + ToSuffix(HandCost[10], "0.00", false);
            LblRainbowniteHandsProfit.Text = "+ " + ToSuffix(HProfit[10], "0", false) + " BPC";

            LblBlackStoneHandsAmount.Text = ToSuffix(HandAmount[11], "0.00", false);
            LblBlackStoneHandsCost.Text = "🍌" + ToSuffix(HandCost[11], "0.00", false);
            LblBlackStoneHandProfit.Text = "+ " + ToSuffix(HProfit[11], "0", false) + " BPC";


            // monkis Shop

            LblMarmocetsAmount.Text = ToSuffix(MonkiAmount[0], "0.00", false);
            LblMarmocetsCost.Text = "🍌" + ToSuffix(MonkiCost[0], "0.00", false);
            LblMarmocetsProfit.Text = "+ " + ToSuffix(MProfit[0], "0", false) + " BPS";

            LblCapuchinAmount.Text = ToSuffix(MonkiAmount[1], "0.00", false);
            LblCapuchinCost.Text = "🍌" + ToSuffix(MonkiCost[1], "0.00", false);
            LblCapuchinProfit.Text = "+ " + ToSuffix(MProfit[1], "0", false) + " BPS";

            LblBonoboAmount.Text = ToSuffix(MonkiAmount[2], "0.00", false);
            LblBononoCost.Text = "🍌" + ToSuffix(MonkiCost[2], "0.00", false);
            LblBonoboProfit.Text = "+ " + ToSuffix(MProfit[2], "0", false) + " BPS";

            LblOrangutanAmount.Text = ToSuffix(MonkiAmount[3], "0", false);
            LblOrangutanCost.Text = "🍌" + ToSuffix(MonkiCost[3], "0", false);
            lblOrangutanProfit.Text = "+ " + ToSuffix(MProfit[3], "0", false) + " BPS";

            LblBaboonAmount.Text = ToSuffix(MonkiAmount[4], "0.00", false);
            lblBaboonCost.Text = "🍌" + ToSuffix(MonkiCost[4], "0.00", false);
            LblBaboonProfit.Text = "+ " + ToSuffix(MProfit[4], "0", false) + " BPS";

            LblChimpanzeeAmount.Text = ToSuffix(MonkiAmount[5], "0.00", false);
            LblChimpanzeeCost.Text = "🍌" + ToSuffix(MonkiCost[5], "0.00", false);
            LblChimpanzeeProfit.Text = "+ " + ToSuffix(MProfit[5], "0", false) + " BPS";

            LblMandrillAmount.Text = ToSuffix(MonkiAmount[6], "0.00", false);
            LblMandrillCost.Text = "🍌" + ToSuffix(MonkiCost[6], "0.00", false);
            LblMandrillProfit.Text = "+ " + ToSuffix(MProfit[6], "0", false) + " BPS";

            LblGeladaAmount.Text = ToSuffix(MonkiAmount[7], "0.00", false);
            LblGeladaCost.Text = "🍌" + ToSuffix(MonkiCost[7], "0.00", false);
            LblGeladaProfit.Text = "+ " + ToSuffix(MProfit[7], "0", false) + " BPS";

            LblGorillaAmount.Text = ToSuffix(MonkiAmount[8], "0.00", false);
            LblGorillaCost.Text = "🍌" + ToSuffix(MonkiCost[8], "0.00", false);
            LblGorillaProfit.Text = "+ " + ToSuffix(MProfit[8], "0", false) + " BPS";

            LblHomoHabilisAmount.Text = ToSuffix(MonkiAmount[9], "0.00", false);
            LblHomoHabilisCost.Text = "🍌" + ToSuffix(MonkiCost[9], "0.00", false);
            LblHomoHabilisProfit.Text = "+ " + ToSuffix(MProfit[9], "0", false) + " BPS";

            LblHomoErectusAmount.Text = ToSuffix(MonkiAmount[10], "0.00", false);
            LblHomoErectusCost.Text = "🍌" + ToSuffix(MonkiCost[10], "0.00", false);
            LblHomoErectusProfit.Text = "+ " + ToSuffix(MProfit[10], "0", false) + " BPS";

            LblHomoSapienAmount.Text = ToSuffix(MonkiAmount[11], "0.00", false);
            LblHomoSapienCost.Text = "🍌" + ToSuffix(MonkiCost[11], "0.00", false);
            LblHomoSapienProfit.Text = "+ " + ToSuffix(MProfit[11], "0", false) + " BPS";


            // this is for the upgrades tab
            Upgr_Unlocks(false);
            prestiges(false, true);

            // this is if the upgrade cap has been reached
            
            if (Bananas >= 1e302)
            {
                PnlEndGame.Visible = true;
                PnlMainGame.Visible = false;
                PnlMainMenu.Visible = false;
                Refresh.Enabled = false;
            }





            Refresh.Enabled = true;
            
            
        }




        //Main Menu

        private void BtnMMQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMMChangeLog_Click(object sender, EventArgs e)
        {
            RTBMMChangeLog.Visible = !RTBMMChangeLog.Visible;
        }



        private void BtnMMOptions_Click(object sender, EventArgs e)
        {
            PnlMMOptions.Visible = !PnlMMOptions.Visible;
        }



        private void BtnMMPlay_Click(object sender, EventArgs e)
        {
            
            if(Bananas > 1e302)
            {
                PnlMainMenu.Visible = false;
                PnlEndGame.Visible = true;
                Refresh.Enabled = false;

            }
            else
            {
                PnlMainMenu.Visible = false;
                PnlMainGame.Visible = true;
            }

        }
           ///DATA RESET BUTTON!!!
        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("THIS WILL RESET ALL YOUR PROGRESS , ARE YOU SURE?", "GAME DATA RESET", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.IO.Directory.CreateDirectory("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\");

                var Data = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Main.ID");
                Data.WriteLine("0");
                Data.WriteLine("1");
                Data.WriteLine("0");
                Data.Close();

                Bananas = 0;
                BPC = 1;
                BPS = 0;


                var P = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Prestige.ID");
                P.WriteLine(0);
                P.WriteLine(0);
                P.Close();

                prestige_no = 0;
                Intelligence = 0;


                var HA = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandAmount.ID");
                HA.WriteLine("1");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.WriteLine("0");
                HA.Close();

                HandAmount[0] = 1;
                HandAmount[1] = 0;
                HandAmount[2] = 0;
                HandAmount[3] = 0;
                HandAmount[4] = 0;
                HandAmount[5] = 0;
                HandAmount[6] = 0;
                HandAmount[7] = 0;
                HandAmount[8] = 0;
                HandAmount[9] = 0;
                HandAmount[10] = 0;
                HandAmount[11] = 0;




                var HC = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandCost.ID");
                HC.WriteLine("15");
                HC.WriteLine("150");
                HC.WriteLine("10000");
                HC.WriteLine("250000");
                HC.WriteLine("5000000");
                HC.WriteLine("5e8");
                HC.WriteLine("1e12");
                HC.WriteLine("1e15");
                HC.WriteLine("5e17");
                HC.WriteLine("1e18");
                HC.WriteLine("5e21");
                HC.WriteLine("1e24");
                HC.Close();

                HandCost[0] = 15;
                HandCost[1] = 150;
                HandCost[2] = 10000;
                HandCost[3] = 250000;
                HandCost[4] = 5000000;
                HandCost[5] = 5e8;
                HandCost[6] = 1e12;
                HandCost[7] = 1e15;
                HandCost[8] = 5e17;
                HandCost[9] = 1e18;
                HandCost[10] = 5e21;
                HandCost[11] = 1e24;



                var HP = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandProfit.ID");
                HP.WriteLine("1");
                HP.WriteLine("10");
                HP.WriteLine("500");
                HP.WriteLine("10000");
                HP.WriteLine("500000");
                HP.WriteLine("2.5e7");
                HP.WriteLine("1e9");
                HP.WriteLine("5e11");
                HP.WriteLine("2.5e13");
                HP.WriteLine("1e15");
                HP.WriteLine("2.5e20");
                HP.WriteLine("1e22");
                HP.Close();


                HandProfit[0] = 1;
                HandProfit[1] = 10;
                HandProfit[2] = 500;
                HandProfit[3] = 10000;
                HandProfit[4] = 500000;
                HandProfit[5] = 2.5e7;
                HandProfit[6] = 1e9;
                HandProfit[7] = 5e11;
                HandProfit[8] = 2.5e13;
                HandProfit[9] = 1e15;
                HandProfit[10] = 2.5e20;
                HandProfit[11] = 1e22;



                var MA = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiAmount.ID");
                MA.WriteLine("1");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.WriteLine("0");
                MA.Close();

                MonkiAmount[0] = 1;
                MonkiAmount[1] = 0;
                MonkiAmount[2] = 0;
                MonkiAmount[3] = 0;
                MonkiAmount[4] = 0;
                MonkiAmount[5] = 0;
                MonkiAmount[6] = 1;
                MonkiAmount[7] = 0;
                MonkiAmount[8] = 0;
                MonkiAmount[9] = 0;
                MonkiAmount[10] = 0;
                MonkiAmount[11] = 0;

                var MC = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiCost.ID");
                MC.WriteLine("250");
                MC.WriteLine("10000");
                MC.WriteLine("2500000");
                MC.WriteLine("50000000");
                MC.WriteLine("1e9");
                MC.WriteLine("5e10");
                MC.WriteLine("1e12");
                MC.WriteLine("7.5e14");
                MC.WriteLine("2.5e17");
                MC.WriteLine("2.5e20");
                MC.WriteLine("1e22");
                MC.WriteLine("1e27");
                MC.Close();

                MonkiCost[0] = 250;
                MonkiCost[1] = 10000;
                MonkiCost[2] = 2500000;
                MonkiCost[3] = 50000000;
                MonkiCost[4] = 1e9;
                MonkiCost[5] = 5e10;
                MonkiCost[6] = 1e12;
                MonkiCost[7] = 7.5e14;
                MonkiCost[8] = 2.5e17;
                MonkiCost[9] = 2.5e20;
                MonkiCost[10] = 1e22;
                MonkiCost[11] = 1e27;


                var MP = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiProfit.ID");
                MP.WriteLine("5");
                MP.WriteLine("100");
                MP.WriteLine("10000");
                MP.WriteLine("500000");
                MP.WriteLine("50000000");
                MP.WriteLine("1e9");
                MP.WriteLine("7.5e10");
                MP.WriteLine("1e12");
                MP.WriteLine("1e15");
                MP.WriteLine("1e17");
                MP.WriteLine("1e19");
                MP.WriteLine("1e21");
                MP.Close();

                MonkiProfit[0] = 5;
                MonkiProfit[1] = 100;
                MonkiProfit[2] = 10000;
                MonkiProfit[3] = 500000;
                MonkiProfit[4] = 5e7;
                MonkiProfit[5] = 1e9;
                MonkiProfit[6] = 7.5e10;
                MonkiProfit[7] = 1e12;
                MonkiProfit[8] = 1e15;
                MonkiProfit[9] = 1e17;
                MonkiProfit[10] = 1e19;
                MonkiProfit[11] = 1e21;



                var D = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Upgr.ID");
                D.WriteLine("1");
                D.Close();

                Upgr_count = 1;

                LblUpgrAmnt1.Text = "Upgrades " + Upgr_count.ToString();
                LblUpgrDest1.Text = Upgr_Desc[Upgr_count].ToString();
                LblupgrCost1.Text = "🍌" + ToSuffix(Upgr_Price[Upgr_count], "0.00", false);

                LblUpgrAmnt2.Text = "Upgrades " + (Upgr_count + 1).ToString();
                LblUpgrDest2.Text = Upgr_Desc[Upgr_count + 1].ToString();
                LblupgrCost2.Text = "🍌" + ToSuffix(Upgr_Price[Upgr_count + 1], "0.00", false);

                LblUpgrAmnt3.Text = "Upgrades " + (Upgr_count + 2).ToString();
                LblUpgrDest3.Text = Upgr_Desc[Upgr_count + 2].ToString();
                LblupgrCost3.Text = "🍌" + ToSuffix(Upgr_Price[Upgr_count + 2], "0.00", false);

                LblUpgrAmnt4.Text = "Upgrades " + (Upgr_count + 3).ToString();
                LblUpgrDest4.Text = Upgr_Desc[Upgr_count + 3].ToString();
                LblupgrCost4.Text = "🍌" + ToSuffix(Upgr_Price[Upgr_count + 3], "0.00", false);







            LblWoodenHandsOwned.Text = ToSuffix(HandAmount[0], "0.00", false);
            LblWoodenHandsPrice.Text = "🍌" + ToSuffix(HandCost[0], "0.00", false);
            LblWoodenHandProfit.Text = "+ " + ToSuffix(HandProfit[0], "0", false) + " BPC";

            LblStoneHandsOwned.Text = ToSuffix(HandAmount[1], "0.00", false);
            LblStoneHandPrice.Text = "🍌" + ToSuffix(HandCost[1], "0.00", false);
            lblStoneHandProfit.Text = "+ " + ToSuffix(HandProfit[1], "0", false) + " BPC";

            LblCoalHandsOwned.Text = ToSuffix(HandAmount[2], "0.00", false);
            LblCoalHandCost.Text = "🍌" + ToSuffix(HandCost[2], "0.00", false);
            LblCoalHandProfit.Text = "+ " + ToSuffix(HandProfit[2], "0", false) + " BPC";

            LblIronHandAmount.Text = ToSuffix(HandAmount[3], "0.00", false);
            LblIronHandCost.Text = "🍌" + ToSuffix(HandCost[3], "0.00", false);
            LblIronHandProfit.Text = "+ " + ToSuffix(HandProfit[3], "0", false) + " BPC";

            LblGoldHandsAmount.Text = ToSuffix(HandAmount[4], "0.00", false);
            LblGoldHandCost.Text = "🍌" + ToSuffix(HandCost[4], "0.00", false);
            LblGoldHandsProfit.Text = "+ " + ToSuffix(HandProfit[4], "0", false) + " BPC";

            LblDiamondHandsAmount.Text = ToSuffix(HandAmount[5], "0.00", false);
            LblDiamondHandPrice.Text = "🍌" + ToSuffix(HandCost[5], "0.00", false);
            LblDiamondHandProfit.Text = "+ " + ToSuffix(HandProfit[5], "0", false) + " BPC";

            LblEmeraldHandAmount.Text = ToSuffix(HandAmount[6], "0.00", false);
            LblEmeraldHandsCost.Text = "🍌" + ToSuffix(HandCost[6], "0.00", false);
            LblEmeraldHandsProfit.Text = "+ " + ToSuffix(HandProfit[6], "0", false) + " BPC";

            LblRubyHandsAmount.Text = ToSuffix(HandAmount[7], "0.00", false);
            LblRubyHandsCost.Text = "🍌" + ToSuffix(HandCost[7], "0.00", false);
            LblRubyHandsProfit.Text = "+ " + ToSuffix(HandProfit[7], "0", false) + " BPC";

            LblSaphireHandsAmount.Text = ToSuffix(HandAmount[8], "0.00", false);
            LblSaphireHandsCost.Text = "🍌" + ToSuffix(HandCost[8], "0.00", false);
            LblSaphireHandsProfit.Text = "+ " + ToSuffix(HandProfit[8], "0", false) + " BPC";

            LblVoidHandsAmount.Text = ToSuffix(HandAmount[9], "0.00", false);
            LblVoidHandCost.Text = "🍌" + ToSuffix(HandCost[9], "0.00", false);
            LblVOidHandProfit.Text = "+ " + ToSuffix(HandProfit[9], "0", false) + " BPC";

            LblRainbownitehandsAMount.Text = ToSuffix(HandAmount[10], "0.00", false);
            LblRainbowniteHandsCost.Text = "🍌" + ToSuffix(HandCost[10], "0.00", false);
            LblRainbowniteHandsProfit.Text = "+ " + ToSuffix(HandProfit[10], "0", false) + " BPC";

            LblBlackStoneHandsAmount.Text = ToSuffix(HandAmount[11], "0.00", false);
            LblBlackStoneHandsCost.Text = "🍌" + ToSuffix(HandCost[11], "0.00", false);
            LblBlackStoneHandProfit.Text = "+ " + ToSuffix(HandProfit[11], "0", false) + " BPC";


            // monkis Shop

            LblMarmocetsAmount.Text = ToSuffix(MonkiAmount[0], "0.00", false);
            LblMarmocetsCost.Text = "🍌" + ToSuffix(MonkiCost[0], "0.00", false);
            LblMarmocetsProfit.Text = "+ " + ToSuffix(MonkiProfit[0], "0.00", false) + " BPS";

            LblCapuchinAmount.Text = ToSuffix(MonkiAmount[1], "0.00", false);
            LblCapuchinCost.Text = "🍌" + ToSuffix(MonkiCost[1], "0.00", false);
            LblCapuchinProfit.Text = "+ " + ToSuffix(MonkiProfit[1], "0.00", false) + " BPS";

            LblBonoboAmount.Text = ToSuffix(MonkiAmount[2], "0.00", false);
            LblBononoCost.Text = "🍌" + ToSuffix(MonkiCost[2], "0.00", false);
            LblBonoboProfit.Text = "+ " + ToSuffix(MonkiProfit[2], "0.00", false) + " BPS";

            LblOrangutanAmount.Text = ToSuffix(MonkiAmount[3], "0.00", false);
            LblOrangutanCost.Text = "🍌" + ToSuffix(MonkiCost[3], "0.00", false);
            lblOrangutanProfit.Text = "+ " + ToSuffix(MonkiProfit[3], "0.00", false) + " BPS";

            LblBaboonAmount.Text = ToSuffix(MonkiAmount[4], "0.00", false);
            lblBaboonCost.Text = "🍌" + ToSuffix(MonkiCost[4], "0.00", false);
            LblBaboonProfit.Text = "+ " + ToSuffix(MonkiProfit[4], "0.00", false) + " BPS";

            LblChimpanzeeAmount.Text = ToSuffix(MonkiAmount[5], "0.00", false);
            LblChimpanzeeCost.Text = "🍌" + ToSuffix(MonkiCost[5], "0.00", false);
            LblChimpanzeeProfit.Text = "+ " + ToSuffix(MonkiProfit[5], "0.00", false) + " BPS";

            LblMandrillAmount.Text = ToSuffix(MonkiAmount[6], "0.00", false);
            LblMandrillCost.Text = "🍌" + ToSuffix(MonkiCost[6], "0.00", false);
            LblMandrillProfit.Text = "+ " + ToSuffix(MonkiProfit[6], "0.00", false) + " BPS";

            LblGeladaAmount.Text = ToSuffix(MonkiAmount[7], "0.00", false);
            LblGeladaCost.Text = "🍌" + ToSuffix(MonkiCost[7], "0.00", false);
            LblGeladaProfit.Text = "+ " + ToSuffix(MonkiProfit[7], "0.00", false) + " BPS";

            LblGorillaAmount.Text = ToSuffix(MonkiAmount[8], "0.00", false);
            LblGorillaCost.Text = "🍌" + ToSuffix(MonkiCost[8], "0.00", false);
            LblGorillaProfit.Text = "+ " + ToSuffix(MonkiProfit[8], "0.00", false) + " BPS";

            LblHomoHabilisAmount.Text = ToSuffix(MonkiAmount[9], "0.00", false);
            LblHomoHabilisCost.Text = "🍌" + ToSuffix(MonkiCost[9], "0.00", false);
            LblHomoHabilisProfit.Text = "+ " + ToSuffix(MonkiProfit[9], "0.00", false) + " BPS";

            LblHomoErectusAmount.Text = ToSuffix(MonkiAmount[10], "0.00", false);
            LblHomoErectusCost.Text = "🍌" + ToSuffix(MonkiCost[10], "0.00", false);
            LblHomoErectusProfit.Text = "+ " + ToSuffix(MonkiProfit[10], "0.00", false) + " BPS";

            LblHomoSapienAmount.Text = ToSuffix(MonkiAmount[11], "0.00", false);
            LblHomoSapienCost.Text = "🍌" + ToSuffix(MonkiCost[11], "0.00", false);
            LblHomoSapienProfit.Text = "+ " + ToSuffix(MonkiProfit[11], "0.00", false) + " BPS";


            if (MessageBox.Show("Please Restart Banana Clicker, To update changes!", "Application Restart", MessageBoxButtons.OK) == DialogResult.OK)
                { 
                    this.Close();
                }

            }

        }



        // main game

        private void BtnBBananaClick_Click(object sender, EventArgs e)
        {
            Bananas += BPC;
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";



        }

        private void PBHandsShop_Click(object sender, EventArgs e)
        {
            FPnlHelp.Visible = false;
            FPlMonkisShop.Visible = false;
            FPnlUpgradesMain.Visible = false;
            PnlPrestige.Visible = false;
            FPnlMonkiHands.Visible = true;
            LblTab.Text = "Monki Hands";
        }

        private void PBMonkiShop_Click(object sender, EventArgs e)
        {
            FPnlHelp.Visible = false;
            FPnlMonkiHands.Visible = false;
            FPnlUpgradesMain.Visible = false;
            PnlPrestige.Visible = false;
            FPlMonkisShop.Visible = true;
            LblTab.Text = "Monki Shop";
        }


        //when the upgrade button is clicked
        private void PBUpgrades_Click(object sender, EventArgs e)
        {
            FPnlHelp.Visible = false;
            FPnlMonkiHands.Visible = false;
            FPlMonkisShop.Visible = false;
            PnlPrestige.Visible = false;
            FPnlUpgradesMain.Visible = true;
            LblTab.Text = "Upgrades - Bananas";
        }

        private void BtnEndGameMenu_Click(object sender, EventArgs e)
        {
            // this is when the main menu button within the end game panel is clicked
            PnlMainMenu.Visible = true;
            PnlMainGame.Visible = false;
            PnlEndGame.Visible = false;

        }

        private void LblBPS_Click(object sender, EventArgs e)
        {

        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            FPnlHelp.Visible = true;
            FPnlMonkiHands.Visible = false;
            FPlMonkisShop.Visible = false;
            PnlPrestige.Visible = false;
            FPnlUpgradesMain.Visible = false;
            LblTab.Text = "Help";
        }





        private void BtnPause_Click(object sender, EventArgs e)
        {
            PnlMainGame.Visible = false;
            PnlMainMenu.Visible = true;
        }


        //REFRESH REFRESH REFRESH REFRESH REFRESH REFRESH REFRESH REFRESH REFRESH 
        private void Refresh_Tick(object sender, EventArgs e)
        {
            Bananas += BPS; // adds Banana per second

            //unlocks the new hands
            HandUnlocks(Bananas);
            MonkiUnlocks(MonkiAmount[0]);
            

            // Updates the label and text per second
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
            LblEndGameBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
            LblBPC.Text = ToSuffix(BPC, "0.00", false) + " BPC"; 
            LblBPS.Text = ToSuffix(BPS, "0.00", false) + " BPS";



            //max buttons load
            //hands
            if(HandAmount[0] >= 100) { BtbWoodHandsMax.Visible = true; }
            if (HandAmount[1] >= 100) { BtnStonehandsMax.Visible = true; }
            if (HandAmount[2] >= 100) { BtnCoalHandsMax.Visible = true; }
            if (HandAmount[3] >= 100) { BtnIronHandMax.Visible = true; }
            if (HandAmount[4] >= 100) { BtnGoldHandMax.Visible = true; }
            if (HandAmount[5] >= 100) { BtnDiamondHandMax.Visible = true; }
            if (HandAmount[6] >= 100) { BtnEmeraldHandMax.Visible = true; }
            if (HandAmount[7] >= 100) { BtnRubyHandsMax.Visible = true; }
            if (HandAmount[8] >= 100) { BtnSaphireMax.Visible = true; }
            if (HandAmount[9] >= 100) { BtnVoidHandMax.Visible = true; }
            if (HandAmount[10] >= 100) { BtnRainbowniteMax.Visible = true; }
            if (HandAmount[11] >= 100) { BtnBlackStoneMax.Visible = true; }



            //monki
            if (MonkiAmount[0] >= 100) { BtnMaxMarmocets.Visible = true; }
            if (MonkiAmount[1] >= 100) { BtnCapuchinMax.Visible = true; }
            if (MonkiAmount[2] >= 100) { BtnBonoboMax.Visible = true; }
            if (MonkiAmount[3] >= 100) { BtnOrangutanMax.Visible = true; }
            if (MonkiAmount[4] >= 100) { BtnMaxBabbon.Visible = true; }
            if (MonkiAmount[5] >= 100) { LblChimpanzeeMax.Visible = true; }
            if (MonkiAmount[6] >= 100) { BtnMandrillMax.Visible = true; }
            if (MonkiAmount[7] >= 100) { BtnGeladaMax.Visible = true; }
            if (MonkiAmount[8] >= 100) { BtnGorillaMax.Visible = true; }
            if (MonkiAmount[9] >= 100) { BtmHomoHabilisMax.Visible = true; }
            if (MonkiAmount[10] >= 100) { BtnHomoErectusMax.Visible = true; }
            if (MonkiAmount[11] >= 100) { BtnHomoSapienMax.Visible = true; }



            if (HandAmount[1] >= 50) { PBMonkiShop.Visible = true; }
            if (MonkiAmount[3] >= 50) { PBUpgrades.Visible = true; }
            if (MonkiAmount[11] >= 250) { BtnPrestige.Visible = true; }
            if (MonkiAmount[11] >= 250) { LblIntelligence.Visible = true; }

            // this is for the end game

            if (Bananas >= 1e302)
            {
                PnlEndGame.Visible = true;
                PnlMainGame.Visible = false;
                PnlMainMenu.Visible = false;
                Refresh.Enabled = false;

            }





            IdleCash(true, BPS);
            prestiges(false, false);
            Playtime(false);



            try
            {
                //writes game data every second
                var Data = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\Main.ID");
                Data.WriteLine(Bananas.ToString());
                Data.WriteLine(BPC.ToString());
                Data.WriteLine(BPS.ToString());
                Data.Close();



                var HA = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandAmount.ID");
                HA.WriteLine(HandAmount[0].ToString());
                HA.WriteLine(HandAmount[1].ToString());
                HA.WriteLine(HandAmount[2].ToString());
                HA.WriteLine(HandAmount[3].ToString());
                HA.WriteLine(HandAmount[4].ToString());
                HA.WriteLine(HandAmount[5].ToString());
                HA.WriteLine(HandAmount[6].ToString());
                HA.WriteLine(HandAmount[7].ToString());
                HA.WriteLine(HandAmount[8].ToString());
                HA.WriteLine(HandAmount[9].ToString());
                HA.WriteLine(HandAmount[10].ToString());
                HA.WriteLine(HandAmount[11].ToString());
                HA.Close();

                var HC = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandCost.ID");
                HC.WriteLine(HandCost[0].ToString());
                HC.WriteLine(HandCost[1].ToString());
                HC.WriteLine(HandCost[2].ToString());
                HC.WriteLine(HandCost[3].ToString());
                HC.WriteLine(HandCost[4].ToString());
                HC.WriteLine(HandCost[5].ToString());
                HC.WriteLine(HandCost[6].ToString());
                HC.WriteLine(HandCost[7].ToString());
                HC.WriteLine(HandCost[8].ToString());
                HC.WriteLine(HandCost[9].ToString());
                HC.WriteLine(HandCost[10].ToString());
                HC.WriteLine(HandCost[11].ToString());
                HC.Close();

                var HP = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\HandProfit.ID");
                HP.WriteLine(HandProfit[0].ToString());
                HP.WriteLine(HandProfit[1].ToString());
                HP.WriteLine(HandProfit[2].ToString());
                HP.WriteLine(HandProfit[3].ToString());
                HP.WriteLine(HandProfit[4].ToString());
                HP.WriteLine(HandProfit[5].ToString());
                HP.WriteLine(HandProfit[6].ToString());
                HP.WriteLine(HandProfit[7].ToString());
                HP.WriteLine(HandProfit[8].ToString());
                HP.WriteLine(HandProfit[9].ToString());
                HP.WriteLine(HandProfit[10].ToString());
                HP.WriteLine(HandProfit[11].ToString());
                HP.Close();


                var MA = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiAmount.ID");
                MA.WriteLine(MonkiAmount[0].ToString());
                MA.WriteLine(MonkiAmount[1].ToString());
                MA.WriteLine(MonkiAmount[2].ToString());
                MA.WriteLine(MonkiAmount[3].ToString());
                MA.WriteLine(MonkiAmount[4].ToString());
                MA.WriteLine(MonkiAmount[5].ToString());
                MA.WriteLine(MonkiAmount[6].ToString());
                MA.WriteLine(MonkiAmount[7].ToString());
                MA.WriteLine(MonkiAmount[8].ToString());
                MA.WriteLine(MonkiAmount[9].ToString());
                MA.WriteLine(MonkiAmount[10].ToString());
                MA.WriteLine(MonkiAmount[11].ToString());
                MA.Close();

                var MC = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiCost.ID");
                MC.WriteLine(MonkiCost[0].ToString());
                MC.WriteLine(MonkiCost[1].ToString());
                MC.WriteLine(MonkiCost[2].ToString());
                MC.WriteLine(MonkiCost[3].ToString());
                MC.WriteLine(MonkiCost[4].ToString());
                MC.WriteLine(MonkiCost[5].ToString());
                MC.WriteLine(MonkiCost[6].ToString());
                MC.WriteLine(MonkiCost[7].ToString());
                MC.WriteLine(MonkiCost[8].ToString());
                MC.WriteLine(MonkiCost[9].ToString());
                MC.WriteLine(MonkiCost[10].ToString());
                MC.WriteLine(MonkiCost[11].ToString());
                MC.Close();

                var MP = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + current_user + "\\.GameData\\MonkiProfit.ID");
                MP.WriteLine(MonkiProfit[0].ToString());
                MP.WriteLine(MonkiProfit[1].ToString());
                MP.WriteLine(MonkiProfit[2].ToString());
                MP.WriteLine(MonkiProfit[3].ToString());
                MP.WriteLine(MonkiProfit[4].ToString());
                MP.WriteLine(MonkiProfit[5].ToString());
                MP.WriteLine(MonkiProfit[6].ToString());
                MP.WriteLine(MonkiProfit[7].ToString());
                MP.WriteLine(MonkiProfit[8].ToString());
                MP.WriteLine(MonkiProfit[9].ToString());
                MP.WriteLine(MonkiProfit[10].ToString());
                MP.WriteLine(MonkiProfit[11].ToString());
                MP.Close();

            }
            catch (System.IO.DirectoryNotFoundException)
            {
            }



        }





        //_______________________________________
        // wooden hands
        private void LblWoodenHandsPrice_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (Bananas >= HandCost[x])
            {
                Bananas = Bananas - HandCost[x];
                HandAmount[x] = HandAmount[x] + 1;
                HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPC = BPC + HProfit[x];
                //cost algritm
                HandCost[x] = 15 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                //Milesstones
                HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                //Updating the ui text
                LblWoodenHandsOwned.Text = ToSuffix(HandAmount[x], "0.00", false);
                LblWoodenHandsPrice.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
                LblWoodenHandProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if(HandAmount[x] >= 100) { BtbWoodHandsMax.Visible = true; }
                HandUnlocks(Bananas);


            }
        }
        //wood max
        private void BtbWoodHandsMax_Click(object sender, EventArgs e)
        {
            int x = 0;
            int i = 0;

            if (Bananas >= HandCost[x])
            {
                do
                {
                    Bananas = Bananas - HandCost[x];
                    HandAmount[x] = HandAmount[x] + 1;
                    HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPC = BPC + HProfit[x];
                    //cost algritm
                    HandCost[x] = 15 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                    //Milesstones
                    HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                    HandUnlocks(Bananas);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }

                } while (Bananas >= HandCost[x]);
            }
            //Updating the ui text
            LblWoodenHandsOwned.Text = ToSuffix(HandAmount[x], "0.00", false);
            LblWoodenHandsPrice.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
            LblWoodenHandProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }






        // Stone hands
        private void panel1_Click(object sender, EventArgs e)
        {
            int x = 1;

            if (Bananas >= HandCost[x])
            {
                Bananas = Bananas - HandCost[x];
                HandAmount[x] = HandAmount[x] + 1;
                HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPC = BPC + HProfit[x];
                //cost algritm
                HandCost[x] = 150 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                //Milesstones
                HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                //Updating the ui text
                LblStoneHandsOwned.Text = ToSuffix(HandAmount[x], "0.00", false);
                LblStoneHandPrice.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
                lblStoneHandProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (HandAmount[x] >= 100) { BtnStonehandsMax.Visible = true; }
                if (HandAmount[x] >= 50) { PBMonkiShop.Visible = true; }
                HandUnlocks(Bananas);


            }
        }



        //stone max
        private void BtnStonehandsMax_Click(object sender, EventArgs e)
        {
            int x = 1;
            int i = 0;

            if (Bananas >= HandCost[x])
            {
                do
                {
                    Bananas = Bananas - HandCost[x];
                    HandAmount[x] = HandAmount[x] + 1;
                    HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPC = BPC + HProfit[x];
                    //cost algritm
                    HandCost[x] = 150 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                    //Milesstones
                    HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                    HandUnlocks(Bananas);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= HandCost[x]);
            }
            //Updating the ui text
            LblStoneHandsOwned.Text = ToSuffix(HandAmount[x], "0.00", false);
            LblStoneHandPrice.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
            lblStoneHandProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }






        //COal HAnds
        private void FpnlCoal_Click(object sender, EventArgs e)
        {
            int x = 2;

            if (Bananas >= HandCost[x])
            {
                Bananas = Bananas - HandCost[x];
                HandAmount[x] = HandAmount[x] + 1;
                HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPC = BPC + HProfit[x];
                //cost algritm
                HandCost[x] = 10000 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                //Milesstones
                HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                //Updating the ui text
                LblCoalHandsOwned.Text = ToSuffix(HandAmount[x], "0.00", false);
                LblCoalHandCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
                LblCoalHandProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if(HandAmount[x] >= 100) { BtnCoalHandsMax.Visible = true; }
                HandUnlocks(Bananas);

            }
        }



        //coal max
        private void BtnCoalHandsMax_Click(object sender, EventArgs e)
        {
            int x = 2;
            int i = 0;

            if (Bananas >= HandCost[x])
            {
                do
                {
                    Bananas = Bananas - HandCost[x];
                    HandAmount[x] = HandAmount[x] + 1;
                    HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPC = BPC + HProfit[x];
                    //cost algritm
                    HandCost[x] = 10000 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                    //Milesstones
                    HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                    HandUnlocks(Bananas);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }

                } while (Bananas >= HandCost[x]);
            }
            //Updating the ui text
            LblCoalHandsOwned.Text = ToSuffix(HandAmount[x], "0.00", false);
            LblCoalHandCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
            LblCoalHandProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }




        //ironhands
        private void panel1_Click_1(object sender, EventArgs e)
        {
            int x = 3;
            if (Bananas >= HandCost[x])
            {
                Bananas = Bananas - HandCost[x];
                HandAmount[x] = HandAmount[x] + 1;
                HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPC = BPC + HProfit[x];
                //cost algritm
                HandCost[x] = 250000 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                //Milesstones
                HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                //Updating the ui text
                LblIronHandAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
                LblIronHandCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
                LblIronHandProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (HandAmount[x] >= 100) { BtnIronHandMax.Visible = true; }
                HandUnlocks(Bananas);


            }
        }



        //iron Max
        private void BtnIronHandMax_Click(object sender, EventArgs e)
        {
            int x = 3;
            int i = 0;
            if (Bananas >= HandCost[x])
            {
                do
                {
                    Bananas = Bananas - HandCost[x];
                    HandAmount[x] = HandAmount[x] + 1;
                    HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPC = BPC + HProfit[x];
                    //cost algritm
                    HandCost[x] = 250000 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                    //Milesstones
                    HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                    HandUnlocks(Bananas);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= HandCost[x]);
            }
            //Updating the ui text
            LblIronHandAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
            LblIronHandCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
            LblIronHandProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }




        //gold hands
        private void FPnlGoldHands_Click(object sender, EventArgs e)
        {
            int x = 4;
            if (Bananas >= HandCost[x])
            {
                Bananas = Bananas - HandCost[x];
                HandAmount[x] = HandAmount[x] + 1;
                HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPC = BPC + HProfit[x];
                //cost algritm
                HandCost[x] = 5e6 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                //Milesstones
                HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                //Updating the ui text
                LblGoldHandsAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
                LblGoldHandCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
                LblGoldHandsProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (HandAmount[x] >= 100) { BtnGoldHandMax.Visible = true; }
                HandUnlocks(Bananas);


            }
        }



        //gold max
        private void BtnGoldHandMax_Click(object sender, EventArgs e)
        {
            int x = 4;
            int i = 0;
            if (Bananas >= HandCost[x])
            {
                do
                {
                    Bananas = Bananas - HandCost[x];
                    HandAmount[x] = HandAmount[x] + 1;
                    HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPC = BPC + HProfit[x];
                    //cost algritm
                    HandCost[x] = 5e6 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                    //Milesstones
                    HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                    HandUnlocks(Bananas);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= HandCost[x]);
            }
            //Updating the ui text
            LblGoldHandsAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
            LblGoldHandCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
            LblGoldHandsProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }





        //diamond hands

        private void FPnlDiamondHands_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (Bananas >= HandCost[x])
            {
                Bananas = Bananas - HandCost[x];
                HandAmount[x] = HandAmount[x] + 1;
                HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPC = BPC + HProfit[x];
                //cost algritm
                HandCost[x] = 5e8 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                //Milesstones
                HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                //Updating the ui text
                LblDiamondHandsAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
                LblDiamondHandPrice.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
                LblDiamondHandProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (HandAmount[x] >= 100) { BtnDiamondHandMax.Visible = true; }
                HandUnlocks(Bananas);


            }
        }



        //diamondsmax

        private void BtnDiamondHandMax_Click(object sender, EventArgs e)
        {
            int x = 5;
            int i = 0;
            if (Bananas >= HandCost[x])
            {
                do
                {
                    Bananas = Bananas - HandCost[x];
                    HandAmount[x] = HandAmount[x] + 1;
                    HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPC = BPC + HProfit[x];
                    //cost algritm
                    HandCost[x] = 5e8 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                    //Milesstones
                    HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                    HandUnlocks(Bananas);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= HandCost[x]);
            }
            //Updating the ui text
            LblDiamondHandsAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
            LblDiamondHandPrice.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
            LblDiamondHandProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }


        //emeralnd hand
        private void FPnlEmeralndHands_Click(object sender, EventArgs e)
        {
            int x = 6;
            if (Bananas >= HandCost[x])
            {
                Bananas = Bananas - HandCost[x];
                HandAmount[x] = HandAmount[x] + 1;
                HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPC = BPC + HProfit[x];
                //cost algritm
                HandCost[x] = 1e12 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                //Milesstones
                HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                //Updating the ui text
                LblEmeraldHandAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
                LblEmeraldHandsCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
                LblEmeraldHandsProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (HandAmount[x] >= 100) { BtnEmeraldHandMax.Visible = true; }
                HandUnlocks(Bananas);


            }
        }

        //emeralndmax
        private void BtnEmeraldHandMax_Click(object sender, EventArgs e)
        {
            int x = 6;
            int i = 0;
            if (Bananas >= HandCost[x])
            {
                do
                {
                    Bananas = Bananas - HandCost[x];
                    HandAmount[x] = HandAmount[x] + 1;
                    HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPC = BPC + HProfit[x];
                    //cost algritm
                    HandCost[x] = 1e12 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                    //Milesstones
                    HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                    HandUnlocks(Bananas);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= HandCost[x]);
            }
            //Updating the ui text
            LblEmeraldHandAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
            LblEmeraldHandsCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
            LblEmeraldHandsProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }

        //ruby hands
        private void FpnlRubyHands_Click(object sender, EventArgs e)
        {
            int x = 7;
            if (Bananas >= HandCost[x])
            {
                Bananas = Bananas - HandCost[x];
                HandAmount[x] = HandAmount[x] + 1;
                HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPC = BPC + HProfit[x];
                //cost algritm
                HandCost[x] = 1e15 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                //Milesstones
                HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                //Updating the ui text
                LblRubyHandsAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
                LblRubyHandsCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
                LblRubyHandsProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (HandAmount[x] >= 100) { BtnRubyHandsMax.Visible = true; }
                HandUnlocks(Bananas);


            }
        }

        //ruby max
        private void BtnRubyHandsMax_Click(object sender, EventArgs e)
        {
            int x = 7;
            int i = 0;
            if (Bananas >= HandCost[x])
            {
                do
                {
                    Bananas = Bananas - HandCost[x];
                    HandAmount[x] = HandAmount[x] + 1;
                    HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPC = BPC + HProfit[x];
                    //cost algritm
                    HandCost[x] = 1e15 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                    //Milesstones
                    HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                    HandUnlocks(Bananas);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= HandCost[x]);
            }
            //Updating the ui text
            LblRubyHandsAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
            LblRubyHandsCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
            LblRubyHandsProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }


        //saphire 
        private void FpnlSaphire_Click(object sender, EventArgs e)
        {
            int x = 8;
            if (Bananas >= HandCost[x])
            {
                Bananas = Bananas - HandCost[x];
                HandAmount[x] = HandAmount[x] + 1;
                HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPC = BPC + HProfit[x];
                //cost algritm
                HandCost[x] = 5e17 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                //Milesstones
                HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                //Updating the ui text
                LblSaphireHandsAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
                LblSaphireHandsCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
                LblSaphireHandsProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (HandAmount[x] >= 100) { BtnSaphireMax.Visible = true; }
                HandUnlocks(Bananas);


            }
        }
        //saphire max
        private void BtnSaphireMax_Click(object sender, EventArgs e)
        {
            int x = 8;
            int i = 0;
            if (Bananas >= HandCost[x])
            {
                do
                {
                    Bananas = Bananas - HandCost[x];
                    HandAmount[x] = HandAmount[x] + 1;
                    HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPC = BPC + HProfit[x];
                    //cost algritm
                    HandCost[x] = 5e17 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                    //Milesstones
                    HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                    HandUnlocks(Bananas);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= HandCost[x]);
            }
            //Updating the ui text
            LblSaphireHandsAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
            LblSaphireHandsCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
            LblSaphireHandsProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }

        //void

        private void FpnlVoid_Click(object sender, EventArgs e)
        {
            int x = 9;
            if (Bananas >= HandCost[x])
            {
                Bananas = Bananas - HandCost[x];
                HandAmount[x] = HandAmount[x] + 1;
                HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPC = BPC + HProfit[x];
                //cost algritm
                HandCost[x] = 1e18 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                //Milesstones
                HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                //Updating the ui text
                LblVoidHandsAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
                LblVoidHandCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
                LblVOidHandProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (HandAmount[x] >= 100) { BtnVoidHandMax.Visible = true; }
                HandUnlocks(Bananas);


            }
        }

        //void max

        private void BtnVoidHandMax_Click(object sender, EventArgs e)
        {
            int x = 9;
            int i = 0;
            if (Bananas >= HandCost[x])
            {
                do
                {
                    Bananas = Bananas - HandCost[x];
                    HandAmount[x] = HandAmount[x] + 1;
                    HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPC = BPC + HProfit[x];
                    //cost algritm
                    HandCost[x] = 1e18 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                    //Milesstones
                    HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                    HandUnlocks(Bananas);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= HandCost[x]);
            }
            //Updating the ui text
            LblVoidHandsAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
            LblVoidHandCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
            LblVOidHandProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }

        //rainbownite
        private void FpnlRainbownite_Click(object sender, EventArgs e)
        {
            int x = 10;
            if (Bananas >= HandCost[x])
            {
                Bananas = Bananas - HandCost[x];
                HandAmount[x] = HandAmount[x] + 1;
                HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPC = BPC + HProfit[x];
                //cost algritm
                HandCost[x] = 5e21 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                //Milesstones
                HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                //Updating the ui text
                LblRainbownitehandsAMount.Text = ToSuffix(HandAmount[x], "0.00", false);
                LblRainbowniteHandsCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
                LblRainbowniteHandsProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (HandAmount[x] >= 100) { BtnRainbowniteMax.Visible = true; }
                HandUnlocks(Bananas);


            }
        }
        
        //rainbownite max

        private void BtnRainbowniteMax_Click(object sender, EventArgs e)
        {
            int x = 10;
            int i = 0;
            if (Bananas >= HandCost[x])
            {
                do
                {
                    Bananas = Bananas - HandCost[x];
                    HandAmount[x] = HandAmount[x] + 1;
                    HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPC = BPC + HProfit[x];
                    //cost algritm
                    HandCost[x] = 5e21 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                    //Milesstones
                    HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                    HandUnlocks(Bananas);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= HandCost[x]);
            }
            //Updating the ui text
            LblRainbownitehandsAMount.Text = ToSuffix(HandAmount[x], "0.00", false);
            LblRainbowniteHandsCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
            LblRainbowniteHandsProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }


        //blackstone
        private void FpnlBlackStoneHand_Click(object sender, EventArgs e)
        {
            int x = 11;
            if (Bananas >= HandCost[x])
            {
                Bananas = Bananas - HandCost[x];
                HandAmount[x] = HandAmount[x] + 1;
                HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPC = BPC + HProfit[x];
                //cost algritm
                HandCost[x] = 1e24 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                //Milesstones
                HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                //Updating the ui text
                LblBlackStoneHandsAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
                LblBlackStoneHandsCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
                LblBlackStoneHandProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (HandAmount[x] >= 100) { BtnBlackStoneMax.Visible = true; }
                HandUnlocks(Bananas);


            }
        }

        //blackstone max
        private void BtnBlackStoneMax_Click(object sender, EventArgs e)
        {
            int x = 11;
            int i = 0;
            if (Bananas >= HandCost[x])
            {
                do
                {
                    Bananas = Bananas - HandCost[x];
                    HandAmount[x] = HandAmount[x] + 1;
                    HProfit[x] = HandProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPC = BPC + HProfit[x];
                    //cost algritm
                    HandCost[x] = 1e24 * (Math.Pow((1 + (CostMultiplier) / (1 + (HandAmount[x]) / (5000))), HandAmount[x]));
                    //Milesstones
                    HandProfit[x] = MilesStonesMulti(HandAmount[x], HandProfit[x]);
                    HandUnlocks(Bananas);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= HandCost[x]);
            }
            //Updating the ui text
            LblBlackStoneHandsAmount.Text = ToSuffix(HandAmount[x], "0.00", false);
            LblBlackStoneHandsCost.Text = "🍌" + ToSuffix(HandCost[x], "0.00", false);
            LblBlackStoneHandProfit.Text = "+ " + ToSuffix(HProfit[x], "0", false) + " BPC";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }

















































        //this is for the monkis


        //marmocets 
        private void LblMarmocetsCost_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (Bananas >= MonkiCost[x])
            {
                Bananas = Bananas - MonkiCost[x];
                MonkiAmount[x] = MonkiAmount[x] + 1;
                MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPS = BPS + MProfit[x];
                //cost algritm
                MonkiCost[x] = 250 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                //Milesstones
                MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                //Updating the ui text
                LblMarmocetsAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
                LblMarmocetsCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
                LblMarmocetsProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (MonkiAmount[x] >= 100) { BtnMaxMarmocets.Visible = true; }
                MonkiUnlocks(MonkiAmount[x]);
            }


        }



        //marmocetsmax
        private void BtnMaxMarmocets_Click(object sender, EventArgs e)
        {
            int x = 0;
            int i = 0;
            if (Bananas >= MonkiCost[x])
            {
                do
                {
                    Bananas = Bananas - MonkiCost[x];
                    MonkiAmount[x] = MonkiAmount[x] + 1;
                    MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPS = BPS + MProfit[x];
                    //cost algritm
                    MonkiCost[x] = 250 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                    //Milesstones
                    MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                    MonkiUnlocks(MonkiAmount[x]);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= MonkiCost[x]);
            }
            //Updating the ui text
            LblMarmocetsAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
            LblMarmocetsCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
            LblMarmocetsProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }



        //Capuchin
        private void LblCapuchinAmount_Click(object sender, EventArgs e)
        {
            int x = 1;
            if (Bananas >= MonkiCost[x])
            {
                Bananas = Bananas - MonkiCost[x];
                MonkiAmount[x] = MonkiAmount[x] + 1;
                MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPS = BPS + MProfit[x];
                //cost algritm
                MonkiCost[x] = 10000 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                //Milesstones
                MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                //Updating the ui text
                LblCapuchinAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
                LblCapuchinCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
                LblCapuchinProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (MonkiAmount[x] >= 100) { BtnCapuchinMax.Visible = true; }
                MonkiUnlocks(MonkiAmount[x]);

            }
        }



        private void BtnCapuchinMax_Click(object sender, EventArgs e)
        {
            int x = 1;
            int i = 0;
            if (Bananas >= MonkiCost[x])
            {
                do
                {
                    Bananas = Bananas - MonkiCost[x];
                    MonkiAmount[x] = MonkiAmount[x] + 1;
                    MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPS = BPS + MProfit[x];
                    //cost algritm
                    MonkiCost[x] = 10000 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                    //Milesstones
                    MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                    MonkiUnlocks(MonkiAmount[x]);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= MonkiCost[x]);
            }
            //Updating the ui text
            LblCapuchinAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
            LblCapuchinCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
            LblCapuchinProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }




        //bompbp

        private void LblBonoboAmount_Click_1(object sender, EventArgs e)
        {
            int x = 2;
            if (Bananas >= MonkiCost[x])
            {
                Bananas = Bananas - MonkiCost[x];
                MonkiAmount[x] = MonkiAmount[x] + 1;
                MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPS = BPS + MProfit[x];
                //cost algritm
                MonkiCost[x] = 2500000 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                //Milesstones
                MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                //Updating the ui text
                LblBonoboAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
                LblBononoCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
                LblBonoboProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (MonkiAmount[x] >= 100) { BtnBonoboMax.Visible = true; }
                MonkiUnlocks(MonkiAmount[x]);

            }
        }



        //bonobomax

        private void BtnBonoboMax_Click(object sender, EventArgs e)
        {
            int x = 2;
            int i = 0;

            if (Bananas >= MonkiCost[x])
            {
                do
                {
                    Bananas = Bananas - MonkiCost[x];
                    MonkiAmount[x] = MonkiAmount[x] + 1;
                    MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPS = BPS + MProfit[x];
                    //cost algritm
                    MonkiCost[x] = 250000 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                    //Milesstones
                    MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                    MonkiUnlocks(MonkiAmount[x]);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= MonkiCost[x]);
            }
            //Updating the ui text
            LblBonoboAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
            LblBononoCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
            LblBonoboProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }



        //orangutan
        private void LblOrangutanAmount_Click(object sender, EventArgs e)
        {
            int x = 3;
            if (Bananas >= MonkiCost[x])
            {
                Bananas = Bananas - MonkiCost[x];
                MonkiAmount[x] = MonkiAmount[x] + 1;
                MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPS = BPS + MProfit[x];
                //cost algritm
                MonkiCost[x] = 5e7 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                //Milesstones
                MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                //Updating the ui text
                LblOrangutanAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
                LblOrangutanCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
                lblOrangutanProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (MonkiAmount[x] >= 100) { BtnOrangutanMax.Visible = true; }
                if (MonkiAmount[x] >= 50) { PBUpgrades.Visible = true; }
                MonkiUnlocks(MonkiAmount[x]);

            }
        }



        //orautanman max

        private void LblOrangutanMax_Click(object sender, EventArgs e)
        {
            int x = 3;
            int i = 0;
            if (Bananas >= MonkiCost[x])
            {
                do
                {
                    Bananas = Bananas - MonkiCost[x];
                    MonkiAmount[x] = MonkiAmount[x] + 1;
                    MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPS = BPS + MProfit[x];
                    //cost algritm
                    MonkiCost[x] = 5e7 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                    //Milesstones
                    MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                    MonkiUnlocks(MonkiAmount[x]);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= MonkiCost[x]);
            }
            //Updating the ui text
            LblOrangutanAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
            LblOrangutanCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
            lblOrangutanProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }




        //banboon

        private void LblBaboonAmount_Click(object sender, EventArgs e)
        {
            int x = 4;
            if (Bananas >= MonkiCost[x])
            {
                Bananas = Bananas - MonkiCost[x];
                MonkiAmount[x] = MonkiAmount[x] + 1;
                MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPS = BPS + MProfit[x];
                //cost algritm
                MonkiCost[x] = 1e9 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                //Milesstones
                MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                //Updating the ui text
                LblBaboonAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
                lblBaboonCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
                LblBaboonProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (MonkiAmount[x] >= 100) { BtnMaxBabbon.Visible = true; }
                MonkiUnlocks(MonkiAmount[x]);

            }
        }
        //baboonmax

        private void BtnMaxBabbon_Click(object sender, EventArgs e)
        {            
            int x = 4;
            int i = 0;

            if (Bananas >= MonkiCost[x])
            {
                do
                {
                    Bananas = Bananas - MonkiCost[x];
                    MonkiAmount[x] = MonkiAmount[x] + 1;
                    MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPS = BPS + MProfit[x];
                    //cost algritm
                    MonkiCost[x] = 1e9 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                    //Milesstones
                    MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                    MonkiUnlocks(MonkiAmount[x]);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= MonkiCost[x]);
            }
            //Updating the ui text
            LblBaboonAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
            lblBaboonCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
            LblBaboonProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }




        //chimp
        private void LblChimpanzeeAmount_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (Bananas >= MonkiCost[x])
            {
                Bananas = Bananas - MonkiCost[x];
                MonkiAmount[x] = MonkiAmount[x] + 1;
                MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPS = BPS + MProfit[x];
                //cost algritm
                MonkiCost[x] = 5e10 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                //Milesstones
                MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                //Updating the ui text
                LblChimpanzeeAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
                LblChimpanzeeCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
                LblChimpanzeeProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (MonkiAmount[x] >= 100) { LblChimpanzeeMax.Visible = true; }
                MonkiUnlocks(MonkiAmount[x]);

            }
        }





        //chimp max

        private void LblChimpanzeeMax_Click(object sender, EventArgs e)
        {
            int x = 5;
            int i = 0;

            if (Bananas >= MonkiCost[x])
            {
                do
                {
                    Bananas = Bananas - MonkiCost[x];
                    MonkiAmount[x] = MonkiAmount[x] + 1;
                    MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPS = BPS + MProfit[x];
                    //cost algritm
                    MonkiCost[x] = 5e10 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                    //Milesstones
                    MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                    MonkiUnlocks(MonkiAmount[x]);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= MonkiCost[x]);
            }
            //Updating the ui text
            LblChimpanzeeAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
            LblChimpanzeeCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
            LblChimpanzeeProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }




        //madrill
        private void FPnlMandrill_Click(object sender, EventArgs e)
        {
            int x = 6;
            if (Bananas >= MonkiCost[x])
            {
                Bananas = Bananas - MonkiCost[x];
                MonkiAmount[x] = MonkiAmount[x] + 1;
                MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPS = BPS + MProfit[x];
                //cost algritm
                MonkiCost[x] = 1e12 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                //Milesstones
                MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                //Updating the ui text
                LblMandrillAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
                LblMandrillCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
                LblMandrillProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (MonkiAmount[x] >= 100) { BtnMandrillMax.Visible = true; }
                MonkiUnlocks(MonkiAmount[x]);

            }
        }




        //mandrillMax
        private void BtnMandrillMax_Click(object sender, EventArgs e)
        {
            int x = 6;
            int i = 0;

            if (Bananas >= MonkiCost[x])
            {
                do
                {
                    Bananas = Bananas - MonkiCost[x];
                    MonkiAmount[x] = MonkiAmount[x] + 1;
                    MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPS = BPS + MProfit[x];
                    //cost algritm
                    MonkiCost[x] = 1e12 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                    //Milesstones
                    MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                    MonkiUnlocks(MonkiAmount[x]);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= MonkiCost[x]);
            }
            //Updating the ui text
            LblMandrillAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
            LblMandrillCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
            LblMandrillProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }



        //gelada
        private void FpnlGelada_Click(object sender, EventArgs e)
        {
            int x = 7;
            if (Bananas >= MonkiCost[x])
            {
                Bananas = Bananas - MonkiCost[x];
                MonkiAmount[x] = MonkiAmount[x] + 1;
                MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPS = BPS + MProfit[x];
                //cost algritm
                MonkiCost[x] = 7.5e14 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                //Milesstones
                MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                //Updating the ui text
                LblGeladaAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
                LblGeladaCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
                LblGeladaProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (MonkiAmount[x] >= 100) { BtnGeladaMax.Visible = true; }
                MonkiUnlocks(MonkiAmount[x]);

            }
        }



        //geladaMax
        private void BtnGeladaMax_Click(object sender, EventArgs e)
        {
            int x = 7;
            int i = 0;

            if (Bananas >= MonkiCost[x])
            {
                do
                {
                    Bananas = Bananas - MonkiCost[x];
                    MonkiAmount[x] = MonkiAmount[x] + 1;
                    MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPS = BPS + MProfit[x];
                    //cost algritm
                    MonkiCost[x] = 7.5e14 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                    //Milesstones
                    MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                    MonkiUnlocks(MonkiAmount[x]);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= MonkiCost[x]);
            }
            //Updating the ui text
            LblGeladaAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
            LblGeladaCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
            LblGeladaProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }





        //gorilla

        private void FpnlGorilla_Click(object sender, EventArgs e)
        {
            int x = 8;
            if (Bananas >= MonkiCost[x])
            {
                Bananas = Bananas - MonkiCost[x];
                MonkiAmount[x] = MonkiAmount[x] + 1;
                MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPS = BPS + MProfit[x];
                //cost algritm
                MonkiCost[x] = 2.5e17 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                //Milesstones
                MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                //Updating the ui text
                LblGorillaAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
                LblGorillaCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
                LblGorillaProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (MonkiAmount[x] >= 100) { BtnGorillaMax.Visible = true; }
                MonkiUnlocks(MonkiAmount[x]);

            }
        }

  


        //gorilla max
        private void BtnGorillaMax_Click(object sender, EventArgs e)
        {
            int x = 8;
            int i = 0;

            if (Bananas >= MonkiCost[x])
            {
                do
                {
                    Bananas = Bananas - MonkiCost[x];
                    MonkiAmount[x] = MonkiAmount[x] + 1;
                    MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPS = BPS + MProfit[x];
                    //cost algritm
                    MonkiCost[x] = 2.5e17 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                    //Milesstones
                    MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                    MonkiUnlocks(MonkiAmount[x]);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= MonkiCost[x]);
            }
            //Updating the ui text
            LblGorillaAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
            LblGorillaCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
            LblGorillaProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }



        //homo hablis
        private void FpnlHomoHabilis_Click(object sender, EventArgs e)
        {
            int x = 9;
            if (Bananas >= MonkiCost[x])
            {
                Bananas = Bananas - MonkiCost[x];
                MonkiAmount[x] = MonkiAmount[x] + 1;
                MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPS = BPS + MProfit[x];
                //cost algritm
                MonkiCost[x] = 2.5e20 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                //Milesstones
                MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                //Updating the ui text
                LblHomoHabilisAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
                LblHomoHabilisCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
                LblHomoHabilisProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (MonkiAmount[x] >= 100) { BtmHomoHabilisMax.Visible = true; }
                MonkiUnlocks(MonkiAmount[x]);

            }
        }




        //homohablis max
        private void BtmHomoHabilisMax_Click(object sender, EventArgs e)
        {
            int x = 9;
            int i = 0;

            if (Bananas >= MonkiCost[x])
            {
                do
                {
                    Bananas = Bananas - MonkiCost[x];
                    MonkiAmount[x] = MonkiAmount[x] + 1;
                    MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPS = BPS + MProfit[x];
                    //cost algritm
                    MonkiCost[x] = 2.5e20 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                    //Milesstones
                    MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                    MonkiUnlocks(MonkiAmount[x]);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= MonkiCost[x]);
            }
            //Updating the ui text
            LblHomoHabilisAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
            LblHomoHabilisCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
            LblHomoHabilisProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }

 


        //homo erectus 

        private void FpnlHomoErectus_Click(object sender, EventArgs e)
        {
            int x = 10;
            if (Bananas >= MonkiCost[x])
            {
                Bananas = Bananas - MonkiCost[x];
                MonkiAmount[x] = MonkiAmount[x] + 1;
                MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPS = BPS + MProfit[x];
                //cost algritm
                MonkiCost[x] = 1e22 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                //Milesstones
                MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                //Updating the ui text
                LblHomoErectusAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
                LblHomoErectusCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
                LblHomoErectusProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (MonkiAmount[x] >= 100) { BtnHomoErectusMax.Visible = true; }
                MonkiUnlocks(MonkiAmount[x]);

            }
        }



        //homo erectus MAx
        private void BtnHomoErectusMax_Click(object sender, EventArgs e)
        {
            int x = 10;
            int i = 0;

            if (Bananas >= MonkiCost[x])
            {
                do
                {
                    Bananas = Bananas - MonkiCost[x];
                    MonkiAmount[x] = MonkiAmount[x] + 1;
                    MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPS = BPS + MProfit[x];
                    //cost algritm
                    MonkiCost[x] = 1e22 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                    //Milesstones
                    MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                    MonkiUnlocks(MonkiAmount[x]);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= MonkiCost[x]);
            }
            //Updating the ui text
            LblHomoErectusAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
            LblHomoErectusCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
            LblHomoErectusProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }






        //homo sapien
        private void FpnlHomoSapien_Click(object sender, EventArgs e)
        {
            int x = 11;
            if (Bananas >= MonkiCost[x])
            {
                Bananas = Bananas - MonkiCost[x];
                MonkiAmount[x] = MonkiAmount[x] + 1;
                MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                BPS = BPS + MProfit[x];
                //cost algritm
                MonkiCost[x] = 1e27 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                //Milesstones
                MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                //Updating the ui text
                LblHomoSapienAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
                LblHomoSapienCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
                LblHomoSapienProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
                LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
                if (MonkiAmount[x] >= 100) { BtnHomoSapienMax.Visible = true; }
                if (MonkiAmount[x] >= 250) { BtnPrestige.Visible = true; }
                MonkiUnlocks(MonkiAmount[x]);

            }
        }



        //homo sapien MAx

        private void BtnHomoSapienMax_Click(object sender, EventArgs e)
        {
            int x = 11;
            int i = 0;

            if (Bananas >= MonkiCost[x])
            {
                do
                {
                    Bananas = Bananas - MonkiCost[x];
                    MonkiAmount[x] = MonkiAmount[x] + 1;
                    MProfit[x] = MonkiProfit[x] * (1 + (Intelligence * Prestige_Multi));
                    BPS = BPS + MProfit[x];
                    //cost algritm
                    MonkiCost[x] = 1e22 * (Math.Pow((1 + (CostMultiplier) / (1 + (MonkiAmount[x]) / (5000))), MonkiAmount[x]));
                    //Milesstones
                    MonkiProfit[x] = MilesStonesMulti(MonkiAmount[x], MonkiProfit[x]);
                    MonkiUnlocks(MonkiAmount[x]);
                    i++;
                    if (i == 100)
                    {
                        i = 0;
                        break;
                    }
                } while (Bananas >= MonkiCost[x]);
            }
            //Updating the ui text
            LblHomoSapienAmount.Text = ToSuffix(MonkiAmount[x], "0.00", false);
            LblHomoSapienCost.Text = "🍌" + ToSuffix(MonkiCost[x], "0.00", false);
            LblHomoSapienProfit.Text = "+ " + ToSuffix(MProfit[x], "0", false) + " BPS";
            LblBananas.Text = ToSuffix(Bananas, "0.00", true) + " 🍌";
        }

        private void BtnPrestige_Click(object sender, EventArgs e)
        {
            FPnlHelp.Visible = false;
            FPnlMonkiHands.Visible = false;
            FPlMonkisShop.Visible = false;
            FPnlUpgradesMain.Visible = false;
            PnlPrestige.Visible = true;
            LblTab.Text = "Prestige";
        }











        // for the upgrades
        private void PnlUpgrade1_Click(object sender, EventArgs e)
        {
            Upgr_Unlocks(true);

        }





         //prestige buttons is pressed
        private void BtnPrestigeNow_Click(object sender, EventArgs e)
        {
            prestiges(true, false);
        }



    }




}


