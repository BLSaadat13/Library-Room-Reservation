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
    public partial class LibrarianRequest : Form
    {
        Controller ctrl = new Controller();
        public LibrarianRequest()
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Room rm = new Room(lblNewRoom.Text);
            if (rm.checkSpecificRoomAvailablity(lblNewDT.Text))
            {
                MessageBox.Show("The new room is already been reserved.", "Room not available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string id = requestList.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to accept this request?", "Accept request", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int status = ctrl.acceptRequest(id, lblOldRoom.Text, lblOldDT.Text, lblNewRoom.Text, lblstudentID.Text, lblNewDT.Text);
                    if (status > 0)
                    {
                        MessageBox.Show("Reserved room updated", "Successfully Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reserved room not updated", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    requestListLoad();
                }
            } 
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            string id = requestList.SelectedItem.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to reject this request?", "Reject request", buttons);
            if (result == DialogResult.Yes)
            {
                int status = ctrl.rejectRequest(id);
                if (status > 0)
                {
                    MessageBox.Show("Reserved room updated", "Successfully Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Reserved room not updated", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                requestListLoad();

            }
        }

        private void LibrarianRequest_Load(object sender, EventArgs e)
        {
            requestListLoad();
        }
        private void requestListLoad()
        {
            requestList.Items.Clear();
            ctrl.removeExpiredRequest();
            bool exist = ctrl.librarianCheckRequestExist();
            if (exist)
            {
                requestList.DataSource = ctrl.getRequestIdList();
                requestList.SelectedIndex = 0;
                string requestId = requestList.SelectedItem.ToString();
                var requestDetail = ctrl.getRequestDetail(requestId);
                lblNewDT.Text = requestDetail.newDT;
                lblOldDT.Text = requestDetail.oldDT;
                lblNewRoom.Text = requestDetail.newRoomId;
                lblOldRoom.Text = requestDetail.oldRoomId;
                lblstudentID.Text = requestDetail.studentId;
                lblReason.Text = requestDetail.reason;
            }
            else
            {
                MessageBox.Show("All change room request has been settled. ", "No more change room request.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                librarianDashboard ss = new librarianDashboard();
                ss.Show();
            }
        }


        private void requestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requestId = requestList.SelectedItem.ToString();
            var requestDetail = ctrl.getRequestDetail(requestId);
            lblNewDT.Text = requestDetail.newDT;
            lblOldDT.Text = requestDetail.oldDT;
            lblNewRoom.Text = requestDetail.newRoomId;
            lblOldRoom.Text = requestDetail.oldRoomId;
            lblstudentID.Text = requestDetail.studentId;
            lblReason.Text = requestDetail.reason;
        }
    }
}
