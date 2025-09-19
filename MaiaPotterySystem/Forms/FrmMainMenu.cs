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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            // centers form to screen and disables maximise and minimise
            InitializeComponent();
            CenterToScreen();
            CommonMethods.lockform(this);
        }

        // opens maintainance on undeveloped options, method to avoid repetition.
        private void showMaintainaceForm()
        {
            new FrmMaintainance().Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // confirmation message box, if yes the application will quit
            CommonMethods.QuitApplication(this);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // returns to login form
            CommonMethods.LogOut(this);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // opens the help 
            CommonMethods.HelpPDF(this);
        }

        // all these buttons use the one method from above
        private void btnPodBooking_Click(object sender, EventArgs e)
        {
            showMaintainaceForm();
        }

        private void btnYoga_Click(object sender, EventArgs e)
        {
            showMaintainaceForm();
        }

        private void btnPainting_Click(object sender, EventArgs e)
        {
            showMaintainaceForm();
        }

        private void btnWorkshops_Click(object sender, EventArgs e)
        {
            showMaintainaceForm();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            showMaintainaceForm();
        }

        // closes the current form and opens the next menu.
        private void btnPottery_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPotteryMainMenu().Show();
        }
    }
}
