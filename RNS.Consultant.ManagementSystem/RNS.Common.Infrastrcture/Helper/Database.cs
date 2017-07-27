using System.Configuration;

namespace RNS.Common.Infrastrcture
{
    public class Database
    {
        public static string GetDatabaseConnectionstring()
        {
            return ConfigurationManager.ConnectionStrings["DatabaseConnectionstring"].ConnectionString;
        }
    }
}
