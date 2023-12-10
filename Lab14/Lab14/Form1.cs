using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Lab14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionBullet = true;
            // Set indentation in pixels for list items
            richTextBox1.BulletIndent = 50;
            richTextBox1.SelectionFont = new Font("Arial", 16);
            // Display text that is not affected by the set 
            // indentation (SelectionBullet = false)
            richTextBox1.SelectedText = "Below is a list \n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            // Next is a list
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "Apple" + "\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Orange;
            richTextBox1.SelectedText = "Orange" + "\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Purple;
            richTextBox1.SelectedText = "Grapes" + "\n";
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionFont = new Font("Verdana", 10);
            richTextBox1.SelectedText = "The list is over \n";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "My site http://moi.ru";
            richTextBox1.LinkClicked += richTextBox1_LinkClicked;

        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string sText1, sText2, sText3, sText4, sText5;

            for (int i = 1; i <= 5; i++)
            {
                richTextBox1.Text += "String" + i.ToString() +
                    System.Environment.NewLine;
            }

            sText1 = "String1";
            sText2 = "String2";
            sText3 = "String3";
            sText4 = "String4";
            sText5 = "String5";

            SetFontForString(sText1, new Font("Arial", 10), Color.Red);
            SetFontForString(sText2, new Font("Arial", 12, FontStyle.Underline), Color.Blue);
            SetFontForString(sText3, new Font("Arial", 14, FontStyle.Bold), Color.Aqua);
            SetFontForString(sText4, new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic), Color.Cyan);
            SetFontForString(sText5, new Font("Arial", 18, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout), Color.Brown);
        }
        private void SetFontForString(string searchString, Font font, Color color)
        {
            richTextBox1.Select(richTextBox1.Find(searchString), searchString.Length);
            richTextBox1.SelectionFont = font;
            richTextBox1.SelectionColor = color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("a.rtf", RichTextBoxStreamType.RichText);
            richTextBox1.Clear();
            richTextBox1.LoadFile("a.rtf", RichTextBoxStreamType.RichText);
        }
    }
}
