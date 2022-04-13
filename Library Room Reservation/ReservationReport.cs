using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Room_Reservation
{
    public partial class ReservationReport : Form
    {
        DateTime now = DateTime.Now;
        Controller ctrl = new Controller();
        string[] calMonth = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        int monthIndex = 0;

        public ReservationReport()
        {
            InitializeComponent();
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

        private void ReservationReport_Load(object sender, EventArgs e)
        {
            radViewDaily.Checked = true;
            cboMonths.Items.AddRange(calMonth);
            cboMonths.SelectedIndex = 0;
        }

        private void radViewMonthly_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void radViewDaily_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            RoomReservationList rpt = new RoomReservationList();
            rpt.SetDataSource(ctrl.getDataForDailyReport());
            crystalReportViewer1.ReportSource = rpt;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (txtYear.Text == "")
            {
                MessageBox.Show("Please fill in the year.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RoomReservationList rpt = new RoomReservationList();
                int year = int.Parse(txtYear.Text);
                rpt.SetDataSource(ctrl.getDataForMonthlyReport(monthIndex, year));
                crystalReportViewer1.ReportSource = rpt;
            }
            else
            {
                RoomReservationList rpt = new RoomReservationList();
                int year = int.Parse(txtYear.Text);
                rpt.SetDataSource(ctrl.getDataForMonthlyReport(monthIndex, year));
                crystalReportViewer1.ReportSource = rpt;
            }
        }

        private void cboMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthIndex = cboMonths.SelectedIndex + 1;
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }     
        }
    }
}
