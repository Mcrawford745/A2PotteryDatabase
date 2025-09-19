using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using PotteryDBA_V1._0.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PotteryDBA_V1._0.Forms
{
    public partial class FrmCourseManager : Form
    {
        int NoOfRecords = 0;
        bool searching = false;
        int courset = 0;
        // manages the radio button for toggling search
        bool isChecked = false;

        public FrmCourseManager()
        {
            InitializeComponent();
            CenterToScreen();
            CommonMethods.lockform(this);
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            lblNoResults.Visible = false;
            btnAddMode.Enabled = false;
            btnDeleteCourse.Visible = false;
            lblCourseCode.Visible = false;
            txtCourseID.Visible = false;
            txtCourseID.Text = "C";
            dgvCoursesOut.ClearSelection();
            //0 = none set, 1 = weekend, 2 = five day

        }
        // method to empty all boxes
        private void emptyboxes()
        {
            ckbxFiveday.Checked = false;
            ckbxWeekend.Checked = false;
            safeDate(dtpStartDateEntry);
            cbxSkillLevel.Text = "";
            txtCourseID.Text = "C";
            dgvCoursesOut.ClearSelection();
        }
        // method to set the date picker to a date that will definitly not cause looping
        // errors. sets to the next wednesday from today's date.
        private void safeDate(DateTimePicker x)
        {
            if (DateTime.Today.AddDays(1).DayOfWeek.ToString() == "Monday")
            {
                x.Value = DateTime.Today.AddDays(3);
            }
            else if (DateTime.Today.AddDays(1).DayOfWeek.ToString() == "Tuesday")
            {
                x.Value = DateTime.Today.AddDays(2);
            }
            else if (DateTime.Today.AddDays(1).DayOfWeek.ToString() == "Wednesday")
            {
                x.Value = DateTime.Today.AddDays(1);
            }
            else if (DateTime.Today.AddDays(1).DayOfWeek.ToString() == "Thursday")
            {
                x.Value = DateTime.Today.AddDays(7);
            }
            else if (DateTime.Today.AddDays(1).DayOfWeek.ToString() == "Friday")
            {
                x.Value = DateTime.Today.AddDays(6);
            }
            else if (DateTime.Today.AddDays(1).DayOfWeek.ToString() == "Saturday")
            {
                x.Value = DateTime.Today.AddDays(5);
            }
            else if (DateTime.Today.AddDays(1).DayOfWeek.ToString() == "Sunday")
            {
                x.Value = DateTime.Today.AddDays(4);
            }
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
            //new FrmHelpCourseAddDeleteMenu().Show();
        }
        //form load event
        private void FrmCourseManager_Load(object sender, EventArgs e)
        {
            this.courseTableAdapter.Fill(this.courseDetails.Course);
            NoOfRecords = dgvCoursesOut.Rows.Count;
            dgvCoursesOut.ClearSelection();
            lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecords);
            dgvCoursesOut.Columns[4].DefaultCellStyle.Format = "c2";
            dgvCoursesOut.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");

        }
        // refills the dgv and refreshes the record nuber label
        private void refreshdgv()
        {
            // performs a search from the max possible to min
            // possible dates to return all courses
            DateTime x = new DateTime(1780, 01, 01);
            DateTime y = new DateTime(9998, 12, 31);
            if (searching)
            {
                int outcome = CourseDal.SearchBetweenDates(dtpStartDate.Value, dtpEndDate.Value, dgvCoursesOut);
                if (outcome == -10)
                {
                    lblNoResults.Visible = true;
                    dgvCoursesOut.DataSource = null;
                }
                else if (outcome == 1)
                {
                    lblNoResults.Visible = false;
                }
            }
            else
            {
                CourseDal.SearchBetweenDates(x, y, dgvCoursesOut);
            }
            NoOfRecords = dgvCoursesOut.Rows.Count;
            lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecords);
            dgvCoursesOut.ClearSelection();
        }
        // ensures the end date for the search is after the start date and then searches
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            // ensures always after start date
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                MessageBox.Show("End date must be later than start date.", "Invalid date.");
                dtpEndDate.Value = dtpStartDate.Value;
            }
            // performs the search if everything was valid
            else
            {
                if (searching)
                {
                    int outcome = CourseDal.SearchBetweenDates(dtpStartDate.Value, dtpEndDate.Value, dgvCoursesOut);
                    if (outcome == -10)
                    {
                        lblNoResults.Visible = true;
                        dgvCoursesOut.DataSource = null;
                        NoOfRecords = dgvCoursesOut.Rows.Count;
                        lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecords);
                    }
                    else if (outcome == 1)
                    {
                        lblNoResults.Visible = false;
                        NoOfRecords = dgvCoursesOut.Rows.Count;
                        lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecords);
                    }
                    dgvCoursesOut.ClearSelection();
                }
            }
        }
        //ensures the start date is before the end date and then searches
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            // validates the starting date for search
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                dtpEndDate.Value = dtpStartDate.Value;
            }
            // when valid performs search
            else
            {
                if (searching)
                {
                    int outcome = CourseDal.SearchBetweenDates(dtpStartDate.Value, dtpEndDate.Value, dgvCoursesOut);
                    if (outcome == -10)
                    {
                        lblNoResults.Visible = true;
                        dgvCoursesOut.DataSource = null;
                        NoOfRecords = dgvCoursesOut.Rows.Count;
                        lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecords);
                    }
                    else if (outcome == 1)
                    {
                        lblNoResults.Visible = false;
                        NoOfRecords = dgvCoursesOut.Rows.Count;
                        lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecords);
                    }
                }
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // if the button is checked, enable selecting dates to search
            isChecked = rbSearchEDnabled.Checked;
            if (isChecked)
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
                searching = true;
                // performs the search
                int outcome = CourseDal.SearchBetweenDates(dtpStartDate.Value, dtpEndDate.Value, dgvCoursesOut);
                if (outcome == -10)
                {
                    lblNoResults.Visible = true;
                    dgvCoursesOut.DataSource = null;
                    NoOfRecords = dgvCoursesOut.Rows.Count;
                    lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecords);
                }
                else if (outcome == 1)
                {
                    lblNoResults.Visible = false;
                    NoOfRecords = dgvCoursesOut.Rows.Count;
                    lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecords);
                }
            }
            // if searching is not checked, refresh the view.
            else if (!isChecked)
            {
                dtpStartDate.Enabled = false;
                dtpEndDate.Enabled = false;
                searching = false;
                lblNoResults.Visible = false;
                refreshdgv();
                NoOfRecords = dgvCoursesOut.Rows.Count;
                lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecords);
            }

        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            dgvCoursesOut.ClearSelection();
            if (rbSearchEDnabled.Checked && !isChecked)
                rbSearchEDnabled.Checked = false;
            else
            {
                rbSearchEDnabled.Checked = true;
                isChecked = false;
            }
        }
        // manages the validation of course start date selection for adding courses
        private void dtpStartDateEntry_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDateEntry.Value <= DateTime.Now)
            {
                MessageBox.Show("Start date must be a future date.", "Invalid Start Date");
                safeDate(dtpStartDateEntry);
            }
            for (int i = 0; i < dgvCoursesOut.Rows.Count; i++)
            {
                if (dgvCoursesOut.Rows[i].Cells[1].Value.ToString().Substring(0, 10) == dtpStartDateEntry.Value.ToString().Substring(0, 10))
                {
                    MessageBox.Show("Start date cannot already be assigned to a course.", "Invalid Start Date");
                    safeDate(dtpStartDateEntry);
                }
            }
        }
        // manages the rest of the validation for adding a course
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            // is the date future?
            if (dtpStartDateEntry.Value > DateTime.Now)
            {
                // has a course type been selected?
                if (courset == 0)
                {
                    MessageBox.Show("Please ensure to select a course type, as this determines cost.", "Empty Field Detected");
                }
                // has a course type been selected?
                else if (courset == 1)
                {
                    // is the date for a weekend course a saturday?
                    if (dtpStartDateEntry.Value.DayOfWeek == DayOfWeek.Saturday)
                    {
                        // has a skill level been selected?
                        if (cbxSkillLevel.Text.Trim() == "")
                        {
                            MessageBox.Show("Please ensure to enter a skill type for this course.");
                        }
                        // has a skill level been selected?
                        else if (cbxSkillLevel.Text.Trim() == "Beginner")
                        {
                            // Is there space for a new course in the chosen year?
                            int checkcount = CourseDal.CountExistingCourses(dtpStartDateEntry.Value, "Beginner", "Weekend");
                            if (checkcount > 4)
                            {
                                MessageBox.Show("There is no more space in " + dtpStartDateEntry.Value.Year.ToString() + " for a Beginner Weekend course.", "Annual Schedule Full");
                            }
                            else
                            {
                                // Course being created
                                int outcome = CourseDal.AddCourse(dtpStartDateEntry.Value, "Weekend", "Beginner", 100.00m, 14);
                                if (outcome > 0)
                                {
                                    MessageBox.Show("Course added successfully", "Success");
                                }
                                else if (outcome <= 0)
                                {
                                    MessageBox.Show("Adding course failed", "Failed");
                                }
                                refreshdgv();
                            }
                        }
                        // has a skill level been selected?
                        else if (cbxSkillLevel.Text.Trim() == "Intermediate")
                        {
                            // Is there space for a new course in the chosen year?
                            int checkcount = CourseDal.CountExistingCourses(dtpStartDateEntry.Value, "Intermediate", "Weekend");
                            if (checkcount > 4)
                            {
                                MessageBox.Show("There is no more space in " + dtpStartDateEntry.Value.Year.ToString() + " for an Intermediate Weekend course.", "Annual Schedule Full");
                            }
                            else
                            {
                                // Course being created
                                int outcome = CourseDal.AddCourse(dtpStartDateEntry.Value, "Weekend", "Intermediate", 150.00m, 14);
                                if (outcome > 0)
                                {
                                    MessageBox.Show("Course added successfully", "Success");
                                }
                                else if (outcome <= 0)
                                {
                                    MessageBox.Show("Adding course failed", "Failed");
                                }
                                refreshdgv();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please ensure selected start date is a Saturday.", "Invalid Start Date");
                    }


                }
                // has a course type been selected?
                else if (courset == 2)
                {
                    // is the date for a five day course a monday?
                    if (dtpStartDateEntry.Value.DayOfWeek == DayOfWeek.Monday)
                    {
                        // has a skill level been selected?
                        if (cbxSkillLevel.Text == "")
                        {
                            MessageBox.Show("Please ensure to enter a skill type for this course.");
                        }
                        // has a skill level been selected?
                        else if (cbxSkillLevel.Text.Trim() == "Advanced")
                        {
                            // Is there space for a new course in the chosen year?
                            int checkcount = CourseDal.CountExistingCourses(dtpStartDateEntry.Value, "Advanced", "Five-Day");
                            if (checkcount > 2)
                            {
                                MessageBox.Show("There is no more space in " + dtpStartDateEntry.Value.Year.ToString() + " for an Advanced Five-Day course.", "Annual Schedule Full");
                            }
                            else
                            {
                                // Course being created
                                int outcome = CourseDal.AddCourse(dtpStartDateEntry.Value, "Five-Day", "Advanced", 400.00m, 16);
                                if (outcome > 0)
                                {
                                    MessageBox.Show("Course added successfully", "Success");
                                }
                                else if (outcome <= 0)
                                {
                                    MessageBox.Show("Adding course failed", "Failed");
                                }
                                refreshdgv();
                            }
                        }
                        // has a skill level been selected?
                        else if (cbxSkillLevel.Text.Trim() == "Intermediate")
                        {
                            // Is there space for a new course in the chosen year?
                            int checkcount = CourseDal.CountExistingCourses(dtpStartDateEntry.Value, "Intermediate", "Five-Day");
                            if (checkcount > 2)
                            {
                                MessageBox.Show("There is no more space in " + dtpStartDateEntry.Value.Year.ToString() + " for an Intermediate Five-Day course.", "Annual Schedule Full");
                            }
                            else
                            {
                                // Course being created
                                int outcome = CourseDal.AddCourse(dtpStartDateEntry.Value, "Five-Day", "Intermediate", 375.00m, 16);
                                if (outcome > 0)
                                {
                                    MessageBox.Show("Course added successfully", "Success");
                                }
                                else if (outcome <= 0)
                                {
                                    MessageBox.Show("Adding course failed", "Failed");
                                }
                                refreshdgv();
                                emptyboxes();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please ensure selected start date is a Monday.", "Invalid Start Date");
                    }
                }
            }
            else
            {
                MessageBox.Show("Start date must be a future date.", "Invalid Start Date");
            }
            emptyboxes();
        }
        // manages the selection of course type and ensures only one can be
        // clicked at a time. also refils the skill level combo box
        private void ckbxWeekend_Changed(object sender, EventArgs e)
        {
            if (ckbxFiveday.Checked && ckbxWeekend.Checked)
            {
                ckbxFiveday.Checked = false;
                cbxSkillLevel.Items.Clear();
                cbxSkillLevel.Items.Add("Beginner");
                cbxSkillLevel.Items.Add("Intermediate");
                courset = 1;
            }
            else if (ckbxWeekend.Checked)
            {
                cbxSkillLevel.Items.Clear();
                cbxSkillLevel.Items.Add("Beginner");
                cbxSkillLevel.Items.Add("Intermediate");
                courset = 1;
            }
            else if (!ckbxFiveday.Checked && !ckbxWeekend.Checked)
            {
                courset = 0;
            }
        }
        private void ckbxFiveday_Changed(object sender, EventArgs e)
        {
            if (ckbxFiveday.Checked && ckbxWeekend.Checked)
            {
                ckbxWeekend.Checked = false;
                cbxSkillLevel.Items.Clear();
                cbxSkillLevel.Items.Add("Intermediate");
                cbxSkillLevel.Items.Add("Advanced");
                courset = 2;
            }
            else if (ckbxFiveday.Checked)
            {
                cbxSkillLevel.Items.Clear();
                cbxSkillLevel.Items.Add("Intermediate");
                cbxSkillLevel.Items.Add("Advanced");
                courset = 2;
            }
            else if (!ckbxFiveday.Checked && !ckbxWeekend.Checked)
            {
                courset = 0;
            }
        }

        // methods for swapping in and out of add mode
        private void btnAddMode_Click(object sender, EventArgs e)
        {
            btnAddMode.Enabled = false;
            lblCourseCode.Visible = false;
            btnDeleteCourse.Visible = false;
            btnAddCourse.Visible = true;
            btnDeleteMode.Enabled = true;
            lblCourseType.Visible = true;
            lblStartDate.Visible = true;
            lblSkillLevel.Visible = true;
            ckbxWeekend.Visible = true;
            ckbxFiveday.Visible = true;
            dtpStartDateEntry.Visible = true;
            cbxSkillLevel.Visible = true;
            txtCourseID.Visible = false;
            emptyboxes();

        }

        // methods for swapping in and out of delete mode
        private void btnDeleteMode_Click(object sender, EventArgs e)
        {
            btnAddMode.Enabled = true;
            lblCourseCode.Visible = true;
            btnDeleteCourse.Visible = true;
            btnAddCourse.Visible = false;
            btnDeleteMode.Enabled = false;
            lblCourseType.Visible = false;
            lblStartDate.Visible = false;
            lblSkillLevel.Visible = false;
            ckbxWeekend.Visible = false;
            ckbxFiveday.Visible = false;
            dtpStartDateEntry.Visible = false;
            cbxSkillLevel.Visible = false;
            txtCourseID.Visible = true;
            emptyboxes();
        }

        private void txtCourseID_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.CodeEntryCheck(txtCourseID, "C");
        }

        // when dgv row selected copy details into text box
        private void dgvCoursesOut_SelectionChanged(object sender, EventArgs e)
        {
            if (lblCourseCode.Visible)
            {
                if (dgvCoursesOut.SelectedCells.Count != 0)
                {
                    txtCourseID.Text = dgvCoursesOut.SelectedCells[0].Value.ToString();
                }
            }
            if (btnAddMode.Enabled == false)
            {
                dgvCoursesOut.ClearSelection();
            }
        }

        // checks an id was actually entered before trying to perform a delete.
        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (txtCourseID.Text.Length > 1)
            {
                int success = CourseDal.DeleteCourse(txtCourseID.Text.Trim());
                if (success == -1)
                {
                    MessageBox.Show("Courses with guests booked into them cannot be deleted.\n Please delete bookings to enable course deletion.", "Bookings detected");
                    emptyboxes();
                    refreshdgv();
                }
                else
                {
                    MessageBox.Show("Course successfully deleted.", "Success");
                    emptyboxes();
                    refreshdgv();
                }
            }
            else
            {
                MessageBox.Show("Please ensure to select a Course from the Table.", "No Course Found");
                emptyboxes();
                refreshdgv();
            }

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

        private void makeABookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.MakeABookingOpen(this);
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

        // ensures you cant type in course ID field
        private void txtCourseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
