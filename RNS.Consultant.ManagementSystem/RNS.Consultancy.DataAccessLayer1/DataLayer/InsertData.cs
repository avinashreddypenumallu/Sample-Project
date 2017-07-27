using System;
using System.Data;
using System.Data.SqlClient;
using RNS.Consultant.ManagementSystem.Models;

namespace RNS.Consultant.ManagementSystem.DataLayer

{
    public class InsertData
    {
        private EmployeeDetails _employeedetails;
        
        private int _educationalDetails;
        private int _workexpereinceResult;

        public void saveuserdetails(EmployeeDetails employeedetails)
        {
            Connection insertdata = new Connection();

            if (ConnectionState.Closed == insertdata.SqlConnection.State)
            {
                insertdata.SqlConnection.Open();
            }
            try
            {
                SqlCommand _sqlcommand = new SqlCommand("Insert into  PersonalDetails(FirstName,LastName,DateOfBirth,Address) values(@FirstName,@LastName,@DateOfBirth,@Address)" + "SELECT CAST(scope_identity() AS int)", insertdata.SqlConnection);
                _sqlcommand.CommandType = CommandType.Text;
                _employeedetails = employeedetails;
                _sqlcommand.Parameters.AddWithValue("@FirstName", _employeedetails.Employee.FirstName);
                _sqlcommand.Parameters.AddWithValue("@LastName", _employeedetails.Employee.LastName);
                _sqlcommand.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(_employeedetails.Employee.DateOfBirth));
                _sqlcommand.Parameters.AddWithValue("@Address", _employeedetails.Employee.MailingAddress);
                int _recentlyInsertedemployeeid = (int)_sqlcommand.ExecuteScalar();
                if (_recentlyInsertedemployeeid > 0)
                {
                    SqlCommand _sqlcommandeducation = new SqlCommand("Insert into  EducationDetails" +
                   "(EducationLevel,Specialization,InstitutionName,YearOfPassing,EmployeeId) " +
                   "values(@EducationLevel,@Specialization,@InstitutionName,@YearOfPassing,@EmployeeId)", insertdata.SqlConnection);
                    _sqlcommandeducation.CommandType = CommandType.Text;
                    _sqlcommandeducation.Parameters.AddWithValue("@EducationLevel", _employeedetails.Education.EducationLevel);
                    _sqlcommandeducation.Parameters.AddWithValue("@Specialization", _employeedetails.Education.Specialization);
                    _sqlcommandeducation.Parameters.AddWithValue("@InstitutionName", _employeedetails.Education.InstitutionName);
                    _sqlcommandeducation.Parameters.AddWithValue("@YearOfPassing", _employeedetails.Education.EndYear);
                    _sqlcommandeducation.Parameters.AddWithValue("@EmployeeId", _recentlyInsertedemployeeid);
                    _educationalDetails = _sqlcommandeducation.ExecuteNonQuery();
                    SqlCommand _sqlcommandworkexperience = new SqlCommand("Insert into  WorkExperienceDetails(CompanyName,[From],[To],Skillset,EmployeeId) values(@CompanyName,@From,@To,@Skillset,@EmployeeId)", insertdata.SqlConnection);
                    _sqlcommandworkexperience.Parameters.AddWithValue("@CompanyName", _employeedetails.WorkExperience.FirstCompanyName);
                    _sqlcommandworkexperience.Parameters.AddWithValue("@From", Convert.ToInt16(_employeedetails.WorkExperience.From));
                    _sqlcommandworkexperience.Parameters.AddWithValue("@To", Convert.ToInt16(_employeedetails.WorkExperience.To));
                    _sqlcommandworkexperience.Parameters.AddWithValue("@Skillset", _employeedetails.WorkExperience.Skillset);
                    _sqlcommandworkexperience.Parameters.AddWithValue("@EmployeeId", _recentlyInsertedemployeeid);
                    _workexpereinceResult = _sqlcommandworkexperience.ExecuteNonQuery();
                    var resultmessage = (_educationalDetails + _workexpereinceResult) > 0 ? "Employee Details saved success fully" :
                           "Employee Details not saved success fully";
                   // MessageBox.Show(resultmessage);
                   
                }
                else
                {
                   // MessageBox.Show("Employee Personal details not saved successfully");
                }

            }
           /* catch (Exception ex)
            {
                // MessageBox.Show("exception occured  in while saving the employee details data", ex.Message);
                throw;
            }*/
            finally
            {
                insertdata.SqlConnection.Close();
            }
        }
    }

}


