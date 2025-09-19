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
    public partial class FrmCourseMainMenu : Form
    {
        public FrmCourseMainMenu()
        {
            InitializeComponent();
            CenterToScreen();
            CommonMethods.lockform(this);
        }
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
        // ensures a booking cannot be placed during the calendar setting time for the business
        private void btnCourseManagement_Click(object sender, EventArgs e)
        {
            DateTime max = new DateTime(DateTime.Now.Year, 12, 20);
            DateTime min = new DateTime(DateTime.Now.Year, 1, 20);
            if (DateTime.Today > min && DateTime.Today < max)
            {
                this.Hide();
                new FrmMakeBooking().Show();
            }
            else
            {
                MessageBox.Show("Bookings cannot be placed between December 20th and January 20th \nof the following year, due to scheduling of the calander for the year.", "Unable to Place Bookings at this time.");
            }

        }
        private void btnGuestManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCourseManager().Show();
        }
        private void btnCourseReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmGetIDForCourseReport().Show();
        }
    }
}
