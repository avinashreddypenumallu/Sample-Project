using RNS.Common.Infrastrcture;
using System.Data.SqlClient;

namespace RNS.Consultant.ManagementSystem.DataLayer
{

    public class Connection
    {
        public SqlConnection _sqlcommonconnection = new SqlConnection(Database.GetDatabaseConnectionstring());
    }
}
