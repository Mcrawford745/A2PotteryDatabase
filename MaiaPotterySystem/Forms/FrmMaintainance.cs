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
    public partial class FrmMaintainance : Form
    {
        public FrmMaintainance()
        {
            // centers form and locks minimise and maximise buttons
            InitializeComponent();
            CenterToScreen();
            CommonMethods.lockform(this);
        }

        private void btnMainMenuHelpDone_Click(object sender, EventArgs e)
        {
            // when clicked, closes the current form and opens the main menu again.
            this.Hide();
            new FrmMainMenu().Show();
        }
    }
}
