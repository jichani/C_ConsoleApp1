namespace HelloCharpWin
{
    partial class Calculator
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
            NumButton1 = new Button();
            NumButton2 = new Button();
            NumScreen = new Label();
            NumPlus = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            NumClear = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // NumButton1
            // 
            NumButton1.Location = new Point(30, 377);
            NumButton1.Margin = new Padding(4);
            NumButton1.Name = "NumButton1";
            NumButton1.Size = new Size(80, 80);
            NumButton1.TabIndex = 0;
            NumButton1.Text = "1";
            NumButton1.UseVisualStyleBackColor = true;
            NumButton1.Click += NumButton1_Click;
            // 
            // NumButton2
            // 
            NumButton2.Location = new Point(118, 377);
            NumButton2.Margin = new Padding(4);
            NumButton2.Name = "NumButton2";
            NumButton2.Size = new Size(80, 80);
            NumButton2.TabIndex = 1;
            NumButton2.Text = "2";
            NumButton2.UseVisualStyleBackColor = true;
            NumButton2.Click += NumButton1_Click;
            // 
            // NumScreen
            // 
            NumScreen.BackColor = Color.White;
            NumScreen.BorderStyle = BorderStyle.Fixed3D;
            NumScreen.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NumScreen.Location = new Point(30, 21);
            NumScreen.Margin = new Padding(4, 0, 4, 0);
            NumScreen.Name = "NumScreen";
            NumScreen.Size = new Size(365, 44);
            NumScreen.TabIndex = 2;
            NumScreen.Text = "0";
            NumScreen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NumPlus
            // 
            NumPlus.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NumPlus.Location = new Point(315, 377);
            NumPlus.Margin = new Padding(4);
            NumPlus.Name = "NumPlus";
            NumPlus.Size = new Size(80, 80);
            NumPlus.TabIndex = 3;
            NumPlus.Text = "+";
            NumPlus.UseVisualStyleBackColor = true;
            NumPlus.Click += NumOpt_Click;
            // 
            // button1
            // 
            button1.Location = new Point(206, 377);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(80, 80);
            button1.TabIndex = 4;
            button1.Text = "3";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NumButton1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(30, 289);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(80, 80);
            button2.TabIndex = 5;
            button2.Text = "4";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NumButton1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(118, 289);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(80, 80);
            button3.TabIndex = 6;
            button3.Text = "5";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumButton1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(206, 289);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(80, 80);
            button4.TabIndex = 7;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NumButton1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(30, 201);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(80, 80);
            button5.TabIndex = 8;
            button5.Text = "7";
            button5.UseVisualStyleBackColor = true;
            button5.Click += NumButton1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(118, 201);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(80, 80);
            button6.TabIndex = 9;
            button6.Text = "8";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumButton1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(206, 201);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(80, 80);
            button7.TabIndex = 10;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumButton1_Click;
            // 
            // button8
            // 
            button8.Location = new Point(118, 465);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(80, 80);
            button8.TabIndex = 11;
            button8.Text = "0";
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumButton1_Click;
            // 
            // button9
            // 
            button9.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(315, 286);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(80, 80);
            button9.TabIndex = 12;
            button9.Text = "-";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumOpt_Click;
            // 
            // NumClear
            // 
            NumClear.Location = new Point(118, 113);
            NumClear.Margin = new Padding(4);
            NumClear.Name = "NumClear";
            NumClear.Size = new Size(80, 80);
            NumClear.TabIndex = 13;
            NumClear.Text = "C";
            NumClear.UseVisualStyleBackColor = true;
            NumClear.Click += NumClear_Click;
            // 
            // button10
            // 
            button10.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(315, 465);
            button10.Margin = new Padding(4);
            button10.Name = "button10";
            button10.Size = new Size(80, 80);
            button10.TabIndex = 14;
            button10.Text = "=";
            button10.UseVisualStyleBackColor = true;
            button10.Click += NumOpt_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 570);
            Controls.Add(button10);
            Controls.Add(NumClear);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NumPlus);
            Controls.Add(NumScreen);
            Controls.Add(NumButton2);
            Controls.Add(NumButton1);
            Margin = new Padding(4);
            Name = "Calculator";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button NumButton1;
        private Button NumButton2;
        private Label NumScreen;
        private Button NumPlus;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button NumClear;
        private Button button10;
    }
}