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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.MouseMove += Move_mouse;
            this.MouseClick += Click_mouse;
        }

        private void Move_mouse(object sender, MouseEventArgs user_mouse)
        { 
            Text = $"(X: {user_mouse.X} Y: {user_mouse.Y})";
        }

        private void Click_mouse(object sender, MouseEventArgs user_mouse)
        {
            if (user_mouse.Button == MouseButtons.Right)
            {
                MessageBox.Show($"Client window size (Width:{ClientSize.Width} Height: {ClientSize.Height})",
                    "New message!",
                    MessageBoxButtons.OKCancel);
            }
            if (user_mouse.Button == MouseButtons.Left)
            {
                if(ModifierKeys == Keys.Control)
                {
                    Close();
                }
                if ((user_mouse.X == 10 || user_mouse.X == ClientSize.Width - 10) ||
                    (user_mouse.Y == 10 || user_mouse.Y == ClientSize.Height - 10))
                {
                    MessageBox.Show("Pushing on the border", "New message!", MessageBoxButtons.OKCancel);
                }
                if ((user_mouse.X < 10 || user_mouse.X > ClientSize.Width - 10) ||
                    (user_mouse.Y < 10 || user_mouse.Y > ClientSize.Height - 10))
                {
                    MessageBox.Show("Pushing outside", "New message!", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("Pushing inside", "New message!", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
