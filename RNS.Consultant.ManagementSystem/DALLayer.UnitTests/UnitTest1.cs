using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RNS.Consultancy.DataAccessLayer.DataModels;
using RNS.Consultancy.Models;
using System.Collections.Generic;

namespace DALLayer.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertEmployeeRecord()
        {
            EmployeeDetail _employeeDetails = FillEmployeeMockData();
            using (EmployeeContext employeeContext = new EmployeeContext())
            {
                employeeContext.EmployeeDetails.Add(_employeeDetails);
                var _employeeDetailid = employeeContext.SaveChanges();
                Assert.AreEqual(7, _employeeDetailid);
            }

        }

         static EmployeeDetail FillEmployeeMockData()
        {
            var _employee = new Employee
            {
                FirstName = @"Narendra",
                LastName = @"Venkata",
                EmailId = @"Narendra472@gmail.com",
                DateOfBirth = DateTime.Now.ToString(),
                City = @"Bangalore",
                Country = @"India",
                Gender = @"Male",
                MobileNumber = @"9729771566",
                Nationality = @"Indian"
            };
            Company _company = new Company
            {
                Name = @"BallyTechnologies",
                WorkStartDate = Convert.ToDateTime("2011-03-21 18:06:46.240"),
                WorkEndDate = Convert.ToDateTime("2013-03-21 18:06:46.240"),
                Country = @"India",
                City = @"Bangalore",
                SkillSet = @".Net",
            };
            Company _company2 = new Company
            {
                Name = @"Morganstanley",
                WorkStartDate = Convert.ToDateTime("2013-03-21 18:06:46.240"),
                WorkEndDate = Convert.ToDateTime("2015-03-21 18:06:46.240"),
                Country = @"India",
                City = @"Bangalore",
                SkillSet = @".Net",
            };
            Company _company3 = new Company
            {
                Name = @"Inlogic",
                WorkStartDate = Convert.ToDateTime("2015-03-21 18:06:46.240"),
                WorkEndDate = Convert.ToDateTime("2017-03-21 18:06:46.240"),
                Country = @"India",
                City = @"Chennai",
                SkillSet = @".Net",
            };

            var Companies = new List<Company>
            {
                _company,
                _company2,
                _company3
            };
            EducationDetail _educationDetail = new EducationDetail
            {
                InstituteName = "Murthy Inistitute of Technology and Science",
                CGP = "3.4",
                PassYear = "2010",
                Specialization = "CSIT"
            };
            EmployeeDetail _employeeDetails = new EmployeeDetail
            {
                Companies = Companies,
                Educationdetai = _educationDetail,
                Employee = _employee
            };
            return _employeeDetails;
        }
    }
}
