namespace EmployeeApplication
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            label9 = new Label();
            label10 = new Label();
            lblFname = new Label();
            lblLname = new Label();
            lblBsalary = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 72);
            label1.Name = "label1";
            label1.Size = new Size(73, 17);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(313, 72);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 139);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 2;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(313, 139);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 3;
            label4.Text = "Job title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(73, 211);
            label5.Name = "label5";
            label5.Size = new Size(94, 17);
            label5.TabIndex = 4;
            label5.Text = "Rate per Hour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(313, 211);
            label6.Name = "label6";
            label6.Size = new Size(127, 17);
            label6.TabIndex = 5;
            label6.Text = "Total hours worked";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(313, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(73, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(202, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(313, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(202, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(73, 231);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(202, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(313, 231);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(202, 23);
            textBox6.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(297, 23);
            label7.Name = "label7";
            label7.Size = new Size(214, 20);
            label7.TabIndex = 12;
            label7.Text = "Employee Salary Calculation";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.Location = new Point(491, 305);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 13;
            label8.Text = "First name:";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(225, 273);
            button1.Name = "button1";
            button1.Size = new Size(127, 41);
            button1.TabIndex = 14;
            button1.Text = "Compute Salary";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.Location = new Point(491, 343);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 15;
            label9.Text = "Last name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label10.Location = new Point(491, 383);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 16;
            label10.Text = "Basic Salary:";
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblFname.Location = new Point(611, 305);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(138, 20);
            lblFname.TabIndex = 13;
            lblFname.Text = "<first name here>";
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblLname.Location = new Point(611, 343);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(134, 20);
            lblLname.TabIndex = 17;
            lblLname.Text = "<last name here>";
            // 
            // lblBsalary
            // 
            lblBsalary.AutoSize = true;
            lblBsalary.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblBsalary.Location = new Point(611, 383);
            lblBsalary.Name = "lblBsalary";
            lblBsalary.Size = new Size(49, 20);
            lblBsalary.TabIndex = 18;
            lblBsalary.Text = "00.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBsalary);
            Controls.Add(lblLname);
            Controls.Add(lblFname);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Label label9;
        private Label label10;
        private Label lblFname;
        private Label lblLname;
        private Label lblBsalary;
    }
}
