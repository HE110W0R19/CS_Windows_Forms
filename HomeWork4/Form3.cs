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
    public partial class Form3 : Form
    {
        uint result_sum;
        List<string> orders = new List<string>();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 add_info = new Form4("", 0);
            if (add_info.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text +=
                    $"|Тип: {comboBox1.SelectedItem.ToString()}|" +
                    $"{add_info.get_all_info}|" +
                    $"Цена: {add_info.get_cost}|";
                result_sum += add_info.get_cost;
                textBox2.Text = result_sum.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            orders.Add($"{textBox1.Text}");
            listBox1.Items.Add($"|Заказ №{orders.Count.ToString()}|Cумма:{result_sum}|");
            result_sum = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 add_info = new Form4(textBox1.Text, 0);
            if (add_info.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = "";
                result_sum = 0;
                textBox1.Text += add_info.get_all_info;
                result_sum = add_info.get_cost;
            }
        }
    }
}
