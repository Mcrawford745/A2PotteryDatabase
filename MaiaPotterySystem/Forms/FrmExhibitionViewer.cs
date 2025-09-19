using PotteryDBA_V1._0.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotteryDBA_V1._0.Forms
{
    public partial class FrmExhibitionViewer : Form
    {
        // variables used throughout
        bool FutureMode = false;
        bool PastMode = false;
        bool AllMode = true;
        int NoOfRecords;
        bool AddMode = false;
        bool UpdateMode = false;
        bool DeleteMode = false;

        // imported module to handle the numeric up down caret
        [DllImport("user32")]
        private static extern bool HideCaret(IntPtr hWnd);
        // when form loads, set into add mode, center to screen and disable minimise.
        public FrmExhibitionViewer()
        {
            InitializeComponent();
            CenterToScreen();
            CommonMethods.lockform(this);
            ShowDgv('A');
        }
        // method to manage when each data grid view is visible
        private void ShowDgv(char type)
        {
            switch (type)
            {
                case ('A'):
                    lblAllExhibitions.Visible = true;
                    lblPastExhibitions.Visible = false;
                    lblFutureExhibitions.Visible = false;
                    dgvAllExhibitions.Visible = true;
                    dgvPastExhibitions.Visible = false;
                    dgvFutureExhibitions.Visible = false;
                    FutureMode = false;
                    PastMode = false;
                    AllMode = true;
                    dgvAllExhibitions.ClearSelection();
                    refreshCountLabel();
                    break;
                case ('F'):
                    lblAllExhibitions.Visible = false;
                    lblPastExhibitions.Visible = false;
                    lblFutureExhibitions.Visible = true;
                    dgvAllExhibitions.Visible = false;
                    dgvPastExhibitions.Visible = false;
                    dgvFutureExhibitions.Visible = true;
                    FutureMode = true;
                    PastMode = false;
                    AllMode = false;
                    dgvFutureExhibitions.ClearSelection();
                    refreshCountLabel();
                    break;
                case ('P'):
                    lblAllExhibitions.Visible = false;
                    lblPastExhibitions.Visible = true;
                    lblFutureExhibitions.Visible = false;
                    dgvAllExhibitions.Visible = false;
                    dgvPastExhibitions.Visible = true;
                    dgvFutureExhibitions.Visible = false;
                    FutureMode = false;
                    PastMode = true;
                    AllMode = false;
                    dgvPastExhibitions.ClearSelection();
                    refreshCountLabel();
                    break;
            }
        }
        // methods to toggle each mode
        private void AddModeSwap(string type)
        {
            switch (type)
            {
                case ("On"):
                    AddMode = true;
                    DeleteMode = false;
                    UpdateMode = false;
                    lblExhibitionYearAdd.Visible = true;
                    nudExhibitionYearAdd.Visible = true;
                    nudExhibitionYearAdd.Minimum = Convert.ToInt32(DateTime.Now.Year);
                    nudExhibitionYearAdd.Value = nudExhibitionYearAdd.Minimum;
                    lblExhibitionDateAdd.Visible = true;
                    mcExhibitionDate.Visible = true;
                    btnAddExhibition.Visible = true;
                    nudYear_ValueChanged(this, new EventArgs());
                    dgvAllExhibitions.ClearSelection();
                    dgvFutureExhibitions.ClearSelection();
                    dgvPastExhibitions.ClearSelection();
                    break;
                case ("Off"):
                    AddMode = false;
                    lblExhibitionYearAdd.Visible = false;
                    nudExhibitionYearAdd.Visible = false;
                    lblExhibitionDateAdd.Visible = false;
                    mcExhibitionDate.Visible = false;
                    btnAddExhibition.Visible = false;
                    lblYearFull.Visible = false;
                    break;
            }
        }
        private void UpdateModeSwap(string type)
        {
            switch (type)
            {
                case ("On"):
                    UpdateMode = true;
                    DeleteMode = false;
                    AddMode = false;
                    lblExhibitionIDUpdate.Visible = true;
                    txtExhibitionIDUpdate.Visible = true;
                    txtExhibitionIDUpdate.Text = "EX";
                    lblExhibitionDateUpdate.Visible = true;
                    mcExhibitionDateUpdate.Visible = true;
                    lblCateringNoUpdate.Visible = true;
                    nudCateringNumberUpdate.Visible = true;
                    nudCateringNumberUpdate.Value = 0;
                    btnUpdateExhibition.Visible = true;
                    ShowDgv('F');
                    advancedGuestArtworkToolStripMenuItem.Enabled = true;
                    generalGuestArtworkToolStripMenuItem.Enabled = false;
                    allExhibitionsToolStripMenuItem.Enabled = false;
                    break;
                case ("Off"):
                    UpdateMode = false;
                    lblExhibitionIDUpdate.Visible = false;
                    txtExhibitionIDUpdate.Visible = false;
                    lblExhibitionDateUpdate.Visible = false;
                    mcExhibitionDateUpdate.Visible = false;
                    lblCateringNoUpdate.Visible = false;
                    nudCateringNumberUpdate.Visible = false;
                    btnUpdateExhibition.Visible = false;
                    advancedGuestArtworkToolStripMenuItem.Enabled = true;
                    generalGuestArtworkToolStripMenuItem.Enabled = true;
                    allExhibitionsToolStripMenuItem.Enabled = true;
                    break;
            }
        }
        private void DeleteModeSwap(string type)
        {
            switch (type)
            {
                case ("On"):
                    DeleteMode = true;
                    AddMode = false;
                    UpdateMode = false;
                    lblExhibitionIDDelete.Visible = true;
                    txtExhibitionIDDelete.Visible = true;
                    txtExhibitionIDDelete.Text = "EX";
                    btnDeleteExhibition.Visible = true;
                    ShowDgv('F');
                    advancedGuestArtworkToolStripMenuItem.Enabled = true;
                    generalGuestArtworkToolStripMenuItem.Enabled = false;
                    allExhibitionsToolStripMenuItem.Enabled = false;

                    break;
                case ("Off"):
                    DeleteMode = false;
                    lblExhibitionIDDelete.Visible = false;
                    txtExhibitionIDDelete.Visible = false;
                    btnDeleteExhibition.Visible = false;
                    lblExhibitionHAsArtworks.Visible = false;
                    advancedGuestArtworkToolStripMenuItem.Enabled = true;
                    generalGuestArtworkToolStripMenuItem.Enabled = true;
                    allExhibitionsToolStripMenuItem.Enabled = true;
                    break;
            }
        }
        // method to refresh the label based of the visible data grid view
        private void refreshCountLabel()
        {
            if (AllMode)
            {
                NoOfRecords = dgvAllExhibitions.Rows.Count;
            }
            else if (FutureMode)
            {
                NoOfRecords = dgvFutureExhibitions.Rows.Count;
            }
            else if (PastMode)
            {
                NoOfRecords = dgvPastExhibitions.Rows.Count;
            }

            lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecords);
        }
        // menu strip click items
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPotteryMainMenu().Show();
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
        private void advancedGuestArtworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDgv('F');
        }
        private void generalGuestArtworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDgv('P');
        }
        private void allExhibitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDgv('A');
        }
        // method to reset the data grid views
        private void RefreshDGVs()
        {
            this.populatePastExhibitionsTableAdapter.Fill(this.populatePastExhibitions._PopulatePastExhibitions);

            this.populateFutureExhibitionsTableAdapter.Fill(this.populateFutureExhibitions._PopulateFutureExhibitions);

            this.populateAllExhibitionsTableAdapter.Fill(this.populateAllExhibitions._PopulateAllExhibitions);
            refreshCountLabel();
        }
        //fills the data grid views and the count label when the form loads
        private void FrmExhibitionViewer_Load(object sender, EventArgs e)
        {
            this.populatePastExhibitionsTableAdapter.Fill(this.populatePastExhibitions._PopulatePastExhibitions);
            this.populateFutureExhibitionsTableAdapter.Fill(this.populateFutureExhibitions._PopulateFutureExhibitions);
            this.populateAllExhibitionsTableAdapter.Fill(this.populateAllExhibitions._PopulateAllExhibitions);
            refreshCountLabel();
            dgvAllExhibitions.ClearSelection();
            dgvFutureExhibitions.ClearSelection();
            dgvPastExhibitions.ClearSelection();
            btnAddMode.PerformClick();
        }
        // toggles the modes and disables or enables the button
        private void btnAddMode_Click(object sender, EventArgs e)
        {
            if (!AddMode)
            {
                btnAddMode.Enabled = false;
                btnDeleteMode.Enabled = true;
                btnUpdateMode.Enabled = true;

                DeleteModeSwap("Off");
                UpdateModeSwap("Off");
                AddModeSwap("On");
            }
        }
        private void btnDeleteMode_Click(object sender, EventArgs e)
        {
            if (!DeleteMode)
            {
                btnAddMode.Enabled = true;
                btnDeleteMode.Enabled = false;
                btnUpdateMode.Enabled = true;

                AddModeSwap("Off");
                UpdateModeSwap("Off");
                DeleteModeSwap("On");
            }
        }
        private void btnUpdateMode_Click(object sender, EventArgs e)
        {
            if (!UpdateMode)
            {
                btnAddMode.Enabled = true;
                btnDeleteMode.Enabled = true;
                btnUpdateMode.Enabled = false;

                DeleteModeSwap("Off");
                AddModeSwap("Off");
                UpdateModeSwap("On");
            }
        }
        // when value changed, hides the caret and then adjusts the calendar accordingly.
        private void nudYear_ValueChanged(object sender, EventArgs e)
        {
            HideCaret(this.nudExhibitionYearAdd.Controls[1].Handle);
            DateTime Min = new DateTime(Convert.ToInt32(nudExhibitionYearAdd.Value), 12, 01);
            DateTime Max = new DateTime(Convert.ToInt32(nudExhibitionYearAdd.Value), 12, 31);
            for (int i = 0; i < dgvAllExhibitions.Rows.Count; i++)
            {
                int year = Convert.ToInt32(dgvAllExhibitions.Rows[i].Cells[1].Value.ToString().Substring(6, 4));
                if (year == Convert.ToInt32(nudExhibitionYearAdd.Value))
                {
                    nudExhibitionYearAdd.ForeColor = Color.Red;
                    mcExhibitionDate.Enabled = false;
                    lblYearFull.Visible = true;
                    btnAddExhibition.Enabled = false;
                    break;
                }
                else
                {
                    nudExhibitionYearAdd.ForeColor = Color.Black;
                    mcExhibitionDate.Enabled = true;
                    lblYearFull.Visible = false;
                    btnAddExhibition.Enabled = true;
                }
            }
            if (Convert.ToInt32(nudExhibitionYearAdd.Value) > mcExhibitionDate.MinDate.Year)
            {
                mcExhibitionDate.MaxDate = Max;
                mcExhibitionDate.MinDate = Min;
            }
            else if (Convert.ToInt32(nudExhibitionYearAdd.Value) < mcExhibitionDate.MinDate.Year)
            {
                mcExhibitionDate.MinDate = Min;
                mcExhibitionDate.MaxDate = Max;
            }

        }
        // handles key presses so the numeric up down cannot be typed in
        private void nudExhibitionYearAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        // when the calendar is clicked on, catches the location in order to disable the year or decade view.
        private void mcExhibitionDate_MouseDown(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo x = mcExhibitionDate.HitTest(e.Location);
            if (x.HitArea.ToString() == "TitleBackground")
            {
                mcExhibitionDate.Enabled = false;
                mcExhibitionDate.Enabled = true;
            }
        }
        // when button pressed create new exhibition and refresh dgv.
        private void btnAddExhibition_Click(object sender, EventArgs e)
        {
            int success = ExhibitionDal.AddExhibition(mcExhibitionDate.SelectionStart.Date);
            if (success < 1)
            {
                MessageBox.Show("Something went wrong creating a new exhibition. Please try again.", "Failed");
            }
            else
            {
                MessageBox.Show("Successfully created a new exhibition. You should see it in the All Exhibitions Table.", "Success");
            }
            RefreshDGVs();
            AddModeSwap("On");
        }
        // check the code is valid and if it is enable the delete button
        private void txtExhibitionIDDelete_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.CodeEntryCheck(txtExhibitionIDDelete, "EX", 2);
            for (int i = 0; i < dgvFutureExhibitions.Rows.Count; i++)
            {
                if (dgvFutureExhibitions.Rows[i].Cells[0].Value.ToString() == txtExhibitionIDDelete.Text.Trim())
                {
                    if (Convert.ToInt32(dgvFutureExhibitions.Rows[i].Cells[3].Value) <= 0)
                    {
                        btnDeleteExhibition.Enabled = true;
                        lblExhibitionHAsArtworks.Visible = false;
                        break;
                    }
                    else
                    {
                        btnDeleteExhibition.Enabled = false;
                        lblExhibitionHAsArtworks.Visible = true;
                        break;
                    }
                }
                else
                {
                    btnDeleteExhibition.Enabled = false;
                    lblExhibitionHAsArtworks.Visible = false;
                }
            }
        }
        // when selection in data grid view changes check the mode and populate boxes accordingly
        private void DGVSelectionChange(object sender, EventArgs e)
        {
            if (AddMode)
            {
                dgvAllExhibitions.ClearSelection();
                dgvFutureExhibitions.ClearSelection();
                dgvPastExhibitions.ClearSelection();
            }
            else if (DeleteMode)
            {

                if (FutureMode && dgvFutureExhibitions.Visible)
                {
                    try
                    {
                        txtExhibitionIDDelete.Text = dgvFutureExhibitions.SelectedCells[0].Value.ToString();
                    }
                    catch
                    {
                        txtExhibitionIDDelete.Text = "EX";
                    }


                }
                else
                {
                    dgvAllExhibitions.ClearSelection();
                    dgvFutureExhibitions.ClearSelection();
                    dgvPastExhibitions.ClearSelection();
                }
            }
            else if (UpdateMode)
            {
                if (FutureMode && dgvFutureExhibitions.Visible)
                {
                    try
                    {
                        txtExhibitionIDUpdate.Text = dgvFutureExhibitions.SelectedCells[0].Value.ToString();
                    }
                    catch
                    {
                        txtExhibitionIDUpdate.Text = "EX";
                    }


                }
                else
                {
                    dgvAllExhibitions.ClearSelection();
                    dgvFutureExhibitions.ClearSelection();
                    dgvPastExhibitions.ClearSelection();
                }
            }
        }
        // get user confirmation and perform delete, then refresh data grid view
        private void btnDeleteExhibition_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you wish to permanently delete exhibition " + txtExhibitionIDDelete.Text.Trim() + " from the system?", "Are You Sure?", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                int success = ExhibitionDal.DeleteExhibition(txtExhibitionIDDelete.Text.Trim());
                if (success < 1)
                {
                    MessageBox.Show("Something went wrong deleting the exhibition. Please try again.", "Failed");
                }
                else
                {
                    MessageBox.Show("Successfully deleted an exhibition.", "Success");
                }
                RefreshDGVs();
                DeleteModeSwap("On");
            }
        }
        // hode the caret on the catering number numeric up down
        private void nudCateringNumberUpdate_ValueChanged(object sender, EventArgs e)
        {
            HideCaret(this.nudCateringNumberUpdate.Controls[1].Handle);
        }
        // if the exhibition id changes validate the code and
        // then adjust the calendar and catering number to match the record.
        private void txtExhibitionIDUpdate_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.CodeEntryCheck(txtExhibitionIDUpdate, "EX", 2);
            bool found = false;
            for (int i = 0; i < dgvFutureExhibitions.Rows.Count; i++)
            {
                if (dgvFutureExhibitions.Rows[i].Cells[0].Value.ToString() == txtExhibitionIDUpdate.Text.Trim())
                {
                    found = true;
                    mcExhibitionDateUpdate.Enabled = true;
                    int tempMax = mcExhibitionDateUpdate.MaxDate.Year;
                    DateTime Min = new DateTime(Convert.ToInt32(dgvFutureExhibitions.Rows[i].Cells[1].Value.ToString().Substring(6, 4)), 12, 1);
                    DateTime Max = new DateTime(Convert.ToInt32(dgvFutureExhibitions.Rows[i].Cells[1].Value.ToString().Substring(6, 4)), 12, 31);
                    // if increasing, set max then min, if decreasing min then max
                    if (tempMax < Max.Year)
                    {
                        mcExhibitionDateUpdate.MaxDate = Max;
                        mcExhibitionDateUpdate.MinDate = Min;
                    }
                    else if (tempMax > Max.Year)
                    {
                        mcExhibitionDateUpdate.MinDate = Min;
                        mcExhibitionDateUpdate.MaxDate = Max;
                    }
                    DateTime ExhibitionCurrentDate = new DateTime(Convert.ToInt32(dgvFutureExhibitions.Rows[i].Cells[1].Value.ToString().Substring(6, 4)), Convert.ToInt32(dgvFutureExhibitions.Rows[i].Cells[1].Value.ToString().Substring(3, 2)), Convert.ToInt32(dgvFutureExhibitions.Rows[i].Cells[1].Value.ToString().Substring(0, 2)));
                    mcExhibitionDateUpdate.SelectionStart = ExhibitionCurrentDate;
                    nudCateringNumberUpdate.Enabled = true;
                    nudCateringNumberUpdate.Value = Convert.ToInt32(dgvFutureExhibitions.Rows[i].Cells[2].Value.ToString());
                    btnUpdateExhibition.Enabled = true;
                    break;
                }
            }
            if (!found)
            {
                mcExhibitionDateUpdate.Enabled = false;
                nudCateringNumberUpdate.Enabled = false;
                btnUpdateExhibition.Enabled = false;
                nudCateringNumberUpdate.Value = 0;
            }
        }
        // perform update and refresh data grid view
        private void btnUpdateExhibition_Click(object sender, EventArgs e)
        {
            int success = ExhibitionDal.UpdateExhibition(txtExhibitionIDUpdate.Text.Trim(), mcExhibitionDateUpdate.SelectionStart.Date, (int)nudCateringNumberUpdate.Value);
            if (success < 1)
            {
                MessageBox.Show("Something went wrong updating the exhibition. Please try again.", "Failed");
            }
            else
            {
                MessageBox.Show("Successfully updated an exhibition.", "Success");
            }
            RefreshDGVs();
            UpdateModeSwap("On");
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

        private void makeABookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.MakeABookingOpen(this);
        }

        private void getCourseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.GetCourseReportOpen(this);
        }

        private void artworkManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.ArtworkManagerOpen(this);
        }

        private void mainMenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonMethods.MainMenuOpen(this);
        }

        private void txtExhibitionIDDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // extra event for the update month picker to fix failed test 15.19

        private void mcExhibitionDateUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo x = mcExhibitionDateUpdate.HitTest(e.Location);
            if (x.HitArea.ToString() == "TitleBackground")
            {
                mcExhibitionDateUpdate.Enabled = false;
                mcExhibitionDateUpdate.Enabled = true;
            }
        }
    }
}

