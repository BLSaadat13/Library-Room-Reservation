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
    public partial class librarianDashboard : Form
    {
        Controller ctrl = new Controller();
        public librarianDashboard()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            bool exist = ctrl.librarianCheckRequestExist();
            if (exist)
            {
                LibrarianRequest ss = new LibrarianRequest();
                this.Hide();
                ss.Show();
            }

            else
            {
                MessageBox.Show("No change room request at the moment. ", "No change room request.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            LibrarianCreate ss = new LibrarianCreate();
            this.Hide();
            ss.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReservationReport ss = new ReservationReport();
            this.Hide();
            ss.Show();
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

        private void librarianDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + Login.librarianUsername;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            LibrarianEditProfile ss = new LibrarianEditProfile();
            this.Hide();
            ss.Show();
        }
    }
}
