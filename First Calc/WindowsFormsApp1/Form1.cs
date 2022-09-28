using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        String Result = "";
        String Operation = "";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            label1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            label1.Text += "0";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            label1.Text += " - ";
            Operation = "-";
        }

        private void Divid_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            label1.Text += " / ";
            Operation = "/";
        }

        private void Multy_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            label1.Text += " * ";
            Operation = "*";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            label1.Text += " + ";
            Operation = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            switch(Operation)
            {
                case ("+"):
                    Result = (num1 + num2).ToString();
                    break;

                case ("-"):
                    Result = (num1 - num2).ToString();
                    break;

                case ("*"):
                    Result = (num1 * num2).ToString();
                    break;

                case ("/"):
                    Result = (num1 / num2).ToString();
                    break;

                default:
                    textBox1.Text = "Error choise!";
                    break;
            }
            label1.Text += " = " + Result;
            textBox1.Text = Result;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += ",";
            textBox1.Text += ",";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }
    }
}
