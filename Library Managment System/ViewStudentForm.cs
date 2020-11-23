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
using Library_Managment_System.Properties;

namespace Library_Managment_System
{
    public partial class ViewStudentForm : Form
    {
        public ViewStudentForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            panel2.Enabled = false;
        }
        private DataTable DtStudent = new DataTable();
        private void ViewStudentForm_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            DtStudent = GetAllStudentData();
            StudentDataGridView.DataSource = DtStudent;
        }

        private DataTable GetAllStudentData()
        {
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllStudentDetail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    //Execute The Command
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtStudent.Load(reader);
                }
            }
            return DtStudent;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView Dv = DtStudent.DefaultView;
            Dv.RowFilter = "Enrollment_No LIKE '%" + SearchTextBox.Text + "%'";

            if (SearchTextBox.Text != "")
            {
                pictureBox1.Image = Resources.search1;
            }
            else
            {
                pictureBox1.Image = Resources.search;
            }
        }
        private int StudentID;
        private void StudentDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int Rowtoupdate = StudentDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            StudentID = (int)StudentDataGridView.Rows[Rowtoupdate].Cells["ID"].Value;

            DataTable DtStudentInfo = GetBookInfoByid(StudentID);
            DataRow row = DtStudentInfo.Rows[0];
            StudentNameTextBox.Text = row["Student Name"].ToString();
            EnrollmentTextBox.Text = row["Enrollment_No"].ToString();
            DeptTextBox.Text = row["Department"].ToString();
            SemisterTextBox.Text = row["Semister"].ToString();
            ContactTextBox.Text = row["Contact"].ToString();
            EmailTextBox.Text = row["Email"].ToString();
        }

        private DataTable GetBookInfoByid(int StudentID)
        {
            DataTable DtStudentinfo = new DataTable();
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetStudentByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);

                    //Execute The Command
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtStudentinfo.Load(reader);
                }
            }
            return DtStudentinfo;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Realy Want To Update Record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UpdateBookInfo();
                MessageBox.Show("Record Update Sucessfully", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //LoadStudentData();
        }

        private void UpdateBookInfo()
        {
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_UpdateStudentRecord", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    //parameters
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    cmd.Parameters.AddWithValue("@StudentName", StudentNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@EnrollID", EnrollmentTextBox.Text);
                    cmd.Parameters.AddWithValue("@Department", DeptTextBox.Text);
                    cmd.Parameters.AddWithValue("@Semister", SemisterTextBox.Text);
                    cmd.Parameters.AddWithValue("@Contact", ContactTextBox.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
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
           // LoadStudentData();
        }

        private void DeleteBookInfo()
        {
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DeleteStudentRecord", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    //parameters
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    //Execute The Command
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
