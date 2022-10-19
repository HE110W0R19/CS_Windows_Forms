using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string story = null;
        public MainWindow()
        {
            InitializeComponent();
            foreach(UIElement el in Test_Window.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string tmp = (string)((Button)sender).Content;
            if (tmp == "<" && textBlock2.Text.Length != 0)
            {
                textBlock2.Text = textBlock2.Text.Remove(textBlock2.Text.Length - 1);
            }
            if (tmp == "C")
            {
                textBlock2.Text = "";
                story = "";
            }
            if(tmp == "CE")
            {
                textBlock2.Text = "";
            }
            if (tmp == "=")
            {
                textBlock2.Text = new DataTable().Compute(story, null).ToString();
                textBlock1.Text = story + " = " + textBlock2.Text;
                story = textBlock2.Text;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text += "1";
            story += "1";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text += "2";
            story += "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text += "3";
            story += "3";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text += "4";
            story += "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text += "5";
            story += "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text += "6";
            story += "6";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text += "7";
            story += "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text += "8";
            story += "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text += "9";
            story += "9";
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text += "0";
            story += "0";
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text = "";
            story += ".";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text = "";
            story += "+";
            textBlock1.Text = story;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text = "";
            story += "-";
            textBlock1.Text = story;
        }

        private void multy_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text = "";
            story += "*";
            textBlock1.Text = story;
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text = "";
            story += "/";
            textBlock1.Text = story;
        }

        private void Del2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
