using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotteryDBA_V1._0.Methods
{
    internal class ExhibitionDal
    {
        static string _connectionString = ConfigurationManager.ConnectionStrings["PotteryDB_ConnectionString"].ConnectionString;

        // method to create a new exhibition record
        public static int AddExhibition (DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand AddExCommand = new SqlCommand();
                AddExCommand.Connection = connection;
                AddExCommand.CommandType = System.Data.CommandType.StoredProcedure;
                AddExCommand.CommandText = "AddExhibition";
                AddExCommand.Parameters.Add(new SqlParameter("@Date", date));
                int rowsAffected = AddExCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }

        // method to delete an exhibition record
        public static int DeleteExhibition(string ID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand DelExCommand = new SqlCommand();
                DelExCommand.Connection = connection;
                DelExCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DelExCommand.CommandText = "DeleteExhibition";
                DelExCommand.Parameters.Add(new SqlParameter("@ID", ID));
                int rowsAffected = DelExCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }

        // method to update an exhibitin record
        public static int UpdateExhibition(string ID, DateTime Date, int CaterNo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand UpdateExhibitionCommand = new SqlCommand();
                UpdateExhibitionCommand.Connection = connection;
                UpdateExhibitionCommand.CommandType = System.Data.CommandType.StoredProcedure;
                UpdateExhibitionCommand.CommandText = "UpdateExhibition";
                UpdateExhibitionCommand.Parameters.Add(new SqlParameter("@ID", ID));
                UpdateExhibitionCommand.Parameters.Add(new SqlParameter("@Date", Date));
                UpdateExhibitionCommand.Parameters.Add(new SqlParameter("@CaterNo", CaterNo));
                int rowsAffected = UpdateExhibitionCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }

        // method that returns a table of all sold artworks for the invoice report

        public static DataTable getSoldArtworkDetails(string GuestID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                System.Data.DataSet ds = new System.Data.DataSet();
                DataTable dt = new DataTable();
                //string[] details = new string[4];
                SqlCommand GetDetails = new SqlCommand();
                GetDetails.Connection = connection;
                GetDetails.CommandType = System.Data.CommandType.StoredProcedure;
                GetDetails.CommandText = "IsSoldArtworkInExhibition";
                GetDetails.Parameters.Add(new SqlParameter("@GuestID", GuestID));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.SelectCommand = GetDetails;
                dataAdapter.Fill(ds);
                int length = ds.Tables[0].Rows.Count;

                dt = ds.Tables[0].Clone();

                for (int i = 0; i < length; i++)
                {
                  dt.ImportRow(ds.Tables[0].Rows[i]);
                }
                connection.Close();
                return dt;
            }
        }
    }
}
