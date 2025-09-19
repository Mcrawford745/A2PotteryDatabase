using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PotteryDBA_V1._0.Methods
{
    public class Address : IComparable
    {
        // addributes of an address for a guest
        private string StreetAddress;
        private string City;
        private string Country;

        public string AddressLine1
        {
            get { return StreetAddress; }
            set { StreetAddress = value; }
        }

        public string Addressline2
        {
            get { return City; }
            set { City = value; }
        }

        public string Addressline3
        {
            get { return Country; }
            set { Country = value; }
        }

        // constructor that spits the string into attributes, and catches incorrect addresses using custom exception
        public Address(string address)
        {
            
            try
            {
                string[] temp = address.Split(',');
                ValidateAddress(temp, address);
                StreetAddress = temp[0];
                City = temp[1];
                Country = temp[2];
            }
            catch (InvalidAddressFormatException)
            {
                MessageBox.Show("Sort by Country is currently unavailable due to\nan incorrectly formatted Address in the system. Please \ndelete any records without full Address.");
            }

        }

        // method to validate addresses
        private static void ValidateAddress(string[] address, string addressfull)
        {
            if (address.Length != 3) 
            { 
                throw new InvalidAddressFormatException(addressfull);
            }
        }

        // custom compare to that allows for object comparison
        public int CompareTo(object incoming)
        {
            int returnval = 0;
            try
            {
                Address incomingAddress = incoming as Address;
                returnval = Country.CompareTo(incomingAddress.Country);
            }
            catch (Exception)
            {

            }
            return returnval;

        }

        public static void AddressSort(DataGridView dgv)
        {
            // take searched dgv, perform sort

            // creates a datatable from datagridview
            DataTable dt = new DataTable();
            dt.Columns.Add("GuestID");
            dt.Columns.Add("Forename");
            dt.Columns.Add("Surname");
            dt.Columns.Add("ContactNo");
            dt.Columns.Add("HomeAddress");
            dt.Columns.Add("SkillLevel");

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }

            // creates a temporary table to stop datarow already belongs to table error
            DataTable temptable = new DataTable();
            temptable.Columns.Add("GuestID");
            temptable.Columns.Add("Forename");
            temptable.Columns.Add("Surname");
            temptable.Columns.Add("ContactNo");
            temptable.Columns.Add("HomeAddress");
            temptable.Columns.Add("SkillLevel");

            //turns existing table from dgv into a dataview that can be sorted
            DataView dv = new DataView(dt);
            // turns into an array list
            ArrayList lst = new ArrayList();
            lst.AddRange(dv.Table.Rows);
            // uses custom address Icomparer to sort by country
            lst.Sort(new MyComparer());
            foreach (DataRow dr in lst)
            {
                temptable.ImportRow(dr);
            }

            // sets the sorted table as a source for the data grid view
            dgv.DataSource = temptable;
        }
    }


    // CUSTOM EXCEPTION for invalid adresses
    [Serializable]
    class InvalidAddressFormatException : Exception
    {
        public InvalidAddressFormatException()
        {

        }
        public InvalidAddressFormatException(string address) : base(String.Format("{0} is not a valid address format.", address))
        { 
            
        } 
    }


    // custom comparer that turns a cell from a row into an address object
    class MyComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            DataRow rx = x as DataRow;
            DataRow ry = y as DataRow;
            Address addressX = new Address(rx[4].ToString().Trim());
            Address addressY = new Address(ry[4].ToString().Trim());
            AddressComparer compared = new AddressComparer();
            try
            {
                return compared.Compare(addressX, addressY);
            }
            catch(Exception)
            {
                return 0;
            }
        }
    }


    // custom Icomparer for address objects
    public class AddressComparer : IComparer
    {

        public int Compare(object x, object y)
        {
            return this.CompareAddresses(x as Address, y as Address);
        }

        public int CompareAddresses(Address x, Address y)
        {
            Address addressA = x as Address;
            Address addressB = y as Address;
            try
            {
                if (addressA.CompareTo(addressB) < 0)
                {
                    return -1;
                }
                else if (addressA.CompareTo(addressB) > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}