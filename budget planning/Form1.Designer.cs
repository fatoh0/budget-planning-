namespace budget_planning
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel5 = new Panel();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 516);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 26);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 0;
            label1.Text = "Budget Planning";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(217, 68);
            label2.Name = "label2";
            label2.Size = new Size(251, 15);
            label2.TabIndex = 1;
            label2.Text = "Set spending limits and monitor your progress";
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(626, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 100);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(414, 158);
            panel3.Name = "panel3";
            panel3.Size = new Size(181, 100);
            panel3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(3, 12);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 0;
            label4.Text = "Spent So Far";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(3, 12);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 0;
            label5.Text = "Remaining";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(681, 279);
            button1.Name = "button1";
            button1.Size = new Size(118, 32);
            button1.TabIndex = 5;
            button1.Text = "+ New Budget";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 45);
            label7.Name = "label7";
            label7.Size = new Size(61, 25);
            label7.TabIndex = 1;
            label7.Text = "0.00$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 45);
            label8.Name = "label8";
            label8.Size = new Size(61, 25);
            label8.TabIndex = 1;
            label8.Text = "0.00$";
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(217, 158);
            panel4.Name = "panel4";
            panel4.Size = new Size(160, 100);
            panel4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 0;
            label3.Text = "Monthly Budget";
            label3.Click += label3_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 45);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 1;
            label6.Text = "0.00$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(35, 170);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 0;
            label9.Text = "D      Dashboard";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(37, 213);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 1;
            label10.Text = "I      Income";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(35, 266);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 2;
            label11.Text = "E      Expenses";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(35, 311);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 3;
            label12.Text = "B      Budget";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(35, 358);
            label13.Name = "label13";
            label13.Size = new Size(67, 15);
            label13.TabIndex = 4;
            label13.Text = "R      Report";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(label14);
            panel5.Location = new Point(220, 326);
            panel5.Name = "panel5";
            panel5.Size = new Size(579, 181);
            panel5.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(18, 23);
            label14.Name = "label14";
            label14.Size = new Size(155, 15);
            label14.TabIndex = 0;
            label14.Text = "Monthly Category Budgets";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = Properties.Resources._39c8f16f856d23e08b995f8facdbcf8d;
            pictureBox1.Location = new Point(269, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(248, 114);
            label15.Name = "label15";
            label15.Size = new Size(138, 15);
            label15.TabIndex = 2;
            label15.Text = "No budgets created yet";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.DimGray;
            label16.Location = new Point(209, 140);
            label16.Name = "label16";
            label16.Size = new Size(258, 15);
            label16.TabIndex = 3;
            label16.Text = "Create a budget to start tracking category limits";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(35, 44);
            label17.Name = "label17";
            label17.Size = new Size(108, 25);
            label17.TabIndex = 5;
            label17.Text = "MyFinance";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(37, 80);
            label18.Name = "label18";
            label18.Size = new Size(70, 13);
            label18.TabIndex = 6;
            label18.Text = "MAIN MENU";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "January 2027", "", "February 2027", "", "March 2027", "", "April 2027", "", "May 2027", "June 2027", "July 2027", "August 2027", "", "September 2027", "", "October 2027", "November 2027", "", "December 2027" });
            comboBox1.Location = new Point(678, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 516);
            Controls.Add(comboBox1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Label label4;
        private Button button1;
        private Label label8;
        private Label label7;
        private Panel panel4;
        private Label label3;
        private Label label6;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Panel panel5;
        private Label label14;
        private PictureBox pictureBox1;
        private Label label16;
        private Label label15;
        private Label label18;
        private Label label17;
        private ComboBox comboBox1;
    }
}
