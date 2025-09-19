using Microsoft.Reporting.Map.WebForms.BingMaps;
using PotteryDBA_V1._0.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PotteryDBA_V1._0.Methods
{
    // class of commonly used methods in my program to reduce repitition
    static internal class CommonMethods
    {

        // returns to the login form
        static public void LogOut(Form frm)
        {
            frm.Hide();
            new FrmLogin().Show();
        }
        // disables the maximise and minimise buttons
        static public void lockform(Form frm)
        {
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
        }

        // shows a confirmation message box and then if yes, closes the program
        static public void QuitApplication(Form frm)
        {
            DialogResult quit = MessageBox.Show("Are you sure you want to close the program?", "Are you sure?", MessageBoxButtons.YesNo);
            if (quit == DialogResult.Yes)
            {
                frm.Close();
            }
        }

        //methods for opening different forms from the menu strip
        //MAIN MENU
        static public void MainMenuOpen(Form frm)
        {
            frm.Hide();
            new FrmMainMenu().Show();
        }
        //GUEST FORMS
        static public void GuestManagementOpen(Form frm)
        {
            frm.Hide();
            new FrmGuestMenu().Show();
        }
        static public void GuestManagerOpen(Form Frm)
        {
            Frm.Hide();
            new FrmAddGuest().Show();
        }

        static public void LogEquipmentOpen(Form frm)
        {
            frm.Hide();
            new FrmLogEquipment().Show();
        }

        static public void GuestInvoiceOpen(Form frm)
        {
            frm.Hide();
            new FrmGetIDForInvoice().Show();
        }

        //COURSE FORMS
        static public void CourseMenuOpen(Form frm)
        {
            frm.Hide();
            new FrmCourseMainMenu().Show();
        }
        static public void CourseManagerOpen(Form frm)
        {
            frm.Hide();
            new FrmCourseManager().Show();
        }

        static public void MakeABookingOpen(Form frm)
        {
            DateTime max = new DateTime(DateTime.Now.Year, 12, 20);
            DateTime min = new DateTime(DateTime.Now.Year, 1, 20);
            if (DateTime.Today > min && DateTime.Today < max)
            {
                frm.Hide();
                new FrmMakeBooking().Show();
            }
            else
            {
                MessageBox.Show("Bookings cannot be placed between December 20th and January 20th \nof the following year, due to scheduling of the calander for the year.", "Unable to Place Bookings at this time.");
            }
        }
        static public void GetCourseReportOpen(Form frm)
        {
            frm.Hide();
            new FrmGetIDForCourseReport().Show(); 
        }
        //ARTWORK FORMS
        static public void ArtworkManagerOpen(Form frm)
        {
            frm.Hide();
            new FrmArtworkViewer().Show();
        }

        //EXHIBITION FORMS
        static public void ExhibitionManagerOpen(Form frm)
        {
            frm.Hide();
            new FrmExhibitionViewer().Show();
        }
        // placeholder for unfinished buttons
        static public void PlaceholderBox()
        {
            MessageBox.Show("placeholder", "PLACEHOLDER");
        }
        // code entry check normal
        static public void CodeEntryCheck(TextBox textbox, string type)
        {
            // event to ensure there is always a letter for the code
            // in the text box and only numbers can be entered into it.
            string text = textbox.Text;
            if (text == "")
            {
                textbox.Text = type;
                textbox.Select(textbox.Text.Length, 0);
            }
            else if (text[0] != Convert.ToChar(type))
            {
                textbox.Text = type;
                textbox.Select(textbox.Text.Length, 0);

            }
            for (int i = 1; i < textbox.Text.Length; i++)
            {
                if (text[i] == Convert.ToChar(" "))
                {
                    textbox.Text = textbox.Text.Replace(" ", "");
                    textbox.Select(textbox.Text.Length, 0);
                    break;
                }
                else if (char.IsNumber(text[i]) == false)
                {
                    textbox.Text = textbox.Text.Replace(Convert.ToString(text[i]), "");
                    textbox.Select(textbox.Text.Length, 0);
                }
            }
        }
        // code entry override for excluded characters
        static public void CodeEntryCheck(TextBox textbox, string type, List<char> Exclusions)
        {
            // override method for if code entry needs punctuation, such as price
            string text = textbox.Text;
            if (text == "")
            {
                textbox.Text = type;
                textbox.Select(textbox.Text.Length, 0);
            }
            else if (text[0] != Convert.ToChar(type))
            {
                textbox.Text = type;
                textbox.Select(textbox.Text.Length, 0);

            }
            for (int i = 1; i < textbox.Text.Length; i++)
            {
                if (text[i] == Convert.ToChar(" "))
                {
                    textbox.Text = textbox.Text.Replace(" ", "");
                    textbox.Select(textbox.Text.Length, 0);
                    break;
                }
                else if (char.IsNumber(text[i]) == false)
                {
                    bool foundchar = false;
                    foreach(char j in Exclusions)
                    {
                        if (Convert.ToChar(text[i]) == Exclusions[j]) 
                        {
                            foundchar = true;
                        }
                    }
                    if (!foundchar) 
                    {
                        textbox.Text = textbox.Text.Replace(Convert.ToString(text[i]), "");
                        textbox.Select(textbox.Text.Length, 0);
                    }
                }
            }
        }
        // code entry override check of string not char
        static public void CodeEntryCheck(TextBox textbox, string type, int codelength)
        {
            // override if code char is more than one letter
            string text = textbox.Text;
            if (text == "")
            {
                textbox.Text = type;
                textbox.Select(textbox.Text.Length, 0);
            }
            else if(text.Length < codelength)
            {
                while (textbox.Text.Length < codelength)
                {
                    textbox.Text += "-";
                }
                textbox.Text = type;
                textbox.Select(textbox.Text.Length, 0);
            }
            for (int i = codelength; i < textbox.Text.Length; i++)
            {
                if (text[i] == Convert.ToChar(" "))
                {
                    textbox.Text = textbox.Text.Replace(" ", "");
                    textbox.Select(textbox.Text.Length, 0);
                    break;
                }
                else if (char.IsNumber(text[i]) == false)
                {
                    textbox.Text = textbox.Text.Replace(Convert.ToString(text[i]), "");
                    textbox.Select(textbox.Text.Length, 0);
                }
            }
        }

        // help pdf opener
        public static void HelpPDF(Form frm)
        {
            //Convert The resource Data into Byte[]
            byte[] PDF = Properties.Resources.Help;
            MemoryStream ms = new MemoryStream(PDF);
            //Create PDF File From Binary of resources folders help.pdf

            FileStream f = new FileStream("help.pdf", FileMode.OpenOrCreate);
            //Write Bytes into the Created help.pdf

            ms.WriteTo(f);

            f.Close();

            ms.Close();

            // Finally Show the Created PDF from resources
            Process.Start("help.pdf");
        }
    }
}
