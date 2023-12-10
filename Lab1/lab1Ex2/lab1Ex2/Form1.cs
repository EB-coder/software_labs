using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double aNumber = Convert.ToInt32(textBox1.Text);
            double bNumber = Convert.ToInt32(textBox2.Text);

            if (textBox3.Text == "-")
            {
                textBox4.Text = (aNumber - bNumber).ToString();
            }
            else if (textBox3.Text == "+")
            {
                textBox4.Text = (aNumber + bNumber).ToString();
            }
            else if (textBox3.Text == "*")
            {
                textBox4.Text = (aNumber * bNumber).ToString();
            }
            else if (textBox3.Text == "/")
            {
                if (aNumber == 0)
                {
                    MessageBox.Show("You cannot divide to zero!!!");
                }
                else
                {
                    textBox4.Text = (aNumber / bNumber).ToString();
                }
            }
        }
    }
}
