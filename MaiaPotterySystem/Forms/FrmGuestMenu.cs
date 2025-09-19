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
    public partial class FrmGuestMenu : Form
    {
        public FrmGuestMenu()
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
        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmAddGuest().Show();
        }
        private void btnLogEquipment_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmLogEquipment().Show();
        }

        private void btnGuestInvoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmGetIDForInvoice().Show();
        }
    }
}
