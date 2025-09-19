using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using PotteryDBA_V1._0.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotteryDBA_V1._0.Forms
{
    public partial class FrmMakeBooking : Form
    {
        // variable used in form
        int NoOfRecords = 0;
        // when form loads disable the minimise and centre to screen
        public FrmMakeBooking()
        {
            InitializeComponent();
            CenterToScreen();
            CommonMethods.lockform(this);
            txtGuestID.Text = "G";
            HideAll();
            lblNoResults.Visible = false;
            lblexistingbooking.Visible = false;
            btnMakeBooking.Visible = false;
            dgvBookingAvailable.ClearSelection();
        }
        // hide controls not required
        private void HideAll()
        {
            lblFore.Visible = false;
            lblSur.Visible = false;
            lblCourseID.Visible = false;
            cbxCourseID.Visible = false;
            cbxCourseID.Text = string.Empty;
            lblexistingbooking.Visible = false;
            btnMakeBooking.Visible = false;
        }
        // on load populate data grid view and refresh count label
        private void FrmMakeBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookingManagerSetFromProcedure.GetTableForBookingManager' table. You can move, or remove it, as needed.
            this.getTableForBookingManagerTableAdapter.Fill(this.bookingManagerSetFromProcedure.GetTableForBookingManager);
            NoOfRecords = dgvBookingAvailable.Rows.Count;
            lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecords);
            btnMakeBooking.Enabled = false;
        }
        // refreshes the number in the cound records label
        private void RefreshCountLabel()
        {
            NoOfRecords = dgvBookingAvailable.Rows.Count;
            lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecords);
        }
        // menu strip events
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCourseMainMenu().Show();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.LogOut(this);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.QuitApplication(this);
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.HelpPDF(this);
           
        }
       // when id changed validate and then populate the labels if record exists.
       // changes available courses to match the guest
        private void txtGuestID_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.CodeEntryCheck(txtGuestID, "G");
            string[] person = GuestDal.CheckForID(txtGuestID.Text);
            if (person[0] != null)
            {
                lblFore.Text = "Forename: " + person[1];
                lblFore.Visible = true;
                lblSur.Text = "Surname: " + person[2];
                lblSur.Visible = true;
                CourseDal.AvailableCourses(dgvBookingAvailable, person, lblNoResults);
                RefreshCountLabel();
                lblCourseID.Visible = true;
                cbxCourseID.Visible = true;
                cbxCourseID.Text = string.Empty;
                cbxCourseID.Items.Clear();
                btnMakeBooking.Visible = true;
                btnMakeBooking.Enabled = false;
                for (int i = 0; i<dgvBookingAvailable.Rows.Count; i++)
                {

                    cbxCourseID.Items.Add(dgvBookingAvailable.Rows[i].Cells[0].Value.ToString());
                }
            }
            else
            {
                CourseDal.AvailableCoursesReset(dgvBookingAvailable, lblNoResults);
                btnMakeBooking.Enabled = false;
                RefreshCountLabel();
                HideAll();
            }
        }
        // when course is changed validate if the booking can be made and enable the button
        private void cbxCourseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxCourseID.Text != null)
            {
                int doublebooked = CourseDal.GuestDoubleBooked(txtGuestID.Text.Trim(), cbxCourseID.Text.Trim());
                if (doublebooked > 0)
                {
                    btnMakeBooking.Enabled = false;
                    lblexistingbooking.Visible = true;
                }
                else
                {
                    btnMakeBooking.Enabled = true;
                    lblexistingbooking.Visible= false;
                }
            }
            else
            {
                btnMakeBooking.Enabled = false;
            }
        }
        // if booking can be made, do it.
        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            if(cbxCourseID.Text != null)
            {
                int success = CourseDal.MakeBooking(txtGuestID.Text.Trim(), cbxCourseID.Text.Trim());
                if ( success != 1)
                {
                    MessageBox.Show("Something went wrong when placing this booking. Please try again later.", "Failed");
                }
                else
                {
                    MessageBox.Show("Booking successfully placed. To see \nthis booking and other bookings, view the report for \nthis course from the course menu.", "Success");
                }
                HideAll();
                txtGuestID.Text = "G";
            }
        }
        // when selection is changed, clear it immidiatelyfor the illusion of being disabled
        private void dgvBookingAvailable_SelectionChanged(object sender, EventArgs e)
        {
            dgvBookingAvailable.ClearSelection();
        }

        private void guestManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.GuestManagementOpen(this);
        }

        private void guestManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonMethods.GuestManagerOpen(this);
        }

        private void logEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.LogEquipmentOpen(this);
        }

        private void guestInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.GuestInvoiceOpen(this);
        }

        private void courseMaagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.CourseMenuOpen(this);
        }

        private void courseManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.CourseManagerOpen(this);
        }

        private void getCourseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.GetCourseReportOpen(this);
        }

        private void exhibitionManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.ExhibitionManagerOpen(this);
        }

        private void artworkManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.ArtworkManagerOpen(this);
        }

        private void mainMenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonMethods.MainMenuOpen(this);
        }
    }
}
