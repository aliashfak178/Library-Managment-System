namespace Library_Managment_System
{
    partial class ViewBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BookDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BookPublicationTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BookPriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BookPurchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.BookQuantityTextBox = new System.Windows.Forms.TextBox();
            this.BookAutherTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 123);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(396, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(332, 133);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(228, 32);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(579, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookDataGridView
            // 
            this.BookDataGridView.AllowUserToAddRows = false;
            this.BookDataGridView.AllowUserToDeleteRows = false;
            this.BookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataGridView.Location = new System.Drawing.Point(12, 175);
            this.BookDataGridView.Name = "BookDataGridView";
            this.BookDataGridView.ReadOnly = true;
            this.BookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDataGridView.Size = new System.Drawing.Size(960, 275);
            this.BookDataGridView.TabIndex = 4;
            this.BookDataGridView.DoubleClick += new System.EventHandler(this.BookDataGridView_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.UpdateButton);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.BookPublicationTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.BookPriceTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.CancelButton);
            this.panel2.Controls.Add(this.BookPurchaseDateTimePicker);
            this.panel2.Controls.Add(this.BookNameTextBox);
            this.panel2.Controls.Add(this.BookQuantityTextBox);
            this.panel2.Controls.Add(this.BookAutherTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Location = new System.Drawing.Point(12, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 330);
            this.panel2.TabIndex = 5;
            // 
            // UpdateButton
            // 
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(549, 269);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(115, 32);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(672, 269);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(115, 32);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Book Publication";
            // 
            // BookPublicationTextBox
            // 
            this.BookPublicationTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPublicationTextBox.Location = new System.Drawing.Point(217, 173);
            this.BookPublicationTextBox.Name = "BookPublicationTextBox";
            this.BookPublicationTextBox.Size = new System.Drawing.Size(234, 32);
            this.BookPublicationTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(506, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Book Price";
            // 
            // BookPriceTextBox
            // 
            this.BookPriceTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPriceTextBox.Location = new System.Drawing.Point(726, 115);
            this.BookPriceTextBox.Name = "BookPriceTextBox";
            this.BookPriceTextBox.Size = new System.Drawing.Size(221, 32);
            this.BookPriceTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(506, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Book Purchase Date";
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(793, 269);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 32);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BookPurchaseDateTimePicker
            // 
            this.BookPurchaseDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPurchaseDateTimePicker.Location = new System.Drawing.Point(726, 42);
            this.BookPurchaseDateTimePicker.Name = "BookPurchaseDateTimePicker";
            this.BookPurchaseDateTimePicker.Size = new System.Drawing.Size(221, 32);
            this.BookPurchaseDateTimePicker.TabIndex = 3;
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameTextBox.Location = new System.Drawing.Point(217, 48);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(234, 32);
            this.BookNameTextBox.TabIndex = 0;
            // 
            // BookQuantityTextBox
            // 
            this.BookQuantityTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookQuantityTextBox.Location = new System.Drawing.Point(726, 173);
            this.BookQuantityTextBox.Name = "BookQuantityTextBox";
            this.BookQuantityTextBox.Size = new System.Drawing.Size(221, 32);
            this.BookQuantityTextBox.TabIndex = 5;
            // 
            // BookAutherTextBox
            // 
            this.BookAutherTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAutherTextBox.Location = new System.Drawing.Point(217, 112);
            this.BookAutherTextBox.Name = "BookAutherTextBox";
            this.BookAutherTextBox.Size = new System.Drawing.Size(234, 32);
            this.BookAutherTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Book Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(506, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Book Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Auther Name";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(962, 330);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DarkOrange;
            this.lineShape1.BorderWidth = 6;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 482;
            this.lineShape1.X2 = 482;
            this.lineShape1.Y1 = 4;
            this.lineShape1.Y2 = 228;
            // 
            // ViewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1020, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BookDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Books";
            this.Load += new System.EventHandler(this.ViewBookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView BookDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BookPublicationTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BookPriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DateTimePicker BookPurchaseDateTimePicker;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.TextBox BookQuantityTextBox;
        private System.Windows.Forms.TextBox BookAutherTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}