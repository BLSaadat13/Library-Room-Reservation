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
    public partial class LibrarianCreate : Form
    {
        Controller ctrl = new Controller();
        public LibrarianCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirm.Text)
            {
                if (ctrl.librarianUsernameExist(txtUsername.Text) == false)
                {
                    Librarian ln = new Librarian(txtUsername.Text, txtPassword.Text);
                    int status = ln.addNewLibrarian();
                    if (status > 0)
                    {
                        MessageBox.Show("New librarian account created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error occured, librarian acount not created.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConfirm.Text = "";
                }
                else
                {
                    MessageBox.Show("Librarian username exists !", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("The password do not match !", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go back?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                librarianDashboard ss = new librarianDashboard();
                this.Hide();
                ss.Show();
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (ctrl.librarianUsernameExist(txtUsername.Text))
            {
                lbld.Text = "*Librarian username exists !";
            }
            else
            {
                lbld.Text = "";
            }
        }
    }
}
