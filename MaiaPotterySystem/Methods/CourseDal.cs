using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotteryDBA_V1._0.Methods
{
    internal class CourseDal
    {
        // sets up the connection string
        static string _connectionString = ConfigurationManager.ConnectionStrings["PotteryDB_ConnectionString"].ConnectionString;

        // method for adding a new course record using stored procedure
        public static int AddCourse(DateTime start, string type, string skill, decimal cost, int capacity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // creates a new command from the stored procedure and adds all the details passed into the method as parameters
                SqlCommand AddCourseCommand = new SqlCommand();
                AddCourseCommand.Connection = connection;
                AddCourseCommand.CommandType = System.Data.CommandType.StoredProcedure;
                AddCourseCommand.CommandText = "AddCourse";
                AddCourseCommand.Parameters.Add(new SqlParameter("@Start", start));
                AddCourseCommand.Parameters.Add(new SqlParameter("@Type", type));
                AddCourseCommand.Parameters.Add(new SqlParameter("@Skill", skill));
                AddCourseCommand.Parameters.Add(new SqlParameter("@Cost", cost));
                AddCourseCommand.Parameters.Add(new SqlParameter("@Capacity", capacity));
                int rowsAffected = AddCourseCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }

        // method for placing a booking using a stored procedure
        public static int MakeBooking(string GuestID, string CourseID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // creates a new command from the stored procedure and adds all the details passed into the method as parameters
                SqlCommand AddBookingCommand = new SqlCommand();
                AddBookingCommand.Connection = connection;
                AddBookingCommand.CommandType = System.Data.CommandType.StoredProcedure;
                AddBookingCommand.CommandText = "AddBooking";
                AddBookingCommand.Parameters.Add(new SqlParameter("@GuestID", GuestID));
                AddBookingCommand.Parameters.Add(new SqlParameter("@CourseID", CourseID));
                AddBookingCommand.Parameters.Add(new SqlParameter("@DateBooked",DateTime.Now.Date));
                AddBookingCommand.Parameters.Add(new SqlParameter("@TimeBooked",DateTime.Now.TimeOfDay));
                int rowsAffected = AddBookingCommand.ExecuteNonQuery();
                connection.Close();

                return rowsAffected;
            }
        }

        // method to perform search for records between dates and then set the dgv passed into it to the data table returned
        public static int SearchBetweenDates(DateTime start, DateTime end, DataGridView dgv)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand DateSearch = new SqlCommand();
                DateSearch.Connection = connection;
                DateSearch.CommandType = System.Data.CommandType.StoredProcedure;
                DateSearch.CommandText = "BetweenDates";
                DateSearch.Parameters.Add(new SqlParameter("@start", start));
                DateSearch.Parameters.Add(new SqlParameter("@end", end));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                System.Data.DataSet ds = new System.Data.DataSet();
                dataAdapter.SelectCommand = DateSearch;
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

        // method to count the number odf courses in a year to determine space
        public static int CountExistingCourses(DateTime start, string skill, string type)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand CourseCount = new SqlCommand();
                CourseCount.Connection = connection;
                CourseCount.CommandType = System.Data.CommandType.StoredProcedure;
                CourseCount.CommandText = "CountExistingCoursesByYearAndType";
                CourseCount.Parameters.Add(new SqlParameter("@year", start));
                CourseCount.Parameters.Add(new SqlParameter("@skill", skill));
                CourseCount.Parameters.Add(new SqlParameter("@type", type));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                System.Data.DataSet ds = new System.Data.DataSet();
                dataAdapter.SelectCommand = CourseCount;
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    connection.Close();
                    return -10;
                }
                else
                {
                    connection.Close();
                    return ds.Tables[0].Rows.Count;
                }

            }
        }

        // merthods to return the participants with bookings for a course for the report
        public static int CheckForParticipants(string id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // currently adding course booing no checks before the delete

                SqlCommand CheckForParticipants = new SqlCommand();
                CheckForParticipants.Connection = connection;
                CheckForParticipants.CommandType = System.Data.CommandType.StoredProcedure;
                CheckForParticipants.CommandText = "CheckIfCourseHasParticipants";
                CheckForParticipants.Parameters.Add(new SqlParameter("@id", id));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                System.Data.DataSet ds = new System.Data.DataSet();
                dataAdapter.SelectCommand = CheckForParticipants;
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    connection.Close();
                    return -10;
                }
                else
                {
                    connection.Close();
                    return ds.Tables[0].Rows.Count;
                }

            }
        }

        // method used to delete course records using a stored procedure
        public static int DeleteCourse(string id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int rowsAffected;
                connection.Open();
                int areGuestsAssigned = CheckForParticipants(id);
                if (areGuestsAssigned <= 0)
                {
                    SqlCommand DeleteCourse = new SqlCommand();
                    DeleteCourse.Connection = connection;
                    DeleteCourse.CommandType = System.Data.CommandType.StoredProcedure;
                    DeleteCourse.CommandText = "DeleteCourse";
                    DeleteCourse.Parameters.Add(new SqlParameter("@id", id));
                    rowsAffected = DeleteCourse.ExecuteNonQuery();
                }
                else
                {
                    rowsAffected = -1;
                }
                connection.Close();
                return rowsAffected;
            }
        }

        // method to check the ID is valid
        public static string CheckForID(string CourseID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string Course = null;
                System.Data.DataSet ds = new System.Data.DataSet();
                SqlCommand GetDetails = new SqlCommand();
                GetDetails.Connection = connection;
                GetDetails.CommandType = System.Data.CommandType.StoredProcedure;
                GetDetails.CommandText = "FindCourseById";
                GetDetails.Parameters.Add(new SqlParameter("@id", CourseID));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.SelectCommand = GetDetails;
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    Course = ds.Tables[0].Rows[0][0].ToString();
                }
                connection.Close();
                return Course;
            }
        }

        // shortcut to reset the dgv to all records by returning the whole table
        public static void AvailableCoursesReset(DataGridView dgv, Label lblNoResults)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand available = new SqlCommand();
                available.Connection = connection;
                available.CommandType = System.Data.CommandType.StoredProcedure;
                available.CommandText = "GetTableForBookingManager";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = available;
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds);
                if (ds != null)
                {
                    dgv.DataSource = ds.Tables[0];
                    lblNoResults.Visible = false;
                }
                else
                {
                    dgv.DataSource = null;
                    lblNoResults.Visible = true;
                }
                connection.Close();
            }
        }

        // method to get available courses for the provided guest ID
        public static void AvailableCourses(DataGridView dgv, string[] person, Label lblNoResults)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand available = new SqlCommand();
                available.Connection = connection;
                available.CommandType = System.Data.CommandType.StoredProcedure;
                available.CommandText = "GetSkillAvailableCourses";
                available.Parameters.Add(new SqlParameter("@skill", person[3]));
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = available;
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds);
                if (ds != null)
                {
                    dgv.DataSource = ds.Tables[0];
                    lblNoResults.Visible = false;
                }
                else
                {
                    dgv.DataSource = null;
                    lblNoResults.Visible = true;
                }
                connection.Close();
            }
        }

        // method to check for existing booking to prevent double booking
        public static int GuestDoubleBooked(string GuestID, string CourseID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                int outcome = 0;
                SqlCommand doubleBooked = new SqlCommand();
                doubleBooked.Connection = connection;
                doubleBooked.CommandType = System.Data.CommandType.StoredProcedure;
                doubleBooked.CommandText = "CheckForDoubleBookingGuest";
                doubleBooked.Parameters.Add(new SqlParameter("@GuestID", GuestID));
                doubleBooked.Parameters.Add(new SqlParameter("@CourseID", CourseID));
                object x = doubleBooked.ExecuteScalar();
                if (x  != null)
                {
                    outcome = 1;
                }
                connection.Close();
                return outcome;
            }
        }


        // method to get basic info about a course
        public static string[] GetCourseBaseInfo(string CourseID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                System.Data.DataSet ds = new System.Data.DataSet();
                string[] details = new string[2];
                SqlCommand Getbaseinfo = new SqlCommand();
                Getbaseinfo.Connection = connection;
                Getbaseinfo.CommandType = System.Data.CommandType.StoredProcedure;
                Getbaseinfo.CommandText = "CourseBaseDetails";
                Getbaseinfo.Parameters.Add(new SqlParameter("@CourseID", CourseID));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.SelectCommand = Getbaseinfo;
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


        // method to return the last course attended by a guest
        public static string[] GetLastCourseAttended(string CourseID, string GuestID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                System.Data.DataSet ds = new System.Data.DataSet();
                string[] details = new string[2];
                SqlCommand GetCourseinfo = new SqlCommand();
                GetCourseinfo.Connection = connection;
                GetCourseinfo.CommandType = System.Data.CommandType.StoredProcedure;
                GetCourseinfo.CommandText = "GetLastCourseAttended";
                GetCourseinfo.Parameters.Add(new SqlParameter("@CourseID", CourseID));
                GetCourseinfo.Parameters.Add(new SqlParameter("@GuestID", GuestID));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.SelectCommand = GetCourseinfo;
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
    }
}
