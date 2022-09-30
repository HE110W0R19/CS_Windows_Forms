using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Get_info
{
    public partial class Form1 : Form
    {
        //for the task 1 =============================================
        string F = "U***"; //because the public repository, sorry (
        string I = "A***";
        string O = "I***";
        string location = "Russia/Nalchik";
        DateTime born = new DateTime(1888, 08, 08);
        double counter = 0;
        //for the task 2 ================================================
        int user_number = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Task 1 =====================================================
            MessageBox.Show($"Surname: {F}\nName: {I}\nPatronymic: {O} ",
                "Full FIO",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.None);
            MessageBox.Show($"Location: {location}",
                "Country",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.None);

            counter = Convert.ToDouble(F.Length + I.Length + O.Length + location.Length + born.ToString().Length) / 3;

            MessageBox.Show($"Born: {location}",
                $"Average quantity: {counter}",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.None);
            //Close();
            //Task 2 ============================================================
        }

        private void label2_Click(object sender, EventArgs e)
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
            int attempts = 0;
            Random rand = new Random();
            int random_number = rand.Next(0, 2001);
            user_number = Convert.ToInt32(textBox1.Text);
            while (true)
            {
                DialogResult result = MessageBox.Show($"{random_number} - ?",
                $"Your number is: ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes || random_number == user_number)
                {
                    if (random_number == user_number)
                    {
                        MessageBox.Show($"Your number is: {user_number}\n" +
                            $"Number of attempts: {attempts}",
                            "Finish game!",
                            MessageBoxButtons.OKCancel);
                        break;
                    }
                    else
                    {
                        DialogResult lie = MessageBox.Show($"You're lying to me :(\n" +
                            $"Do you wanna continue game?",
                            "Hey!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (lie == DialogResult.Yes)
                            continue;
                        if (lie == DialogResult.No)
                            break;
                    }
                }
                else
                {
                    random_number = rand.Next(0, 2001);
                    ++attempts;
                    continue;
                }
            }
        }
    }
}
