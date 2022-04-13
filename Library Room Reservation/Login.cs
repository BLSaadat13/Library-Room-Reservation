using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Room_Reservation
{
    public partial class Login : Form
    {
        public static string studentId = "";
        public static string librarianUsername = "";
        Controller ctrl = new Controller();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in your login detail.", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else
            {
                string user = ctrl.userLogin(txtUsername.Text, txtPassword.Text);
                if (user == "student")
                {
                    studentId = txtUsername.Text;
                    this.Hide();
                    userDashboard ss = new userDashboard();
                    ss.Show();
                }
                else if (user == "librarian")
                {
                    librarianUsername = txtUsername.Text;
                    this.Hide();
                    librarianDashboard ss = new librarianDashboard();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Unable to sign in. Please check that login id or password is correct", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUsername.Clear();
                    txtUsername.Focus();
                }
            }       
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SignUp ss = new SignUp();
            this.Hide();
            ss.Show();
        }

        private void chbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
