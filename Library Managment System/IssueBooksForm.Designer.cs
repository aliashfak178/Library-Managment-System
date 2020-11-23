namespace Library_Managment_System
{
    partial class IssueBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooksForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.StudentButton = new System.Windows.Forms.Button();
            this.EnrollmentNOTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BookNameComboBox = new System.Windows.Forms.ComboBox();
            this.BoolsLabel = new System.Windows.Forms.Label();
            this.IssueButton = new System.Windows.Forms.Button();
            this.IssueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StudentDeptTextBox = new System.Windows.Forms.TextBox();
            this.StudentEmailTextBox = new System.Windows.Forms.TextBox();
            this.StudentContactTextBox = new System.Windows.Forms.TextBox();
            this.StudentSemisterTextBox = new System.Windows.Forms.TextBox();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 107);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISSUE BOOKS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.StudentButton);
            this.panel2.Controls.Add(this.EnrollmentNOTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(12, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 372);
            this.panel2.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.CloseButton.Location = new System.Drawing.Point(25, 307);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(228, 38);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "CLOSE";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentButton
            // 
            this.StudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.StudentButton.FlatAppearance.BorderSize = 0;
            this.StudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentButton.Location = new System.Drawing.Point(25, 247);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(237, 37);
            this.StudentButton.TabIndex = 1;
            this.StudentButton.Text = "SEARCH STUDENT";
            this.StudentButton.UseVisualStyleBackColor = false;
            this.StudentButton.Click += new System.EventHandler(this.StudentButton_Click);
            // 
            // EnrollmentNOTextBox
            // 
            this.EnrollmentNOTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollmentNOTextBox.Location = new System.Drawing.Point(19, 193);
            this.EnrollmentNOTextBox.Name = "EnrollmentNOTextBox";
            this.EnrollmentNOTextBox.Size = new System.Drawing.Size(243, 35);
            this.EnrollmentNOTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Enrollment NO.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(68, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.BookNameComboBox);
            this.panel3.Controls.Add(this.BoolsLabel);
            this.panel3.Controls.Add(this.IssueButton);
            this.panel3.Controls.Add(this.IssueDateTimePicker);
            this.panel3.Controls.Add(this.StudentDeptTextBox);
            this.panel3.Controls.Add(this.StudentEmailTextBox);
            this.panel3.Controls.Add(this.StudentContactTextBox);
            this.panel3.Controls.Add(this.StudentSemisterTextBox);
            this.panel3.Controls.Add(this.StudentNameTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(312, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 395);
            this.panel3.TabIndex = 2;
            // 
            // BookNameComboBox
            // 
            this.BookNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookNameComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameComboBox.FormattingEnabled = true;
            this.BookNameComboBox.Location = new System.Drawing.Point(180, 218);
            this.BookNameComboBox.Name = "BookNameComboBox";
            this.BookNameComboBox.Size = new System.Drawing.Size(216, 27);
            this.BookNameComboBox.TabIndex = 7;
            // 
            // BoolsLabel
            // 
            this.BoolsLabel.AutoSize = true;
            this.BoolsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoolsLabel.ForeColor = System.Drawing.Color.Red;
            this.BoolsLabel.Location = new System.Drawing.Point(110, 359);
            this.BoolsLabel.Name = "BoolsLabel";
            this.BoolsLabel.Size = new System.Drawing.Size(309, 19);
            this.BoolsLabel.TabIndex = 20;
            this.BoolsLabel.Text = "Maximum 3 Book Can be Issued to 1 Student";
            // 
            // IssueButton
            // 
            this.IssueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IssueButton.FlatAppearance.BorderSize = 0;
            this.IssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IssueButton.Location = new System.Drawing.Point(33, 309);
            this.IssueButton.Name = "IssueButton";
            this.IssueButton.Size = new System.Drawing.Size(372, 47);
            this.IssueButton.TabIndex = 9;
            this.IssueButton.Text = "Issue";
            this.IssueButton.UseVisualStyleBackColor = false;
            this.IssueButton.Click += new System.EventHandler(this.IssueButton_Click);
            // 
            // IssueDateTimePicker
            // 
            this.IssueDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueDateTimePicker.Location = new System.Drawing.Point(180, 262);
            this.IssueDateTimePicker.Name = "IssueDateTimePicker";
            this.IssueDateTimePicker.Size = new System.Drawing.Size(216, 26);
            this.IssueDateTimePicker.TabIndex = 8;
            // 
            // StudentDeptTextBox
            // 
            this.StudentDeptTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentDeptTextBox.Location = new System.Drawing.Point(180, 65);
            this.StudentDeptTextBox.Name = "StudentDeptTextBox";
            this.StudentDeptTextBox.Size = new System.Drawing.Size(216, 26);
            this.StudentDeptTextBox.TabIndex = 3;
            // 
            // StudentEmailTextBox
            // 
            this.StudentEmailTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentEmailTextBox.Location = new System.Drawing.Point(180, 182);
            this.StudentEmailTextBox.Name = "StudentEmailTextBox";
            this.StudentEmailTextBox.Size = new System.Drawing.Size(216, 26);
            this.StudentEmailTextBox.TabIndex = 6;
            // 
            // StudentContactTextBox
            // 
            this.StudentContactTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentContactTextBox.Location = new System.Drawing.Point(180, 144);
            this.StudentContactTextBox.Name = "StudentContactTextBox";
            this.StudentContactTextBox.Size = new System.Drawing.Size(216, 26);
            this.StudentContactTextBox.TabIndex = 5;
            // 
            // StudentSemisterTextBox
            // 
            this.StudentSemisterTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSemisterTextBox.Location = new System.Drawing.Point(180, 105);
            this.StudentSemisterTextBox.Name = "StudentSemisterTextBox";
            this.StudentSemisterTextBox.Size = new System.Drawing.Size(216, 26);
            this.StudentSemisterTextBox.TabIndex = 4;
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameTextBox.Location = new System.Drawing.Point(180, 21);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(216, 26);
            this.StudentNameTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Department :-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Issue Date: -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Book Name:-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Student Email :-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Student Contact : -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Student Semister : -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Student Name :-";
            // 
            // IssueBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(744, 512);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IssueBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Books";
            this.Load += new System.EventHandler(this.IssueBooksForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.TextBox EnrollmentNOTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label BoolsLabel;
        private System.Windows.Forms.Button IssueButton;
        private System.Windows.Forms.DateTimePicker IssueDateTimePicker;
        private System.Windows.Forms.TextBox StudentDeptTextBox;
        private System.Windows.Forms.TextBox StudentEmailTextBox;
        private System.Windows.Forms.TextBox StudentContactTextBox;
        private System.Windows.Forms.TextBox StudentSemisterTextBox;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox BookNameComboBox;
    }
}