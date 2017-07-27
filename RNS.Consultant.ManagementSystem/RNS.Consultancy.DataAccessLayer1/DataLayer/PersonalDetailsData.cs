using System.Data;
using System.Data.SqlClient;

namespace RNS.Consultant.ManagementSystem.DataLayer
{
    class PersonalDetailsData
    {
        
        public DataTable GetPersonalDetails()
        {
            DataTable PersonalDatatable = new DataTable();
            Connection personaldetailsdata = new Connection();
            
            if (ConnectionState.Closed == personaldetailsdata.SqlConnection.State)
            {
                personaldetailsdata.SqlConnection.Open();
            }
            SqlCommand personaldetailscommand = new SqlCommand("Select * from PersonalDetails",personaldetailsdata.SqlConnection);
            try
            {
                SqlDataReader _sqldatareader = personaldetailscommand.ExecuteReader();
                PersonalDatatable.Load(_sqldatareader);
                return PersonalDatatable;
            }
            catch
            {
                throw;
            }
        }
        public DataTable UpdatePersonalDetails(int Id)
        {
            DataTable PersonalDatatable = new DataTable();
            Connection personaldetailsdata = new Connection();

            if (ConnectionState.Closed == personaldetailsdata._sqlcommonconnection.State)
            {
                personaldetailsdata._sqlcommonconnection.Open();
            }
            SqlCommand personaldetailscommand = new SqlCommand("Select * from PersonalDetails", personaldetailsdata._sqlcommonconnection);
            try
            {
                SqlDataReader _sqldatareader = personaldetailscommand.ExecuteReader();
                PersonalDatatable.Load(_sqldatareader);
                return PersonalDatatable;
            }
            catch
            {
                throw;
            }

            finally
            {
                personaldetailsdata._sqlcommonconnection.Close();
            }
        }
        public DataTable DeletePersonalDetails(int Id)
        {
            DataTable PersonalDatatable = new DataTable();
            Connection personaldetailsdata = new Connection();

            if (ConnectionState.Closed == personaldetailsdata._sqlcommonconnection.State)
            {
                personaldetailsdata._sqlcommonconnection.Open();
            }
            SqlCommand personaldetailscommand = new SqlCommand("Select * from PersonalDetails", personaldetailsdata._sqlcommonconnection);
            try
            {
                SqlDataReader _sqldatareader = personaldetailscommand.ExecuteReader();
                PersonalDatatable.Load(_sqldatareader);
                return PersonalDatatable;
            }
            catch
            {
                throw;
            }
        }
        public DataTable InsertPersonalDetails()
        {
            DataTable PersonalDatatable = new DataTable();
            Connection personaldetailsdata = new Connection();

            if (ConnectionState.Closed == personaldetailsdata._sqlcommonconnection.State)
            {
                personaldetailsdata._sqlcommonconnection.Open();
            }
            SqlCommand personaldetailscommand = new SqlCommand("Select * from PersonalDetails", personaldetailsdata._sqlcommonconnection);
            try
            {
                SqlDataReader _sqldatareader = personaldetailscommand.ExecuteReader();
                PersonalDatatable.Load(_sqldatareader);
                return PersonalDatatable;
            }
            catch
            {
                throw;
            }
        }
    }
}
