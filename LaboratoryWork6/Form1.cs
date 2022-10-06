using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryWork6
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Bold);
            }
            else
            {
                label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Regular);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Strikeout);
            }
            else
            {
                label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Regular);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Italic);
            }
            else
            {
                label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Regular);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Underline);
            }
            else
            {
                label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Regular);
            }
        }
    }
}
