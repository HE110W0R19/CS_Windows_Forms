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
    public partial class Form4 : Form
    {
        string all_info;
        uint cost;
        public string get_all_info => all_info;
        public uint get_cost => cost;
        public Form4(string type, string info, uint cost)
        {
            InitializeComponent();
            textBox1.Text = $" Описание:\n{info}\n";
            textBox2.Text = cost.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            all_info = $"\n{textBox1.Text.ToString()}\n";
            cost = Convert.ToUInt32(textBox2.Text);
        }
    }
}
