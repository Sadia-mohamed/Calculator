namespace Calculater
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1_plus = new System.Windows.Forms.Button();
            this.button2_mines = new System.Windows.Forms.Button();
            this.button3_times = new System.Windows.Forms.Button();
            this.button4_divide = new System.Windows.Forms.Button();
            this.button5_rem = new System.Windows.Forms.Button();
            this.button6_exit = new System.Windows.Forms.Button();
            this.button7_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button8_equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(177, 1);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 51);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1_plus
            // 
            this.button1_plus.Location = new System.Drawing.Point(177, 87);
            this.button1_plus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1_plus.Name = "button1_plus";
            this.button1_plus.Size = new System.Drawing.Size(66, 38);
            this.button1_plus.TabIndex = 1;
            this.button1_plus.Text = "+";
            this.button1_plus.UseVisualStyleBackColor = true;
            this.button1_plus.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2_mines
            // 
            this.button2_mines.Location = new System.Drawing.Point(251, 87);
            this.button2_mines.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2_mines.Name = "button2_mines";
            this.button2_mines.Size = new System.Drawing.Size(73, 38);
            this.button2_mines.TabIndex = 2;
            this.button2_mines.Text = "-";
            this.button2_mines.UseVisualStyleBackColor = true;
            this.button2_mines.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3_times
            // 
            this.button3_times.Location = new System.Drawing.Point(332, 87);
            this.button3_times.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3_times.Name = "button3_times";
            this.button3_times.Size = new System.Drawing.Size(68, 38);
            this.button3_times.TabIndex = 3;
            this.button3_times.Text = "x";
            this.button3_times.UseVisualStyleBackColor = true;
            this.button3_times.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4_divide
            // 
            this.button4_divide.Location = new System.Drawing.Point(408, 87);
            this.button4_divide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4_divide.Name = "button4_divide";
            this.button4_divide.Size = new System.Drawing.Size(67, 38);
            this.button4_divide.TabIndex = 4;
            this.button4_divide.Text = "/";
            this.button4_divide.UseVisualStyleBackColor = true;
            this.button4_divide.Click += new System.EventHandler(this.button4_divide_Click);
            // 
            // button5_rem
            // 
            this.button5_rem.ImageKey = "(none)";
            this.button5_rem.Location = new System.Drawing.Point(483, 87);
            this.button5_rem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5_rem.Name = "button5_rem";
            this.button5_rem.Size = new System.Drawing.Size(82, 38);
            this.button5_rem.TabIndex = 5;
            this.button5_rem.Text = "%";
            this.button5_rem.UseVisualStyleBackColor = true;
            this.button5_rem.Click += new System.EventHandler(this.button5_rem_Click);
            // 
            // button6_exit
            // 
            this.button6_exit.Location = new System.Drawing.Point(177, 179);
            this.button6_exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6_exit.Name = "button6_exit";
            this.button6_exit.Size = new System.Drawing.Size(88, 36);
            this.button6_exit.TabIndex = 6;
            this.button6_exit.Text = "Exit";
            this.button6_exit.UseVisualStyleBackColor = true;
            this.button6_exit.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7_clear
            // 
            this.button7_clear.Location = new System.Drawing.Point(447, 179);
            this.button7_clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7_clear.Name = "button7_clear";
            this.button7_clear.Size = new System.Drawing.Size(118, 36);
            this.button7_clear.TabIndex = 7;
            this.button7_clear.Text = "Clear";
            this.button7_clear.UseVisualStyleBackColor = true;
            this.button7_clear.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(592, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 8;
            // 
            // button8_equal
            // 
            this.button8_equal.Location = new System.Drawing.Point(291, 179);
            this.button8_equal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8_equal.Name = "button8_equal";
            this.button8_equal.Size = new System.Drawing.Size(148, 36);
            this.button8_equal.TabIndex = 9;
            this.button8_equal.Text = "=";
            this.button8_equal.UseVisualStyleBackColor = true;
            this.button8_equal.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(568, 264);
            this.Controls.Add(this.button8_equal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7_clear);
            this.Controls.Add(this.button6_exit);
            this.Controls.Add(this.button5_rem);
            this.Controls.Add(this.button4_divide);
            this.Controls.Add(this.button3_times);
            this.Controls.Add(this.button2_mines);
            this.Controls.Add(this.button1_plus);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1_plus;
        private System.Windows.Forms.Button button2_mines;
        private System.Windows.Forms.Button button3_times;
        private System.Windows.Forms.Button button4_divide;
        private System.Windows.Forms.Button button5_rem;
        private System.Windows.Forms.Button button6_exit;
        private System.Windows.Forms.Button button7_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8_equal;
    }
}

