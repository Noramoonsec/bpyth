﻿namespace tictaktoe
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            button10 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(2, 2);
            button1.Name = "button1";
            button1.Size = new Size(75, 72);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Coral;
            button2.Location = new Point(83, 2);
            button2.Name = "button2";
            button2.Size = new Size(75, 72);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Coral;
            button3.Location = new Point(164, 2);
            button3.Name = "button3";
            button3.Size = new Size(75, 72);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Coral;
            button4.Location = new Point(2, 80);
            button4.Name = "button4";
            button4.Size = new Size(75, 72);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Coral;
            button5.Location = new Point(83, 80);
            button5.Name = "button5";
            button5.Size = new Size(75, 72);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Crimson;
            button6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Coral;
            button6.Location = new Point(164, 80);
            button6.Name = "button6";
            button6.Size = new Size(75, 72);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.Coral;
            button7.Location = new Point(2, 158);
            button7.Name = "button7";
            button7.Size = new Size(75, 72);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.Coral;
            button8.Location = new Point(83, 158);
            button8.Name = "button8";
            button8.Size = new Size(75, 72);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Crimson;
            button9.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.Coral;
            button9.Location = new Point(164, 158);
            button9.Name = "button9";
            button9.Size = new Size(75, 72);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(12, 243);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 9;
            // 
            // button10
            // 
            button10.Location = new Point(2, 279);
            button10.Name = "button10";
            button10.Size = new Size(237, 23);
            button10.TabIndex = 10;
            button10.Text = "Oyuna yeniden başla!";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 308);
            Controls.Add(button10);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Button button10;
    }
}