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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                GetStudentInfo();
                MessageBox.Show("Record Insert Sucessfully","Record Inesrt",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ClearAllRecords();
            }
        }

        private void ClearAllRecords()
        {
            StudentNameTextBox.Clear();
            StudentEnrollmentnoTextBox.Clear();
            StudentDeptTextBox.Clear();
            StudentSemisterTextBox.Clear();
            StudentContactTextBox.Clear();
            StudentEmailTextBox.Clear();
            StudentNameTextBox.Focus();
        }

        private void GetStudentInfo()
        {
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_AddStudent", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    //parameters
                    cmd.Parameters.AddWithValue("@StudentName", StudentNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@StudentEnrollemnt", StudentEnrollmentnoTextBox.Text);
                    cmd.Parameters.AddWithValue("@StudentDept", StudentDeptTextBox.Text);
                    cmd.Parameters.AddWithValue("@StudentSem", StudentSemisterTextBox.Text);
                    cmd.Parameters.AddWithValue("@StudentContact", StudentContactTextBox.Text);
                    cmd.Parameters.AddWithValue("@StudentEmail", StudentEmailTextBox.Text);
                    //Execute The Command
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool IsValid()
        {
            if (StudentNameTextBox.Text.Trim() == string.Empty)
            {
                ValidationMessage("Enter Student Name First");
                return false;
            }
            if (StudentEnrollmentnoTextBox.Text.Trim() == string.Empty)
            {
                ValidationMessage("Enter Enrollment No First");
                return false;
            }
            if (StudentDeptTextBox.Text.Trim() == string.Empty)
            {
                ValidationMessage("Enter Department First");
                return false;
            }
            if (StudentSemisterTextBox.Text.Trim() == string.Empty)
            {
                ValidationMessage("Enter Samister First");
                return false;
            }
            if (StudentContactTextBox.Text.Trim() == string.Empty)
            {
                ValidationMessage("Enter Contact First");
                return false;
            }
            if (StudentEmailTextBox.Text.Trim() == string.Empty)
            {
                ValidationMessage("Enter Email First");
                return false;
            }
            return true;
        }

        private void ValidationMessage(string p)
        {
            MessageBox.Show(p,"Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
