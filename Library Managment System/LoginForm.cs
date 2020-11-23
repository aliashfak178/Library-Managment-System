using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Utilitys;
namespace Library_Managment_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserNameTextBox_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "UserName")
            {
                UserNameTextBox.Clear();
            }
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Password")
            {
                PasswordTextBox.Clear();
                PasswordTextBox.PasswordChar='*';
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                bool IsUserNameCurrect, IsPasswordCurrect;
                GetIsUserLoginCurrect(out IsUserNameCurrect, out IsPasswordCurrect);
                if (IsUserNameCurrect && IsPasswordCurrect)
                {
                    DashbordForm DF = new DashbordForm();
                    DF.Show();
                    this.Hide();
                }
                else
                {
                    if (!IsUserNameCurrect)
                    {
                        MessageBox.Show("UserName is Not Currect.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UserNameTextBox.Clear();
                        PasswordTextBox.Clear();
                        UserNameTextBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Password is Not Currect.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PasswordTextBox.Clear();
                        PasswordTextBox.Focus();
                    }
                }
            }
        }

        private void GetIsUserLoginCurrect(out bool IsUserNameCurrect, out bool IsPasswordCurrect)
        {
            string connString = ConnectionStrings.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_UserChackLoginDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    //output parameters
                    cmd.Parameters.Add("@IsUserNameCurrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@IsPasswordCurrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    //parameters
                    cmd.Parameters.AddWithValue("@UserName", UserNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);

                    //Execute The Command
                    cmd.ExecuteNonQuery();

                    //Passed Parameter's Values From Db
                    IsUserNameCurrect = (bool)cmd.Parameters["@IsUserNameCurrect"].Value;
                    IsPasswordCurrect = (bool)cmd.Parameters["@IsPasswordCurrect"].Value;
                }
            }
        }

        private bool isValid()
        {
            if (UserNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter UserName First","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                UserNameTextBox.Clear();
                UserNameTextBox.Focus();
                return false;
            }
            if(PasswordTextBox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please Enter Password First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Clear();
            }
            return true;
        }

    }
}
