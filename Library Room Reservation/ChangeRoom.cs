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
    public partial class ChangeRoom : Form
    {
        Controller ctrl = new Controller();
        public ChangeRoom()
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
                userDashboard ss = new userDashboard();
                this.Hide();
                ss.Show();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtReason.Text == "" || txtReason.Text == "Reason to change")
            {
                MessageBox.Show("Please fill up your reason to change room.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (listRoom.Items.Count > 0)
                {
                    string oldRoom = lblRoom.Text;
                    string oldDT = lblDateTime.Text;
                    string newRoom = listRoom.SelectedItem.ToString();
                    DateTime selectDate = dtpDate.Value;
                    string sqlFormattedDate = selectDate.Date.ToString("yyyy-MM-dd ");
                    string selectTime = cboTime.SelectedItem.ToString();
                    string newDT = sqlFormattedDate + selectTime;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Previous room ID: " + oldRoom + "\nPrevious Date and Time: " + oldDT + "\nRequested room ID: " + newRoom + "\nRequested Date and Time: " + newDT + "", "Reserve confirmation", buttons);
                    if (result == DialogResult.Yes)
                    {
                        Room rm = new Room(oldRoom);
                        Request req = new Request(newRoom, newDT, oldRoom, oldDT, Login.studentId, txtReason.Text);
                        int status = req.createNewRequest();
                        if (status > 0)
                        {
                            MessageBox.Show("Request sent !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error occured, request not send !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        userDashboard ss = new userDashboard();
                        this.Hide();
                        ss.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please select your desired room.", "Room not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
        }

        private void ChangeRoom_Load(object sender, EventArgs e)
        {
            cboTime.SelectedIndex = 0;
            dtpDate.MinDate = DateTime.Today.AddDays(2);
            var studentBooked = ctrl.getStudentDetailAndRoom(Login.studentId);
            lblRoom.Text = studentBooked.room;
            lblDateTime.Text = studentBooked.dateTime;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DateTime selectDate = dtpDate.Value;
            String sqlFormattedDate = selectDate.Date.ToString("yyyy-MM-dd ");
            String selectTime = cboTime.SelectedItem.ToString();
            string sqlDateTime = sqlFormattedDate + selectTime;
            lblSelectedDT.Text = sqlDateTime;
            listRoom.Items.Clear();
            listRoom.DataSource = ctrl.getAvailableRoomList(sqlDateTime);
            listRoom.SelectedIndex = 0;
        }
    }
}
