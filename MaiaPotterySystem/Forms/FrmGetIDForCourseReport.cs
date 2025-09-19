using Microsoft.Reporting.WinForms;
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
    public partial class FrmGetIDForCourseReport : Form
    {
        public FrmGetIDForCourseReport()
        {
            InitializeComponent();
            CenterToScreen();
            CommonMethods.lockform(this);
            txtCourseID.Text = "C";
        }
        // if the ID is valid enable the button
        private void txtCourseID_TextChanged(object sender, EventArgs e)
        {
            CommonMethods.CodeEntryCheck(txtCourseID, "C");
            string Course = CourseDal.CheckForID(txtCourseID.Text);
            if (Course != null)
            {
                btnCourseReport.Enabled = true;
            }
            else
            {
                btnCourseReport.Enabled = false;
            }
        }
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCourseMainMenu().Show();
        }
        private void btnCourseReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmEnrolmentReport(txtCourseID.Text.Trim()).Show();
        }
    }
}
