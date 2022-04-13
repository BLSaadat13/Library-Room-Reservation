using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Room_Reservation
{
    public partial class LibrarianEditProfile : Form
    {
        Controller ctrl = new Controller();
        public LibrarianEditProfile()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string message = "Do you want to go back?";
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                librarianDashboard ss = new librarianDashboard();
                this.Hide();
                ss.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in your desired password.", "Pasword is empty !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var librarianDetail = ctrl.getLibrarianDetail(Login.librarianUsername);
                if (txtPassword.Text == librarianDetail.librarianPassword)
                {
                    MessageBox.Show("New password is same as the previous one.", "No data changed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int status = ctrl.librarianUpdateProfile(txtID.Text, txtPassword.Text);
                    if (status > 0)
                    {
                        MessageBox.Show("Password updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Password not updated", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtPassword.ReadOnly = true;
                    txtPassword.UseSystemPasswordChar = true;
                }
            }
        }

        private void LibrarianEditProfile_Load(object sender, EventArgs e)
        {
            var librarianDetail = ctrl.getLibrarianDetail(Login.librarianUsername);
            txtID.Text = librarianDetail.librarianUsername;
            txtPassword.Text = librarianDetail.librarianPassword;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            txtPassword.ReadOnly = false;
            txtPassword.UseSystemPasswordChar = false;
        }
    }
}
