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
    }
}
