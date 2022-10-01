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
    public partial class Form3 : Form
    {
        int mouse_x_cord;
        int mouse_y_cord;
        int counter;
        public Form3()
        {
            InitializeComponent();
            this.MouseDown += mouse_button_down;
            this.MouseUp += mouse_button_up;
        }
        private void mouse_button_down(object sender, MouseEventArgs user_mouse)
        {
            if (user_mouse.Button == MouseButtons.Left)
            {
                mouse_x_cord = user_mouse.X;
                mouse_y_cord = user_mouse.Y;
                Text = $"{mouse_x_cord}, {mouse_y_cord}";
            }
        }
        private void mouse_button_up(object sender, MouseEventArgs user_mouse)
        {
            ++counter;
            if (user_mouse.Button == MouseButtons.Left)
            {
                Label user_static = new Label();
                if (user_mouse.X > mouse_x_cord && user_mouse.Y > mouse_y_cord)
                {
                    user_static.Location = new Point(mouse_x_cord, mouse_y_cord);
                }
                else if (user_mouse.X > mouse_x_cord && user_mouse.Y < mouse_y_cord)
                {
                    user_static.Location = new Point(mouse_x_cord, user_mouse.Y);
                }
                else if (user_mouse.X < mouse_x_cord && user_mouse.Y < mouse_y_cord)
                {
                    user_static.Location = new Point(user_mouse.X, user_mouse.Y);
                }
                else
                {
                    user_static.Location = new Point(user_mouse.X, mouse_y_cord);
                }
                if ((user_mouse.X - mouse_x_cord > 10) && (user_mouse.Y - mouse_y_cord > 10))
                {
                    user_static.BackColor = Color.Black;
                    user_static.ForeColor = Color.White;
                    user_static.Size = new Size(user_mouse.X - mouse_x_cord, user_mouse.Y - mouse_y_cord);
                    user_static.TextAlign = ContentAlignment.MiddleCenter;
                    user_static.Text = $"{counter}";
                    Controls.Add(user_static);
                    user_static.MouseClick += right_mouse_click;
                    user_static.MouseDoubleClick += double_mouse_click;
                }
                else
                {
                    Text = "Wrong static size! Try again";
                }
            }
        }
        private void double_mouse_click(object sender, MouseEventArgs user_moise)
        {
            int deleted_num = counter;
            if (user_moise.Button == MouseButtons.Left)
            {
                foreach (Label tmp in Controls)
                {
                    Point location = tmp.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X +
                        tmp.Width && MousePosition.Y > location.Y &&
                        MousePosition.Y < location.Y + tmp.Height)
                    {
                        if (counter > Int32.Parse(tmp.Text))
                        {
                            counter = Int32.Parse(tmp.Text);
                        }
                    }
                    if (counter == Int32.Parse(tmp.Text))
                    {
                        tmp.MouseClick -= right_mouse_click;
                        tmp.MouseDoubleClick -= double_mouse_click;
                        Controls.Remove(tmp);
                        --counter;
                    }
                }
            }
        }
        private void right_mouse_click(object sender, MouseEventArgs user_mouse)
        {
            if (user_mouse.Button == MouseButtons.Right)
            {
                foreach (Label tmp in Controls)
                {
                    Point loc = tmp.PointToScreen(Point.Empty);
                    if (MousePosition.X > loc.X && MousePosition.X < loc.X
                        + tmp.Width && MousePosition.Y > loc.Y &&
                        MousePosition.Y < loc.Y + tmp.Height)
                    {
                        Text = $"№: {tmp.Text} / S: {tmp.Width * tmp.Height}" +
                            $" / Location Х: {tmp.Location.X} Y: {tmp.Location.Y}";
                    }
                }
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
