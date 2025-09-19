using Microsoft.ReportingServices.Diagnostics.Internal;
using PotteryDBA_V1._0.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PotteryDBA_V1._0.Forms
{
    public partial class FrmAddGuest : Form
    {
        // global variables used throughout
        int NoOfRecordsInDGV = 0;
        bool UpdateMode = false;
        bool DeleteMode = false;
        bool AddMode = false;
        bool ForeMode;
        bool SurMode;
        bool IDMode;
        string Forename;
        string Surname;
        string searchvalue;
        int sortcount = 0;
        public FrmAddGuest()
        {
            // centers to screen and disables the maximise and minimise buttons
            InitializeComponent();
            CenterToScreen();
            CommonMethods.lockform(this);
            lblexistingbooking.Visible = false;
        }

        // toggle method for Adding Guests. shows all the componets required for adding aqnd hides the rest.
        private void AddModeSwap(string type)
        {
            switch (type)
            {
                case ("On"):
                    UpdateMode = false;
                    DeleteMode = false;
                    AddMode = true;
                    lblForenameAddUpdate.Visible = true;
                    txtForenameAddUpdate.Visible = true;
                    txtForenameAddUpdate.Text = string.Empty;
                    lblSurnameAddUpdate.Visible = true;
                    txtSurnameAddUpdate.Visible = true;
                    txtSurnameAddUpdate.Text = string.Empty;
                    lblContactNoAddUpdate.Visible = true;
                    txtContactNoAddUpdate.Visible = true;
                    txtContactNoAddUpdate.Text = "+";
                    lblDialCodeAddUpdate.Visible = true;
                    lblAddressLine1AddUpdate.Visible = true;
                    txtAddressLine1AddUpdate.Visible = true;
                    txtAddressLine1AddUpdate.Text = string.Empty;
                    lblAddressLine2AddUpdate.Visible = true;
                    txtAddressLine2AddUpdate.Visible = true;
                    txtAddressLine2AddUpdate.Text = string.Empty;
                    lblAddressLine3AddUpdate.Visible = true;
                    txtAddressLine3AddUpdate.Visible = true;
                    txtAddressLine3AddUpdate.Text = string.Empty;
                    lblSkillLevelAddUpdate.Visible = true;
                    cbxSkillLevelAddUpdate.Visible = true;
                    cbxSkillLevelAddUpdate.SelectedIndex = -1;
                    btnAddGuest.Visible = true;
                    dgvGuestsOut.ClearSelection();
                    break;
                case ("Off"):
                    AddMode = false;
                    lblForenameAddUpdate.Visible = false;
                    txtForenameAddUpdate.Visible = false;
                    lblSurnameAddUpdate.Visible = false;
                    txtSurnameAddUpdate.Visible = false;
                    lblContactNoAddUpdate.Visible = false;
                    txtContactNoAddUpdate.Visible = false;
                    lblDialCodeAddUpdate.Visible = false;
                    lblAddressLine1AddUpdate.Visible = false;
                    txtAddressLine1AddUpdate.Visible = false;
                    lblAddressLine2AddUpdate.Visible = false;
                    txtAddressLine2AddUpdate.Visible = false;
                    lblAddressLine3AddUpdate.Visible = false;
                    txtAddressLine3AddUpdate.Visible = false;
                    lblSkillLevelAddUpdate.Visible = false;
                    cbxSkillLevelAddUpdate.Visible = false;
                    btnAddGuest.Visible = false;
                    dgvGuestsOut.ClearSelection();
                    break;
            }
        }

        // toggle method for Updating Guests
        private void UpdateModeSwap(string type)
        {
            switch (type)
            {
                case ("On"):
                    UpdateMode = true;
                    DeleteMode = false;
                    AddMode = false;
                    lblForenameAddUpdate.Visible = true;
                    txtForenameAddUpdate.Visible = true;
                    txtForenameAddUpdate.Text = string.Empty;
                    lblSurnameAddUpdate.Visible = true;
                    txtSurnameAddUpdate.Visible = true;
                    txtSurnameAddUpdate.Text = string.Empty;
                    lblContactNoAddUpdate.Visible = true;
                    txtContactNoAddUpdate.Visible = true;
                    txtContactNoAddUpdate.Text = "+";
                    lblDialCodeAddUpdate.Visible = true;
                    lblAddressLine1AddUpdate.Visible = true;
                    txtAddressLine1AddUpdate.Visible = true;
                    txtAddressLine1AddUpdate.Text = string.Empty;
                    lblAddressLine2AddUpdate.Visible = true;
                    txtAddressLine2AddUpdate.Visible = true;
                    txtAddressLine2AddUpdate.Text = string.Empty;
                    lblAddressLine3AddUpdate.Visible = true;
                    txtAddressLine3AddUpdate.Visible = true;
                    txtAddressLine3AddUpdate.Text = string.Empty;
                    lblSkillLevelAddUpdate.Visible = true;
                    cbxSkillLevelAddUpdate.Visible = true;
                    cbxSkillLevelAddUpdate.SelectedIndex = -1;
                    btnUpdateGuest.Visible = true;
                    dgvGuestsOut.ClearSelection();
                    break;
                case ("Off"):
                    UpdateMode = false;
                    lblForenameAddUpdate.Visible = false;
                    txtForenameAddUpdate.Visible = false;
                    lblSurnameAddUpdate.Visible = false;
                    txtSurnameAddUpdate.Visible = false;
                    lblContactNoAddUpdate.Visible = false;
                    txtContactNoAddUpdate.Visible = false;
                    lblDialCodeAddUpdate.Visible = false;
                    lblAddressLine1AddUpdate.Visible = false;
                    txtAddressLine1AddUpdate.Visible = false;
                    lblAddressLine2AddUpdate.Visible = false;
                    txtAddressLine2AddUpdate.Visible = false;
                    lblAddressLine3AddUpdate.Visible = false;
                    txtAddressLine3AddUpdate.Visible = false;
                    lblSkillLevelAddUpdate.Visible = false;
                    cbxSkillLevelAddUpdate.Visible = false;
                    btnUpdateGuest.Visible = false;
                    dgvGuestsOut.ClearSelection();
                    break;
            }
        }

        // toggle method for Deleting Guests
        private void DeleteModeSwap(string type)
        {
            switch (type)
            {
                case ("On"):
                    UpdateMode = false;
                    DeleteMode = true;
                    AddMode = false;
                    lblGuestIDDelete.Visible = true;
                    txtGuestIDDelete.Visible = true;
                    txtGuestIDDelete.Text = "G";
                    btnDeleteGuest.Visible = true;
                    dgvGuestsOut.ClearSelection();
                    break;
                case ("Off"):
                    DeleteMode = false;
                    lblGuestIDDelete.Visible = false;
                    txtGuestIDDelete.Visible = false;
                    btnDeleteGuest.Visible = false;
                    dgvGuestsOut.ClearSelection();
                    break;
            }
        }

        // method refreshes data grid view with all records. Also clears search bars.
        public void refreshdgv()
        {
            GuestDal.SearchByForename("", dgvGuestsOut);
            lblNoResults.Visible = false;
            EmptyBoxes();
            NoOfRecordsInDGV = dgvGuestsOut.Rows.Count;
            lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecordsInDGV);
            //ClearSearchBoxes();
        }

        // method refreshes data grid view with the current search.
        public void refreshwithsearch()
        {
            // checks the mode and search is visible
            if (IDMode && txtGuestIDsearch.Visible)
            {
                // takes the search text and passes it into the method and then the stored procedure
                string x = txtGuestIDsearch.Text.Trim();
                int outcome = GuestDal.SearchByGuestID(x, dgvGuestsOut);
                NoOfRecordsInDGV = dgvGuestsOut.Rows.Count;
                lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecordsInDGV);
                if (outcome == -10)
                {
                    lblNoResults.Visible = true;
                    dgvGuestsOut.DataSource = null;
                }
                else
                {
                    lblNoResults.Visible = false;
                }
            }
            else if (ForeMode && txtForenamesearch.Visible)
            {
                string x = txtForenamesearch.Text.Trim();
                int outcome = GuestDal.SearchByForename(x, dgvGuestsOut);
                if (outcome == -10)
                {
                    lblNoResults.Visible = true;
                    dgvGuestsOut.DataSource = null;
                }
                else
                {
                    lblNoResults.Visible = false;
                }
                NoOfRecordsInDGV = dgvGuestsOut.Rows.Count;
                lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecordsInDGV);
            }
            else if (SurMode && txtSurnamesearch.Visible)
            {
                string x = txtSurnamesearch.Text.Trim();
                int outcome = GuestDal.SearchBySurname(x, dgvGuestsOut);
                if (outcome == -10)
                {
                    lblNoResults.Visible = true;
                    dgvGuestsOut.DataSource = null;
                }
                else
                {
                    lblNoResults.Visible = false;
                }
                NoOfRecordsInDGV = dgvGuestsOut.Rows.Count;
                lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecordsInDGV);
            }
            else
            {
                GuestDal.SearchByForename("", dgvGuestsOut);
                NoOfRecordsInDGV = dgvGuestsOut.Rows.Count;
                lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecordsInDGV);
            }
        }

        private void FrmHalfTermTask_Load(object sender, EventArgs e)
        {
            refreshdgv();
            ForeMode = false;
            SurMode = false;
            IDMode = false;
            cbxSearchBy.SelectedIndex = 2;
            UpdateModeSwap("Off");
            DeleteModeSwap("Off");
            AddModeSwap("On");
            btnCancelUpdate.Enabled = false;
        }

        // method to empty all controls
        public void EmptyBoxes()
        {
            txtForenameAddUpdate.Text = string.Empty;
            txtSurnameAddUpdate.Text = string.Empty;
            txtContactNoAddUpdate.Text = "+";
            txtAddressLine1AddUpdate.Text = string.Empty;
            txtAddressLine2AddUpdate.Text = string.Empty;
            txtAddressLine3AddUpdate.Text = string.Empty;
            cbxSkillLevelAddUpdate.SelectedIndex = -1;
            txtGuestIDDelete.Text = "G";
        }

        // event for the Add guest Button Click
        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            // when the add guest button is clicked, check of all fields contain something
            if (txtForenameAddUpdate.Text == string.Empty || txtSurnameAddUpdate.Text == string.Empty || txtContactNoAddUpdate.Text == string.Empty
                || txtAddressLine1AddUpdate.Text == string.Empty || txtAddressLine2AddUpdate.Text == string.Empty || txtAddressLine3AddUpdate.Text == string.Empty || cbxSkillLevelAddUpdate.SelectedIndex == -1)
            {
                MessageBox.Show("Please ensure to enter all guest details carefully.", "Empty Fields Detected");
            }
            else
            {
                // separates all the fields for the table, concatenates the address into one string
                string forename = txtForenameAddUpdate.Text.Trim();
                string surname = txtSurnameAddUpdate.Text.Trim();
                string no = txtContactNoAddUpdate.Text.Trim();
                string address = txtAddressLine1AddUpdate.Text.Trim() + ", " + txtAddressLine2AddUpdate.Text.Trim() + ", " + txtAddressLine3AddUpdate.Text.Trim();
                string skill = cbxSkillLevelAddUpdate.Text.Trim();
                // runs the add guest method and assigns it to an int to use the stored procedure output to check if it worked
                int success = GuestDal.AddGuest(forename, surname, no, address, skill);
                if (success != 0)
                {
                    MessageBox.Show($"{forename} {surname} successfully added.", "Success");
                }
                else
                {
                    MessageBox.Show("Failed to add Guest. Please try again.", "Failed");
                }
                refreshwithsearch();
                AddModeSwap("On");
            }
        }

        // method to stop spaces and letters from being entered into the phone number text box
        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            string text = txtContactNoAddUpdate.Text;
            if (text == "")
            {
                txtContactNoAddUpdate.Text = "+";
                txtContactNoAddUpdate.Select(txtContactNoAddUpdate.Text.Length, 0);
            }
            else if (text[0] != '+')
            {
                txtContactNoAddUpdate.Text = "+";
                txtContactNoAddUpdate.Select(txtContactNoAddUpdate.Text.Length, 0);
            }
            for (int i = 1; i < txtContactNoAddUpdate.Text.Length; i++)
            {
                if (text[i] == Convert.ToChar(" "))
                {
                    txtContactNoAddUpdate.Text = txtContactNoAddUpdate.Text.Replace(" ", "");
                    txtContactNoAddUpdate.Select(txtContactNoAddUpdate.Text.Length, 0);
                    break;
                }
                else if (char.IsNumber(text[i]) == false)
                {
                    txtContactNoAddUpdate.Text = txtContactNoAddUpdate.Text.Replace(Convert.ToString(text[i]), "");
                    txtContactNoAddUpdate.Select(txtContactNoAddUpdate.Text.Length, 0);
                }
            }
        }

        // menu strip item events
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmGuestMenu().Show();
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
        private void myCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // event for the selection changing in the data grid view.
        private void dgvGuestsOut_SelectionChanged(object sender, EventArgs e)
        {
            if (UpdateMode)
            {
                if (dgvGuestsOut.SelectedRows.Count == 1)
                {
                    txtForenameAddUpdate.Text = dgvGuestsOut.SelectedCells[1].Value.ToString().Trim();
                    txtSurnameAddUpdate.Text = dgvGuestsOut.SelectedCells[2].Value.ToString().Trim();
                    txtContactNoAddUpdate.Text = dgvGuestsOut.SelectedCells[3].Value.ToString().Trim();
                    string FullAddress = dgvGuestsOut.SelectedCells[4].Value.ToString().Trim();
                    string[] SplitAddress = FullAddress.Split(',');
                    txtAddressLine1AddUpdate.Text = SplitAddress[0].Trim();
                    txtAddressLine2AddUpdate.Text = SplitAddress[1].Trim();
                    txtAddressLine3AddUpdate.Text = SplitAddress[2].Trim();
                    string skillL = dgvGuestsOut.SelectedCells[5].Value.ToString().Trim();

                    string GuestID = dgvGuestsOut.SelectedCells[0].Value.ToString().Trim();

                    int CheckingBookings = GuestDal.CheckForFutureBookings(GuestID);
                    if (CheckingBookings == -20)
                    {
                        // bookings
                        cbxSkillLevelAddUpdate.Enabled = false;
                        lblexistingbooking.Visible = true;
                    }
                    else if (CheckingBookings == -50)
                    {
                        // no bookings
                        cbxSkillLevelAddUpdate.Enabled = true;
                        lblexistingbooking.Visible = false;
                    }
                    if (skillL == "Beginner")
                    {
                        cbxSkillLevelAddUpdate.SelectedIndex = 0;
                    }
                    else if (skillL == "Intermediate")
                    {
                        cbxSkillLevelAddUpdate.SelectedIndex = 1;
                    }
                    else if (skillL == "Advanced")
                    {
                        cbxSkillLevelAddUpdate.SelectedIndex = 2;
                    }
                    btnAddGuest.Visible = false;
                    btnCancelUpdate.Visible = true;
                    btnUpdateGuest.Visible = true;
                }
            }
            else if (DeleteMode)
            {
                try
                {
                    txtGuestIDDelete.Text = dgvGuestsOut.SelectedCells[0].Value.ToString().Trim();
                }
                catch
                {
                    dgvGuestsOut.ClearSelection();
                    txtGuestIDDelete.Text = "G";
                }

            }
            else
            {
                dgvGuestsOut.ClearSelection();
            }
        }

        // methods to trigger changes in mode based off the three mode buttons
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            UpdateModeSwap("Off");
            DeleteModeSwap("Off");
            AddModeSwap("On");
            btnCancelUpdate.Enabled = false;
            btnDeleteMode.Enabled = true;
            btnEnterUpdate.Enabled = true;

            EmptyBoxes();
        }

        private void btnEnterUpdate_Click(object sender, EventArgs e)
        {
            DeleteModeSwap("Off");
            AddModeSwap("Off");
            UpdateModeSwap("On");
            EmptyBoxes();
            btnCancelUpdate.Enabled = true;
            btnDeleteMode.Enabled = true;
            btnEnterUpdate.Enabled = false;
        }

        private void btnDeleteMode_Click(object sender, EventArgs e)
        {
            AddModeSwap("Off");
            UpdateModeSwap("Off");
            DeleteModeSwap("On");
            EmptyBoxes();
            btnCancelUpdate.Enabled = true;
            btnDeleteMode.Enabled = false;
            btnEnterUpdate.Enabled = true;
        }

        // method checks details have been filled in and triggers an update as a result
        private void btnUpdateGuest_Click(object sender, EventArgs e)
        {
            // need to maybe add check for future courses to ensure skill level cannot change
            if (dgvGuestsOut.SelectedRows.Count > 0 && txtForenameAddUpdate.Text.Trim() != "" && txtSurnameAddUpdate.Text.Trim() != "" && txtContactNoAddUpdate.Text.Trim() != "+"
                && txtAddressLine1AddUpdate.Text.Trim() != "" && txtAddressLine2AddUpdate.Text.Trim() != "" && txtAddressLine3AddUpdate.Text.Trim() != "" && cbxSkillLevelAddUpdate.Text.Trim() != "")
            {
                string forename = txtForenameAddUpdate.Text.Trim();
                string surname = txtSurnameAddUpdate.Text.Trim();
                string number = txtContactNoAddUpdate.Text.Trim();
                string address = txtAddressLine1AddUpdate.Text.Trim() + "," + txtAddressLine2AddUpdate.Text.Trim() + ", " + txtAddressLine3AddUpdate.Text.Trim();
                string skill = cbxSkillLevelAddUpdate.Text.Trim();
                string GuestID = dgvGuestsOut.SelectedCells[0].Value.ToString().Trim();


                int updatesuccess = GuestDal.UpdateGuest(forename, surname, number, address, skill, GuestID);
                if (updatesuccess == 0)
                {
                    MessageBox.Show("Guest" + forename + " " + surname + " \ncould not be updated. Try again later.", "Failed");
                }
                else if (updatesuccess == 1)
                {
                    MessageBox.Show("Guest " + forename + " " + surname + " was successfully updated.", "Success");
                }
                refreshwithsearch();
            }
            else
            {
                MessageBox.Show("Please ensure to fill all fields with valid information.\nYou can select a row from the table to fill the information.", "Missing Data");
            }

        }

        // event for clicking on 6he sort by skill menu strip item
        private void sortBySkillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // adjusts the sort type so it cycles from BIA to IAB to ABI
            // and so on, using a counter from when the form is opened.
            if (sortcount == 0)
            {
                sortcount = 1;
            }
            else if (sortcount == 1)
            {
                sortcount = 2;
            }
            else if (sortcount == 2)
            {
                sortcount = 0;
            }

            // this section uses the selected search type to
            // ensure the right search is used in the stored procedures.
            int selectedSearch = cbxSearchBy.SelectedIndex;
            switch (selectedSearch)
            {
                case 0:
                    searchvalue = txtForenamesearch.Text.Trim();
                    break;
                case 1:
                    searchvalue = txtSurnamesearch.Text.Trim();
                    break;
                case 2:
                    searchvalue = txtGuestIDsearch.Text.Trim();
                    break;
            }
            // using the type of sort from the counter, This passes
            // the search type and value into the method to allow a
            // search to be sorted by skill type.
            switch (sortcount)
            {
                case 0:
                    GuestDal.BeginnerSort(dgvGuestsOut, searchvalue, selectedSearch);
                    break;
                case 1:
                    GuestDal.IntermediateSort(dgvGuestsOut, searchvalue, selectedSearch);
                    break;
                case 2:
                    GuestDal.AdvancedSort(dgvGuestsOut, searchvalue, selectedSearch);
                    break;
            }

        }

        // event for when the search type is changed.
        private void cbxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshdgv();
            // disables boxes based off of the option selected in the combo box.
            if (cbxSearchBy.SelectedIndex == 0)
            {
                txtForenamesearch.Visible = true;
                txtSurnamesearch.Visible = false;
                txtSurnamesearch.Text = string.Empty;
                txtGuestIDsearch.Visible = false;
                txtGuestIDsearch.Text = "";
                ForeMode = true;
                SurMode = false;
                IDMode = false;
            }
            else if (cbxSearchBy.SelectedIndex == 1)
            {
                txtForenamesearch.Visible = false;
                txtSurnamesearch.Visible = true;
                txtForenamesearch.Text = string.Empty;
                txtGuestIDsearch.Visible = false;
                txtGuestIDsearch.Text = "";
                ForeMode = false;
                SurMode = true;
                IDMode = false;
            }
            else if (cbxSearchBy.SelectedIndex == 2)
            {
                txtForenamesearch.Visible = false;
                txtSurnamesearch.Text = string.Empty;
                txtSurnamesearch.Visible = false;
                txtForenamesearch.Text = string.Empty;
                txtGuestIDsearch.Visible = true;
                txtGuestIDsearch.Text = "G";
                ForeMode = false;
                SurMode = false;
                IDMode = true;
            }
        }

        // These methods search every time the text in the box changes, meaning the search is always current.
        private void txtForename_TextChanged(object sender, EventArgs e)
        {
            if (ForeMode && txtForenamesearch.Visible)
            {
                string x = txtForenamesearch.Text.Trim();
                int outcome = GuestDal.SearchByForename(x, dgvGuestsOut);
                if (outcome == -10)
                {
                    lblNoResults.Visible = true;
                    dgvGuestsOut.DataSource = null;
                }
                else
                {
                    lblNoResults.Visible = false;
                }
                NoOfRecordsInDGV = dgvGuestsOut.Rows.Count;
                lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecordsInDGV);
            }

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (SurMode && txtSurnamesearch.Visible)
            {
                string x = txtSurnamesearch.Text.Trim();
                int outcome = GuestDal.SearchBySurname(x, dgvGuestsOut);
                if (outcome == -10)
                {
                    lblNoResults.Visible = true;
                    dgvGuestsOut.DataSource = null;
                }
                else
                {
                    lblNoResults.Visible = false;
                }
                NoOfRecordsInDGV = dgvGuestsOut.Rows.Count;
                lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecordsInDGV);
            }

        }

        private void txtGuestID_TextChanged(object sender, EventArgs e)
        {
            if (IDMode && txtGuestIDsearch.Visible)
            {
                CommonMethods.CodeEntryCheck(txtGuestIDsearch, "G");
                // carries out the search when the text is changed to keep it current.
                string x = txtGuestIDsearch.Text.Trim();
                int outcome = GuestDal.SearchByGuestID(x, dgvGuestsOut);
                NoOfRecordsInDGV = dgvGuestsOut.Rows.Count;
                lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecordsInDGV);
                if (outcome == -10)
                {
                    lblNoResults.Visible = true;
                    dgvGuestsOut.DataSource = null;
                }
                else
                {
                    lblNoResults.Visible = false;
                }
            }

        }

        // method to empty all the text boxes for searches
        private void ClearSearchBoxes()
        {
            txtForenamesearch.Text = string.Empty;
            txtSurnamesearch.Text = string.Empty;
            txtGuestIDsearch.Text = "G";
            cbxSearchBy.SelectedIndex = 2;
            dgvGuestsOut.ClearSelection();
        }

        // event for clear searches button click
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            ClearSearchBoxes();
        }

        // event to only enable the delete button when the guest id is valid.
        // Also manages the inputs for the code to ensure only numbers.
        private void txtGuestIDDelete_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.CodeEntryCheck(txtGuestIDDelete, "G");
            string GuestID = txtGuestIDDelete.Text.Trim();
            bool foundGuest = false;
            foreach (DataGridViewRow i in dgvGuestsOut.Rows)
            {
                if (i.Cells[0].Value.ToString() == GuestID)
                {
                    foundGuest = true;
                    Forename = i.Cells[1].Value.ToString().Trim();
                    Surname = i.Cells[2].Value.ToString().Trim();
                    break;
                }
            }
            if (!foundGuest)
            {
                btnDeleteGuest.Enabled = false;
            }
            else
            {
                btnDeleteGuest.Enabled = true;
            }
        }

        // event for when the delete button is pressed.
        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            string GuestID = txtGuestIDDelete.Text.Trim();
            // if there is a guest, request confirmation
            DialogResult x = MessageBox.Show("Are you sure you want to delete Guest \"" + Forename + " " + Surname + "\"?\nThis action is permanent. All previous\nbookings will be erased from the system.", "Are You Sure?", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                // attempt to delete guest and show message box based on the result.
                int RowsAffected = GuestDal.DeleteGuest(GuestID);
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Guest \"" + Forename + " " + Surname + "\" was successfully deleted. \nAll previous bookings will also have been removed.", "Success");
                }
                else if (RowsAffected == -15)
                {
                    MessageBox.Show("Guest \"" + Forename + " " + Surname + "\" could not be deleted, they \ncurrenly have artwork stored in the system. \nPlease go to Artwork Management and delete \nartwork belonging to this guest before proceeding.", "Failed");
                }
                refreshwithsearch();
            }

        }

        private void courseMaagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.CourseMenuOpen(this);
        }

        private void guestManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.GuestManagementOpen(this);
        }

        private void logEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.LogEquipmentOpen(this);
        }

        private void guestInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.GuestInvoiceOpen(this);
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

        private void dgvGuestsOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // uses i comparable and custom exceptions to sort the addresses by city.
        private void sortByCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Address.AddressSort(dgvGuestsOut);
        }


        // events to avoid a comma being entered as it is the separator char into the address boxes
        private void txtAddressLine1AddUpdate_TextChanged(object sender, EventArgs e)
        {
            string temp = txtAddressLine1AddUpdate.Text;
            for (int i = 0; i < txtAddressLine1AddUpdate.Text.Length; i++)
            {
                if (temp[i] == ',')
                {
                    txtAddressLine1AddUpdate.Text = txtAddressLine1AddUpdate.Text.Replace(Convert.ToString(temp[i]), "");
                    txtAddressLine1AddUpdate.Select(txtAddressLine1AddUpdate.Text.Length, 0);
                }
            }
        }

        private void txtAddressLine2AddUpdate_TextChanged(object sender, EventArgs e)
        {
            string temp = txtAddressLine2AddUpdate.Text;
            for (int i = 0; i < txtAddressLine2AddUpdate.Text.Length; i++)
            {
                if (temp[i] == ',')
                {
                    txtAddressLine2AddUpdate.Text = txtAddressLine2AddUpdate.Text.Replace(Convert.ToString(temp[i]), "");
                    txtAddressLine2AddUpdate.Select(txtAddressLine2AddUpdate.Text.Length, 0);
                }
            }
        }

        private void txtAddressLine3AddUpdate_TextChanged(object sender, EventArgs e)
        {
            string temp = txtAddressLine3AddUpdate.Text;
            for (int i = 0; i < txtAddressLine3AddUpdate.Text.Length; i++)
            {
                if (temp[i] == ',')
                {
                    txtAddressLine3AddUpdate.Text = txtAddressLine3AddUpdate.Text.Replace(Convert.ToString(temp[i]), "");
                    txtAddressLine3AddUpdate.Select(txtAddressLine3AddUpdate.Text.Length, 0);
                }
            }
        }

        private void txtGuestIDDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
