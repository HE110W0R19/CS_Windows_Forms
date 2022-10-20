using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Work_5
{
    public partial class Form1 : Form
    {
        string file_name = null;
        string text_buffer = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt) | *.txt || ";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader reader =
                System.IO.File.OpenText(open.FileName);
                richTextBox1.Text = reader.ReadToEnd();
                file_name = open.FileName;
                this.label1.Text = System.IO.Path.GetFullPath(open.FileName);
                reader.Close();
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(file_name);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(save.FileName);
                writer.Write(richTextBox1.Text);
                writer.Close();
            }
        }
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.text_buffer = this.richTextBox1.SelectedText;
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectedText = this.text_buffer;
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectedText = "";
            this.text_buffer = "";
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void выделитьВсеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            this.richTextBox1.BackColor = Color.Black;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            this.richTextBox1.BackColor = Color.Red;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            this.richTextBox1.BackColor = Color.White;
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            this.richTextBox1.BackColor = Color.Green;
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            this.richTextBox1.BackColor = Color.Blue;
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor = Color.White;
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor = Color.Black;
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor = Color.Red;
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor = Color.Green;
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor = Color.Blue;
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Font = 
                new Font(this.richTextBox1.Font.FontFamily,this.richTextBox1.Font.Size, FontStyle.Regular);
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Font =
                new Font(this.richTextBox1.Font.FontFamily, this.richTextBox1.Font.Size, FontStyle.Bold);
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Font =
                new Font(this.richTextBox1.Font.FontFamily, this.richTextBox1.Font.Size, FontStyle.Underline);
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Font =
                new Font(this.richTextBox1.Font.FontFamily, this.richTextBox1.Font.Size, FontStyle.Italic);
        }
    }
}
