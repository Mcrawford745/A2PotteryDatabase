using PotteryDBA_V1._0.Methods;
using PotteryDBA_V1._0.Properties;
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
    public partial class FrmLogin : Form
    {
        public bool passvisible = false;
        public FrmLogin()
        {
            // centres to screen, lock the maximise and minimise button,
            // and ensures the password visibility is initially off.
            InitializeComponent();
            CenterToScreen();
            CommonMethods.lockform(this);
            picton.Visible = false;
            pictoff.Visible = true;
            txtPassword.UseSystemPasswordChar = true;
        }

        // visibility button event
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // when either visibility image is clicked, check
            // current state and flip every setting to the other.
            if (passvisible == false) 
            {
                passvisible = true;
                picton.Visible=true;
                pictoff.Visible = false;
                txtPassword.UseSystemPasswordChar = false;
            }
            else if (passvisible == true)
            {
                passvisible = false;
                picton.Visible=false;
                pictoff.Visible=true;
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // uses exit method from common method class to close application
            CommonMethods.QuitApplication(this);
        }

        private void lOGINDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // opens a message box with the login details for the application. 
            MessageBox.Show("Username: LakesideEscapes\nPassword: Passw0rd", "Login Details");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // checks the user has entered the right details and opens the first menu if they have.
            if(txtPassword.Text == "Passw0rd" && txtUsername.Text == "LakesideEscapes")
            {
                this.Hide();
                new FrmMainMenu().Show();
            }
            else
            {
                // error message telling user where to get login details from
                MessageBox.Show("Please ensure login is correct. Details can be found in Options.", "Incorrect Username or Password");
            }
        }
    }
}
