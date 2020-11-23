using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilitys;
using System.Data.SqlClient;

namespace Library_Managment_System
{
    public partial class ViewBookForm : Form
    {
        public ViewBookForm()
        {
            InitializeComponent();
        }
        
        private void ViewBookForm_Load(object sender, EventArgs e)
        {
            GetGridView();   
        }
        private DataTable DtBooks = new DataTable();
        private void GetGridView()
        {
            DtBooks = GetAllBookData();
            BookDataGridView.DataSource = DtBooks;
        }
        
        private DataTable GetAllBookData()
        {
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllBookDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    //Execute The Command
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtBooks.Load(reader);
                }     
            }
            return DtBooks;
        }

        private int BookID;
        private void BookDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int Rowtoupdate = BookDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            BookID = (int)BookDataGridView.Rows[Rowtoupdate].Cells["BookID"].Value;

            DataTable DtBookInfo = GetBookInfoByid(BookID);
            DataRow row = DtBookInfo.Rows[0];
            BookNameTextBox.Text = row["BookName"].ToString();
            BookAutherTextBox.Text = row["BookAuther"].ToString();
            BookPublicationTextBox.Text = row["BookPublication"].ToString();
            BookPurchaseDateTimePicker.Value = Convert.ToDateTime(row["BookPurchaseDate"]);
            BookPriceTextBox.Text = row["BookPrice"].ToString();
            BookQuantityTextBox.Text = row["BookQuantity"].ToString();

            panel2.Visible = true;
        }

        private DataTable GetBookInfoByid(int BookID)
        {
            DataTable DtBookinfo = new DataTable();
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetBookInfoById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    cmd.Parameters.AddWithValue("@BookId",BookID);

                    //Execute The Command
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtBookinfo.Load(reader);
                }
            }
            return DtBookinfo;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView DvBook = DtBooks.DefaultView;
            DvBook.RowFilter = "BookName LIKE '%" + SearchTextBox.Text + "%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            panel2.Visible = false;
            //GetGridView();  
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Realy Want To Update Record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UpdateBookInfo();
                MessageBox.Show("Record Update Sucessfully", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

             
       }

        private void UpdateBookInfo()
        {
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_UpdateBookinfo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    //parameters
                    cmd.Parameters.AddWithValue("@BookId", BookID);
                    cmd.Parameters.AddWithValue("@BName", BookNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@BAuther", BookAutherTextBox.Text);
                    cmd.Parameters.AddWithValue("@BPublication", BookPublicationTextBox.Text);
                    cmd.Parameters.AddWithValue("@BPrice", BookPriceTextBox.Text);
                    cmd.Parameters.AddWithValue("@BPurchaseDate", BookPurchaseDateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@BQuantity", BookQuantityTextBox.Text);
                    //Execute The Command
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Realy Want To Delete Record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteBookInfo();
                MessageBox.Show("Record Delted Sucessfully", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteBookInfo()
        {
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DeleteBookRecord", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    //parameters
                    cmd.Parameters.AddWithValue("@BookId", BookID);
                    //Execute The Command
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
