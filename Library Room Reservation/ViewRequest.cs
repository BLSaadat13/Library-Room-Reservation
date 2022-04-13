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
    public partial class ViewRequest : Form
    {
        Controller ctrl = new Controller();
        public ViewRequest()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go back?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                userDashboard ss = new userDashboard();
                this.Hide();
                ss.Show();
            }
        }

        private void ViewRequest_Load(object sender, EventArgs e)
        {
            var detail = ctrl.studentGetRequestDetail(Login.studentId);
            lblId.Text = detail.requestId;
            lblOldRoom.Text = detail.oldRoomId;
            lblOldDT.Text = detail.oldDT;
            lblNewRoom.Text = detail.newRoomId;
            lblNewDT.Text = detail.newDT;
            lblStatus.Text = detail.status;
        }

    }
}
