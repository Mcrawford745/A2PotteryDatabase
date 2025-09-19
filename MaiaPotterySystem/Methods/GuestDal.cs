using System;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Data.Common;
using System.Net.Http.Headers;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System.Collections.ObjectModel;

namespace PotteryDBA_V1._0.Methods
{
    internal class GuestDal
    {
        // sets up the connection string
        static string _connectionString = ConfigurationManager.ConnectionStrings["PotteryDB_ConnectionString"].ConnectionString;
        //method takes guest details as parameters and returns an into to tell whether the add worked
        public static int AddGuest(string forename, string surname, string no, string address, string skill)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // creates a new command from the stored procedure and adds all the details passed into the method as parameters
                SqlCommand AddGuestCommand = new SqlCommand();
                AddGuestCommand.Connection = connection;
                AddGuestCommand.CommandType = System.Data.CommandType.StoredProcedure;
                AddGuestCommand.CommandText = "AddGuest";
                AddGuestCommand.Parameters.Add(new SqlParameter("@forename", forename ));
                AddGuestCommand.Parameters.Add(new SqlParameter("@surname", surname ));
                AddGuestCommand.Parameters.Add(new SqlParameter("@no", no ));
                AddGuestCommand.Parameters.Add(new SqlParameter("@address", address ));
                AddGuestCommand.Parameters.Add(new SqlParameter("@skill", skill ));
                int rowsAffected = AddGuestCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }
        public static int UpdateGuest(string forename, string surname, string no, string address, string skill, string GuestID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // creates a new command from the stored procedure and adds all the details passed into the method as parameters
                SqlCommand UpdateGuestCommand = new SqlCommand();
                UpdateGuestCommand.Connection = connection;
                UpdateGuestCommand.CommandType = System.Data.CommandType.StoredProcedure;
                UpdateGuestCommand.CommandText = "UpdateGuest";
                UpdateGuestCommand.Parameters.Add(new SqlParameter("@forename", forename));
                UpdateGuestCommand.Parameters.Add(new SqlParameter("@surname", surname));
                UpdateGuestCommand.Parameters.Add(new SqlParameter("@no", no));
                UpdateGuestCommand.Parameters.Add(new SqlParameter("@address", address));
                UpdateGuestCommand.Parameters.Add(new SqlParameter("@skill", skill));
                UpdateGuestCommand.Parameters.Add(new SqlParameter("@GuestID", GuestID));
                int rowsAffected = UpdateGuestCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }
        public static int DeleteGuest(string GuestID)
            // need to check for artwork or course first. maybe check if there is a future booking, if not, delete all previous bookings.
        {
            int rowsAffected; // unsure what happens when no guest is deleted.
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // checks if the guest currently has any artwork stored.
                // if they do, they will not be deleted.
                connection.Open();
                rowsAffected = 0;
                SqlCommand CheckArtwork = new SqlCommand();
                CheckArtwork.Connection = connection;
                CheckArtwork.CommandType = System.Data.CommandType.StoredProcedure;
                CheckArtwork.CommandText = "DoesGuestHaveArtwork";
                CheckArtwork.Parameters.Add(new SqlParameter("Id", GuestID));
                object outcome = CheckArtwork.ExecuteScalar();
                if (outcome == null)
                {
                    // check for bookings here
                    int CheckingBookings = CheckForFutureBookings(GuestID);
                    if (CheckingBookings == -20)
                    {
                        // authorise delete bookings and guest
                        DialogResult x = MessageBox.Show("This Guest has future bookings. \nIf you proceed these will be lost. Are \nyou sure you want to proceed?", "Are You Sure?", MessageBoxButtons.YesNo);
                        if (x == DialogResult.Yes)
                        {
                            SqlCommand DeleteGuestCommand = new SqlCommand();
                            DeleteGuestCommand.Connection = connection;
                            DeleteGuestCommand.CommandType = System.Data.CommandType.StoredProcedure;
                            DeleteGuestCommand.CommandText = "DeleteGuest";
                            DeleteGuestCommand.Parameters.Add(new SqlParameter("Id", GuestID));
                            rowsAffected = DeleteGuestCommand.ExecuteNonQuery();
                        }
                        else { rowsAffected = -101; /* user aborted. */ }
                    }
                    else if (CheckingBookings == -50)
                    {
                        // delete if no bookings
                        SqlCommand DeleteGuestCommand = new SqlCommand();
                        DeleteGuestCommand.Connection = connection;
                        DeleteGuestCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        DeleteGuestCommand.CommandText = "DeleteGuest";
                        DeleteGuestCommand.Parameters.Add(new SqlParameter("Id", GuestID));
                        rowsAffected = DeleteGuestCommand.ExecuteNonQuery();
                    }
                }
                else
                {
                    rowsAffected = -15 /* Artwork existed, can't delete */;
                }
                connection.Close();
                return rowsAffected;
            }
        }
        public static int CheckForFutureBookings (string GuestID)
        // checks for bookings in the future
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int returnvalue;
                connection.Open();
                SqlCommand FutureBookings = new SqlCommand();
                FutureBookings.Connection = connection;
                FutureBookings.CommandType = System.Data.CommandType.StoredProcedure;
                FutureBookings.CommandText = "DoesGuestHaveFutureBooking";
                FutureBookings.Parameters.Add(new SqlParameter("Id", GuestID));
                object existingbooking = FutureBookings.ExecuteScalar();
                if (existingbooking != null)
                {
                    returnvalue = -20;
                }
                else { returnvalue = -50; }
                connection.Close();
                return returnvalue;
            }
        }
        public static int SearchByForename(string search, DataGridView dgv)
        {
            // performs a search using a string on the guest.forename column and returns matches as the dgv source
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand ForenameSearch = new SqlCommand();
                ForenameSearch.Connection = connection;
                ForenameSearch.CommandType = System.Data.CommandType.StoredProcedure;
                ForenameSearch.CommandText = "SearchByForename";
                ForenameSearch.Parameters.Add(new SqlParameter("@Fore", search));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                System.Data.DataSet ds = new System.Data.DataSet();
                dataAdapter.SelectCommand = ForenameSearch;
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    connection.Close();
                    return -10;
                }
                else
                {
                    dgv.ReadOnly = true;
                    dgv.DataSource = ds.Tables[0];
                    connection.Close();
                    return 1;
                }

            }
        }
        public static int SearchBySurname(string search, DataGridView dgv)
        {
            // performs a search using a string on the guest.surname column and returns matches as the dgv source
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand SurnameSearch = new SqlCommand();
                SurnameSearch.Connection = connection;
                SurnameSearch.CommandType = System.Data.CommandType.StoredProcedure;
                SurnameSearch.CommandText = "SearchBySurname";
                SurnameSearch.Parameters.Add(new SqlParameter("@Sur", search));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                System.Data.DataSet ds = new System.Data.DataSet();
                dataAdapter.SelectCommand = SurnameSearch;
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    connection.Close();
                    return -10;
                }
                else
                {
                    dgv.ReadOnly = true;
                    dgv.DataSource = ds.Tables[0];
                    connection.Close();
                    return 1;
                }

            }
        }
        public static int SearchByGuestID(string search, DataGridView dgv)
        {
            // performs a search using a string on the guest.guestID column and returns matches as the dgv source
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand IDSearch = new SqlCommand();
                IDSearch.Connection = connection;
                IDSearch.CommandType = System.Data.CommandType.StoredProcedure;
                IDSearch.CommandText = "SearchByID";
                IDSearch.Parameters.Add(new SqlParameter("@id", search));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                System.Data.DataSet ds = new System.Data.DataSet();
                dataAdapter.SelectCommand = IDSearch;
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    connection.Close();
                    return -10;
                }
                else
                {
                    dgv.ReadOnly = true;
                    dgv.DataSource = ds.Tables[0];
                    connection.Close();
                    return 1;
                }

            }
        }
        // the sort used when the sort counter is set for beginner.
        public static void BeginnerSort(DataGridView dgv, string searchvalue, int type)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // first finds all matching beginners by both searching and then filtering
                System.Data.DataSet ds = new System.Data.DataSet();
                SqlCommand BeginnerSort = new SqlCommand();
                BeginnerSort.Connection = connection;
                BeginnerSort.CommandType = System.Data.CommandType.StoredProcedure;
                BeginnerSort.CommandText = "BeginnerSort";
                BeginnerSort.Parameters.Add(new SqlParameter("@value", searchvalue));
                BeginnerSort.Parameters.Add(new SqlParameter("@type", type));
                SqlDataAdapter dataAdapterB = new SqlDataAdapter();
                SqlCommandBuilder commandBuilderB = new SqlCommandBuilder(dataAdapterB);
                dataAdapterB.SelectCommand = BeginnerSort;
                dataAdapterB.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    //MessageBox.Show("NOPE B");
                }
                // next adds all intermediate onto the beginners using searching and filtering
                SqlCommand intermediateSort = new SqlCommand();
                intermediateSort.Connection = connection;
                intermediateSort.CommandType = System.Data.CommandType.StoredProcedure;
                intermediateSort.CommandText = "IntermediateSort";
                intermediateSort.Parameters.Add(new SqlParameter("@value", searchvalue));
                intermediateSort.Parameters.Add(new SqlParameter("@type", type));
                SqlDataAdapter dataAdapterI = new SqlDataAdapter();
                SqlCommandBuilder commandBuilderI = new SqlCommandBuilder(dataAdapterI);
                dataAdapterI.SelectCommand = intermediateSort;
                dataAdapterI.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    //MessageBox.Show("NOPE I");
                }  
                // finally adds the advanced guests onto the bottom
                SqlCommand AdvancedSort = new SqlCommand();
                AdvancedSort.Connection = connection;
                AdvancedSort.CommandType = System.Data.CommandType.StoredProcedure;
                AdvancedSort.CommandText = "AdvancedSort";
                AdvancedSort.Parameters.Add(new SqlParameter("@value", searchvalue));
                AdvancedSort.Parameters.Add(new SqlParameter("@type", type));
                SqlDataAdapter dataAdapterAd = new SqlDataAdapter();
                SqlCommandBuilder commandBuilderAd = new SqlCommandBuilder(dataAdapterAd);
                dataAdapterAd.SelectCommand = AdvancedSort;
                dataAdapterAd.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    //MessageBox.Show("NOPE Ad");
                }
                // assigns the dgv data set to the final sorted source
                dgv.DataSource = ds.Tables[0];
                connection.Close();
            }
        }
        // intermediate and advanced sort work in the same manner as above,
        // but in shuffled orders depending on the sort type.
        public static void IntermediateSort(DataGridView dgv, string searchvalue, int type)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                System.Data.DataSet ds = new System.Data.DataSet();
                SqlCommand intermediateSort = new SqlCommand();
                intermediateSort.Connection = connection;
                intermediateSort.CommandType = System.Data.CommandType.StoredProcedure;
                intermediateSort.CommandText = "IntermediateSort";
                intermediateSort.Parameters.Add(new SqlParameter("@value", searchvalue));
                intermediateSort.Parameters.Add(new SqlParameter("@type", type));
                SqlDataAdapter dataAdapterI = new SqlDataAdapter();
                SqlCommandBuilder commandBuilderI = new SqlCommandBuilder(dataAdapterI);
                dataAdapterI.SelectCommand = intermediateSort;
                dataAdapterI.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    //MessageBox.Show("NOPE I");
                }
                SqlCommand AdvancedSort = new SqlCommand();
                AdvancedSort.Connection = connection;
                AdvancedSort.CommandType = System.Data.CommandType.StoredProcedure;
                AdvancedSort.CommandText = "AdvancedSort";
                AdvancedSort.Parameters.Add(new SqlParameter("@value", searchvalue));
                AdvancedSort.Parameters.Add(new SqlParameter("@type", type));
                SqlDataAdapter dataAdapterAd = new SqlDataAdapter();
                SqlCommandBuilder commandBuilderAd = new SqlCommandBuilder(dataAdapterAd);
                dataAdapterAd.SelectCommand = AdvancedSort;
                dataAdapterAd.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    //MessageBox.Show("NOPE Ad");
                }
                SqlCommand BeginnerSort = new SqlCommand();
                BeginnerSort.Connection = connection;
                BeginnerSort.CommandType = System.Data.CommandType.StoredProcedure;
                BeginnerSort.CommandText = "BeginnerSort";
                BeginnerSort.Parameters.Add(new SqlParameter("@value", searchvalue));
                BeginnerSort.Parameters.Add(new SqlParameter("@type", type));
                SqlDataAdapter dataAdapterB = new SqlDataAdapter();
                SqlCommandBuilder commandBuilderB = new SqlCommandBuilder(dataAdapterB);
                dataAdapterB.SelectCommand = BeginnerSort;
                dataAdapterB.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    //MessageBox.Show("NOPE B");
                }
                dgv.DataSource = ds.Tables[0];
                connection.Close();
            }
        }
        public static void AdvancedSort(DataGridView dgv, string searchvalue, int type)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                System.Data.DataSet ds = new System.Data.DataSet();
                SqlCommand AdvancedSort = new SqlCommand();
                AdvancedSort.Connection = connection;
                AdvancedSort.CommandType = System.Data.CommandType.StoredProcedure;
                AdvancedSort.CommandText = "AdvancedSort";
                AdvancedSort.Parameters.Add(new SqlParameter("@value", searchvalue));
                AdvancedSort.Parameters.Add(new SqlParameter("@type", type));
                SqlDataAdapter dataAdapterAd = new SqlDataAdapter();
                SqlCommandBuilder commandBuilderAd = new SqlCommandBuilder(dataAdapterAd);
                dataAdapterAd.SelectCommand = AdvancedSort;
                dataAdapterAd.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    //MessageBox.Show("NOPE Ad");
                }
                SqlCommand BeginnerSort = new SqlCommand();
                BeginnerSort.Connection = connection;
                BeginnerSort.CommandType = System.Data.CommandType.StoredProcedure;
                BeginnerSort.CommandText = "BeginnerSort";
                BeginnerSort.Parameters.Add(new SqlParameter("@value", searchvalue));
                BeginnerSort.Parameters.Add(new SqlParameter("@type", type));
                SqlDataAdapter dataAdapterB = new SqlDataAdapter();
                SqlCommandBuilder commandBuilderB = new SqlCommandBuilder(dataAdapterB);
                dataAdapterB.SelectCommand = BeginnerSort;
                dataAdapterB.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    //MessageBox.Show("NOPE B");
                }
                SqlCommand intermediateSort = new SqlCommand();
                intermediateSort.Connection = connection;
                intermediateSort.CommandType = System.Data.CommandType.StoredProcedure;
                intermediateSort.CommandText = "IntermediateSort";
                intermediateSort.Parameters.Add(new SqlParameter("@value", searchvalue));
                intermediateSort.Parameters.Add(new SqlParameter("@type", type));
                SqlDataAdapter dataAdapterI = new SqlDataAdapter();
                SqlCommandBuilder commandBuilderI = new SqlCommandBuilder(dataAdapterI);
                dataAdapterI.SelectCommand = intermediateSort;
                dataAdapterI.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    //MessageBox.Show("NOPE I");
                }
                dgv.DataSource = ds.Tables[0];
                connection.Close();
            }
        }
        // this method checks if the person exists from
        // their id and returns their basic details for
        // the log equipment screen
        public static string[] CheckForID(string GuestID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string[] person = new string[4];
                System.Data.DataSet ds = new System.Data.DataSet();
                SqlCommand GetDetails = new SqlCommand();
                GetDetails.Connection = connection;
                GetDetails.CommandType = System.Data.CommandType.StoredProcedure;
                GetDetails.CommandText = "FindGuestByID";
                GetDetails.Parameters.Add(new SqlParameter("@id", GuestID));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.SelectCommand = GetDetails;
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    person[0] = ds.Tables[0].Rows[0][0].ToString();
                    person[1] = ds.Tables[0].Rows[0][1].ToString();
                    person[2] = ds.Tables[0].Rows[0][2].ToString();
                    person[3] = ds.Tables[0].Rows[0][3].ToString();
                }
                connection.Close();
                return person;
            }
        }

        // this method finds out what courses a specific guest id is
        // enrolled in and will return an array that is used to populate
        // the combo box
        public static string[] GetCourseOptions(string GuestID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string[] courses;
                System.Data.DataSet ds = new System.Data.DataSet();
                SqlCommand GetCourses = new SqlCommand();
                GetCourses.Connection = connection;
                GetCourses.CommandType = System.Data.CommandType.StoredProcedure;
                GetCourses.CommandText = "FindCoursesByID";
                GetCourses.Parameters.Add(new SqlParameter("@id", GuestID));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.SelectCommand = GetCourses;
                dataAdapter.Fill(ds);
                int length = ds.Tables[0].Rows.Count;
                courses = new string[length];
                for (int i = 0; i < length; i++)
                {
                    courses[i] = ds.Tables[0].Rows[i][0].ToString();
                }
                connection.Close();
                return courses;
            }
        }

        // method gets the guest's details for their invoice
        public static string[] getGuestInvoicePersonalDetails(string GuestID, string CourseID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                System.Data.DataSet ds = new System.Data.DataSet();
                string[] details = new string[5];
                SqlCommand GetPersonalDetails = new SqlCommand();
                GetPersonalDetails.Connection = connection;
                GetPersonalDetails.CommandType = CommandType.StoredProcedure;
                GetPersonalDetails.CommandText = "InvoicePersonalDetails";
                GetPersonalDetails.Parameters.Add(new SqlParameter("@GuestID", GuestID));
                GetPersonalDetails.Parameters.Add(new SqlParameter("@CourseID", CourseID));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.SelectCommand = GetPersonalDetails;
                dataAdapter.Fill(ds);
                int length = ds.Tables[0].Columns.Count;
                for (int i = 0; i < length; i++)
                {
                    details[i] = ds.Tables[0].Rows[0][i].ToString();
                }
                connection.Close();
                return details;
            }
        }

        // method to check if the guest is an advanced guest
        public static bool IsGuestAdvanced(string GuestID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand CheckSkill = new SqlCommand();
                CheckSkill.Connection = connection;
                CheckSkill.CommandType = System.Data.CommandType.StoredProcedure;
                CheckSkill.CommandText = "IsGuestAdvanced";
                CheckSkill.Parameters.Add(new SqlParameter("GuestID", GuestID));
                object outcome = CheckSkill.ExecuteScalar();
                connection.Close();
                if (outcome.ToString() == "Advanced") { return true; }
                else { return false; }
            }
                
        }
    }
}
