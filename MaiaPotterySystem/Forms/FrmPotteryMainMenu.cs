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
    public partial class FrmPotteryMainMenu : Form
    {
        public FrmPotteryMainMenu()
        {
            // centers form and disables minimise and maximise buttons
            InitializeComponent();
            CenterToScreen();
            CommonMethods.lockform(this);
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // closes current form and returns to main menu by opening new form.
            this.Hide();
            new FrmMainMenu().Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // uses logout method to return to login form
            CommonMethods.LogOut(this);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // uses exit method to confirm choice and then close application
            CommonMethods.QuitApplication(this);
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonMethods.HelpPDF(this);
        }

        private void btnGuestManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmGuestMenu().Show();
        }

        private void btnCourseManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCourseMainMenu().Show();
        }

        private void btnExhibitionManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmExhibitionViewer().Show();
        }

        private void btnArtworkManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmArtworkViewer().Show();
        }
    }
}
