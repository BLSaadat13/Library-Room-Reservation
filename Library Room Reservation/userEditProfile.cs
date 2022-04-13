using System;
using System.Windows.Forms;

namespace Library_Room_Reservation
{
    public partial class userEditProfile : Form
    {
        Controller ctrl = new Controller();

        public userEditProfile()
        {
            InitializeComponent();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            txtEmail.ReadOnly = false;
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            txtPassword.ReadOnly = false;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void userEditProfile_Load(object sender, EventArgs e)
        {
            var detail = ctrl.getStudentDetailAndRoom(Login.studentId);
            txtName.Text = detail.studentName;
            txtID.Text = Login.studentId;
            txtEmail.Text = detail.studentEmail;
            txtPassword.Text = detail.studentPassword;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in the details that you wish to update", "Textbox empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var detail = ctrl.getStudentDetailAndRoom(Login.studentId);
                if (txtEmail.Text == detail.studentEmail && txtPassword.Text == detail.studentPassword)
                {
                    MessageBox.Show("No data have changed from the previous record", "No data changed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int status = ctrl.studentUpdateProfile(Login.studentId, txtEmail.Text, txtPassword.Text);
                    if (status > 0)
                    {
                        MessageBox.Show("Profile updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Profile not updated", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                    txtEmail.ReadOnly = true;
                    txtPassword.ReadOnly = true;
                    txtPassword.UseSystemPasswordChar = true;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string message = "Do you want to go back?";
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                userDashboard ss = new userDashboard();
                this.Hide();
                ss.Show();
            }
        }
    }
}

