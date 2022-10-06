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
    public partial class Form2 : Form
    {
        int R = 0, G = 0, B = 0;
        float start_size = 10;
        public Form2()
        {
            InitializeComponent();
            label1.Text = radioButton1.Text;
            label1.Font = new Font(label1.Font.FontFamily, start_size,FontStyle.Regular);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label1.Text = radioButton2.Text;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                label1.Text = radioButton1.Text;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            G = trackBar2.Value;
            label1.ForeColor = Color.FromArgb(R, G, B);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            B = trackBar3.Value;
            label1.ForeColor = Color.FromArgb(R, G, B);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            R = trackBar1.Value;
            label1.ForeColor = Color.FromArgb(R, G, B);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            if (trackBar4.Value != 0)
            {
                start_size = trackBar4.Value;
                label1.Font = new Font(label1.Font.FontFamily, start_size, FontStyle.Regular);
            }
        }
    }
}
