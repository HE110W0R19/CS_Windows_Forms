using System;
using System.Windows.Forms;

namespace Home_Work_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            treeView1.BeforeSelect += treeView1_BeforeSelect;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            FillDriveNodes();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label1.Text = treeView1.SelectedNode.FullPath;
        }
        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = System.IO.Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex) { }
        }
        private void FillDriveNodes()
        {
            foreach (System.IO.DriveInfo drive in System.IO.DriveInfo.GetDrives())
            {
                TreeNode driveNode = new TreeNode { Text = drive.Name };
                FillTreeNode(driveNode, drive.Name);
                treeView1.Nodes.Add(driveNode);
            }
        }
        void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            if (System.IO.Directory.Exists(e.Node.FullPath))
            {
                dirs = System.IO.Directory.GetDirectories(e.Node.FullPath);
                if (dirs.Length != 0)
                {
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        TreeNode dirNode = new TreeNode(new System.IO.DirectoryInfo(dirs[i]).Name);
                        FillTreeNode(dirNode, dirs[i]);
                        e.Node.Nodes.Add(dirNode);
                    }
                }
            }
        }
        void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            if (System.IO.Directory.Exists(e.Node.FullPath))
            {
                dirs = System.IO.Directory.GetDirectories(e.Node.FullPath);
                if (dirs.Length != 0)
                {
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        TreeNode dirNode = new TreeNode(new System.IO.DirectoryInfo(dirs[i]).Name);
                        FillTreeNode(dirNode, dirs[i]);
                        e.Node.Nodes.Add(dirNode);
                    }
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start
                (new System.Diagnostics.ProcessStartInfo(label1.Text));
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.treeView1.BackColor = System.Drawing.Color.White;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.treeView1.BackColor = System.Drawing.Color.Black;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.treeView1.BackColor = System.Drawing.Color.Red;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            this.treeView1.BackColor = System.Drawing.Color.Green;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.treeView1.BackColor = System.Drawing.Color.Blue;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            this.treeView1.ForeColor = System.Drawing.Color.White;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            this.treeView1.ForeColor = System.Drawing.Color.Black;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            this.treeView1.ForeColor = System.Drawing.Color.Red;
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            this.treeView1.ForeColor = System.Drawing.Color.Green;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            this.treeView1.ForeColor = System.Drawing.Color.Blue;
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            this.treeView1.Font = new System.Drawing.Font
                (treeView1.Font.FontFamily, treeView1.Font.Size, System.Drawing.FontStyle.Bold);
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            this.treeView1.Font = new System.Drawing.Font
               (treeView1.Font.FontFamily, treeView1.Font.Size, System.Drawing.FontStyle.Italic);
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            this.treeView1.Font = new System.Drawing.Font
               (treeView1.Font.FontFamily, treeView1.Font.Size, System.Drawing.FontStyle.Underline);
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            this.treeView1.Font = new System.Drawing.Font
               (treeView1.Font.FontFamily, treeView1.Font.Size, System.Drawing.FontStyle.Regular);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
