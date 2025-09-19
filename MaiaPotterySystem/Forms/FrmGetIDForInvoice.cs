using PotteryDBA_V1._0.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotteryDBA_V1._0.Forms
{
    public partial class FrmGetIDForInvoice : Form
    {
        // trakcs if the guest doesnt have existing bookings
        bool NoCourses = true;
        public FrmGetIDForInvoice()
        {
            InitializeComponent();
            CenterToScreen();
            CommonMethods.lockform(this);
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmGuestMenu().Show();
        }

        // checks if the ID is valid and displays courses if it is. if they have no courses, the label will be visible.
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
                    cbxCourseID.DataSource = null;
                    cbxCourseID.Enabled = false;
                    lblnocourses.Visible = true;
                    btnCourseReport.Enabled = false;
                    NoCourses = true;
                }
                else
                {
                    cbxCourseID.Enabled = true;
                    cbxCourseID.DataSource = options;
                    lblnocourses.Visible = false;
                    btnCourseReport.Enabled = true;
                    NoCourses = false;
                }
            }
            else
            {
                cbxCourseID.DataSource = null;
                lblnocourses.Visible = false;
                cbxCourseID.Enabled = false;
                btnCourseReport.Enabled = false;
            }
        }

        private void FrmGetIDForInvoice_Load(object sender, EventArgs e)
        {
            lblnocourses.Visible = false;
            txtGuestID.Text = "G";
        }

        private void btnCourseReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmInvoiceViewer(txtGuestID.Text.Trim(), cbxCourseID.Text.Trim()).Show();
        }
    }
}
