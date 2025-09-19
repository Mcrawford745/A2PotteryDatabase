using Microsoft.Reporting.WinForms;
using PotteryDBA_V1._0.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotteryDBA_V1._0.Forms
{
    public partial class FrmInvoiceViewer : Form
    {
        // initialises all the guest details that will be passes as variables into the report
        string GuestID = "Placeholder";
        string GuestForename = "Placeholder";
        string GuestSurname = "Placeholder";
        string AddressLine1 = "PlaceholderPlaceholderPlaceholder";
        string AddressLine2 = "PlaceholderPlaceholderPlaceholder";
        string AddressLine3 = "PlaceholderPlaceholderPlaceholder";
        string CourseID = "Placeholder";
        string DateBooked = "11/11/1111";
        string TimeBooked = "11:11";
        string CourseCost = "£00.00";
        string CourseType = "Placeholder";
        DataTable ds = new DataTable();
        bool usedequipment = false;
        bool recentsold = false;
        decimal EquipAndCostTotal = 0;
        decimal SoldArtworkTotal = 0;

        // performs queries to gather all the data required using the IDs passed into the form
        public FrmInvoiceViewer(string _GuestID, string _CourseID)
        {
            InitializeComponent();
            CommonMethods.lockform(this);
            CenterToScreen();
            ds.Columns.Add("ItemName");
            ds.Columns.Add("AmountUsed");
            ds.Columns.Add("Column1");
            GuestID = _GuestID;
            CourseID = _CourseID;
            GetDataSet();
            string[] details = GuestDal.getGuestInvoicePersonalDetails(GuestID,CourseID);
            GuestForename= details[0].Trim();
            GuestSurname= details[1].Trim();
            string[] AddressFull = details[2].Split(',');
            AddressLine1 = AddressFull[0].Trim();
            AddressLine2 = AddressFull[1].Trim();
            AddressLine3 = AddressFull[2].Trim();
            DateBooked = details[3].Substring(0, 10);
            TimeBooked = details[4].Substring(0, 5);
            string[] coursedetails = CourseDal.GetCourseBaseInfo(CourseID);
            CourseCost = "£" + coursedetails[0].Trim();
            CourseType = "Type: " + coursedetails[1].Trim() + " Course";
        }

        // gets the dataset information about recently sold artworks, and whether they are deductable
        public DataSet RecentlySold()
        {
            // checks if the user is advanced
            bool isAdvanced = GuestDal.IsGuestAdvanced(GuestID);
            List<string> details = new List<string>();
            DataSet _ds= new DataSet();
            if (isAdvanced)
            {
                DataTable artworkdetails = new DataTable();
                artworkdetails.Clear();
                // collects all sold artworks for the artist
                artworkdetails = ExhibitionDal.getSoldArtworkDetails(GuestID);
                _ds.Tables.Clear();
                //clones rows from the table so they can be used
                if(artworkdetails.Rows.Count > 0) 
                {
                    _ds.Tables.Add(artworkdetails.Clone());
                    int length = artworkdetails.Rows.Count;

                    for (int i = 0; i < length; i++)
                    {
                        _ds.Tables[0].ImportRow(artworkdetails.Rows[i]);
                    }
                    // gets the last course attended to check if it has been before or after the latest sale
                    string[] LastCourse = CourseDal.GetLastCourseAttended(CourseID, GuestID);
                    string LastDate = LastCourse[1].Substring(0, 10);
                    DateTime LastDate_ = new DateTime(Convert.ToInt16(LastDate.Substring(6,4)), 
                        Convert.ToInt16(LastDate.Substring(3,2)), 
                        Convert.ToInt16(LastDate.Substring(0,2)));
                    foreach (DataRow row in artworkdetails.Rows)
                    {
                        DateTime ExDate_ = new DateTime(Convert.ToInt16(row[3].ToString().Substring(6, 4)),
                        Convert.ToInt16(row[3].ToString().Substring(3, 2)),
                        Convert.ToInt16(row[3].ToString().Substring(0, 2)));
                        if (LastDate_ < ExDate_ && row[2].ToString() == "True")
                        {
                            details.Add(row[0].ToString());
                            details.Add(row[1].ToString());
                            SoldArtworkTotal += Convert.ToDecimal(row[1].ToString());
                        }
                    }
                    if (SoldArtworkTotal <= 0)
                    {
                        recentsold = false;
                    }
                    else { recentsold = true; }
                }
                else
                {
                    recentsold = false;
                }
            }
            else
            {
                recentsold = false;
            }
            return _ds;
        }

        private void btnMainMenuHelpDone_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmGuestMenu().Show();
        }

        static string _connectionString = ConfigurationManager.ConnectionStrings["PotteryDB_ConnectionString"].ConnectionString;
        // gets the data to fill the table on the report with
        private void GetDataSet()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // collects the data about equipment logged for the specific course, and returns it as a table
                SqlCommand getItems = new SqlCommand();
                getItems.Connection = connection;
                getItems.CommandType = System.Data.CommandType.StoredProcedure;
                getItems.CommandText = "InvoiceEquipment";
                getItems.Parameters.Add(new SqlParameter("@GuestID", GuestID));
                getItems.Parameters.Add(new SqlParameter("@CourseID", CourseID));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.SelectCommand = getItems;
                dataAdapter.Fill(ds);
                if (ds.Rows.Count > 0) 
                { 
                    usedequipment = true;
                    for (int i = 0;  i < ds.Rows.Count; i++)
                    {
                        decimal runningcost = Convert.ToDecimal(ds.Rows[i][2].ToString().Substring(1));
                        EquipAndCostTotal += runningcost;
                    }
                }
                else
                    { usedequipment = false; }
                connection.Close();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        // sets all parameters for the form in order that they appear on the report
        private void FrmInvoiceViewer_Load(object sender, EventArgs e)
        {
            string runningtotalstring = "£" + String.Format("{0:C}", Convert.ToString(EquipAndCostTotal));
            DataSet soldArtworks = RecentlySold();
            string runningtotalsold = "£" + String.Format("{0:c}", Convert.ToString(SoldArtworkTotal));

            ReportParameter[] parameters = new ReportParameter[16];
            parameters[0] = new ReportParameter("GuestIDInvoice", GuestID);
            parameters[1] = new ReportParameter("GuestForename", GuestForename);
            parameters[2] = new ReportParameter("GuestSurname", GuestSurname);
            parameters[3] = new ReportParameter("AddressLine1", AddressLine1);
            parameters[4] = new ReportParameter("AddressLine2", AddressLine2);
            parameters[5] = new ReportParameter("AddressLine3", AddressLine3);
            parameters[6] = new ReportParameter("CourseID", CourseID);
            parameters[7] = new ReportParameter("DateBooked", DateBooked);
            parameters[8] = new ReportParameter("TimeBooked", TimeBooked);
            parameters[9] = new ReportParameter("CourseCost", CourseCost);
            parameters[10] = new ReportParameter("CourseType", CourseType);
            parameters[11] = new ReportParameter("usedEquipmentTrue", usedequipment.ToString());
            parameters[12] = new ReportParameter("TotalEquipPlusCost", runningtotalstring);
            parameters[13] = new ReportParameter("TotalSoldArtwork", runningtotalsold);
            parameters[14] = new ReportParameter("FinalInvoiceTotal", "£" + String.Format("{0:C}", Convert.ToString((Convert.ToDecimal(CourseCost.Substring(1)) + EquipAndCostTotal) - SoldArtworkTotal)));
            parameters[15] = new ReportParameter("RecentSoldTrue", Convert.ToString(recentsold));
            reportViewer1.LocalReport.SetParameters(parameters);

            
            if (reportViewer1.LocalReport.DataSources.Count > 0)
            {
                for (int i = 0; i> reportViewer1.LocalReport.DataSources.Count; i++)
                {
                    reportViewer1.LocalReport.DataSources.RemoveAt(0);
                }
            }
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("InvoiceEquipment", ds));
            if(recentsold == true)
            {
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("SoldArtworks", soldArtworks.Tables[0]));
            }
            else
            {
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("SoldArtworks", new DataTable()));
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
