namespace Calcolatrice
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
            btn1 = new Button();
            lbl = new Label();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnclean = new Button();
            btnp = new Button();
            btnm = new Button();
            btnmol = new Button();
            btnu = new Button();
            btnd = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(233, 164);
            btn1.Name = "btn1";
            btn1.Size = new Size(47, 40);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(234, 133);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 15);
            lbl.TabIndex = 1;
            // 
            // btn2
            // 
            btn2.Location = new Point(286, 164);
            btn2.Name = "btn2";
            btn2.Size = new Size(47, 40);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(339, 164);
            btn3.Name = "btn3";
            btn3.Size = new Size(47, 40);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(233, 210);
            btn4.Name = "btn4";
            btn4.Size = new Size(47, 40);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(286, 210);
            btn5.Name = "btn5";
            btn5.Size = new Size(47, 40);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(339, 210);
            btn6.Name = "btn6";
            btn6.Size = new Size(47, 40);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(233, 256);
            btn7.Name = "btn7";
            btn7.Size = new Size(47, 40);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(286, 256);
            btn8.Name = "btn8";
            btn8.Size = new Size(47, 40);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(339, 256);
            btn9.Name = "btn9";
            btn9.Size = new Size(47, 40);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(234, 302);
            btn0.Name = "btn0";
            btn0.Size = new Size(47, 40);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnclean
            // 
            btnclean.Location = new Point(180, 164);
            btnclean.Name = "btnclean";
            btnclean.Size = new Size(47, 40);
            btnclean.TabIndex = 11;
            btnclean.Text = "AC";
            btnclean.UseVisualStyleBackColor = true;
            btnclean.Click += btnclean_Click;
            // 
            // btnp
            // 
            btnp.Location = new Point(392, 164);
            btnp.Name = "btnp";
            btnp.Size = new Size(47, 40);
            btnp.TabIndex = 12;
            btnp.Text = "+";
            btnp.UseVisualStyleBackColor = true;
            btnp.Click += btnp_Click;
            // 
            // btnm
            // 
            btnm.Location = new Point(392, 210);
            btnm.Name = "btnm";
            btnm.Size = new Size(47, 40);
            btnm.TabIndex = 13;
            btnm.Text = "-";
            btnm.UseVisualStyleBackColor = true;
            btnm.Click += btnm_Click;
            // 
            // btnmol
            // 
            btnmol.Location = new Point(392, 256);
            btnmol.Name = "btnmol";
            btnmol.Size = new Size(47, 40);
            btnmol.TabIndex = 14;
            btnmol.Text = "*";
            btnmol.UseVisualStyleBackColor = true;
            btnmol.Click += btnmol_Click;
            // 
            // btnu
            // 
            btnu.Location = new Point(286, 302);
            btnu.Name = "btnu";
            btnu.Size = new Size(100, 40);
            btnu.TabIndex = 15;
            btnu.Text = "=";
            btnu.UseVisualStyleBackColor = true;
            btnu.Click += btnu_Click;
            // 
            // btnd
            // 
            btnd.Location = new Point(392, 302);
            btnd.Name = "btnd";
            btnd.Size = new Size(47, 40);
            btnd.TabIndex = 16;
            btnd.Text = "/";
            btnd.UseVisualStyleBackColor = true;
            btnd.Click += btnd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnd);
            Controls.Add(btnu);
            Controls.Add(btnmol);
            Controls.Add(btnm);
            Controls.Add(btnp);
            Controls.Add(btnclean);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(lbl);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Label lbl;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnclean;
        private Button btnp;
        private Button btnm;
        private Button btnmol;
        private Button btnu;
        private Button btnd;
    }
}
