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
    public partial class userDashboard : Form
    {
        Controller ctrl = new Controller();
        public userDashboard()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            bool exist = ctrl.checkReservationExist(Login.studentId);
            if (exist)
            {
                MessageBox.Show("One student can only reserve one room at a time !", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ReserveRoom ss = new ReserveRoom();
                this.Hide();
                ss.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(lblRoom.Text == "None" && lblDateTime.Text == "None")
            {
                MessageBox.Show("You have not reserved any room", "No reserved room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel the reservation? (" + lblRoom.Text + ", " + lblDateTime.Text + ")", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string room = lblRoom.Text;
                    string DateTime = lblDateTime.Text;
                    Room rm = new Room(room);
                    int status = rm.cancelRoom(DateTime);
                    if (status > 0)
                    {
                        MessageBox.Show("Your request to change room has been removed from the system.", "Request change cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    lblDateTime.Text = "None";
                    lblRoom.Text = "None";
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lblRoom.Text == "None" && lblDateTime.Text == "None")
            {
                MessageBox.Show("You have not reserved any room", "No reserved room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool exist = ctrl.checkRequestExist(Login.studentId);
                if (exist)
                {
                    MessageBox.Show("One reservation can only send one change request ! Please contact librarian if you need more information.", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ChangeRoom ss = new ChangeRoom();
                    this.Hide();
                    ss.Show();
                }
            }      
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            bool exist = ctrl.checkRequestExist(Login.studentId);
            if (exist)
            {
                ViewRequest ss = new ViewRequest();
                this.Hide();
                ss.Show();
            }
            else
            {
                MessageBox.Show("No request sent from you", "No data found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
        }

        private void userDashboard_Load(object sender, EventArgs e)
        {
            string studentId = Login.studentId;
            var studentDasboardLoad = ctrl.getStudentDetailAndRoom(studentId);
            string studentName = studentDasboardLoad.studentName;
            string roomReserved = studentDasboardLoad.room;
            string dateTime = studentDasboardLoad.dateTime.ToString();
            lblWelcome.Text = "Welcome " + studentName;
            lblRoom.Text = roomReserved;
            lblDateTime.Text = dateTime;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to log out?";
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Login ss = new Login();
                this.Hide();
                ss.Show();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            userEditProfile ss = new userEditProfile();
            this.Hide();
            ss.Show();
        }
    }
}
