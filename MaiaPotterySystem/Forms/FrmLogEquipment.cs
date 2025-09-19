using PotteryDBA_V1._0.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotteryDBA_V1._0.Forms
{
    public partial class FrmLogEquipment : Form
    {
        // import method to handle hiding the caret in the numeric up downs
        [DllImport("user32")]
        private static extern bool HideCaret(IntPtr hWnd);
        // clay in lb, glaze in pints, paint in oz.
        // centers form, disables minimise and hides some controls
        public FrmLogEquipment()
        {
            InitializeComponent();
            CenterToScreen();
            CommonMethods.lockform(this);
            txtGuestID.Text = "G";
            txtGuestID.Select(txtGuestID.Text.Length, 0);
            HideallBoxes();
            nudAmount.ReadOnly = true;
            nudAmount.BackColor = SystemColors.Window;
        }
        // method to hide all controls bar the ID
        public void HideallBoxes()
        {
            lblFore.Visible = false; lblSur.Visible = false;
            lblItemName.Visible = false;
            lblItemType.Visible = false;

            cbxItemType.Visible = false;
            cbxClayItemName.Visible = false;
            cbxGlazeItemName.Visible = false;
            cbxPaintItemName.Visible = false;

            cbxItemType.Text = null;
            cbxClayItemName.Text = null;
            cbxGlazeItemName.Text = null;
            cbxPaintItemName.Text = null;

            lblAmount.Visible = false;
            lblInOunces.Visible = false;
            lblInPints.Visible = false;
            lblInPounds.Visible = false;

            nudAmount.Visible = false;
        }
        // menu strip events
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
        // if the id changes, validate it and show the name on the form.
        // then enables next step of process
        private void txtGuestID_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.CodeEntryCheck(txtGuestID, "G");
            string[] person = GuestDal.CheckForID(txtGuestID.Text);
            if (person[0] != null)
            {
                string[] options = GuestDal.GetCourseOptions(txtGuestID.Text.Trim());
                if (options.Length == 0)
                {
                    cbxCourseOptions.DataSource = null;
                }
                else
                {
                    cbxCourseOptions.DataSource = options;
                }
                cbxItemType.Text = null;
                cbxClayItemName.Text = null;
                cbxGlazeItemName.Text = null;
                cbxPaintItemName.Text = null;
                lblFore.Text = "Forename: " + person[1];
                lblFore.Visible = true;
                lblSur.Text = "Surname: " + person[2];
                lblSur.Visible = true;
                lblItemType.Visible = true;
                cbxItemType.Visible = true;

            }
            else
            {
                HideallBoxes();
                cbxCourseOptions.DataSource = null;
            }
        }
        // when the item type is changed show the appropriate box and amount numeric up down
        private void cbxItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbxItemType.SelectedIndex)
            {
                case 0:
                    lblItemName.Visible = true;
                    cbxClayItemName.Visible = true;
                    cbxClayItemName.Text = "";
                    lblInPounds.Visible = true;
                    lblInPints.Visible = false;
                    lblInOunces.Visible = false;
                    cbxGlazeItemName.Visible = false;
                    cbxPaintItemName.Visible = false;
                    lblAmount.Visible = true;
                    nudAmount.Visible = true;
                    nudAmount.Value = 0.00M;
                    break;
                case 1:
                    lblItemName.Visible = true;
                    cbxClayItemName.Visible = false;
                    cbxGlazeItemName.Visible = true;
                    lblInPounds.Visible = false;
                    lblInPints.Visible = true;
                    lblInOunces.Visible = false;
                    cbxGlazeItemName.Text = "";
                    cbxPaintItemName.Visible = false;
                    lblAmount.Visible = true;
                    nudAmount.Visible = true;
                    nudAmount.Value = 0.00M;
                    break;
                case 2:
                    lblItemName.Visible = true;
                    cbxClayItemName.Visible = false;
                    cbxGlazeItemName.Visible = false;
                    cbxPaintItemName.Visible = true;
                    lblInPounds.Visible = false;
                    lblInPints.Visible = false;
                    lblInOunces.Visible = true;
                    cbxPaintItemName.Text = "";
                    lblAmount.Visible = true;
                    nudAmount.Visible = true;
                    nudAmount.Value = 0.00M;
                    break;
                default:
                    lblAmount.Visible = false;
                    lblItemName.Visible = false;
                    cbxClayItemName.Visible = false;
                    cbxGlazeItemName.Visible = false;
                    cbxPaintItemName.Visible = false;
                    lblInPounds.Visible = false;
                    lblInPints.Visible = false;
                    lblInOunces.Visible = false;
                    nudAmount.Visible = false;
                    nudAmount.Value = 0.00M;
                    break;
            }
        }
        // when value changed hide the caret
        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {
            HideCaret(this.nudAmount.Controls[1].Handle);
        }
        // ensure you cannot type in numeric up down
        private void myCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        // when button clicked, log equipment. error messages are explanetory to each section
        private void btnLogEquipment_Click(object sender, EventArgs e)
        {
            if(cbxCourseOptions.Text != "" && cbxItemType.Text != "")
            {
                if (cbxItemType.SelectedIndex == 0)
                {
                    if (cbxClayItemName.Text != "")
                    {
                        if (nudAmount.Value > 0)
                        {
                            string[] ItemDetails = ItemDal.GetIDandCost("Clay", cbxClayItemName.Text.Trim());
                            if (ItemDetails != null)
                            {
                                string ItemID = ItemDetails[0];
                                string GuestID = txtGuestID.Text.Trim();
                                string CourseID = cbxCourseOptions.Text.Trim();
                                decimal amount = nudAmount.Value;
                                int affected = ItemDal.LogEquipmentUse(GuestID, CourseID, ItemID, amount);
                                if (affected > 0)
                                {
                                    MessageBox.Show("Guest has been billed for items used.", "Success");
                                }
                                else
                                {
                                    MessageBox.Show("ERROR");
                                }
                            }
                            else
                            {
                                MessageBox.Show("A problem occured fetching item details.", "Failed");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please ensure to select an amount of clay used.", "No Amount Provided");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please ensure to select a Clay type.", "No Item Selected");
                    }
                }
                else if (cbxItemType.SelectedIndex == 1)
                {
                    if (cbxGlazeItemName.Text != "")
                    {
                        if (nudAmount.Value > 0)
                        {
                            string[] ItemDetails = ItemDal.GetIDandCost("Glaze", cbxGlazeItemName.Text.Trim());
                            if (ItemDetails != null)
                            {
                                string ItemID = ItemDetails[0];
                                string GuestID = txtGuestID.Text.Trim();
                                string CourseID = cbxCourseOptions.Text.Trim();
                                decimal amount = nudAmount.Value;
                                int affected = ItemDal.LogEquipmentUse(GuestID, CourseID, ItemID, amount);
                                if (affected > 0)
                                {
                                    MessageBox.Show("Guest has been billed for items used.", "Success");
                                }
                                else
                                {
                                    MessageBox.Show("ERROR");
                                }
                            }
                            else
                            {
                                MessageBox.Show("A problem occured fetching item details.","Failed");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please ensure to select an amount of glaze used.", "No Amount Provided");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please ensure to select a Glaze type.", "No Item Selected");
                    }
                }
                else if (cbxItemType.SelectedIndex == 2)
                {
                    if (cbxPaintItemName.Text != "")
                    {
                        if (nudAmount.Value > 0)
                        {
                            string[] ItemDetails = ItemDal.GetIDandCost("Paint", cbxPaintItemName.Text.Trim());
                            if (ItemDetails != null)
                            {
                                string ItemID = ItemDetails[0];
                                string GuestID = txtGuestID.Text.Trim();
                                string CourseID = cbxCourseOptions.Text.Trim();
                                decimal amount = nudAmount.Value;
                                int affected = ItemDal.LogEquipmentUse(GuestID, CourseID, ItemID, amount);
                                if (affected > 0)
                                {
                                    MessageBox.Show("Guest has been billed for items used.", "Success");
                                }
                                else
                                {
                                    MessageBox.Show("ERROR");
                                }
                            }
                            else
                            {
                                MessageBox.Show("A problem occured fetching item details.", "Failed");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please ensure to select an amount of paint used.", "No Amount Provided");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please ensure to select a Paint type.", "No Item Selected");
                    }
                }
                else
                {
                    MessageBox.Show("Please select an Item to log.", "No Item Selected");
                }
            }
            else
            {
                MessageBox.Show("Please ensure information has been entered into all fields before trying to log details", "Empty Fields Detected");
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
