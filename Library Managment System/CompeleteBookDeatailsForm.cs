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
    public partial class CompeleteBookDeatailsForm : Form
    {
        public CompeleteBookDeatailsForm()
        {
            InitializeComponent();
        }

        private void CompeleteBookDeatailsForm_Load(object sender, EventArgs e)
        {
            IssedBooks();
            ReturnBooks();
        }

        private void ReturnBooks()
        {
            ReturnBookDataGridView.DataSource = ReturnBooksData();
        }

        private DataTable ReturnBooksData()
        {
            DataTable DtBooks = new DataTable();
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllReturnBook", conn))
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

        private void IssedBooks()
        {
            IssuedBookDataGridView.DataSource = GetData();
        }

        private DataTable GetData()
        {
            DataTable DtBooks = new DataTable();
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllIsseudBook", conn))
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
    }
}
