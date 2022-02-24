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
    public partial class Fileexplorer : Form
    {
        public Fileexplorer()
        {
            InitializeComponent();
            PopulateTreeView();
        }

        public string current_user, Themes;


        private void FileExplorer_Load(object sender, EventArgs e)
        {

            this.Name.Text = "FileExplorer";

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
                //LBUsers.BackColor = Color.FromArgb(128, 128, 128);
                //LBUsers.ForeColor = Color.Black;




                // Text

                label1.ForeColor = Color.Black;




                listView1.BackColor = Color.FromArgb(221, 234, 255);
                listView1.ForeColor = Color.Black;

                listView1.BackColor = Color.FromArgb(128, 128, 128);
                listView1.ForeColor = Color.Black;













                //background

                this.BackColor = Color.FromArgb(221, 234, 255);

            }
            else
            {

            }
        }


        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"C:\\KongolianOS\\");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"),
             new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }







        // for moving the file explorer

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
            this.Close();
        }



        private void Windowbar_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
