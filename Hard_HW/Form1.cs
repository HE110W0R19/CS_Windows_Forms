using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hard_HW
{
    public partial class Form1 : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        Label user_static = new Label();
        public Form1()
        {
            InitializeComponent();
            Text = "Try to close it!";
            user_static.Size = new Size(60,30);
            user_static.ForeColor = Color.Black;
            user_static.BackColor = Color.Cornsilk;
            user_static.BorderStyle = BorderStyle.Fixed3D;
            user_static.TextAlign = ContentAlignment.MiddleCenter;
            user_static.Font = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Regular);
            user_static.Text = "Yes";
            user_static.Location = new Point(ClientSize.Width / 2 - 30, 150);
            Controls.Add(user_static);
            this.MouseMove += Move_mouse;
            this.MouseClick += Click_mouse;
        }
        
        private void Click_mouse(object sender, MouseEventArgs user_mouse)
        {
            if(user_mouse.Button == MouseButtons.Right)
            {
                Close();
            }
        }

        private void Move_mouse(object sender, MouseEventArgs user_mouse)
        {
            int static_x_cord = user_static.Location.X;
            int static_y_cord = user_static.Location.Y;
            if ((user_mouse.X > static_x_cord - 10 && user_mouse.X < static_x_cord + 75) &&
                (user_mouse.Y > static_y_cord - 10 && user_mouse.Y < static_y_cord + 45))
            {
                if (user_mouse.X > static_x_cord - 3 &&
                    user_mouse.X < static_x_cord)
                {
                    user_static.Left += 5;
                }
                else if (user_mouse.Y > static_y_cord - 3 &&
                    user_mouse.Y < static_y_cord)
                {
                    user_static.Top += 5;
                }
                else if (user_mouse.X < static_x_cord + 63 &&
                    user_mouse.X > static_x_cord + 60)
                {
                    user_static.Left -= 5;
                }
                else if (user_mouse.Y < static_y_cord + 33 &&
                    user_mouse.Y > static_y_cord + 30)
                {
                    user_static.Top -= 5;
                }
            }
            if (static_x_cord > ClientSize.Width - 60 || static_y_cord > ClientSize.Height ||
                static_x_cord < 0 || static_y_cord < 0)
            {
                user_static.Location = new Point(ClientSize.Width / 2 - 30, 150);
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams tmp = base.CreateParams;
                tmp.ClassStyle = tmp.ClassStyle | CP_NOCLOSE_BUTTON;
                return tmp;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
