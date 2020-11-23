using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Managment_System
{
    public partial class DashbordForm : Form
    {
        public DashbordForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want to Exit ?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooksForm ABF = new AddBooksForm();
            ABF.ShowDialog();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBookForm VBF = new ViewBookForm();
            VBF.ShowDialog();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm ASF = new AddStudentForm();
            ASF.ShowDialog();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentForm VSF = new ViewStudentForm();
            VSF.ShowDialog();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooksForm IBF = new IssueBooksForm();
            IBF.ShowDialog();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBookForm RBF = new ReturnBookForm();
            RBF.ShowDialog();
        }

        private void returnBooksDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompeleteBookDeatailsForm CBDF = new CompeleteBookDeatailsForm();
            CBDF.ShowDialog();
        }
    }
}
