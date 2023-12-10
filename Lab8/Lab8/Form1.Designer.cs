namespace Lab8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.EventCheckedChanged = new System.Windows.Forms.CheckBox();
            this.ButtonWhichAreSelected = new System.Windows.Forms.Button();
            this.ButtonCheckState = new System.Windows.Forms.Button();
            this.ButtonSelectProgrammatically = new System.Windows.Forms.Button();
            this.RButtonWhichAreSelected = new System.Windows.Forms.Button();
            this.SelectRbuttonProgrammatically = new System.Windows.Forms.Button();
            this.WhichAreSelected = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.EventCheckedChangedR = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(46, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(46, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(46, 86);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // EventCheckedChanged
            // 
            this.EventCheckedChanged.AutoSize = true;
            this.EventCheckedChanged.Location = new System.Drawing.Point(134, 318);
            this.EventCheckedChanged.Name = "EventCheckedChanged";
            this.EventCheckedChanged.Size = new System.Drawing.Size(143, 17);
            this.EventCheckedChanged.TabIndex = 3;
            this.EventCheckedChanged.Text = "Event CheckedChanged";
            this.EventCheckedChanged.UseVisualStyleBackColor = true;
            this.EventCheckedChanged.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // ButtonWhichAreSelected
            // 
            this.ButtonWhichAreSelected.Location = new System.Drawing.Point(12, 148);
            this.ButtonWhichAreSelected.Name = "ButtonWhichAreSelected";
            this.ButtonWhichAreSelected.Size = new System.Drawing.Size(182, 23);
            this.ButtonWhichAreSelected.TabIndex = 4;
            this.ButtonWhichAreSelected.Text = "Which are selected";
            this.ButtonWhichAreSelected.UseVisualStyleBackColor = true;
            this.ButtonWhichAreSelected.Click += new System.EventHandler(this.ButtonWhichAreSelected_Click);
            // 
            // ButtonCheckState
            // 
            this.ButtonCheckState.Location = new System.Drawing.Point(12, 186);
            this.ButtonCheckState.Name = "ButtonCheckState";
            this.ButtonCheckState.Size = new System.Drawing.Size(182, 23);
            this.ButtonCheckState.TabIndex = 5;
            this.ButtonCheckState.Text = "Button CheckState property";
            this.ButtonCheckState.UseVisualStyleBackColor = true;
            this.ButtonCheckState.Click += new System.EventHandler(this.ButtonCheckState_Click);
            // 
            // ButtonSelectProgrammatically
            // 
            this.ButtonSelectProgrammatically.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSelectProgrammatically.Location = new System.Drawing.Point(12, 227);
            this.ButtonSelectProgrammatically.Name = "ButtonSelectProgrammatically";
            this.ButtonSelectProgrammatically.Size = new System.Drawing.Size(182, 23);
            this.ButtonSelectProgrammatically.TabIndex = 6;
            this.ButtonSelectProgrammatically.Text = "Button Select programmatically";
            this.ButtonSelectProgrammatically.UseVisualStyleBackColor = true;
            this.ButtonSelectProgrammatically.Click += new System.EventHandler(this.ButtonSelectProgrammatically_Click);
            // 
            // RButtonWhichAreSelected
            // 
            this.RButtonWhichAreSelected.Location = new System.Drawing.Point(241, 148);
            this.RButtonWhichAreSelected.Name = "RButtonWhichAreSelected";
            this.RButtonWhichAreSelected.Size = new System.Drawing.Size(217, 23);
            this.RButtonWhichAreSelected.TabIndex = 7;
            this.RButtonWhichAreSelected.Text = "R Button Which are selected";
            this.RButtonWhichAreSelected.UseVisualStyleBackColor = true;
            this.RButtonWhichAreSelected.Click += new System.EventHandler(this.RButtonWhichAreSelected_Click);
            // 
            // SelectRbuttonProgrammatically
            // 
            this.SelectRbuttonProgrammatically.Location = new System.Drawing.Point(241, 186);
            this.SelectRbuttonProgrammatically.Name = "SelectRbuttonProgrammatically";
            this.SelectRbuttonProgrammatically.Size = new System.Drawing.Size(217, 23);
            this.SelectRbuttonProgrammatically.TabIndex = 8;
            this.SelectRbuttonProgrammatically.Text = "Select the R button programmatically";
            this.SelectRbuttonProgrammatically.UseVisualStyleBackColor = true;
            this.SelectRbuttonProgrammatically.Click += new System.EventHandler(this.SelectRbuttonProgrammatically_Click);
            // 
            // WhichAreSelected
            // 
            this.WhichAreSelected.Location = new System.Drawing.Point(82, 196);
            this.WhichAreSelected.Name = "WhichAreSelected";
            this.WhichAreSelected.Size = new System.Drawing.Size(148, 23);
            this.WhichAreSelected.TabIndex = 9;
            this.WhichAreSelected.Text = "Which are selected";
            this.WhichAreSelected.UseVisualStyleBackColor = true;
            this.WhichAreSelected.Click += new System.EventHandler(this.WhichAreSelected_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WhichAreSelected);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Location = new System.Drawing.Point(485, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 238);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(313, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(313, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(313, 86);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(114, 96);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(114, 119);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 15;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(114, 142);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 16;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // EventCheckedChangedR
            // 
            this.EventCheckedChangedR.AutoSize = true;
            this.EventCheckedChangedR.Location = new System.Drawing.Point(512, 317);
            this.EventCheckedChangedR.Name = "EventCheckedChangedR";
            this.EventCheckedChangedR.Size = new System.Drawing.Size(145, 17);
            this.EventCheckedChangedR.TabIndex = 17;
            this.EventCheckedChangedR.TabStop = true;
            this.EventCheckedChangedR.Text = "Event CheckedChanged ";
            this.EventCheckedChangedR.UseVisualStyleBackColor = true;
            this.EventCheckedChangedR.CheckedChanged += new System.EventHandler(this.EventCheckedChangedR_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.EventCheckedChangedR);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectRbuttonProgrammatically);
            this.Controls.Add(this.RButtonWhichAreSelected);
            this.Controls.Add(this.ButtonSelectProgrammatically);
            this.Controls.Add(this.ButtonCheckState);
            this.Controls.Add(this.ButtonWhichAreSelected);
            this.Controls.Add(this.EventCheckedChanged);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox EventCheckedChanged;
        private System.Windows.Forms.Button ButtonWhichAreSelected;
        private System.Windows.Forms.Button ButtonCheckState;
        private System.Windows.Forms.Button ButtonSelectProgrammatically;
        private System.Windows.Forms.Button RButtonWhichAreSelected;
        private System.Windows.Forms.Button SelectRbuttonProgrammatically;
        private System.Windows.Forms.Button WhichAreSelected;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton EventCheckedChangedR;
    }
}

