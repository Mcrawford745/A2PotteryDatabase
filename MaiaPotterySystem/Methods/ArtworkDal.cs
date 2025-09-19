using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
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
    internal class ArtworkDal
    {
        static string _connectionString = ConfigurationManager.ConnectionStrings["PotteryDB_ConnectionString"].ConnectionString;

        // method that ues stored procedure to perform a search and set the results to the datasource of the dgv passed in.
        public static int SearchByArtworkIDNormal(string search, DataGridView dgv)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand IDSearch = new SqlCommand();
                IDSearch.Connection = connection;
                IDSearch.CommandType = System.Data.CommandType.StoredProcedure;
                IDSearch.CommandText = "SearchArtworknormalMode";
                IDSearch.Parameters.Add(new SqlParameter("@Type", 1));
                IDSearch.Parameters.Add(new SqlParameter("@Value", search));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                System.Data.DataSet ds = new System.Data.DataSet();
                dataAdapter.SelectCommand = IDSearch;
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    connection.Close();
                    dgv.DataSource = null;
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

        // method that ues stored procedure to perform a search and set the results to the datasource of the dgv passed in.
        public static int SearchByArtworkNameNormal(string search, DataGridView dgv)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand NameSearch = new SqlCommand();
                NameSearch.Connection = connection;
                NameSearch.CommandType = System.Data.CommandType.StoredProcedure;
                NameSearch.CommandText = "SearchArtworknormalMode";
                NameSearch.Parameters.Add(new SqlParameter("@Type", 2));
                NameSearch.Parameters.Add(new SqlParameter("@Value", search));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                System.Data.DataSet ds = new System.Data.DataSet();
                dataAdapter.SelectCommand = NameSearch;
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    connection.Close();
                    dgv.DataSource = null;
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

        // method that ues stored procedure to perform a search and set the results to the datasource of the dgv passed in.
        public static int SearchByArtworkIDAdvanced(string search, DataGridView dgv)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand IDSearch = new SqlCommand();
                IDSearch.Connection = connection;
                IDSearch.CommandType = System.Data.CommandType.StoredProcedure;
                IDSearch.CommandText = "SearchArtworkAdvancedMode";
                IDSearch.Parameters.Add(new SqlParameter("@Type", 1));
                IDSearch.Parameters.Add(new SqlParameter("@Value", search));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                System.Data.DataSet ds = new System.Data.DataSet();
                dataAdapter.SelectCommand = IDSearch;
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    connection.Close();
                    dgv.DataSource = null;
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

        // method that ues stored procedure to perform a search and set the results to the datasource of the dgv passed in.
        public static int SearchByArtworkNameAdvanced(string search, DataGridView dgv)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand NameSearch = new SqlCommand();
                NameSearch.Connection = connection;
                NameSearch.CommandType = System.Data.CommandType.StoredProcedure;
                NameSearch.CommandText = "SearchArtworkAdvancedMode";
                NameSearch.Parameters.Add(new SqlParameter("@Type", 2));
                NameSearch.Parameters.Add(new SqlParameter("@Value", search));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                System.Data.DataSet ds = new System.Data.DataSet();
                dataAdapter.SelectCommand = NameSearch;
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    connection.Close();
                    dgv.DataSource = null;
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

        // method that ues stored procedure to perform a search and set the results to the datasource of the dgv passed in.
        public static int SearchByArtworkPriceAdvanced(decimal search, DataGridView dgv)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand PriceSearch = new SqlCommand();
                PriceSearch.Connection = connection;
                PriceSearch.CommandType = System.Data.CommandType.StoredProcedure;
                PriceSearch.CommandText = "SearchArtworkAdvancedPrice";
                PriceSearch.Parameters.Add(new SqlParameter("@value", search));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                System.Data.DataSet ds = new System.Data.DataSet();
                dataAdapter.SelectCommand = PriceSearch;
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    connection.Close();
                    dgv.DataSource = null;
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

        // method that uses stored procedure to addnew record and returns a nuber based on the outcome.
        public static int AddArtwork(string GuestID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int rowsAffectedlink = 0;
                decimal pricenulled = 0.00m;
                connection.Open();
                SqlCommand AddCommand = new SqlCommand();
                AddCommand.Connection = connection;
                AddCommand.CommandType = System.Data.CommandType.StoredProcedure;
                AddCommand.CommandText = "AddArtwork";
                AddCommand.Parameters.Add(new SqlParameter("@price", pricenulled));
                int rowsAffectedAdd = AddCommand.ExecuteNonQuery();
                if (rowsAffectedAdd == 1) 
                { 
                    SqlCommand GetID = new SqlCommand();
                    GetID.Connection = connection;
                    GetID.CommandType = System.Data.CommandType.StoredProcedure;
                    GetID.CommandText = "GetLatestArtworkID";
                    string id = GetID.ExecuteScalar().ToString();

                    if (id != "")
                    {
                        SqlCommand linkCommand = new SqlCommand();
                        linkCommand.Connection = connection;
                        linkCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        linkCommand.CommandText = "LinkArtwork";
                        linkCommand.Parameters.Add(new SqlParameter("@ArtworkID", id));
                        linkCommand.Parameters.Add(new SqlParameter("@GuestID", GuestID));
                        rowsAffectedlink = linkCommand.ExecuteNonQuery();
                    }

                }
                else
                {
                    rowsAffectedlink = -10;
                }

                connection.Close();

                return rowsAffectedlink;
            }
        }

        // override method for adding a record that is for advanced artworks and has a price to differentiate it.
        public static int AddArtwork(string GuestID, decimal price)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int rowsAffectedlink = 0;
                connection.Open();
                SqlCommand AddCommand = new SqlCommand();
                AddCommand.Connection = connection;
                AddCommand.CommandType = System.Data.CommandType.StoredProcedure;
                AddCommand.CommandText = "AddArtwork";
                AddCommand.Parameters.Add(new SqlParameter("@price", price));
                int rowsAffectedAdd = AddCommand.ExecuteNonQuery();
                if (rowsAffectedAdd == 1)
                {
                    SqlCommand GetID = new SqlCommand();
                    GetID.Connection = connection;
                    GetID.CommandType = System.Data.CommandType.StoredProcedure;
                    GetID.CommandText = "GetLatestArtworkID";
                    string id = GetID.ExecuteScalar().ToString();

                    if (id != "")
                    {
                        SqlCommand linkCommand = new SqlCommand();
                        linkCommand.Connection = connection;
                        linkCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        linkCommand.CommandText = "LinkArtwork";
                        linkCommand.Parameters.Add(new SqlParameter("@ArtworkID", id));
                        linkCommand.Parameters.Add(new SqlParameter("@GuestID", GuestID));
                        rowsAffectedlink = linkCommand.ExecuteNonQuery();

                        SqlCommand GetEx = new SqlCommand();
                        GetEx.Connection = connection;
                        GetEx.CommandType = System.Data.CommandType.StoredProcedure;
                        GetEx.CommandText = "GetNextExhibition";
                        string nextExhibition = GetEx.ExecuteScalar().ToString();
                        if (nextExhibition != "")
                        {
                            SqlCommand linkexCommand = new SqlCommand();
                            linkexCommand.Connection = connection;
                            linkexCommand.CommandType = System.Data.CommandType.StoredProcedure;
                            linkexCommand.CommandText = "LinkexArtwork";
                            linkexCommand.Parameters.Add(new SqlParameter("@ArtworkID", id));
                            linkexCommand.Parameters.Add(new SqlParameter("@ExhibitionID", nextExhibition));
                            rowsAffectedlink = linkexCommand.ExecuteNonQuery();
                        }
                    }

                }
                else
                {
                    rowsAffectedlink = -10;
                }

                connection.Close();

                return rowsAffectedlink;
            }
        }

        // method that looks to see if ID exists
        public static bool CheckForID(string ArtworkID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand GetDetails = new SqlCommand();
                GetDetails.Connection = connection;
                GetDetails.CommandType = System.Data.CommandType.StoredProcedure;
                GetDetails.CommandText = "ValidID";
                GetDetails.Parameters.Add(new SqlParameter("@id", ArtworkID));
                object found = GetDetails.ExecuteScalar();
                if (found != null)
                {
                    connection.Close(); 
                    return true;
                }
                else
                {
                    connection.Close(); 
                    return false;
                }
            }
        }

        // method to find out if artwork exists in past exhibitions
        public static string[] CheckForPastExhibition(string ArtworkID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string[] Exhibition = new string[2];
                System.Data.DataSet ds = new System.Data.DataSet();
                SqlCommand GetDetails = new SqlCommand();
                GetDetails.Connection = connection;
                GetDetails.CommandType = System.Data.CommandType.StoredProcedure;
                GetDetails.CommandText = "FindExhibitionCheckFuture";
                GetDetails.Parameters.Add(new SqlParameter("@ArtworkID", ArtworkID));
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.SelectCommand = GetDetails;
                dataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    Exhibition[0] = ds.Tables[0].Rows[0][0].ToString();
                    Exhibition[1] = ds.Tables[0].Rows[0][1].ToString();
                }
                connection.Close();
                return Exhibition;
            }
        }

        //method that uses stored procedure to delete artwork record
        public static int DeleteArtwork(string id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int rowsAffected;
                connection.Open();
                SqlCommand DeleteArt = new SqlCommand();
                DeleteArt.Connection = connection;
                DeleteArt.CommandType = System.Data.CommandType.StoredProcedure;
                DeleteArt.CommandText = "DeleteArtwork";
                DeleteArt.Parameters.Add(new SqlParameter("@id", id));
                rowsAffected= DeleteArt.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }

        //method that uses stored procedure to update artwork record
        public static int UpdateArtwork(string id, decimal price, bool sold)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int rowsAffected;
                connection.Open();
                SqlCommand UpdateArt = new SqlCommand();
                UpdateArt.Connection = connection;
                UpdateArt.CommandType = System.Data.CommandType.StoredProcedure;
                UpdateArt.CommandText = "UpdateArtwork";
                UpdateArt.Parameters.Add(new SqlParameter("@ArtworkID", id));
                UpdateArt.Parameters.Add(new SqlParameter("@salePrice", price));
                UpdateArt.Parameters.Add(new SqlParameter("@Sold", sold));
                rowsAffected = UpdateArt.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }

        // method to fetch the current exhibition of an artwork
        public static string CurrentExhibition(string ArtworkID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand GetDetails = new SqlCommand();
                GetDetails.Connection = connection;
                GetDetails.CommandType = System.Data.CommandType.StoredProcedure;
                GetDetails.CommandText = "GetCurrentExhibitionForArtwork";
                GetDetails.Parameters.Add(new SqlParameter("@ArtworkID", ArtworkID));
                object found = GetDetails.ExecuteScalar();
                if (found != null)
                {
                    connection.Close();
                    return found.ToString();
                }
                else
                {
                    connection.Close();
                    return null;
                }
            }
        }

        // method to get available exhibitions for the artwork
        public static string[] GetExhibitionOptions()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string[] Ex;
                System.Data.DataSet ds = new System.Data.DataSet();
                SqlCommand GetEX = new SqlCommand();
                GetEX.Connection = connection;
                GetEX.CommandType = System.Data.CommandType.StoredProcedure;
                GetEX.CommandText = "GetAvailableExhibitions";
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.SelectCommand = GetEX;
                dataAdapter.Fill(ds);
                int length = ds.Tables[0].Rows.Count;
                Ex = new string[length];
                for (int i = 0; i < length; i++)
                {
                    Ex[i] = ds.Tables[0].Rows[i][0].ToString();
                }
                connection.Close();
                return Ex;
            }
        }

        // method specifically to update the exhibition an artwork is assigned to.
        public static int UpdateArtworkExhibition( string ArtworkID, string ExhibitionID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int rowsAffected;
                connection.Open();
                SqlCommand UpdateArtEx = new SqlCommand();
                UpdateArtEx.Connection = connection;
                UpdateArtEx.CommandType = System.Data.CommandType.StoredProcedure;
                UpdateArtEx.CommandText = "UpdateArtworkExhibition";
                UpdateArtEx.Parameters.Add(new SqlParameter("@ArtworkID", ArtworkID));
                UpdateArtEx.Parameters.Add(new SqlParameter("@ExhibitionID", ExhibitionID));
                rowsAffected = UpdateArtEx.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }
    }
}
