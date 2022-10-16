using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork4
{
    public partial class Form5 : Form
    {
        bool status = false;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt) | *.txt || ";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader reader =
                System.IO.File.OpenText(open.FileName);
                textBox1.Text = reader.ReadToEnd();
                this.status = true; 
                reader.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.status == true)
            {
                Form6 form = new Form6(textBox1.Text);
                if (form.ShowDialog() == DialogResult.Yes)
                {
                    textBox1.Text = form.get_new_text;
                }
            }
        }
    }
}
