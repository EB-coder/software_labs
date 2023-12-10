namespace lab5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 7);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(415, 78);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 97);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(415, 79);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(45, 191);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(66, 32);
            button1.TabIndex = 2;
            button1.Text = "Add Text";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(131, 191);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(64, 32);
            button2.TabIndex = 3;
            button2.Text = "Append";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(219, 191);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(64, 32);
            button3.TabIndex = 4;
            button3.Text = "Set Lines";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(392, 191);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(66, 32);
            button4.TabIndex = 5;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(45, 238);
            richTextBox1.Margin = new Padding(2, 2, 2, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(192, 88);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            richTextBox1.LinkClicked += richTextBox1_LinkClicked;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(270, 238);
            richTextBox2.Margin = new Padding(2, 2, 2, 2);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(190, 88);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            // 
            // button5
            // 
            button5.Location = new Point(309, 191);
            button5.Margin = new Padding(2, 2, 2, 2);
            button5.Name = "button5";
            button5.Size = new Size(61, 32);
            button5.TabIndex = 8;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(45, 344);
            button6.Margin = new Padding(2, 2, 2, 2);
            button6.Name = "button6";
            button6.Size = new Size(130, 32);
            button6.TabIndex = 9;
            button6.Text = "Add Value";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(186, 344);
            button7.Margin = new Padding(2, 2, 2, 2);
            button7.Name = "button7";
            button7.Size = new Size(121, 32);
            button7.TabIndex = 10;
            button7.Text = "ShowText";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(323, 344);
            button8.Margin = new Padding(2, 2, 2, 2);
            button8.Name = "button8";
            button8.Size = new Size(135, 32);
            button8.TabIndex = 11;
            button8.Text = "Add Text With Link";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 398);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}