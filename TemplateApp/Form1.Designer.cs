﻿namespace TemplateApp
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.whoIsButton = new System.Windows.Forms.Button();
            this.readPropertyButton = new System.Windows.Forms.Button();
            this.writePropertyButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.buttonLightOn = new System.Windows.Forms.Button();
            this.buttonLightOff = new System.Windows.Forms.Button();
            this.buttonLightStart = new System.Windows.Forms.Button();
            this.buttonLightStop = new System.Windows.Forms.Button();
            this.buttonVertLight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 277);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // whoIsButton
            // 
            this.whoIsButton.Location = new System.Drawing.Point(11, 329);
            this.whoIsButton.Name = "whoIsButton";
            this.whoIsButton.Size = new System.Drawing.Size(75, 23);
            this.whoIsButton.TabIndex = 1;
            this.whoIsButton.Text = "Who Is";
            this.whoIsButton.UseVisualStyleBackColor = true;
            this.whoIsButton.Click += new System.EventHandler(this.whoIsButton_Click);
            // 
            // readPropertyButton
            // 
            this.readPropertyButton.Location = new System.Drawing.Point(92, 329);
            this.readPropertyButton.Name = "readPropertyButton";
            this.readPropertyButton.Size = new System.Drawing.Size(98, 23);
            this.readPropertyButton.TabIndex = 2;
            this.readPropertyButton.Text = "RPM";
            this.readPropertyButton.UseVisualStyleBackColor = true;
            this.readPropertyButton.Click += new System.EventHandler(this.readPropertyButton_Click);
            // 
            // writePropertyButton
            // 
            this.writePropertyButton.Location = new System.Drawing.Point(196, 329);
            this.writePropertyButton.Name = "writePropertyButton";
            this.writePropertyButton.Size = new System.Drawing.Size(88, 23);
            this.writePropertyButton.TabIndex = 3;
            this.writePropertyButton.Text = "Write property";
            this.writePropertyButton.UseVisualStyleBackColor = true;
            this.writePropertyButton.Click += new System.EventHandler(this.writePropertyButton_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(217, 46);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(302, 277);
            this.listBox2.TabIndex = 4;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(524, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(525, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 20);
            this.textBox2.TabIndex = 7;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(525, 98);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(268, 225);
            this.listBox3.TabIndex = 8;
            // 
            // buttonLightOn
            // 
            this.buttonLightOn.Location = new System.Drawing.Point(816, 13);
            this.buttonLightOn.Name = "buttonLightOn";
            this.buttonLightOn.Size = new System.Drawing.Size(88, 23);
            this.buttonLightOn.TabIndex = 9;
            this.buttonLightOn.Text = "On";
            this.buttonLightOn.UseVisualStyleBackColor = true;
            this.buttonLightOn.Click += new System.EventHandler(this.buttonLightOn_Click);
            // 
            // buttonLightOff
            // 
            this.buttonLightOff.Location = new System.Drawing.Point(816, 42);
            this.buttonLightOff.Name = "buttonLightOff";
            this.buttonLightOff.Size = new System.Drawing.Size(88, 23);
            this.buttonLightOff.TabIndex = 10;
            this.buttonLightOff.Text = "Off";
            this.buttonLightOff.UseVisualStyleBackColor = true;
            this.buttonLightOff.Click += new System.EventHandler(this.buttonLightOff_Click);
            // 
            // buttonLightStart
            // 
            this.buttonLightStart.Location = new System.Drawing.Point(816, 69);
            this.buttonLightStart.Name = "buttonLightStart";
            this.buttonLightStart.Size = new System.Drawing.Size(88, 23);
            this.buttonLightStart.TabIndex = 11;
            this.buttonLightStart.Text = "Start";
            this.buttonLightStart.UseVisualStyleBackColor = true;
            this.buttonLightStart.Click += new System.EventHandler(this.buttonLightStart_Click);
            // 
            // buttonLightStop
            // 
            this.buttonLightStop.Location = new System.Drawing.Point(816, 98);
            this.buttonLightStop.Name = "buttonLightStop";
            this.buttonLightStop.Size = new System.Drawing.Size(88, 23);
            this.buttonLightStop.TabIndex = 12;
            this.buttonLightStop.Text = "Stop";
            this.buttonLightStop.UseVisualStyleBackColor = true;
            this.buttonLightStop.Click += new System.EventHandler(this.buttonLightStop_Click);
            // 
            // buttonVertLight
            // 
            this.buttonVertLight.Location = new System.Drawing.Point(816, 167);
            this.buttonVertLight.Name = "buttonVertLight";
            this.buttonVertLight.Size = new System.Drawing.Size(88, 23);
            this.buttonVertLight.TabIndex = 13;
            this.buttonVertLight.Text = "Start 1";
            this.buttonVertLight.UseVisualStyleBackColor = true;
            this.buttonVertLight.Click += new System.EventHandler(this.buttonVertLight_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Create object";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Delete object";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(816, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Subscribe COV";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(11, 387);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 20);
            this.textBox3.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "ReadProperty";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(242, 387);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 20);
            this.textBox4.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 468);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonVertLight);
            this.Controls.Add(this.buttonLightStop);
            this.Controls.Add(this.buttonLightStart);
            this.Controls.Add(this.buttonLightOff);
            this.Controls.Add(this.buttonLightOn);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.writePropertyButton);
            this.Controls.Add(this.readPropertyButton);
            this.Controls.Add(this.whoIsButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button whoIsButton;
        private System.Windows.Forms.Button readPropertyButton;
        private System.Windows.Forms.Button writePropertyButton;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button buttonLightOn;
        private System.Windows.Forms.Button buttonLightOff;
        private System.Windows.Forms.Button buttonLightStart;
        private System.Windows.Forms.Button buttonLightStop;
        private System.Windows.Forms.Button buttonVertLight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
    }
}

