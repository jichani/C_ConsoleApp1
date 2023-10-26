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
            SuspendLayout();
            // 
            // NumButton1
            // 
            NumButton1.Location = new Point(23, 66);
            NumButton1.Name = "NumButton1";
            NumButton1.Size = new Size(63, 51);
            NumButton1.TabIndex = 0;
            NumButton1.Text = "1";
            NumButton1.UseVisualStyleBackColor = true;
            NumButton1.Click += NumButton1_Click;
            // 
            // NumButton2
            // 
            NumButton2.Location = new Point(105, 66);
            NumButton2.Name = "NumButton2";
            NumButton2.Size = new Size(63, 51);
            NumButton2.TabIndex = 1;
            NumButton2.Text = "2";
            NumButton2.UseVisualStyleBackColor = true;
            NumButton2.Click += NumButton2_Click;
            // 
            // NumScreen
            // 
            NumScreen.BackColor = Color.White;
            NumScreen.BorderStyle = BorderStyle.Fixed3D;
            NumScreen.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NumScreen.Location = new Point(23, 16);
            NumScreen.Name = "NumScreen";
            NumScreen.Size = new Size(513, 33);
            NumScreen.TabIndex = 2;
            NumScreen.Text = "0";
            NumScreen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NumPlus
            // 
            NumPlus.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NumPlus.Location = new Point(476, 66);
            NumPlus.Name = "NumPlus";
            NumPlus.Size = new Size(66, 51);
            NumPlus.TabIndex = 3;
            NumPlus.Text = "+";
            NumPlus.UseVisualStyleBackColor = true;
            NumPlus.Click += NumPlus_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 333);
            Controls.Add(NumPlus);
            Controls.Add(NumScreen);
            Controls.Add(NumButton2);
            Controls.Add(NumButton1);
            Name = "Calculator";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button NumButton1;
        private Button NumButton2;
        private Label NumScreen;
        private Button NumPlus;
    }
}