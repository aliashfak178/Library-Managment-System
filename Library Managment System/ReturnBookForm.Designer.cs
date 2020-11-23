namespace Library_Managment_System
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.StudentButton = new System.Windows.Forms.Button();
            this.EnrollmentNOTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.IRRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButten = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.ReturnBookDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BookIssueDataTextBox = new System.Windows.Forms.TextBox();
            this.BookTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IRRecordDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            this.panel2.Location = new System.Drawing.Point(2, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 438);
            this.panel2.TabIndex = 2;
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
            // IRRecordDataGridView
            // 
            this.IRRecordDataGridView.AllowUserToAddRows = false;
            this.IRRecordDataGridView.AllowUserToDeleteRows = false;
            this.IRRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IRRecordDataGridView.Location = new System.Drawing.Point(296, 12);
            this.IRRecordDataGridView.Name = "IRRecordDataGridView";
            this.IRRecordDataGridView.ReadOnly = true;
            this.IRRecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IRRecordDataGridView.Size = new System.Drawing.Size(676, 218);
            this.IRRecordDataGridView.TabIndex = 3;
            this.IRRecordDataGridView.DoubleClick += new System.EventHandler(this.IRRecordDataGridView_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.CloseButten);
            this.panel1.Controls.Add(this.ReturnButton);
            this.panel1.Controls.Add(this.ReturnBookDateTimePicker);
            this.panel1.Controls.Add(this.BookIssueDataTextBox);
            this.panel1.Controls.Add(this.BookTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(296, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 214);
            this.panel1.TabIndex = 4;
            // 
            // CloseButten
            // 
            this.CloseButten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CloseButten.FlatAppearance.BorderSize = 0;
            this.CloseButten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButten.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButten.Location = new System.Drawing.Point(555, 107);
            this.CloseButten.Name = "CloseButten";
            this.CloseButten.Size = new System.Drawing.Size(101, 42);
            this.CloseButten.TabIndex = 3;
            this.CloseButten.Text = "Close";
            this.CloseButten.UseVisualStyleBackColor = false;
            this.CloseButten.Click += new System.EventHandler(this.CloseButten_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ReturnButton.FlatAppearance.BorderSize = 0;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(555, 39);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(101, 42);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // ReturnBookDateTimePicker
            // 
            this.ReturnBookDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBookDateTimePicker.Location = new System.Drawing.Point(304, 134);
            this.ReturnBookDateTimePicker.Name = "ReturnBookDateTimePicker";
            this.ReturnBookDateTimePicker.Size = new System.Drawing.Size(224, 32);
            this.ReturnBookDateTimePicker.TabIndex = 2;
            // 
            // BookIssueDataTextBox
            // 
            this.BookIssueDataTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssueDataTextBox.Location = new System.Drawing.Point(304, 80);
            this.BookIssueDataTextBox.Name = "BookIssueDataTextBox";
            this.BookIssueDataTextBox.ReadOnly = true;
            this.BookIssueDataTextBox.Size = new System.Drawing.Size(224, 32);
            this.BookIssueDataTextBox.TabIndex = 1;
            // 
            // BookTextBox
            // 
            this.BookTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTextBox.Location = new System.Drawing.Point(304, 29);
            this.BookTextBox.Name = "BookTextBox";
            this.BookTextBox.ReadOnly = true;
            this.BookTextBox.Size = new System.Drawing.Size(224, 32);
            this.BookTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Book Return Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Issue Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IRRecordDataGridView);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReturnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IRRecordDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.TextBox EnrollmentNOTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView IRRecordDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButten;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.DateTimePicker ReturnBookDateTimePicker;
        private System.Windows.Forms.TextBox BookIssueDataTextBox;
        private System.Windows.Forms.TextBox BookTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}