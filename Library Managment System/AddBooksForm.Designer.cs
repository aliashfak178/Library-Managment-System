namespace Library_Managment_System
{
    partial class AddBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooksForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BookPurchesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BookPublicationsTextBox = new System.Windows.Forms.TextBox();
            this.BookQuantityTextBox = new System.Windows.Forms.TextBox();
            this.BookPriceTextBox = new System.Windows.Forms.TextBox();
            this.BookAutherNameTextBox = new System.Windows.Forms.TextBox();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 115);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Books";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(137, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.CancelButton);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Controls.Add(this.BookPurchesDateTimePicker);
            this.panel2.Controls.Add(this.BookPublicationsTextBox);
            this.panel2.Controls.Add(this.BookQuantityTextBox);
            this.panel2.Controls.Add(this.BookPriceTextBox);
            this.panel2.Controls.Add(this.BookAutherNameTextBox);
            this.panel2.Controls.Add(this.BookNameTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(261, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 414);
            this.panel2.TabIndex = 2;
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(232, 351);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(99, 38);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(59, 351);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(99, 38);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BookPurchesDateTimePicker
            // 
            this.BookPurchesDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPurchesDateTimePicker.Location = new System.Drawing.Point(184, 240);
            this.BookPurchesDateTimePicker.Name = "BookPurchesDateTimePicker";
            this.BookPurchesDateTimePicker.Size = new System.Drawing.Size(216, 29);
            this.BookPurchesDateTimePicker.TabIndex = 4;
            // 
            // BookPublicationsTextBox
            // 
            this.BookPublicationsTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPublicationsTextBox.Location = new System.Drawing.Point(184, 144);
            this.BookPublicationsTextBox.Name = "BookPublicationsTextBox";
            this.BookPublicationsTextBox.Size = new System.Drawing.Size(216, 26);
            this.BookPublicationsTextBox.TabIndex = 2;
            // 
            // BookQuantityTextBox
            // 
            this.BookQuantityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookQuantityTextBox.Location = new System.Drawing.Point(184, 289);
            this.BookQuantityTextBox.Name = "BookQuantityTextBox";
            this.BookQuantityTextBox.Size = new System.Drawing.Size(216, 26);
            this.BookQuantityTextBox.TabIndex = 5;
            this.BookQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookQuantityTextBox_KeyPress);
            // 
            // BookPriceTextBox
            // 
            this.BookPriceTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPriceTextBox.Location = new System.Drawing.Point(184, 192);
            this.BookPriceTextBox.Name = "BookPriceTextBox";
            this.BookPriceTextBox.Size = new System.Drawing.Size(216, 26);
            this.BookPriceTextBox.TabIndex = 3;
            this.BookPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookPriceTextBox_KeyPress);
            // 
            // BookAutherNameTextBox
            // 
            this.BookAutherNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAutherNameTextBox.Location = new System.Drawing.Point(184, 95);
            this.BookAutherNameTextBox.Name = "BookAutherNameTextBox";
            this.BookAutherNameTextBox.Size = new System.Drawing.Size(216, 26);
            this.BookAutherNameTextBox.TabIndex = 1;
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameTextBox.Location = new System.Drawing.Point(184, 50);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(216, 26);
            this.BookNameTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Book Publication:-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Book Purchase Date:-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Book Quantity:-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Book Price:-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Author Name:-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name :-";
            // 
            // AddBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Books";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DateTimePicker BookPurchesDateTimePicker;
        private System.Windows.Forms.TextBox BookPublicationsTextBox;
        private System.Windows.Forms.TextBox BookQuantityTextBox;
        private System.Windows.Forms.TextBox BookPriceTextBox;
        private System.Windows.Forms.TextBox BookAutherNameTextBox;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}