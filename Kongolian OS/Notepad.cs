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
    public partial class Notepad : Form
    {


        public string current_user;
        public Notepad()
        {
            InitializeComponent();
        }
        // button exit
        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        public string Themes;


        private void Notepad_Load(object sender, EventArgs e)
        {
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
                
                //help panel
                PnlAbout.BackColor = Color.FromArgb(221, 234, 255);
                RtAbout.BackColor = Color.FromArgb(221, 234, 255);
                RtAbout.ForeColor = Color.Black;



                //Main panels

                TB.BackColor = Color.FromArgb(221, 234, 255);
                TB.ForeColor = Color.Black;


                //Windowed Bar
                Windowbar.BackColor = Color.FromArgb(128, 128, 128);
                label1.ForeColor = Color.Black;


                /// ms this shit gonna be the hardest
                ///
                ///


                //main body
                MS.BackColor = Color.FromArgb(128, 128, 128);

                // main body items
                fileToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);
                editToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);
                formatToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);
                aboutToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);
                fileToolStripMenuItem.ForeColor = Color.Black;
                editToolStripMenuItem.ForeColor = Color.Black;
                formatToolStripMenuItem.ForeColor = Color.Black;
                aboutToolStripMenuItem.ForeColor = Color.Black;

                // File strip items
                newToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);
                newWindowToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);
                saveToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);
                openToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);

                newToolStripMenuItem.ForeColor = Color.Black;
                newWindowToolStripMenuItem.ForeColor = Color.Black;
                saveToolStripMenuItem.ForeColor = Color.Black;
                openToolStripMenuItem.ForeColor = Color.Black;



                // edit strip items
                undoToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);
                redoToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);
                copyToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);
                pasteToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);
                cutToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);
                selectAllToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);

                undoToolStripMenuItem.ForeColor = Color.Black;
                redoToolStripMenuItem.ForeColor = Color.Black;
                copyToolStripMenuItem.ForeColor = Color.Black;
                pasteToolStripMenuItem.ForeColor = Color.Black;
                cutToolStripMenuItem.ForeColor = Color.Black;
                selectAllToolStripMenuItem.ForeColor = Color.Black;

                // format strip items
                fontToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);
                colourToolStripMenuItem.BackColor = Color.FromArgb(128, 128, 128);

                fontToolStripMenuItem.ForeColor = Color.Black;
                colourToolStripMenuItem.ForeColor = Color.Black;



                // about strip items
                aboutToolStripMenuItem1.BackColor = Color.FromArgb(128, 128, 128);
                aboutToolStripMenuItem1.ForeColor = Color.Black;


                //background

                this.BackColor = Color.FromArgb(221, 234, 255);

            }
            else
            {

            }
        }





        //movement of bar
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


        private void Windowbar_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void LblCurrentFIle_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void LblCurrentFIle_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }


        private void LblCurrentFIle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                mX = MousePosition.X - 400;
                mY = MousePosition.Y - 13;

                this.SetDesktopLocation(mX, mY);

            }
        }


        //About Panel

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PnlAbout.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PnlAbout.Visible = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Clear();
            LblCurrentFIle.Text = "";
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notepad notes = new Notepad();
            notes.Show();
        }





        //Open dialogue

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {


            var CU = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\" + "Current_User.ID");
            current_user = CU.ReadLine();
            CU.Close();


            OpenFileDialog OP = new OpenFileDialog();
            OP.Title = "Open";
            OP.Filter = "Text Document(*.txt)|*.txt|All Files (*.*)|*.*";
            OP.InitialDirectory = "C:\\KongolianOS\\Users\\" + current_user + "\\Documents"; //make it so that the current user makes a temp documents and stuff
            
            
            
            if (OP.ShowDialog() == DialogResult.OK)
            {


                TB.LoadFile(OP.FileName, RichTextBoxStreamType.PlainText);
                LblCurrentFIle.Text = OP.FileName;

            }
        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CU = new System.IO.StreamReader("C:\\KongolianOS\\Sys4\\" + "Current_User.ID");
            current_user = CU.ReadLine();
            CU.Close();


            SaveFileDialog OP = new SaveFileDialog();
            OP.Title = "Save";
            OP.Filter = "Text Document(*.txt)|*.txt|All Files (*.*)|*.*";
            OP.InitialDirectory = "C:\\KongolianOS\\Users\\" + current_user + "\\Documents"; //make it so that the current user makes a temp documents and stuff



            if (OP.ShowDialog() == DialogResult.OK)
            {


                TB.SaveFile(OP.FileName, RichTextBoxStreamType.PlainText);
                LblCurrentFIle.Text = OP.FileName;

            }
        }





        // edit commands

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Undo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Cut();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.SelectAll();
        }



        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Redo();
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog op = new ColorDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                TB.ForeColor = op.Color;

            }
        }



        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog op = new FontDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                TB.Font = op.Font;

            }
        }

    }

}
 