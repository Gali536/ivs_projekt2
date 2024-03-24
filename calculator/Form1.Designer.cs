namespace calculator
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
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            clear = new Button();
            button_divide = new Button();
            button16 = new Button();
            button_subtract = new Button();
            plus = new Button();
            button_factorial = new Button();
            button_power = new Button();
            button_sqrroot = new Button();
            button_modulo = new Button();
            button23 = new Button();
            textbox = new TextBox();
            history = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 19.8000011F);
            button1.Location = new Point(118, 493);
            button1.Name = "button1";
            button1.Size = new Size(100, 60);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 19.8000011F);
            button2.Location = new Point(224, 493);
            button2.Name = "button2";
            button2.Size = new Size(100, 60);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 19.8000011F);
            button3.Location = new Point(330, 493);
            button3.Name = "button3";
            button3.Size = new Size(100, 60);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 19.8000011F);
            button4.Location = new Point(118, 427);
            button4.Name = "button4";
            button4.Size = new Size(100, 60);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 19.8000011F);
            button5.Location = new Point(224, 427);
            button5.Name = "button5";
            button5.Size = new Size(100, 60);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 19.8000011F);
            button6.Location = new Point(330, 427);
            button6.Name = "button6";
            button6.Size = new Size(100, 60);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 19.8000011F);
            button7.Location = new Point(118, 361);
            button7.Name = "button7";
            button7.Size = new Size(100, 60);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 19.8000011F);
            button8.Location = new Point(224, 361);
            button8.Name = "button8";
            button8.Size = new Size(100, 60);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 19.8000011F);
            button9.Location = new Point(330, 361);
            button9.Name = "button9";
            button9.Size = new Size(100, 60);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_1;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 19.8000011F);
            button10.Location = new Point(436, 493);
            button10.Name = "button10";
            button10.Size = new Size(100, 126);
            button10.TabIndex = 9;
            button10.Text = "=";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 19.8000011F);
            button11.Location = new Point(224, 559);
            button11.Name = "button11";
            button11.Size = new Size(100, 60);
            button11.TabIndex = 10;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 19.8000011F);
            button12.Location = new Point(118, 559);
            button12.Name = "button12";
            button12.Size = new Size(100, 60);
            button12.TabIndex = 11;
            button12.Text = "+/-";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 19.8000011F);
            button13.Location = new Point(330, 559);
            button13.Name = "button13";
            button13.Size = new Size(100, 60);
            button13.TabIndex = 12;
            button13.Text = ",";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI", 19.8000011F);
            clear.Location = new Point(436, 361);
            clear.Name = "clear";
            clear.Size = new Size(100, 126);
            clear.TabIndex = 13;
            clear.Text = "CE";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // button_divide
            // 
            button_divide.Font = new Font("Segoe UI", 19.8000011F);
            button_divide.Location = new Point(330, 295);
            button_divide.Name = "button_divide";
            button_divide.Size = new Size(100, 60);
            button_divide.TabIndex = 14;
            button_divide.Text = "/";
            button_divide.UseVisualStyleBackColor = true;
            button_divide.Click += button_divide_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 19.8000011F);
            button16.Location = new Point(224, 295);
            button16.Name = "button16";
            button16.Size = new Size(100, 60);
            button16.TabIndex = 17;
            button16.Text = "×";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button_subtract
            // 
            button_subtract.Font = new Font("Segoe UI", 19.8000011F);
            button_subtract.Location = new Point(118, 295);
            button_subtract.Name = "button_subtract";
            button_subtract.Size = new Size(100, 60);
            button_subtract.TabIndex = 15;
            button_subtract.Text = "-";
            button_subtract.UseVisualStyleBackColor = true;
            button_subtract.Click += button_subtract_Click;
            // 
            // plus
            // 
            plus.Font = new Font("Segoe UI", 19.8000011F);
            plus.Location = new Point(12, 295);
            plus.Name = "plus";
            plus.Size = new Size(100, 60);
            plus.TabIndex = 16;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += button18_Click;
            // 
            // button_factorial
            // 
            button_factorial.Font = new Font("Segoe UI", 19.8000011F);
            button_factorial.Location = new Point(12, 361);
            button_factorial.Name = "button_factorial";
            button_factorial.Size = new Size(100, 60);
            button_factorial.TabIndex = 18;
            button_factorial.Text = "n!";
            button_factorial.UseVisualStyleBackColor = true;
            button_factorial.Click += button_factorial_Click;
            // 
            // button_power
            // 
            button_power.Font = new Font("Segoe UI", 19.8000011F);
            button_power.Location = new Point(12, 427);
            button_power.Name = "button_power";
            button_power.Size = new Size(100, 60);
            button_power.TabIndex = 19;
            button_power.Text = "x^y";
            button_power.UseVisualStyleBackColor = true;
            button_power.Click += button_power_Click;
            // 
            // button_sqrroot
            // 
            button_sqrroot.Font = new Font("Segoe UI", 19.8000011F);
            button_sqrroot.Location = new Point(12, 493);
            button_sqrroot.Name = "button_sqrroot";
            button_sqrroot.Size = new Size(100, 60);
            button_sqrroot.TabIndex = 20;
            button_sqrroot.Text = "x√y";
            button_sqrroot.UseVisualStyleBackColor = true;
            button_sqrroot.Click += button_sqrroot_Click;
            // 
            // button_modulo
            // 
            button_modulo.Font = new Font("Segoe UI", 19.8000011F);
            button_modulo.Location = new Point(12, 559);
            button_modulo.Name = "button_modulo";
            button_modulo.Size = new Size(100, 60);
            button_modulo.TabIndex = 21;
            button_modulo.Text = "%";
            button_modulo.UseVisualStyleBackColor = true;
            button_modulo.Click += button_modulo_Click;
            // 
            // button23
            // 
            button23.Font = new Font("Segoe UI", 19.8000011F);
            button23.Location = new Point(436, 295);
            button23.Name = "button23";
            button23.Size = new Size(100, 60);
            button23.TabIndex = 22;
            button23.Text = "DEL";
            button23.UseVisualStyleBackColor = true;
            // 
            // textbox
            // 
            textbox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textbox.Location = new Point(12, 168);
            textbox.Multiline = true;
            textbox.Name = "textbox";
            textbox.Size = new Size(524, 105);
            textbox.TabIndex = 23;
            textbox.TextAlign = HorizontalAlignment.Right;
            // 
            // history
            // 
            history.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            history.Location = new Point(12, 12);
            history.Multiline = true;
            history.Name = "history";
            history.ReadOnly = true;
            history.Size = new Size(524, 87);
            history.TabIndex = 24;
            history.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(550, 631);
            Controls.Add(history);
            Controls.Add(textbox);
            Controls.Add(button23);
            Controls.Add(button_modulo);
            Controls.Add(button_sqrroot);
            Controls.Add(button_power);
            Controls.Add(button_factorial);
            Controls.Add(button16);
            Controls.Add(button_subtract);
            Controls.Add(plus);
            Controls.Add(button_divide);
            Controls.Add(clear);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
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
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button clear;
        private Button button_divide;
        private Button button16;
        private Button button_subtract;
        private Button plus;
        private Button button_factorial;
        private Button button_power;
        private Button button_sqrroot;
        private Button button_modulo;
        private Button button23;
        private TextBox textbox;
        private TextBox history;
    }
}
