using PotteryDBA_V1._0.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PotteryDBA_V1._0.Forms
{
    public partial class FrmArtworkViewer : Form
    {
        // decalration of variables used in the form
        int NoOfRecords = 0;
        bool advancedMode = false;
        bool AddMode = true;
        bool UpdateMode = false;
        bool DeleteMode = false;
        bool NoCourses = false;
        // imports a module that allows me to disable the flashing caret in my numric up downs.
        [DllImport("user32")]
        private static extern bool HideCaret(IntPtr hWnd);
        // when the form is constructed centre to screen, diable minimise,
        // and set the visibility of the mode it opens on.
        public FrmArtworkViewer()
        {
            InitializeComponent();
            CommonMethods.lockform(this);
            CenterToScreen();
            hideAllTextBoxes();
            lblAdvancedArtwork.Visible = false;
            lblAllArtworks.Visible = true;
            dgvArtworkOutAdvanced.Visible = false;
            lblNoResults.Visible = false;
            cbxSearchby.Text = string.Empty;
            btnAddMode.Enabled = false;
            lblUpdateAllowed.Visible = false;
            showADD();
            hideDELETE();
            hideUPDATE();

        }
        // method to hide all seach boxes
        private void hideAllTextBoxes()
        {
            btnClearSearch.Visible = false;
            lblsearchtext.Visible = false;
            txtAdvancedID.Visible = false;
            txtAdvancedName.Visible = false;
            nudAmount.Visible = false;
            txtNormalID.Visible = false;
            txtNormalName.Visible = false;
        }
        // empty the strings for all search bars
        private void clearsearchboxes()
        {
            txtAdvancedID.Text = "A";
            txtAdvancedName.Text = string.Empty;
            nudAmount.Value = 0.00M;
            txtNormalID.Text = "A";
            txtNormalName.Text = string.Empty;
            if (nudAmount.Visible)
            {
                try
                {
                    cbxSearchby.SelectedIndex = 0;
                    txtAdvancedID.Text = "A0";
                    txtAdvancedID.Text = "A";
                }
                catch
                {
                }

            }

        }
        // methods to toggle modes on and off. switch may be more efficient in future.
        private void showADD()
        {
            lblGuestID.Visible = true;
            txtGuestID.Visible = true;
            txtGuestID.Text = "G";
            lblCourseID.Visible = true;
            cbxCourseIDAdd.Visible = true;
            cbxCourseIDAdd.Enabled = false;
            lblSalePriceAdd.Visible = false;
            nudAddPrice.Visible = false;
            nudAddPrice.Value = 0.00m;
            lblFore.Visible = false;
            lblSur.Visible = false;
            lblnocourses.Visible = false;
            cbxCourseIDAdd.DataSource = null;
            btnAddArtwork.Visible = true;
            btnAddArtwork.Enabled = false;
        }
        private void hideADD()
        {
            lblGuestID.Visible = false;
            txtGuestID.Visible = false;
            txtGuestID.Text = "G";
            lblCourseID.Visible = false;
            cbxCourseIDAdd.Visible = false;
            cbxCourseIDAdd.Enabled = false;
            lblSalePriceAdd.Visible = false;
            nudAddPrice.Visible = false;
            nudAddPrice.Value = 0.00m;
            lblFore.Visible = false;
            lblSur.Visible = false;
            lblnocourses.Visible = false;
            cbxCourseIDAdd.DataSource = null;
            btnAddArtwork.Visible = false;
        }
        private void showDELETE()
        {
            lblArtworkIDDelete.Visible = true;
            txtArtworkIDDelete.Visible = true;
            txtArtworkIDDelete.Text = "A";
            btnDeleteArtwork.Visible = true;
            btnDeleteArtwork.Enabled = false;
        }
        private void hideDELETE()
        {
            lblArtworkIDDelete.Visible = false;
            txtArtworkIDDelete.Visible = false;
            btnDeleteArtwork.Visible = false;
            btnDeleteArtwork.Enabled = false;
            txtArtworkIDDelete.Text = "A";
        }
        private void showUPDATE()
        {
            lblArtworkIDUpdate.Visible = true;
            txtArtworkIDUpdate.Visible = true;
            txtArtworkIDUpdate.Text = "A";
            lblSalePriceUpdate.Visible = true;
            nudSalePriceUpdate.Visible = true;
            nudSalePriceUpdate.Value = 0.00m;
            lblSoldUpdate.Visible = true;
            chbxSold.Visible = true;
            chbxSold.Checked = false;
            btnUpdateArtwork.Visible = true;
            btnUpdateArtwork.Enabled = false;
            viewToolStripMenuItem.DropDownItems[1].Enabled = false;
            viewToolStripMenuItem.DropDownItems[0].PerformClick();
            lblCurrentExhibition.Visible = true;
            lblExhibition.Visible = true;
            cbxExhibtionEdit.Visible = true;
        }
        private void hideUPDATE()
        {
            lblArtworkIDUpdate.Visible = false;
            txtArtworkIDUpdate.Visible = false;
            lblSalePriceUpdate.Visible = false;
            nudSalePriceUpdate.Visible = false;
            lblSoldUpdate.Visible = false;
            chbxSold.Visible = false;
            btnUpdateArtwork.Visible = false;
            btnUpdateArtwork.Enabled = false;
            viewToolStripMenuItem.DropDownItems[1].Enabled = true;
            lblCurrentExhibition.Visible = false;
            lblExhibition.Visible = false;
            cbxExhibtionEdit.Visible = false;
        }
        // method to refresh the count label based off of which dgv is visible
        private void refreshCountLabel()
        {
            if (!advancedMode)
            {
                NoOfRecords = dgvArtworksOutNormal.Rows.Count;
            }
            else
            {
                NoOfRecords = dgvArtworkOutAdvanced.Rows.Count;
            }

            lblNoOfRecords.Text = "Number of Records: " + Convert.ToString(NoOfRecords);
        }
        // events for menu strip clicks
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
        // event for form loading and filling the dgv
        private void FrmArtworkViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'advancedModeFetchArtworkInfo.GetArtworkAdvancedMode' table. You can move, or remove it, as needed.
            this.getArtworkAdvancedModeTableAdapter.Fill(this.advancedModeFetchArtworkInfo.GetArtworkAdvancedMode);
            // TODO: This line of code loads data into the 'normalModeFetchArtworkInfo.GetArtworksNormalMode' table. You can move, or remove it, as needed.
            this.getArtworksNormalModeTableAdapter.Fill(this.normalModeFetchArtworkInfo.GetArtworksNormalMode);
            advancedMode = false;
            dgvArtworksOutNormal.Visible = true;
            dgvArtworkOutAdvanced.Visible = false;
            lblAdvancedArtwork.Visible = false;
            lblAllArtworks.Visible = true;
            cbxSearchby.Items.Clear();
            //clearsearchboxes();
            hideAllTextBoxes();
            if (cbxSearchby.Text != "")
            {
                lblsearchtext.Visible = true;
            }
            else
            {
                lblsearchtext.Visible = false;
            }
            cbxSearchby.Items.AddRange(new String[2] { "Artwork ID", "Name" });
            refreshCountLabel();
            refreshNormal();

        }
        //refreshes the advance dgv
        private void refreshAdvanced()
        {
            ArtworkDal.SearchByArtworkIDAdvanced("", dgvArtworkOutAdvanced);
            refreshCountLabel();
            if (NoOfRecords <= 0)
            {
                lblNoResults.Visible = true;
            }
            else
            {
                lblNoResults.Visible = false;
            }
        }
        // refreshes the normal dgv
        private void refreshNormal()
        {
            ArtworkDal.SearchByArtworkIDNormal("", dgvArtworksOutNormal);
            refreshCountLabel();
            if (NoOfRecords <= 0)
            {
                lblNoResults.Visible = true;
            }
            else
            {
                lblNoResults.Visible = false;
            }
        }
        // changes the form to show advanced artwork stuff
        private void advancedGuestArtworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advancedMode = true;
            dgvArtworkOutAdvanced.Visible = true;
            dgvArtworksOutNormal.Visible = false;
            lblAdvancedArtwork.Visible = true;
            lblAllArtworks.Visible = false;
            cbxSearchby.Items.Clear();
            clearsearchboxes();
            hideAllTextBoxes();
            if (cbxSearchby.Text != "")
            {
                lblsearchtext.Visible = true;
            }
            else
            {
                lblsearchtext.Visible = false;
            }
            cbxSearchby.Items.AddRange(new String[3] { "Artwork ID", "Name", "Sale Price" });
            refreshCountLabel();
            refreshAdvanced();
        }
        // changes the form to show normal artwork stuff
        private void generalGuestArtworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advancedMode = false;
            dgvArtworksOutNormal.Visible = true;
            dgvArtworkOutAdvanced.Visible = false;
            lblAdvancedArtwork.Visible = false;
            lblAllArtworks.Visible = true;
            cbxSearchby.Items.Clear();
            clearsearchboxes();
            hideAllTextBoxes();
            if (cbxSearchby.Text != "")
            {
                lblsearchtext.Visible = true;
            }
            else
            {
                lblsearchtext.Visible = false;
            }
            cbxSearchby.Items.AddRange(new String[2] { "Artwork ID", "Name" });
            refreshCountLabel();
            refreshNormal();
        }
        // changes which search bar is in use based off of the selected search type and form mode.
        private void cbxSearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearsearchboxes();
            if (cbxSearchby.Text != null)
            {
                lblsearchtext.Visible = true;
                if (advancedMode)
                {
                    if (cbxSearchby.Text.Trim() == "Artwork ID")
                    {
                        btnClearSearch.Visible = true;
                        txtAdvancedID.Visible = true;
                        txtAdvancedName.Visible = false;
                        nudAmount.Visible = false;
                        txtNormalID.Visible = false;
                        txtNormalName.Visible = false;
                    }
                    if (cbxSearchby.Text.Trim() == "Name")
                    {
                        btnClearSearch.Visible = true;
                        txtAdvancedID.Visible = false;
                        txtAdvancedName.Visible = true;
                        nudAmount.Visible = false;
                        txtNormalID.Visible = false;
                        txtNormalName.Visible = false;
                    }
                    if (cbxSearchby.Text.Trim() == "Sale Price")
                    {
                        btnClearSearch.Visible = true;
                        txtAdvancedID.Visible = false;
                        txtAdvancedName.Visible = false;
                        nudAmount.Visible = true;
                        txtNormalID.Visible = false;
                        txtNormalName.Visible = false;
                    }
                }
                if (!advancedMode)
                {
                    if (cbxSearchby.Text.Trim() == "Artwork ID")
                    {
                        btnClearSearch.Visible = true;
                        txtAdvancedID.Visible = false;
                        txtAdvancedName.Visible = false;
                        nudAmount.Visible = false;
                        txtNormalID.Visible = true;
                        txtNormalName.Visible = false;
                    }
                    if (cbxSearchby.Text.Trim() == "Name")
                    {
                        btnClearSearch.Visible = true;
                        txtAdvancedID.Visible = false;
                        txtAdvancedName.Visible = false;
                        nudAmount.Visible = false;
                        txtNormalID.Visible = false;
                        txtNormalName.Visible = true;
                    }
                }
            }
            else
            {
                hideAllTextBoxes();
            }

        }
        // toggles add mode when the button is clicked
        private void btnAddMode_Click(object sender, EventArgs e)
        {
            btnAddMode.Enabled = false;
            btnDeleteMode.Enabled = true;
            btnUpdateMode.Enabled = true;
            AddMode = true;
            UpdateMode = false;
            DeleteMode = false;
            dgvArtworksOutNormal.ClearSelection();
            dgvArtworkOutAdvanced.ClearSelection();
            showADD();
            hideDELETE();
            hideUPDATE();
            clearsearchboxes();
        }
        // toggles delete mode when the button is clicked
        private void btnDeleteMode_Click(object sender, EventArgs e)
        {
            btnAddMode.Enabled = true;
            btnDeleteMode.Enabled = false;
            btnUpdateMode.Enabled = true;
            AddMode = false;
            UpdateMode = false;
            DeleteMode = true;
            dgvArtworksOutNormal.ClearSelection();
            dgvArtworkOutAdvanced.ClearSelection();
            hideADD();
            showDELETE();
            hideUPDATE();
            clearsearchboxes();
        }
        // toggles update mode when the button is clicked
        private void btnUpdateMode_Click(object sender, EventArgs e)
        {
            btnAddMode.Enabled = true;
            btnDeleteMode.Enabled = true;
            btnUpdateMode.Enabled = false;
            AddMode = false;
            UpdateMode = true;
            DeleteMode = false;
            dgvArtworksOutNormal.ClearSelection();
            dgvArtworkOutAdvanced.ClearSelection();
            hideADD();
            hideDELETE();
            showUPDATE();
            clearsearchboxes();
        }
        // event to handle hiding the caret, and search by artwork price if the control is visible
        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {
            HideCaret(this.nudAmount.Controls[1].Handle);
            if (nudAmount.Visible == true)
            {
                int outcome = ArtworkDal.SearchByArtworkPriceAdvanced(nudAmount.Value, dgvArtworkOutAdvanced);
                refreshCountLabel();
                if (outcome == -10)
                {
                    lblNoResults.Visible = true;
                }
                else
                {
                    lblNoResults.Visible = false;
                }
            }
        }
        // handles key presses for the numeric up down to disable typing so the value
        // can only be changed using buttons
        private void nudAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        // methods to perform searches based off of the enabled search bar when its text is changed
        private void txtNormalID_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.CodeEntryCheck(txtNormalID, "A");
            if (txtNormalID.Visible == true)
            {
                int outcome = ArtworkDal.SearchByArtworkIDNormal(txtNormalID.Text.Trim(), dgvArtworksOutNormal);
                refreshCountLabel();
                if (outcome == -10)
                {
                    lblNoResults.Visible = true;
                }
                else
                {
                    lblNoResults.Visible = false;
                }
            }

        }
        private void txtAdvancedID_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.CodeEntryCheck(txtAdvancedID, "A");
            if (txtAdvancedID.Visible == true)
            {
                int outcome = ArtworkDal.SearchByArtworkIDAdvanced(txtAdvancedID.Text.Trim(), dgvArtworkOutAdvanced);
                refreshCountLabel();
                if (outcome == -10)
                {
                    lblNoResults.Visible = true;
                }
                else
                {
                    lblNoResults.Visible = false;
                }
            }
        }
        private void txtNormalName_TextChanged(object sender, EventArgs e)
        {
            if (txtNormalName.Visible == true)
            {
                int outcome = ArtworkDal.SearchByArtworkNameNormal(txtNormalName.Text.Trim(), dgvArtworksOutNormal);
                refreshCountLabel();
                if (outcome == -10)
                {
                    lblNoResults.Visible = true;
                }
                else
                {
                    lblNoResults.Visible = false;
                }
            }
        }
        private void txtAdvancedName_TextChanged(object sender, EventArgs e)
        {
            if (txtAdvancedName.Visible == true)
            {
                int outcome = ArtworkDal.SearchByArtworkNameAdvanced(txtAdvancedName.Text.Trim(), dgvArtworkOutAdvanced);
                refreshCountLabel();
                if (outcome == -10)
                {
                    lblNoResults.Visible = true;
                }
                else
                {
                    lblNoResults.Visible = false;
                }
            }
        }
        // method to clear searches
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            clearsearchboxes();
        }
        //Method that based off of the current mode, manages what happens to selected rows
        private void dgvArtwork_SelectionChanged(object sender, EventArgs e)
        {
            if (AddMode)
            {
                dgvArtworkOutAdvanced.ClearSelection();
                dgvArtworksOutNormal.ClearSelection();
            }
            else if (DeleteMode)
            {
                if (dgvArtworkOutAdvanced.Visible)
                {
                    if (dgvArtworkOutAdvanced.SelectedCells.Count != 0)
                    {
                        txtArtworkIDDelete.Text = dgvArtworkOutAdvanced.SelectedCells[0].Value.ToString().Trim();
                    }
                }
                else
                {
                    if (dgvArtworksOutNormal.SelectedCells.Count != 0)
                    {
                        txtArtworkIDDelete.Text = dgvArtworksOutNormal.SelectedCells[0].Value.ToString().Trim();
                    }

                }
            }
            else if (UpdateMode)
            {
                if (dgvArtworkOutAdvanced.SelectedCells.Count != 0)
                {
                    txtArtworkIDUpdate.Text = dgvArtworkOutAdvanced.SelectedCells[0].Value.ToString().Trim();
                    nudSalePriceUpdate.Value = Convert.ToDecimal(dgvArtworkOutAdvanced.SelectedCells[4].Value.ToString());
                    bool soldupdate = false;
                    string currentex = ArtworkDal.CurrentExhibition(dgvArtworkOutAdvanced.SelectedCells[0].Value.ToString());
                    if (currentex != null)
                    {
                        lblCurrentExhibition.Text = "Current Exhibition: " + currentex;
                    }
                    else
                    {
                        lblCurrentExhibition.Text = "Current Exhibition: Missing";
                    }
                    string[] AvailableEx = ArtworkDal.GetExhibitionOptions();
                    cbxExhibtionEdit.Items.Clear();
                    cbxExhibtionEdit.Items.AddRange(AvailableEx);
                    if (dgvArtworkOutAdvanced.SelectedCells[5].Value.ToString() == "True")
                    {
                        soldupdate = true;
                    }
                    if (soldupdate)
                    {
                        chbxSold.Checked = true;
                        chbxSold.Enabled = false;
                        nudSalePriceUpdate.Enabled = false;
                        cbxExhibtionEdit.Enabled = false;
                        btnUpdateArtwork.Enabled = false;
                        lblUpdateAllowed.Visible = true;
                    }
                    else
                    {
                        chbxSold.Checked = false;
                        chbxSold.Enabled = true;
                        nudSalePriceUpdate.Enabled = true;
                        cbxExhibtionEdit.Enabled = true;
                        lblUpdateAllowed.Visible = false;
                    }
                }
            }
        }
        // event to manage hiding the caret and enabling the add button.
        private void numericUpDownAddPrice_ValueChanged(object sender, EventArgs e)
        {
            HideCaret(this.nudAddPrice.Controls[1].Handle);
            if (nudAddPrice.Value > 0.00m)
            {
                btnAddArtwork.Enabled = true;
            }
            else
            {
                btnAddArtwork.Enabled = false;
            }
        }
        // based off of the text will validate the ID and make other options available as a result.
        private void txtGuestID_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.CodeEntryCheck(txtGuestID, "G");
            string[] person = GuestDal.CheckForID(txtGuestID.Text);
            if (person[0] != null)
            {
                lblnocourses.Visible = false;
                string[] options = GuestDal.GetCourseOptions(txtGuestID.Text.Trim());
                if (options.Count() == 0)
                {
                    cbxCourseIDAdd.DataSource = null;
                    cbxCourseIDAdd.Enabled = false;
                    lblnocourses.Visible = true;
                    btnAddArtwork.Enabled = false;
                    NoCourses = true;
                }
                else
                {
                    cbxCourseIDAdd.Enabled = true;
                    cbxCourseIDAdd.DataSource = options;
                    lblnocourses.Visible = false;
                    btnAddArtwork.Enabled = true;
                    NoCourses = false;
                }
                if (person[3].Trim() == "Advanced")
                {
                    advancedMode = true;
                    dgvArtworkOutAdvanced.Visible = true;
                    dgvArtworksOutNormal.Visible = false;
                    lblAdvancedArtwork.Visible = true;
                    lblAllArtworks.Visible = false;
                    cbxSearchby.Items.Clear();
                    //clearsearchboxes();
                    hideAllTextBoxes();
                    if (cbxSearchby.Text != "")
                    {
                        lblsearchtext.Visible = true;
                    }
                    else
                    {
                        lblsearchtext.Visible = false;
                    }
                    cbxSearchby.Items.AddRange(new String[3] { "Artwork ID", "Name", "Sale Price" });
                    refreshCountLabel();
                    refreshAdvanced();

                    if (!NoCourses)
                    {
                        nudAddPrice.Visible = true;
                        lblSalePriceAdd.Visible = true;
                        btnAddArtwork.Enabled = false;
                    }

                }
                else
                {
                    advancedMode = false;
                    dgvArtworksOutNormal.Visible = true;
                    dgvArtworkOutAdvanced.Visible = false;
                    lblAdvancedArtwork.Visible = false;
                    lblAllArtworks.Visible = true;
                    cbxSearchby.Items.Clear();
                    //clearsearchboxes();
                    hideAllTextBoxes();
                    if (cbxSearchby.Text != "")
                    {
                        lblsearchtext.Visible = true;
                    }
                    else
                    {
                        lblsearchtext.Visible = false;
                    }
                    cbxSearchby.Items.AddRange(new String[2] { "Artwork ID", "Name" });
                    refreshCountLabel();
                    refreshNormal();
                    nudAddPrice.Visible = false;
                    if (!NoCourses)
                    {
                        btnAddArtwork.Enabled = true;
                    }
                    else
                    {
                        btnAddArtwork.Enabled = false;
                    }
                }

                lblFore.Text = "Forename: " + person[1];
                lblFore.Visible = true;
                lblSur.Text = "Surname: " + person[2];
                lblSur.Visible = true;
            }
            else
            {
                cbxCourseIDAdd.DataSource = null;
                lblSalePriceAdd.Visible = false;
                nudAddPrice.Visible = false;
                lblnocourses.Visible = false;
                lblFore.Visible = false;
                lblSur.Visible = false;
                btnAddArtwork.Enabled = false;
                if (dgvArtworkOutAdvanced.Visible)
                {
                    if (advancedMode)
                    {
                        advancedMode = true;
                        dgvArtworkOutAdvanced.Visible = true;
                        dgvArtworksOutNormal.Visible = false;
                        lblAdvancedArtwork.Visible = true;
                        lblAllArtworks.Visible = false;
                        //cbxSearchby.Items.Clear();
                        //clearsearchboxes();
                        //hideAllTextBoxes();
                        if (cbxSearchby.Text != "")
                        {
                            lblsearchtext.Visible = true;
                        }
                        else
                        {
                            lblsearchtext.Visible = false;
                        }
                        refreshCountLabel();
                        refreshAdvanced();
                    }
                    else
                    {
                        advancedMode = true;
                        dgvArtworkOutAdvanced.Visible = true;
                        dgvArtworksOutNormal.Visible = false;
                        lblAdvancedArtwork.Visible = true;
                        lblAllArtworks.Visible = false;
                        cbxSearchby.Items.Clear();
                        clearsearchboxes();
                        hideAllTextBoxes();
                        if (cbxSearchby.Text != "")
                        {
                            lblsearchtext.Visible = true;
                        }
                        else
                        {
                            lblsearchtext.Visible = false;
                        }
                        cbxSearchby.Items.AddRange(new String[3] { "Artwork ID", "Name", "Sale Price" });
                        refreshCountLabel();
                        refreshAdvanced();
                    }
                }
                else
                {
                    if (advancedMode)
                    {
                        advancedMode = false;
                        dgvArtworksOutNormal.Visible = true;
                        dgvArtworkOutAdvanced.Visible = false;
                        lblAdvancedArtwork.Visible = false;
                        lblAllArtworks.Visible = true;
                        cbxSearchby.Items.Clear();
                        clearsearchboxes();
                        hideAllTextBoxes();
                        if (cbxSearchby.Text != "")
                        {
                            lblsearchtext.Visible = true;
                        }
                        else
                        {
                            lblsearchtext.Visible = false;
                        }
                        cbxSearchby.Items.AddRange(new String[2] { "Artwork ID", "Name" });
                        refreshCountLabel();
                        refreshNormal();
                    }
                    else
                    {
                        advancedMode = false;
                        dgvArtworksOutNormal.Visible = true;
                        dgvArtworkOutAdvanced.Visible = false;
                        lblAdvancedArtwork.Visible = false;
                        lblAllArtworks.Visible = true;
                        //cbxSearchby.Items.Clear();
                        //clearsearchboxes();
                        //hideAllTextBoxes();
                        if (cbxSearchby.Text != "")
                        {
                            lblsearchtext.Visible = true;
                        }
                        else
                        {
                            lblsearchtext.Visible = false;
                        }
                        refreshCountLabel();
                        refreshNormal();
                    }

                }
            }
        }
        // gets confirmation from the user and then performs the add.
        private void btnAddArtwork_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Do you want to create a new artwork for " + lblFore.Text.Trim().Substring(9) + " " + lblSur.Text.Trim().Substring(8) + "?", "Are you Sure?", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                int outcome;
                if (nudAddPrice.Visible)
                {
                    outcome = ArtworkDal.AddArtwork(txtGuestID.Text.Trim(), nudAddPrice.Value);
                    refreshAdvanced();
                    showADD();
                }
                else
                {
                    outcome = ArtworkDal.AddArtwork(txtGuestID.Text.Trim());
                    refreshNormal();
                    showADD();
                }
                if (outcome <= 0)
                {
                    MessageBox.Show("Something went wrong, artwork could not be created. Please try again.", "Failed");
                }
                else
                {
                    MessageBox.Show("Artwork Succesfully created.", "Success");
                }
            }
            else
            {
                showADD();
            }
        }
        // validates the ID and depending on the results enables or diables the delete button
        private void txtArtworkIDDelete_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.CodeEntryCheck(txtArtworkIDDelete, "A");
            bool found = ArtworkDal.CheckForID(txtArtworkIDDelete.Text.Trim());
            if (found)
            {
                btnDeleteArtwork.Enabled = true;
            }
            else
            {
                //MessageBox.Show("Artwork could not be found, please try a different ID.");
                btnDeleteArtwork.Enabled = false;
            }
        }
        // validates the artwork hasnt sold or been asigned to a past exhibition
        // and request confimation for delete.
        private void btnDeleteArtwork_Click(object sender, EventArgs e)
        {
            string[] ArtEx = ArtworkDal.CheckForPastExhibition(txtArtworkIDDelete.Text.Trim());
            if (ArtEx[0] != null && ArtEx[1] != null)
            {
                //MessageBox.Show(ArtEx[1].Substring(6, 4) + "\n" + ArtEx[1].Substring(3, 2) + "\n" + ArtEx[1].Substring(0, 2));
                DateTime exDate = new DateTime(Convert.ToInt32(ArtEx[1].Substring(6, 4)), Convert.ToInt32(ArtEx[1].Substring(3, 2)), Convert.ToInt32(ArtEx[1].Substring(0, 2)));
                if (exDate <= DateTime.Now.Date)
                {
                    MessageBox.Show("The artwork selected for deletion has already been \ninvolved in a past exhibition. These cannot be removed from the system.", "Artwork found in past Exhibition");
                }
                else
                {
                    DialogResult outcome = MessageBox.Show("This artwork is assigned to an exhibition in the future. Are you sure you want to delete it?", "Are You Sure?", MessageBoxButtons.YesNo);
                    if (outcome == DialogResult.Yes)
                    {
                        int result = ArtworkDal.DeleteArtwork(txtArtworkIDDelete.Text.Trim());
                        if (result >= 1)
                        {
                            MessageBox.Show("Artwork successfully deleted", "Success");
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong, the artwork could not be deleted.", "Failed");
                        }
                        refreshAdvanced();
                        refreshNormal();
                        refreshCountLabel();
                        txtArtworkIDDelete.Text = string.Empty;
                    }
                }

            }
            else
            {
                DialogResult outcome = MessageBox.Show("Are you sure you want to permanently delete this artwork?", "Are You Sure?", MessageBoxButtons.YesNo);
                if (outcome == DialogResult.Yes)
                {
                    int result = ArtworkDal.DeleteArtwork(txtArtworkIDDelete.Text.Trim());
                    if (result >= 1)
                    {
                        MessageBox.Show("Artwork successfully deleted", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong, the artwork could not be deleted.", "Failed");
                    }
                    refreshAdvanced();
                    refreshNormal();
                    refreshCountLabel();
                    txtArtworkIDDelete.Text = string.Empty;
                }

            }
        }
        // manages hiding the cared on the sale price numeric up down
        private void nudSalePriceUpdate_ValueChanged(object sender, EventArgs e)
        {
            HideCaret(this.nudSalePriceUpdate.Controls[1].Handle);
        }
        // enables the update button if the id field is not empty
        private void txtArtworkIDUpdate_TextChanged(object sender, EventArgs e)
        {
            if (txtArtworkIDUpdate.Text != string.Empty)
            {
                btnUpdateArtwork.Enabled = true;
            }
            else
            {
                btnUpdateArtwork.Enabled = false;
            }
        }
        // validates update data, and attepts to update.
        private void btnUpdateArtwork_Click(object sender, EventArgs e)
        {
            if (nudSalePriceUpdate.Value <= 0)
            {
                MessageBox.Show("Sale price must be greater than £0.00.", "Invalid Price");
            }
            else
            {
                bool sold = false;
                if (chbxSold.Checked)
                {
                    sold = true;
                }
                int outcome = ArtworkDal.UpdateArtwork(txtArtworkIDUpdate.Text.Trim(), nudSalePriceUpdate.Value, sold);
                if (outcome < 2)
                {
                    MessageBox.Show("Something went wrong, artwork may not have fully updated. " +
                        "\nPlease check the update was successful or try again.", "Failed");
                }
                else
                {
                    MessageBox.Show("Artwork Update was successful.", "Success");
                }
                if (cbxExhibtionEdit.Text.Trim() != "")
                {
                    int exoutcome = ArtworkDal.UpdateArtworkExhibition(txtArtworkIDUpdate.Text.Trim(), cbxExhibtionEdit.Text.Trim());
                    if (exoutcome < 1)
                    {
                        MessageBox.Show("Something went wrong, artwork Exhibition may not have fully updated." +
                            " \nPlease check the update was successful or try again.", "Failed");
                    }
                    else
                    {
                        //MessageBox.Show("Artwork Exhibition Update was successful.", "Success");
                    }
                }

                refreshAdvanced();
                refreshCountLabel();
            }
        }

        // nebu strip events.
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

        private void exhibitionManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonMethods.ExhibitionManagerOpen(this);
        }

        private void mainMenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonMethods.MainMenuOpen(this);
        }
    }
}
