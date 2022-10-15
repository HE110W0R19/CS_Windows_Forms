using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

//Задача 1

namespace HomeWork4
{
    public partial class Form1 : Form
    {
        Form2 form = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form != null)
                form.Close();
            form = new Form2();
            if (form.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < form.tmp.Count; ++i)
                {
                    listBox1.Items.Add(form.tmp[i]);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
