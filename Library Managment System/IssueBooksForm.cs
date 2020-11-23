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
    public partial class IssueBooksForm : Form
    {
        public IssueBooksForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IssueBooksForm_Load(object sender, EventArgs e)
        {
            GetAllBooks();
        }

        private void GetAllBooks()
        {
            BookNameComboBox.DataSource = GetBookName();
            BookNameComboBox.DisplayMember = "BookName";
            BookNameComboBox.SelectedIndex = -1;
        }

        private DataTable GetBookName()
        {
            DataTable DtBooks = new DataTable();
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
        private int count;
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
                    DataTable DtStudent = GetStudentByNO(EnrollmentNOTextBox.Text);
                    DataRow row = DtStudent.Rows[0];
                    StudentNameTextBox.Text = row["StudentName"].ToString();
                    StudentDeptTextBox.Text = row["DepartMent"].ToString();
                    StudentSemisterTextBox.Text = row["Semister"].ToString();
                    StudentContactTextBox.Text = row["Contact"].ToString();
                    StudentEmailTextBox.Text = row["Email"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Is Wrong Enrollment No","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    ClearAllTextBoxes();
                }
                //--------------------Count Number of books issued-------------------//
                DataTable DtCount = GetCount(EnrollmentNOTextBox.Text);
                DataRow row1 = DtCount.Rows[0];
                count = int.Parse(row1["Count"].ToString());
            }
        }

        private DataTable GetCount(string p)
        {
            DataTable DtCounts = new DataTable();
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetCount", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    cmd.Parameters.AddWithValue("@Enrollment", p);

                    //Execute The Command
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtCounts.Load(reader);
                }
            }
            return DtCounts;
        }

        private void ClearAllTextBoxes()
        {
            StudentNameTextBox.Clear();
            StudentDeptTextBox.Clear();
            StudentSemisterTextBox.Clear();
            StudentContactTextBox.Clear();
            StudentEmailTextBox.Clear();
            EnrollmentNOTextBox.Focus();
        }

        private DataTable GetStudentByNO(string p)
        {
            DataTable DtBookinfo = new DataTable();
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetStudentByEnrollmentNO", conn))
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

        private void IssueButton_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                MessageBox.Show("Please Fill All Record First", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (count <= 4)
                {
                    IssedBooks();
                    MessageBox.Show("Book Issed Successfully And Number Of Book Isued " + count,"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    StudentNameTextBox.Clear();
                    StudentDeptTextBox.Clear();
                    StudentSemisterTextBox.Clear();
                    StudentContactTextBox.Clear();
                    StudentEmailTextBox.Clear();
                    BookNameComboBox.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Allready Issued 4 Books Can't Issed More Book","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
        }

        private void IssedBooks()
        {
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_IssuedBooks", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    //parameters
                    cmd.Parameters.AddWithValue("@Enrollid", EnrollmentNOTextBox.Text);
                    cmd.Parameters.AddWithValue("@S_name", StudentNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@S_Dept", StudentDeptTextBox.Text);
                    cmd.Parameters.AddWithValue("@S_Sem", StudentSemisterTextBox.Text);
                    cmd.Parameters.AddWithValue("@Contact", StudentContactTextBox.Text);
                    cmd.Parameters.AddWithValue("@Email", StudentEmailTextBox.Text);
                    cmd.Parameters.AddWithValue("@B_Name", BookNameComboBox.Text);
                    cmd.Parameters.AddWithValue("@B_IssuedDate", IssueDateTimePicker.Text);
                    
                    //Execute The Command
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool IsValid()
        {
            if (StudentNameTextBox.Text.Trim() == string.Empty)
            {
                ClearAllTextBoxes();
                return false;
            }
            if (StudentDeptTextBox.Text.Trim() == string.Empty)
            {
                ClearAllTextBoxes();
                return false;
            }
            if (StudentSemisterTextBox.Text.Trim() == string.Empty)
            {
                ClearAllTextBoxes();
                return false;
            }
            if (StudentContactTextBox.Text.Trim() == string.Empty)
            {
                ClearAllTextBoxes();
                return false;
            }
            if (StudentEmailTextBox.Text.Trim() == string.Empty)
            {
                ClearAllTextBoxes();
                return false;
            }
            if (BookNameComboBox.SelectedIndex == -1)
            {
                ClearAllTextBoxes();
                return false; 
            }
            return true;
        }
    }
}