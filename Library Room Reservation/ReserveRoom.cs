using System;
using System.Windows.Forms;

namespace Library_Room_Reservation
{
    public partial class ReserveRoom : Form
    {
        Controller ctrl = new Controller();
        public ReserveRoom()
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

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (listRoom.Items.Count > 0)
            {
                string room = listRoom.SelectedItem.ToString();
                DateTime selectDate = dtpDate.Value;
                string sqlFormattedDate = selectDate.Date.ToString("yyyy-MM-dd "); // this space is not a typo, it is meant to be there to be saved inside SQL
                String selectTime = cboTime.SelectedItem.ToString();
                String sqlDateTime = sqlFormattedDate + selectTime;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Room ID: " + room + "\nDate and Time: " + sqlDateTime + "", "Reserve confirmation", buttons);
                if (result == DialogResult.Yes)
                {
                    Room rm = new Room(room);
                    int status = rm.reserveRoom(Login.studentId, sqlDateTime);
                    if (status > 0)
                    {
                        MessageBox.Show("Room reserved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error occured, room not reserved", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void ReserveRoom_Load(object sender, EventArgs e)
        {
            dtpDate.MinDate = DateTime.Today.AddDays(2);
            cboTime.SelectedIndex = 0;
        }

        private void listRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            char a = listRoom.SelectedItem.ToString()[0];
            string type = a.ToString();
            switch (type)
            {
                case "A":
                    lblRoomType.Text = "Amber";
                    lblCapacity.Text = "10";
                    break;
                case "B":
                    lblRoomType.Text = "Black Thorn";
                    lblCapacity.Text = "8";
                    break;
                case "C":
                    lblRoomType.Text = "Cedar";
                    lblCapacity.Text = "4";
                    break;
                case "D":
                    lblRoomType.Text = "Daphne";
                    lblCapacity.Text = "2";
                    break;
            }
        }
    }
}
