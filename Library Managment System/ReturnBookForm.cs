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
    public partial class ReturnBookForm : Form
    {
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            if (EnrollmentNOTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Enrollment NO", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    IRRecordDataGridView.DataSource = GetStudentByNO(EnrollmentNOTextBox.Text);
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Is Wrong Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }

        private DataTable GetStudentByNO(string p)
        {
            DataTable DtBookinfo = new DataTable();
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetIRDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    cmd.Parameters.AddWithValue("@Enrollment", p);

                    //Execute The Command
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtBookinfo.Load(reader);
                }
            }
            return DtBookinfo;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            if (BookTextBox.Text.Trim() != string.Empty && BookIssueDataTextBox.Text.Trim() != string.Empty)
            {
                DialogResult result = MessageBox.Show("Do You Realy Want To Return Book", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ReturnBooks(IRID);
                    MessageBox.Show("Book Return SuccessFully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BookTextBox.Clear();
                    BookIssueDataTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please Select Book Name And Issue Date First","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ReturnBooks(int IRID)
        {
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_ReturnBooks", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    //parameters
                    cmd.Parameters.AddWithValue("@IRID", IRID);
                    cmd.Parameters.AddWithValue("@ReturnDate", ReturnBookDateTimePicker.Text);
                    //Execute The Command
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private int IRID;
        private void IRRecordDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int Rowtoupdate = IRRecordDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            IRID = (int)IRRecordDataGridView.Rows[Rowtoupdate].Cells["IRID"].Value;

            DataTable DtIRInfo = GetIRInfoByid(IRID);
            DataRow row = DtIRInfo.Rows[0];
            BookTextBox.Text = row["BookName"].ToString();
            BookIssueDataTextBox.Text = row["BookIsuueDate"].ToString();
        }

        private DataTable GetIRInfoByid(int IRID)
        {
            DataTable DTIRinfo = new DataTable();
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetIRinfo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    cmd.Parameters.AddWithValue("@IRID", IRID);

                    //Execute The Command
                    SqlDataReader reader = cmd.ExecuteReader();
                    DTIRinfo.Load(reader);
                }
            }
            return DTIRinfo;
        }


    }
}
