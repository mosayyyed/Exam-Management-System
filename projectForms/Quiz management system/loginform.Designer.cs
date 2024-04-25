
namespace Quiz_management_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtselectuser = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wronglabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtuser_id = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnstudentlogin = new System.Windows.Forms.Button();
            this.txtenrollementno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnstudentregister = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(539, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz management system";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(670, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "select user type";
            // 
            // txtselectuser
            // 
            this.txtselectuser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtselectuser.FormattingEnabled = true;
            this.txtselectuser.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.txtselectuser.Location = new System.Drawing.Point(638, 214);
            this.txtselectuser.Name = "txtselectuser";
            this.txtselectuser.Size = new System.Drawing.Size(391, 40);
            this.txtselectuser.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 778);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.txtuser_id);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.wronglabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(638, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 433);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(85, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcom back";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(168, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "User id";
            // 
            // wronglabel
            // 
            this.wronglabel.AutoSize = true;
            this.wronglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wronglabel.ForeColor = System.Drawing.Color.Red;
            this.wronglabel.Location = new System.Drawing.Point(109, 379);
            this.wronglabel.Name = "wronglabel";
            this.wronglabel.Size = new System.Drawing.Size(188, 22);
            this.wronglabel.TabIndex = 2;
            this.wronglabel.Text = "wrong user name or id";
            this.wronglabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(156, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Username";
            // 
            // txtuser_id
            // 
            this.txtuser_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser_id.Location = new System.Drawing.Point(76, 209);
            this.txtuser_id.Name = "txtuser_id";
            this.txtuser_id.Size = new System.Drawing.Size(284, 35);
            this.txtuser_id.TabIndex = 4;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(76, 113);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(284, 35);
            this.txtusername.TabIndex = 5;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlogin.FlatAppearance.BorderSize = 18;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnlogin.ImageKey = "(none)";
            this.btnlogin.Location = new System.Drawing.Point(120, 298);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(197, 48);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnstudentregister);
            this.panel2.Controls.Add(this.btnstudentlogin);
            this.panel2.Controls.Add(this.txtenrollementno);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 433);
            this.panel2.TabIndex = 7;
            // 
            // btnstudentlogin
            // 
            this.btnstudentlogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnstudentlogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnstudentlogin.FlatAppearance.BorderSize = 18;
            this.btnstudentlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudentlogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnstudentlogin.ImageKey = "(none)";
            this.btnstudentlogin.Location = new System.Drawing.Point(120, 266);
            this.btnstudentlogin.Name = "btnstudentlogin";
            this.btnstudentlogin.Size = new System.Drawing.Size(197, 42);
            this.btnstudentlogin.TabIndex = 6;
            this.btnstudentlogin.Text = "Login";
            this.btnstudentlogin.UseVisualStyleBackColor = false;
            // 
            // txtenrollementno
            // 
            this.txtenrollementno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtenrollementno.Location = new System.Drawing.Point(71, 156);
            this.txtenrollementno.Name = "txtenrollementno";
            this.txtenrollementno.Size = new System.Drawing.Size(284, 35);
            this.txtenrollementno.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(99, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Student Enrollement No";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(116, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "wrong user name or id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(81, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 40);
            this.label9.TabIndex = 0;
            this.label9.Text = "Welcome back";
            // 
            // btnstudentregister
            // 
            this.btnstudentregister.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnstudentregister.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnstudentregister.FlatAppearance.BorderSize = 18;
            this.btnstudentregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudentregister.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnstudentregister.ImageKey = "(none)";
            this.btnstudentregister.Location = new System.Drawing.Point(120, 331);
            this.btnstudentregister.Name = "btnstudentregister";
            this.btnstudentregister.Size = new System.Drawing.Size(197, 42);
            this.btnstudentregister.TabIndex = 7;
            this.btnstudentregister.Text = "Register";
            this.btnstudentregister.UseVisualStyleBackColor = false;
            // 
            // btnexit
            // 
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(1170, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(61, 41);
            this.btnexit.TabIndex = 8;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtselectuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtselectuser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtuser_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label wronglabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnstudentregister;
        private System.Windows.Forms.Button btnstudentlogin;
        private System.Windows.Forms.TextBox txtenrollementno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnexit;
    }
}

