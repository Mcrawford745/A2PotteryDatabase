using Microsoft.Reporting.WinForms;
using PotteryDBA_V1._0.DataSets.EnrolmentSetfromQueryTableAdapters;
using PotteryDBA_V1._0.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotteryDBA_V1._0.Forms
{
    public partial class FrmEnrolmentReport : Form
    {
        // initialises variables needed globally here
        string id;
        DataTable ds = new DataTable();

        bool FullyBooked = false;
        public FrmEnrolmentReport(string ID)
        {
            InitializeComponent();
            CenterToScreen();
            CommonMethods.lockform(this);
            // creates a table and adds columns to it
            id = ID;
            ds.Columns.Add("GuestID");
            ds.Columns.Add("Forename");
            ds.Columns.Add("Surname");
            ds.Columns.Add("ContactNo");
            ds.Columns.Add("DateBooked");

        }

        static string _connectionString = ConfigurationManager.ConnectionStrings["PotteryDB_ConnectionString"].ConnectionString;
        // gets the data to fill the table on the report with
        private void GetDataSetUsingCourseID()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand getParticipants = new SqlCommand();
                getParticipants.Connection = connection;
                getParticipants.CommandType = System.Data.CommandType.StoredProcedure;
                getParticipants.CommandText = "getParticipants";
                getParticipants.Parameters.Add(new SqlParameter("@id", id));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.SelectCommand = getParticipants;
                foreach (DataRow dr in ds.Rows) // search whole table
                {
                    dr.ItemArray[4] = dr.ItemArray[4].ToString().Substring(0, 11);
                }
                dataAdapter.Fill(ds);
                connection.Close();
            }
        }

        // checks if the course is fully booked
        private void GetFullyBooked()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand booked = new SqlCommand();
                booked.Connection = connection;
                booked.CommandType = System.Data.CommandType.StoredProcedure;
                booked.CommandText = "CheckFullyBookedById";
                booked.Parameters.Add(new SqlParameter("@id", id));
                string outcome = booked.ExecuteScalar().ToString();
                if (outcome != null)
                {
                    if (outcome == "False")
                    {
                        FullyBooked = false;
                    }
                    else if (outcome == "True")
                    {
                        FullyBooked = true;
                    }
                }
                connection.Close();
            }
        }
        // passes the parameters and table into the report
        private void FrmEnrolmentReport_Load(object sender, EventArgs e)
        {
            GetDataSetUsingCourseID();
            GetFullyBooked();
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("PassedID", id, true);
            parameters[1] = new ReportParameter("FullyBooked", FullyBooked.ToString());
            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.LocalReport.DataSources.RemoveAt(0);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("enrolmentv2", ds));
            this.reportViewer1.RefreshReport();
        }

        private void btnMainMenuHelpDone_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCourseMainMenu().Show();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
