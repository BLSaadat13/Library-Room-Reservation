using System;
using System.Windows.Forms;

namespace Library_Room_Reservation
{
    public partial class SignUp : Form
    {
        Controller ctrl = new Controller();
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Login ss = new Login();
                this.Hide();
                ss.Show();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirm.Text)
            {
                if (ctrl.studentIdExist(txtStudentId.Text) == false)
                {
                    Student std = new Student(txtStudentId.Text, txtName.Text, txtPassword.Text, txtEmail.Text);
                    int i = std.addNewStudent();
                    if (i > 0)
                    {
                        MessageBox.Show("New student account created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error occured, student acount not created.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Login ss = new Login();
                    this.Hide();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Student ID exist !", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Clear();
                    txtStudentId.Clear();
                    txtPassword.Clear();
                    txtConfirm.Clear();
                    txtEmail.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("The password do not match", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (txtConfirm.Text != txtPassword.Text)
            {
                lblConfirm.Text = "*Password do not match !";
            }
            else
            {
                lblConfirm.Text = "";
            }
        }

        private void txtStudentId_Leave(object sender, EventArgs e)
        {
            if (ctrl.studentIdExist(txtStudentId.Text))
            {
                lbld.Text = "*Student ID exists !";
            }
            else
            {
                lbld.Text = "";
            }
        }
    }
}
