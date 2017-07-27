using System.Data;
using System.Data.SqlClient;
using RNS.Consultant.ManagementSystem.DataLayer;

namespace RNS.Consultancy.DataAccessLayer.DataLayer
{
   public  class DisplayEmployeeData
    {
       
        Connection connection = new Connection();
        private DataTable _dataTable;
        private SqlDataAdapter _sqldataadapterpersonal;
        private SqlCommand _sqlcommand;
        

        public DataTable EmployeeData() {

            _sqlcommand = new SqlCommand("Select FirstName,LastName, CompanyName,Skillset from PersonalDetails PD" +
                "  join EducationDetails ED on PD.Id=ED.EmployeeId" +
                " join WorkExperienceDetails WED on ED.EmployeeId =WED.EmployeeId ", connection.SqlConnection);
        _sqlcommand.CommandType = CommandType.Text;
            _sqldataadapterpersonal = new SqlDataAdapter(_sqlcommand);
        _dataTable = new DataTable();
        _sqldataadapterpersonal.Fill(_dataTable);
            return _dataTable;

            }
            

    }
}
