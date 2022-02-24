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
    public partial class SplashScreen : Form
    {


        public SplashScreen()
        {
            InitializeComponent();
        }


        public string current_user, Themes;


        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
            TimePB.Start();
            PnlProgress.Width = 0;

            try
            {
                System.IO.Directory.CreateDirectory("C:\\KongolianOS\\");

                var newperson = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\Update_1-2-12.ID");
                newperson.Close();

                var test = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\ID.ID");
                string Test1 = test.ReadLine();
                test.Close();

                LblID.Text = Test1;



            }
            //REMEBER TO DO BOTH OF THE CATCHES!!!!
            //REMEBER TO DO BOTH OF THE CATCHES!!!!
            //REMEBER TO DO BOTH OF THE CATCHES!!!!
            //REMEBER TO DO BOTH OF THE CATCHES!!!!
            //REMEBER TO DO BOTH OF THE CATCHES!!!!
            //REMEBER TO DO BOTH OF THE CATCHES!!!!




            catch (DirectoryNotFoundException)
            {
                DirectoryInfo di = new DirectoryInfo(@"C:\KongolianOS");


                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);

                }






                System.IO.Directory.CreateDirectory("C:\\KongolianOS\\Sys4\\DataSets");




                var ft = new System.IO.StreamWriter("C:\\KongolianOS\\Sys4\\FirstTime.ID");
                ft.Write("True");
                ft.Close();







                System.IO.Directory.CreateDirectory("C:\\KongolianOS\\Users\\" + "Temp\\.SysData");


                var sw = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + "Temp" + "\\.SysData\\Login.ID");
                sw.Write("Temp" + "\n" + "UABhAHMAcwAxADIAMwA=");
                sw.Close();

                File.WriteAllText("C:\\KongolianOS\\Sys4\\DataSets\\UpdateLog.ID", "");
                File.WriteAllText("C:\\KongolianOS\\Sys4\\DataSets\\AboutUs.ID", "");
                File.WriteAllText("C:\\KongolianOS\\Sys4\\DataSets\\FutureUpdates.ID", "");
                File.WriteAllText("C:\\KongolianOS\\Sys4\\DataSets\\Version.ID", "");
                File.WriteAllText("C:\\KongolianOS\\Sys4\\DataSets\\Devs.ID", "");









                using (StreamWriter UpdateLog = File.AppendText("C:\\KongolianOS\\Sys4\\DataSets\\UpdateLog.ID"))
                {

                    UpdateLog.WriteLine("KongolianOS 1.1.0  -  Login");
                    UpdateLog.WriteLine("> Added Splash Screen");
                    UpdateLog.WriteLine("> Added Login Screen");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.1  - Users ");
                    UpdateLog.WriteLine("> Added Users");
                    UpdateLog.WriteLine("> Added User Directories");
                    UpdateLog.WriteLine("> Password Files");
                    UpdateLog.WriteLine("> Small changes to Splash Screen & login Screen");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.2  - UI");
                    UpdateLog.WriteLine("> Worked On Main OS screen");
                    UpdateLog.WriteLine("    - Added Date and Time");
                    UpdateLog.WriteLine("    - Panels for Notifications Work");
                    UpdateLog.WriteLine("    - UI changed for User Settings");
                    UpdateLog.WriteLine("    - Added Taskbar With Icons");
                    UpdateLog.WriteLine("    - More Apps Panel ");
                    UpdateLog.WriteLine("    - Linked buttons to Apps");
                    UpdateLog.WriteLine("> Bug Fixes");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.3 - Calculator & UI");
                    UpdateLog.WriteLine("> Made Calculator Work");
                    UpdateLog.WriteLine("> Added Shutdown, Restart and Locking Mechanism");
                    UpdateLog.WriteLine("> Fixed  a bug that did not allow people to login for the first time");
                    UpdateLog.WriteLine("> Made it display what user account you are on");
                    UpdateLog.WriteLine("> Cleaner And minimalistic icons Added");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.4 - Directories & Notepad");
                    UpdateLog.WriteLine("> Users have their own personal documents");
                    UpdateLog.WriteLine("> Made a notepad application");
                    UpdateLog.WriteLine("   - Open files");
                    UpdateLog.WriteLine("   - Create files");
                    UpdateLog.WriteLine("   - Text manipilation");
                    UpdateLog.WriteLine("> Bug fixes - Temp user showing up in users");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.5 - Web Browser");
                    UpdateLog.WriteLine("> Added A web-browser");
                    UpdateLog.WriteLine("> Linked searching works");
                    UpdateLog.WriteLine("> Fixed a bug - Repeating users in User settings");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.6");
                    UpdateLog.WriteLine("> Added Update Log in settings");
                    UpdateLog.WriteLine("> Added About Us in settings");
                    UpdateLog.WriteLine("> Added Future Updates in settings");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.7 - File Explorer");
                    UpdateLog.WriteLine("> File Explorer has been made");
                    UpdateLog.WriteLine("  - Can only see the KongolianOS Directory");
                    UpdateLog.WriteLine("  - Can't access .ID files ");
                    UpdateLog.WriteLine("  - Shows Name, File Type and Date Modified");
                    UpdateLog.WriteLine("  - Shows a Folder Tree and File Tree with Directories");
                    UpdateLog.WriteLine("> Fixed a bug - future updates sometimes repeated in text document");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.8 - Directories & UI");
                    UpdateLog.WriteLine("> Fixed the UI of File Explorer ");
                    UpdateLog.WriteLine("  - Can only see the KongolianOS Directory");
                    UpdateLog.WriteLine("  - Can't access .ID files ");
                    UpdateLog.WriteLine("  - Shows Name, File Type and Date Modified");
                    UpdateLog.WriteLine("  - Shows a Folder Tree and File Tree with Directories");
                    UpdateLog.WriteLine("> Fixed a bug - future updates sometimes repeated in text document");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.9 - Minor changes");
                    UpdateLog.WriteLine("> Fixed colour of the UI for the File Explorer ");
                    UpdateLog.WriteLine("> Added version Number into settings");
                    UpdateLog.WriteLine("> Added Section for Developers in setttings");
                    UpdateLog.WriteLine("> Changed the main UI around");
                    UpdateLog.WriteLine("> Small Bug Fixes & Attention To Detail");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.10 - Last update for 1.0.x Huge Bug Fixes!");
                    UpdateLog.WriteLine("> Added Asyem Password encryption");
                    UpdateLog.WriteLine("> repetition in Dev documents ");
                    UpdateLog.WriteLine("> Better Validation on login screen");
                    UpdateLog.WriteLine("> Fixed crash when you entered no details");
                    UpdateLog.WriteLine("> Processes Close, less CPU & RAM hogging");
                    UpdateLog.WriteLine("> Font Fixed in Date & Time");
                    UpdateLog.WriteLine("> User List updates straight away");
                    UpdateLog.WriteLine("> Can now press enter to login");
                    UpdateLog.WriteLine("> In calculator made it display the full problems");
                    UpdateLog.WriteLine("> Gramatical Errors");
                    UpdateLog.WriteLine("> Other bugs fixed with main UI and users");
                    UpdateLog.WriteLine("> People can open multiple interfaces");
                    UpdateLog.WriteLine("> Fixed Icon in Taskbar");
                    UpdateLog.WriteLine("> Background processes fixed");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("Thanks to everyone that Beta tested the OS");
                    UpdateLog.WriteLine("Beta Testers: ");
                    UpdateLog.WriteLine("Lillie");
                    UpdateLog.WriteLine("Gamerboy195");
                    UpdateLog.WriteLine("Toakley");
                    UpdateLog.WriteLine("JakeTheMan");
                    UpdateLog.WriteLine("Olivia");
                    UpdateLog.WriteLine("Faze_Ikonik");
                    UpdateLog.WriteLine("Arch");
                    UpdateLog.WriteLine("Zaven");
                    UpdateLog.WriteLine("Marian");
                    UpdateLog.WriteLine("Warshiptiger");
                    UpdateLog.WriteLine("Venus");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.1 - Appearance Customisation");
                    UpdateLog.WriteLine("> Added formats to notepad (Colour &ver  Font)");
                    UpdateLog.WriteLine("> Background Settings");
                    UpdateLog.WriteLine("  -  Choose from 4 cool Backgrounds!");
                    UpdateLog.WriteLine("  -  Choose from 4 Display Formats");
                    UpdateLog.WriteLine("      -  Tile");
                    UpdateLog.WriteLine("      -  Zoom");
                    UpdateLog.WriteLine("      -  Stretch");
                    UpdateLog.WriteLine("      -  Center");
                    UpdateLog.WriteLine("> Background Colours");
                    UpdateLog.WriteLine("  - Set 21 Preset Colours");
                    UpdateLog.WriteLine("  - RGB Custom Colours");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.2 - Directory Management");
                    UpdateLog.WriteLine("> Each user has a personalised folder for their account settings");
                    UpdateLog.WriteLine("> Backgrounds are now local instead of global");
                    UpdateLog.WriteLine("> Temp User account can't do anything");
                    UpdateLog.WriteLine("> Bug fixes with RGB Setter");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.3 - Time Management");
                    UpdateLog.WriteLine("> Added Date & Time Formats");
                    UpdateLog.WriteLine("> Revamped Time UI in main OS");
                    UpdateLog.WriteLine("> Fixed a bug that only stored a specific format");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.4 - Theme Update");
                    UpdateLog.WriteLine("> Long awaited update, Light theme and dark themes");
                    UpdateLog.WriteLine("   - Can Enable light theme in background / colour settings");
                    UpdateLog.WriteLine("   - All data is saved on perspective user directories, so theme's don't clash with eachother.");
                    UpdateLog.WriteLine("   - Dark theme is the Default theme");
                    //UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("> Small UI altercations");
                    UpdateLog.WriteLine("> Small Bugs fixed in Time Management");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.5 - Task Manager");
                    UpdateLog.WriteLine("> Added Task Manager");
                    UpdateLog.WriteLine("   - see all apps running");
                    UpdateLog.WriteLine("   - Start And force close Apps");
                    UpdateLog.WriteLine("   - See all background processes");
                    UpdateLog.WriteLine("   - Theme added to task manager");
                    UpdateLog.WriteLine("> Added New cursor, designed by Lillie");
                    UpdateLog.WriteLine("> UI changes on Main OS");
                    UpdateLog.WriteLine("> Background bugs - When in Light theme mode the background image and colors are over written");
                    UpdateLog.WriteLine("> Fixed Taskbar - Gradient of the taskbar was showing, now removed");
                    UpdateLog.WriteLine("> Made it so the user needed to restart for theme changed to take place.");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.6 - AutoClicker");
                    UpdateLog.WriteLine("> Added An Auto-Clicker");
                    UpdateLog.WriteLine("  - Pick mouse click intervels");
                    UpdateLog.WriteLine("  - Up To 1000 CPS (If your PC can register it)");
                    UpdateLog.WriteLine("  - Displays the amount of clicks");
                    UpdateLog.WriteLine("  - Small, compact and upfront for easy access");
                    UpdateLog.WriteLine("> Everyone that downloads KongolianOS has a Unique ID");
                    UpdateLog.WriteLine("> If you are an existing user and their is a new update, the directories auto delete and update!");
                    UpdateLog.WriteLine("> Fixed a bug were some applications did not close in task manager!");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.7 - TicTacToe");
                    UpdateLog.WriteLine("> Added An TicTacToe 2 Player version");
                    UpdateLog.WriteLine("  - New Sleek and clean UI");
                    UpdateLog.WriteLine("  - Play with 2 players");
                    UpdateLog.WriteLine("  - Player Point System");
                    UpdateLog.WriteLine("> Fixed certain apps not showing in task manager");
                    UpdateLog.WriteLine("> Auto clicker bug, If value is '0' the program crashes");
                    UpdateLog.WriteLine("> Bug, directory is not being made for new people.");
                    UpdateLog.WriteLine("> Updated TaskManager Icon");
                    UpdateLog.WriteLine("> Fixed lock,restart and shutdown bug");
                    UpdateLog.WriteLine("> apps still shown when OS is locked");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.8 - Banana Clicker");
                    UpdateLog.WriteLine("> One Player Mode TicTacToe");
                    UpdateLog.WriteLine(" - Made a small AI");
                    UpdateLog.WriteLine(" - Faster speeds for 2 player");
                    UpdateLog.WriteLine("> Banana Clicker Game");
                    UpdateLog.WriteLine(" - Updates can be found in the game");
                    UpdateLog.WriteLine(">Small Bug Fixes");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.9 - Banana Clicker");
                    UpdateLog.WriteLine("> Banana Clicker Game Update v1.2");
                    UpdateLog.WriteLine(" - Updates can be found in the game");
                    UpdateLog.WriteLine("> Gui update in login screen & inputs clear when they are incorrect");
                    UpdateLog.WriteLine(">Small Bug Fixes");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.10 - Banana Clicker");
                    UpdateLog.WriteLine("> Banana Clicker Game Update v1.2");
                    UpdateLog.WriteLine(" - Updates can be found in the game");
                    UpdateLog.WriteLine("> File Managment changed around");
                    UpdateLog.WriteLine(">Small Bug Fixes");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.11 - Banana Clicker");
                    UpdateLog.WriteLine("> Banana Clicker Game Update v1.3");
                    UpdateLog.WriteLine(" - Updates can be found in the game");
                    UpdateLog.WriteLine(">Small Bug Fixes");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.12 - Bugs");
                    UpdateLog.WriteLine("> Fixed a few bugs with the launcher");
                    UpdateLog.WriteLine(" Made the ui for the game look cleaner and much more.");
                    UpdateLog.WriteLine(">Small Bug Fixes");














                    UpdateLog.Close();

                    //UpdateLog.WriteLine("");

                }


                using (StreamWriter AboutUs = File.AppendText("C:\\KongolianOS\\Sys4\\DataSets\\AboutUs.ID"))
                {
                    AboutUs.WriteLine("Hello!");
                    AboutUs.WriteLine("My name is Zeeshan or Drkong, I am 17 years old and KongolianOS is one of my projects.");
                    AboutUs.WriteLine("KongolainOS is a small project which I started 2 years ago, a project that did not get finished. I decided to revisit the project and complety start everything again.");
                    AboutUs.WriteLine("I programmed the pervious version of the OS in Visual Basic, Which is outdated. So, I Started the new project in C# language as it's more modern and updated.");
                    AboutUs.WriteLine("This OS is BAD. I'm making this for fun and I need to Learn the C programming language for university.");
                    AboutUs.WriteLine("");
                    AboutUs.WriteLine("I've gridned this project for less than a week, starting on the 4th of june. Right know it's 9th, and I've completed most aspects of the OS.");
                    AboutUs.WriteLine("");
                    AboutUs.WriteLine("Thanks to Lillie who designed all the icons and logos :) ");
                    AboutUs.WriteLine("And thanks to everyone who looked at the videos I sent them to check out the OS and people who've helped me out.");
                    AboutUs.WriteLine("");
                    AboutUs.WriteLine("I have many future Plans for this OS. ");
                    AboutUs.WriteLine("");
                    AboutUs.WriteLine("<3");
                    AboutUs.Close();

                }


                using (StreamWriter FutureUpdates = File.AppendText("C:\\KongolianOS\\Sys4\\DataSets\\FutureUpdates.ID"))
                {
                    FutureUpdates.Flush();
                    //FutureUpdates.WriteLine("> Adding formats to notepad");
                    //FutureUpdates.WriteLine("> Background Settings");
                    //FutureUpdates.WriteLine("> Colours Settings");
                    //FutureUpdates.WriteLine("> Date and Time formats");
                    //FutureUpdates.WriteLine("> Mini Calander");
                    //FutureUpdates.WriteLine("> Light Theme / Dark Themes");
                    //FutureUpdates.WriteLine("> Mini Task Manager");
                    //FutureUpdates.WriteLine("> TicTacToe");
                    //FutureUpdates.WriteLine("> An auto-Clicker");
                    //FutureUpdates.WriteLine("> Adding scientific calculator");
                    //FutureUpdates.WriteLine("> Idle Small Clicker Game");
                    //FutureUpdates.WriteLine("> Make Apps Selection customisable");
                    //FutureUpdates.WriteLine("> Make the web-browser more functional and less laggy");
                    FutureUpdates.WriteLine("This might be the Final update. Not sure yet.");

                    //FutureUpdates.WriteLine("> The Updates above might or might not happen depending on other projects I am working on.");
                    FutureUpdates.Close();
                }

                using (StreamWriter Version = File.AppendText("C:\\KongolianOS\\Sys4\\DataSets\\Version.ID"))
                {
                    Version.WriteLine("KongolianOS 1.2.12");
                    Version.Close();
                }

                using (StreamWriter Dev = File.AppendText("C:\\KongolianOS\\Sys4\\DataSets\\Devs.ID"))
                {
                    Dev.WriteLine("Want to Develop A small application for Kongolian OS?");
                    Dev.WriteLine("");
                    Dev.WriteLine("To get started make a singled form Application, make sure that this app does not go above 1 form. Unless the app is super good.");
                    Dev.WriteLine("Also try to make sure that the app is not linked to the KongolianOS, if you need to execute code on the splash screen for file / directory creation, make a class and add all that data to it and I will try to implement it.");
                    Dev.WriteLine("");
                    Dev.WriteLine("Message me on discord for more details");
                    Dev.WriteLine("Drkong#9054");
                    Dev.WriteLine("");
                    Dev.WriteLine("Also if you are an artist please message me");
                    Dev.WriteLine("I'm looking forward to working with you guys :)");
                    Dev.WriteLine("Thanks <3 - Zeeshan Aka Drkong");
                    Dev.Close();
                }





                using (StreamWriter w = File.AppendText("C:\\KongolianOS\\Users\\" + "Users.ID"))
                {


                    //w.WriteLine("Temp");
                }


                using (StreamWriter w = File.AppendText("C:\\KongolianOS\\Sys4\\Update_1-2-12.ID"))
                {


                    //w.WriteLine("Temp");
                }

                try
                {
                    var test = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\ID.ID");
                    string Test1 = test.ReadLine();
                    test.Close();

                    LblID.Text = Test1;

                }
                catch (FileNotFoundException)
                {
                    string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    string small_alphabets = "abcdefghijklmnopqrstuvwxyz";
                    string numbers = "1234567890";
                    string eee = alphabets + small_alphabets + numbers;
                    string id = string.Empty;
                    //    Ab123-a1
                    string character = string.Empty;


                    for (int i = 0; i < 3; i++)
                    {
                        do
                        {
                            int index = new Random().Next(0, eee.Length);
                            character = eee.ToCharArray()[index].ToString();
                        } while (id.IndexOf(character) != -1);
                        id += character;
                    }
                    id += "-";
                    for (int i = 0; i < 3; i++)
                    {
                        do
                        {
                            int index = new Random().Next(0, eee.Length);
                            character = eee.ToCharArray()[index].ToString();
                        } while (id.IndexOf(character) != -1);
                        id += character;
                    }



                    var ID = new System.IO.StreamWriter("C:\\KongolianOS\\Sys4\\ID.ID");
                    ID.Write(id);
                    ID.Close();



                    var test = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\ID.ID");
                    string Test1 = test.ReadLine();
                    test.Close();

                    LblID.Text = Test1;

                    TimePB.Enabled = false;
                    if (MessageBox.Show("Press 'OK' To Update KongolianOS", "New Update!", MessageBoxButtons.OK) == DialogResult.OK)

                    {

                        Application.Restart();


                    }




                }
            }
            catch (FileNotFoundException)
            {


                DirectoryInfo di = new DirectoryInfo(@"C:\KongolianOS");


                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);

                }






                System.IO.Directory.CreateDirectory("C:\\KongolianOS\\Sys4\\DataSets");




                var ft = new System.IO.StreamWriter("C:\\KongolianOS\\Sys4\\FirstTime.ID");
                ft.Write("True");
                ft.Close();







                System.IO.Directory.CreateDirectory("C:\\KongolianOS\\Users\\" + "Temp\\.SysData");


                var sw = new System.IO.StreamWriter("C:\\KongolianOS\\Users\\" + "Temp" + "\\.SysData\\Login.ID");
                sw.Write("Temp" + "\n" + "UABhAHMAcwAxADIAMwA=");
                sw.Close();

                File.WriteAllText("C:\\KongolianOS\\Sys4\\DataSets\\UpdateLog.ID", "");
                File.WriteAllText("C:\\KongolianOS\\Sys4\\DataSets\\AboutUs.ID", "");
                File.WriteAllText("C:\\KongolianOS\\Sys4\\DataSets\\FutureUpdates.ID", "");
                File.WriteAllText("C:\\KongolianOS\\Sys4\\DataSets\\Version.ID", "");
                File.WriteAllText("C:\\KongolianOS\\Sys4\\DataSets\\Devs.ID", "");









                using (StreamWriter UpdateLog = File.AppendText("C:\\KongolianOS\\Sys4\\DataSets\\UpdateLog.ID"))
                {

                    UpdateLog.WriteLine("KongolianOS 1.1.0  -  Login");
                    UpdateLog.WriteLine("> Added Splash Screen");
                    UpdateLog.WriteLine("> Added Login Screen");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.1  - Users ");
                    UpdateLog.WriteLine("> Added Users");
                    UpdateLog.WriteLine("> Added User Directories");
                    UpdateLog.WriteLine("> Password Files");
                    UpdateLog.WriteLine("> Small changes to Splash Screen & login Screen");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.2  - UI");
                    UpdateLog.WriteLine("> Worked On Main OS screen");
                    UpdateLog.WriteLine("    - Added Date and Time");
                    UpdateLog.WriteLine("    - Panels for Notifications Work");
                    UpdateLog.WriteLine("    - UI changed for User Settings");
                    UpdateLog.WriteLine("    - Added Taskbar With Icons");
                    UpdateLog.WriteLine("    - More Apps Panel ");
                    UpdateLog.WriteLine("    - Linked buttons to Apps");
                    UpdateLog.WriteLine("> Bug Fixes");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.3 - Calculator & UI");
                    UpdateLog.WriteLine("> Made Calculator Work");
                    UpdateLog.WriteLine("> Added Shutdown, Restart and Locking Mechanism");
                    UpdateLog.WriteLine("> Fixed  a bug that did not allow people to login for the first time");
                    UpdateLog.WriteLine("> Made it display what user account you are on");
                    UpdateLog.WriteLine("> Cleaner And minimalistic icons Added");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.4 - Directories & Notepad");
                    UpdateLog.WriteLine("> Users have their own personal documents");
                    UpdateLog.WriteLine("> Made a notepad application");
                    UpdateLog.WriteLine("   - Open files");
                    UpdateLog.WriteLine("   - Create files");
                    UpdateLog.WriteLine("   - Text manipilation");
                    UpdateLog.WriteLine("> Bug fixes - Temp user showing up in users");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.5 - Web Browser");
                    UpdateLog.WriteLine("> Added A web-browser");
                    UpdateLog.WriteLine("> Linked searching works");
                    UpdateLog.WriteLine("> Fixed a bug - Repeating users in User settings");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.6");
                    UpdateLog.WriteLine("> Added Update Log in settings");
                    UpdateLog.WriteLine("> Added About Us in settings");
                    UpdateLog.WriteLine("> Added Future Updates in settings");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.7 - File Explorer");
                    UpdateLog.WriteLine("> File Explorer has been made");
                    UpdateLog.WriteLine("  - Can only see the KongolianOS Directory");
                    UpdateLog.WriteLine("  - Can't access .ID files ");
                    UpdateLog.WriteLine("  - Shows Name, File Type and Date Modified");
                    UpdateLog.WriteLine("  - Shows a Folder Tree and File Tree with Directories");
                    UpdateLog.WriteLine("> Fixed a bug - future updates sometimes repeated in text document");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.8 - Directories & UI");
                    UpdateLog.WriteLine("> Fixed the UI of File Explorer ");
                    UpdateLog.WriteLine("  - Can only see the KongolianOS Directory");
                    UpdateLog.WriteLine("  - Can't access .ID files ");
                    UpdateLog.WriteLine("  - Shows Name, File Type and Date Modified");
                    UpdateLog.WriteLine("  - Shows a Folder Tree and File Tree with Directories");
                    UpdateLog.WriteLine("> Fixed a bug - future updates sometimes repeated in text document");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.9 - Minor changes");
                    UpdateLog.WriteLine("> Fixed colour of the UI for the File Explorer ");
                    UpdateLog.WriteLine("> Added version Number into settings");
                    UpdateLog.WriteLine("> Added Section for Developers in setttings");
                    UpdateLog.WriteLine("> Changed the main UI around");
                    UpdateLog.WriteLine("> Small Bug Fixes & Attention To Detail");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.1.10 - Last update for 1.0.x Huge Bug Fixes!");
                    UpdateLog.WriteLine("> Added Asyem Password encryption");
                    UpdateLog.WriteLine("> repetition in Dev documents ");
                    UpdateLog.WriteLine("> Better Validation on login screen");
                    UpdateLog.WriteLine("> Fixed crash when you entered no details");
                    UpdateLog.WriteLine("> Processes Close, less CPU & RAM hogging");
                    UpdateLog.WriteLine("> Font Fixed in Date & Time");
                    UpdateLog.WriteLine("> User List updates straight away");
                    UpdateLog.WriteLine("> Can now press enter to login");
                    UpdateLog.WriteLine("> In calculator made it display the full problems");
                    UpdateLog.WriteLine("> Gramatical Errors");
                    UpdateLog.WriteLine("> Other bugs fixed with main UI and users");
                    UpdateLog.WriteLine("> People can open multiple interfaces");
                    UpdateLog.WriteLine("> Fixed Icon in Taskbar");
                    UpdateLog.WriteLine("> Background processes fixed");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("Thanks to everyone that Beta tested the OS");
                    UpdateLog.WriteLine("Beta Testers: ");
                    UpdateLog.WriteLine("Lillie");
                    UpdateLog.WriteLine("Gamerboy195");
                    UpdateLog.WriteLine("Toakley");
                    UpdateLog.WriteLine("JakeTheMan");
                    UpdateLog.WriteLine("Olivia");
                    UpdateLog.WriteLine("Faze_Ikonik");
                    UpdateLog.WriteLine("Arch");
                    UpdateLog.WriteLine("Zaven");
                    UpdateLog.WriteLine("Marian");
                    UpdateLog.WriteLine("Warshiptiger");
                    UpdateLog.WriteLine("Venus");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.1 - Appearance Customisation");
                    UpdateLog.WriteLine("> Added formats to notepad (Colour &ver  Font)");
                    UpdateLog.WriteLine("> Background Settings");
                    UpdateLog.WriteLine("  -  Choose from 4 cool Backgrounds!");
                    UpdateLog.WriteLine("  -  Choose from 4 Display Formats");
                    UpdateLog.WriteLine("      -  Tile");
                    UpdateLog.WriteLine("      -  Zoom");
                    UpdateLog.WriteLine("      -  Stretch");
                    UpdateLog.WriteLine("      -  Center");
                    UpdateLog.WriteLine("> Background Colours");
                    UpdateLog.WriteLine("  - Set 21 Preset Colours");
                    UpdateLog.WriteLine("  - RGB Custom Colours");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.2 - Directory Management");
                    UpdateLog.WriteLine("> Each user has a personalised folder for their account settings");
                    UpdateLog.WriteLine("> Backgrounds are now local instead of global");
                    UpdateLog.WriteLine("> Temp User account can't do anything");
                    UpdateLog.WriteLine("> Bug fixes with RGB Setter");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.3 - Time Management");
                    UpdateLog.WriteLine("> Added Date & Time Formats");
                    UpdateLog.WriteLine("> Revamped Time UI in main OS");
                    UpdateLog.WriteLine("> Fixed a bug that only stored a specific format");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.4 - Theme Update");
                    UpdateLog.WriteLine("> Long awaited update, Light theme and dark themes");
                    UpdateLog.WriteLine("   - Can Enable light theme in background / colour settings");
                    UpdateLog.WriteLine("   - All data is saved on perspective user directories, so theme's don't clash with eachother.");
                    UpdateLog.WriteLine("   - Dark theme is the Default theme");
                    //UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("> Small UI altercations");
                    UpdateLog.WriteLine("> Small Bugs fixed in Time Management");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.5 - Task Manager");
                    UpdateLog.WriteLine("> Added Task Manager");
                    UpdateLog.WriteLine("   - see all apps running");
                    UpdateLog.WriteLine("   - Start And force close Apps");
                    UpdateLog.WriteLine("   - See all background processes");
                    UpdateLog.WriteLine("   - Theme added to task manager");
                    UpdateLog.WriteLine("> Added New cursor, designed by Lillie");
                    UpdateLog.WriteLine("> UI changes on Main OS");
                    UpdateLog.WriteLine("> Background bugs - When in Light theme mode the background image and colors are over written");
                    UpdateLog.WriteLine("> Fixed Taskbar - Gradient of the taskbar was showing, now removed");
                    UpdateLog.WriteLine("> Made it so the user needed to restart for theme changed to take place.");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.6 - AutoClicker");
                    UpdateLog.WriteLine("> Added An Auto-Clicker");
                    UpdateLog.WriteLine("  - Pick mouse click intervels");
                    UpdateLog.WriteLine("  - Up To 1000 CPS (If your PC can register it)");
                    UpdateLog.WriteLine("  - Displays the amount of clicks");
                    UpdateLog.WriteLine("  - Small, compact and upfront for easy access");
                    UpdateLog.WriteLine("> Everyone that downloads KongolianOS has a Unique ID");
                    UpdateLog.WriteLine("> If you are an existing user and their is a new update, the directories auto delete and update!");
                    UpdateLog.WriteLine("> Fixed a bug were some applications did not close in task manager!");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.7 - TicTacToe");
                    UpdateLog.WriteLine("> Added An TicTacToe 2 Player version");
                    UpdateLog.WriteLine("  - New Sleek and clean UI");
                    UpdateLog.WriteLine("  - Play with 2 players");
                    UpdateLog.WriteLine("  - Player Point System");
                    UpdateLog.WriteLine("> Fixed certain apps not showing in task manager");
                    UpdateLog.WriteLine("> Auto clicker bug, If value is '0' the program crashes");
                    UpdateLog.WriteLine("> Bug, directory is not being made for new people.");
                    UpdateLog.WriteLine("> Updated TaskManager Icon");
                    UpdateLog.WriteLine("> Fixed lock,restart and shutdown bug");
                    UpdateLog.WriteLine("> apps still shown when OS is locked");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.8 - TicTacToe Ai");
                    UpdateLog.WriteLine("> One Player Mode TicTacToe");
                    UpdateLog.WriteLine(" - Made a small AI");
                    UpdateLog.WriteLine(" - Faster speeds for 2 player");
                    UpdateLog.WriteLine("> Banana Clicker Game");
                    UpdateLog.WriteLine(" - Updates can be found in the game");
                    UpdateLog.WriteLine(">Small Bug Fixes");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.9 - Banana Clicker");
                    UpdateLog.WriteLine("> Banana Clicker Game Update v1.2");
                    UpdateLog.WriteLine(" - Updates can be found in the game");
                    UpdateLog.WriteLine("> Gui update in login screen & inputs clear when they are incorrect");
                    UpdateLog.WriteLine(">Small Bug Fixes");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.10 - Banana Clicker");
                    UpdateLog.WriteLine("> Banana Clicker Game Update v1.2");
                    UpdateLog.WriteLine(" - Updates can be found in the game");
                    UpdateLog.WriteLine("> File Managment changed around");
                    UpdateLog.WriteLine(">Small Bug Fixes");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.11 - Banana Clicker");
                    UpdateLog.WriteLine("> Banana Clicker Game Update v1.3");
                    UpdateLog.WriteLine(" - Updates can be found in the game");
                    UpdateLog.WriteLine(">Small Bug Fixes");
                    UpdateLog.WriteLine("");
                    UpdateLog.WriteLine("KongolianOS 1.2.12 - Bugs");
                    UpdateLog.WriteLine("> Fixed a few bugs with the launcher");
                    UpdateLog.WriteLine(" Made the ui for the game look cleaner and much more.");
                    UpdateLog.WriteLine(">Small Bug Fixes");










                    UpdateLog.Close();

                    //UpdateLog.WriteLine("");

                }


                using (StreamWriter AboutUs = File.AppendText("C:\\KongolianOS\\Sys4\\DataSets\\AboutUs.ID"))
                {
                    AboutUs.WriteLine("Hello!");
                    AboutUs.WriteLine("My name is Zeeshan or Drkong, I am 17 years old and KongolianOS is one of my projects.");
                    AboutUs.WriteLine("KongolainOS is a small project which I started 2 years ago, a project that did not get finished. I decided to revisit the project and complety start everything again.");
                    AboutUs.WriteLine("I programmed the pervious version of the OS in Visual Basic, Which is outdated. So, I Started the new project in C# language as it's more modern and updated.");
                    AboutUs.WriteLine("This OS is BAD. I'm making this for fun and I need to Learn the C programming language for university.");
                    AboutUs.WriteLine("");
                    AboutUs.WriteLine("I've gridned this project for less than a week, starting on the 4th of june. Right know it's 9th, and I've completed most aspects of the OS.");
                    AboutUs.WriteLine("");
                    AboutUs.WriteLine("Thanks to Lillie who designed all the icons and logos :) ");
                    AboutUs.WriteLine("And thanks to everyone who looked at the videos I sent them to check out the OS and people who've helped me out.");
                    AboutUs.WriteLine("");
                    AboutUs.WriteLine("I have many future Plans for this OS. ");
                    AboutUs.WriteLine("");
                    AboutUs.WriteLine("<3");
                    AboutUs.Close();

                }


                using (StreamWriter FutureUpdates = File.AppendText("C:\\KongolianOS\\Sys4\\DataSets\\FutureUpdates.ID"))
                {
                    FutureUpdates.Flush();
                    //FutureUpdates.WriteLine("> Adding formats to notepad");
                    //FutureUpdates.WriteLine("> Background Settings");
                    //FutureUpdates.WriteLine("> Colours Settings");
                    //FutureUpdates.WriteLine("> Date and Time formats");
                    //FutureUpdates.WriteLine("> Mini Calander");
                    //FutureUpdates.WriteLine("> Light Theme / Dark Themes");
                    //FutureUpdates.WriteLine("> Mini Task Manager");
                    //FutureUpdates.WriteLine("> TicTacToe");
                    //FutureUpdates.WriteLine("> An auto-Clicker");
                    //FutureUpdates.WriteLine("> Adding scientific calculator");
                    //FutureUpdates.WriteLine("> Idle Small Clicker Game");
                    //FutureUpdates.WriteLine("> Make Apps Selection customisable");
                    //FutureUpdates.WriteLine("> Make the web-browser more functional and less laggy");
                    FutureUpdates.WriteLine("This might be the Final update. Not sure yet.");

                    //FutureUpdates.WriteLine("> The Updates above might or might not happen depending on other projects I am working on.");
                    FutureUpdates.Close();
                }

                using (StreamWriter Version = File.AppendText("C:\\KongolianOS\\Sys4\\DataSets\\Version.ID"))
                {
                    Version.WriteLine("KongolianOS 1.2.12");
                    Version.Close();
                }

                using (StreamWriter Dev = File.AppendText("C:\\KongolianOS\\Sys4\\DataSets\\Devs.ID"))
                {
                    Dev.WriteLine("Want to Develop A small application for Kongolian OS?");
                    Dev.WriteLine("");
                    Dev.WriteLine("To get started make a singled form Application, make sure that this app does not go above 1 form. Unless the app is super good.");
                    Dev.WriteLine("Also try to make sure that the app is not linked to the KongolianOS, if you need to execute code on the splash screen for file / directory creation, make a class and add all that data to it and I will try to implement it.");
                    Dev.WriteLine("");
                    Dev.WriteLine("Message me on discord for more details");
                    Dev.WriteLine("Drkong#9054");
                    Dev.WriteLine("");
                    Dev.WriteLine("Also if you are an artist please message me");
                    Dev.WriteLine("I'm looking forward to working with you guys :)");
                    Dev.WriteLine("Thanks <3 - Zeeshan Aka Drkong");
                    Dev.Close();
                }





                using (StreamWriter w = File.AppendText("C:\\KongolianOS\\Users\\" + "Users.ID"))
                {


                    //w.WriteLine("Temp");
                }


                using (StreamWriter w = File.AppendText("C:\\KongolianOS\\Sys4\\Update_1-2-12.ID"))
                {


                    //w.WriteLine("Temp");
                }

                try
                {
                    var test = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\ID.ID");
                    string Test1 = test.ReadLine();
                    test.Close();

                    LblID.Text = Test1;

                }
                catch (FileNotFoundException)
                {
                    string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    string small_alphabets = "abcdefghijklmnopqrstuvwxyz";
                    string numbers = "1234567890";
                    string eee = alphabets + small_alphabets + numbers;
                    string id = string.Empty;
                    //    Ab123-a1
                    string character = string.Empty;


                    for (int i = 0; i < 3; i++)
                    {
                        do
                        {
                            int index = new Random().Next(0, eee.Length);
                            character = eee.ToCharArray()[index].ToString();
                        } while (id.IndexOf(character) != -1);
                        id += character;
                    }
                    id += "-";
                    for (int i = 0; i < 3; i++)
                    {
                        do
                        {
                            int index = new Random().Next(0, eee.Length);
                            character = eee.ToCharArray()[index].ToString();
                        } while (id.IndexOf(character) != -1);
                        id += character;
                    }



                    var ID = new System.IO.StreamWriter("C:\\KongolianOS\\Sys4\\ID.ID");
                    ID.Write(id);
                    ID.Close();



                    var test = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\ID.ID");
                    string Test1 = test.ReadLine();
                    test.Close();

                    LblID.Text = Test1;
                    TimePB.Enabled = false;


                    if (MessageBox.Show("Press 'OK' To Update KongolianOS", "New Update!", MessageBoxButtons.OK) == DialogResult.OK)

                    {

                        Application.Restart();


                    }




                }


            }



        }

        private void TimePB_Tick(object sender, EventArgs e)
        {
            


        PnlProgress.Width += + 5;
        LblPercentage.Text = PnlProgress.Width.ToString() + " /256 Assets loaded";

            if ((PnlProgress.Width >= 0) && (PnlProgress.Width <= 50))
            {
                LblDesc.Text = "Growing Bananas";
            }
        

            else if ((PnlProgress.Width >= 51) && (PnlProgress.Width <= 100))
            {
                LblDesc.Text = "Swinging On Branches";
            }

            else if ((PnlProgress.Width >= 101) && (PnlProgress.Width <= 150))
            {
                LblDesc.Text = "Throwing Bananas";
            }

            else if ((PnlProgress.Width >= 151) && (PnlProgress.Width <= 200))
            {
                LblDesc.Text = "OOGA BOOGA";
            }

            else if ((PnlProgress.Width >= 201) && (PnlProgress.Width <= 256))
            {
                LblDesc.Text = "I aou u <3";
            }





            if (PnlProgress.Width >= 256)
            {
                TimePB.Enabled = false;
                OS Os_main = new OS();
                Login scrnlogin = new Login();

                scrnlogin.Show();
                this.Hide();
            };
        }

        private void LblPercentage_Click(object sender, EventArgs e)
        {

        }

        private void PB1_Click(object sender, EventArgs e)
        {

        }
    }
}
