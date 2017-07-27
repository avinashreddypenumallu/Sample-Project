using RNS.Common.Infrastrcture;
using System.Data.SqlClient;

namespace RNS.Consultant.ManagementSystem.DataLayer
{
    public class Connection
    {
        private SqlConnection _sqlConnection;
        public Connection()
        {
            _sqlConnection = new SqlConnection(Database.GetDatabaseConnectionstring());
        }
        public SqlConnection SqlConnection { get { return _sqlConnection; } private set { _sqlConnection = value; } }
    }
}
