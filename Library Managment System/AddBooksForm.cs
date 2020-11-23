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
    public partial class AddBooksForm : Form
    {
        public AddBooksForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BookPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled=true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                InsertAllRecords();
                MessageBox.Show("Record Added Successfully","Submit Record",MessageBoxButtons.OK,MessageBoxIcon.Information);
                BookNameTextBox.Clear();
                BookAutherNameTextBox.Clear();
                BookPublicationsTextBox.Clear();
                BookPriceTextBox.Clear();
                BookPurchesDateTimePicker.CustomFormat = " ";
                BookQuantityTextBox.Clear();
                BookNameTextBox.Focus();

            }
        }

        private void InsertAllRecords()
        {
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_AddnewBook", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    //parameters
                    cmd.Parameters.AddWithValue("@BookName", BookNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@BookAutherName", BookAutherNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@BookPublication", BookPublicationsTextBox.Text);
                    cmd.Parameters.AddWithValue("@BookPrice", BookPriceTextBox.Text);
                    cmd.Parameters.AddWithValue("@BooPerchaseDate", BookPurchesDateTimePicker.Text);
                    cmd.Parameters.AddWithValue("@BookQuntity", BookQuantityTextBox.Text);
                    //Execute The Command
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool Isvalid()
        {
            if(BookNameTextBox.Text.Trim()==string.Empty)
            {
                ShawErrorMessage("Please Enter Book Name First");
                return false;
            }
            if(BookAutherNameTextBox.Text.Trim()==string.Empty)
            {
                ShawErrorMessage("Please Enter Book Auther Name First");
                return false;
            }
            if (BookPublicationsTextBox.Text.Trim()==string.Empty)
            {
                ShawErrorMessage("Please Enter Book Publications Name First");
                return false;
            }
            if (BookPriceTextBox.Text.Trim() == string.Empty)
            {
                ShawErrorMessage("Please Enter Book Price First");
                return false;
            }
            if (BookPurchesDateTimePicker.Text.Trim() == string.Empty)
            {
                ShawErrorMessage("Please Enter Book Puurchase Date First");
                return false;
            }
            if (BookQuantityTextBox.Text.Trim() == string.Empty)
            {
                ShawErrorMessage("Please Enter Book Quantity First");
                return false;
            }
            return true;
        }

        private void ShawErrorMessage(string p)
        {
            MessageBox.Show(p, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BookQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
