namespace Library_Managment_System
{
    partial class CompeleteBookDeatailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.IssuedBookDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ReturnBookDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.IssuedBookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(687, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "RETURN BOOK";
            // 
            // IssuedBookDataGridView
            // 
            this.IssuedBookDataGridView.AllowUserToAddRows = false;
            this.IssuedBookDataGridView.AllowUserToDeleteRows = false;
            this.IssuedBookDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.IssuedBookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IssuedBookDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.IssuedBookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssuedBookDataGridView.Location = new System.Drawing.Point(12, 50);
            this.IssuedBookDataGridView.Name = "IssuedBookDataGridView";
            this.IssuedBookDataGridView.ReadOnly = true;
            this.IssuedBookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IssuedBookDataGridView.Size = new System.Drawing.Size(1011, 219);
            this.IssuedBookDataGridView.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(390, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "ISSUED BOOK";
            // 
            // ReturnBookDataGridView
            // 
            this.ReturnBookDataGridView.AllowUserToAddRows = false;
            this.ReturnBookDataGridView.AllowUserToDeleteRows = false;
            this.ReturnBookDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnBookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReturnBookDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ReturnBookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnBookDataGridView.Location = new System.Drawing.Point(11, 321);
            this.ReturnBookDataGridView.Name = "ReturnBookDataGridView";
            this.ReturnBookDataGridView.ReadOnly = true;
            this.ReturnBookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReturnBookDataGridView.Size = new System.Drawing.Size(1011, 247);
            this.ReturnBookDataGridView.TabIndex = 2;
            // 
            // CompeleteBookDeatailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1034, 502);
            this.Controls.Add(this.ReturnBookDataGridView);
            this.Controls.Add(this.IssuedBookDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CompeleteBookDeatailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compelete Book Deatails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompeleteBookDeatailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IssuedBookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView IssuedBookDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ReturnBookDataGridView;
    }
}