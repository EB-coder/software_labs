using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double aNumber = Convert.ToInt32(textBox1.Text);
            double bNumber = Convert.ToInt32(textBox2.Text);

            if (textBox3.Text == "-") 
            {
                textBox4.Text = (aNumber - bNumber).ToString();
            }
            else if(textBox3.Text == "+")
            {
               textBox4.Text = (aNumber + bNumber).ToString();
            }
            else if(textBox3.Text == "*")
            {
                textBox4.Text = (aNumber * bNumber).ToString();
            }
            else if(textBox3.Text == "/")
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
