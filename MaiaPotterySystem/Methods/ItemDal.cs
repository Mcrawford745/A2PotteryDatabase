using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PotteryDBA_V1._0.Methods
{
    internal class ItemDal
    {
        // sets up the connection string
        static string _connectionString = ConfigurationManager.ConnectionStrings["PotteryDB_ConnectionString"].ConnectionString;

        // method to return an item ID and its cost
        public static string[] GetIDandCost(string ItemType, string ItemName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // this method retreives the item cost and its id using its full name.
                connection.Open();
                string[] Item;
                System.Data.DataSet ds = new System.Data.DataSet();
                SqlCommand GetIDandCost = new SqlCommand();
                GetIDandCost.Connection = connection;
                GetIDandCost.CommandType = System.Data.CommandType.StoredProcedure;
                GetIDandCost.CommandText = "GetItemIDandCost";
                GetIDandCost.Parameters.Add(new SqlParameter("@name", (ItemType.Trim() + ", " + ItemName.Trim())));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.SelectCommand = GetIDandCost;
                dataAdapter.Fill(ds);
                int length = ds.Tables[0].Rows.Count;
                // if more than one item has been found, or no items, no item will be returned
                // if only one item is found, it is returned.
                Item = new string[2];
                if (length == 1)
                {
                    Item[0] = ds.Tables[0].Rows[0][0].ToString();
                    Item[1] = ds.Tables[0].Rows[0][1].ToString();
                }
                else
                {
                    Item = null;
                }
                connection.Close();
                return Item;
            }
        }

        // method to add new equipment details to a booking
        public static int LogEquipmentUse(string GuestID, string CourseID, string ItemID, decimal AmountUsed)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                int recordExists;
                recordExists = RecordExists(GuestID, CourseID, ItemID);
                // creates a new command from the stored procedure and adds all
                // the details passed into the method as parameters
                SqlCommand AddLogCommand = new SqlCommand();
                AddLogCommand.Connection = connection;
                AddLogCommand.CommandType = System.Data.CommandType.StoredProcedure;
                if (recordExists == 1)
                {
                    AddLogCommand.CommandText = "UpdateLog";
                }
                else if (recordExists == 2)
                {
                    AddLogCommand.CommandText = "AddEquipmentLog";
                }
                AddLogCommand.Parameters.Add(new SqlParameter("@GuestID", GuestID));
                AddLogCommand.Parameters.Add(new SqlParameter("@CourseID", CourseID));
                AddLogCommand.Parameters.Add(new SqlParameter("@ItemID", ItemID));
                AddLogCommand.Parameters.Add(new SqlParameter("@AmountUsed", AmountUsed));
                int rowsAffected = AddLogCommand.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }

        // method to check if record exists to avoid duplicate primary keys
        public static int RecordExists(string GuestID, string CourseID, string ItemID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // this method is used to decide if the log already exists, so that
                // primary keys are not duplicated, and instead the original record
                // will be updated.
                SqlCommand check = new SqlCommand();
                check.Connection = connection;
                check.CommandType = System.Data.CommandType.StoredProcedure;
                check.CommandText = "DoesItemRecordExist";
                check.Parameters.Add(new SqlParameter("@GuestID", GuestID));
                check.Parameters.Add(new SqlParameter("@CourseID", CourseID));
                check.Parameters.Add(new SqlParameter("@ItemID", ItemID));
                object recordexists = check.ExecuteScalar();
                connection.Close();
                if (recordexists != null)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
                
            }
        }
    }
}
