using RNS.Consultancy.Models;
using System;
using System.Windows.Forms;

namespace RNS.Consultant.ManagementSystem.UIForms.EmployeeManagement
{
    public partial class EmployeeRegistration : Form
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
        }

        private void BtnSaveEmployee_Click(object sender, EventArgs e)
        {

            var _employeePeronalDetails = FetchEmployeePersonalDetailsFromUI;
            //var _EmployeeEducationalDetails = FetchEmployeeEducationDetailsFromUI();
            //var _employeeWorkExperinceDetails = FetchWorkExperienceDetailsFromUI();
        }
        Employee FetchEmployeePersonalDetailsFromUI
        {
            get
            {
                Employee _employeePersonalDetails = new Employee
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Gender = rdobtnFemale.Text,
                    DateOfBirth = datetimePickerDOB.Value.ToString(),
                    //MobileNumber=
                    MailingAddress = txtMailingAddress.Text,
                    City = cmbCity.SelectedText,
                    Nationality = cmbNationality.SelectedText,
                    Country = cmbCountry.SelectedText,
                    EmailId = txtEmailAddress.Text
                };

                return _employeePersonalDetails;

            }
        }

        //private EducationDetails FetchEmployeeEducationDetailsFromUI()
        //{

        //    Graduation _graduationDetails = new Graduation
        //    {
        //        InstituteName = txtGraduation.Text,
        //        PassYear = txtYearOfGraduationPass.Text,
        //        CGP = txtGradutionCGP.Text,
        //        Specialization = txtBoxGradSpecilization.Text
        //    };
        //    UnderGraduate _underGraduateDetails = new UnderGraduate
        //    {
        //        InstituteName = txtUnderGraduate.Text,
        //        PassYear = txtUGradualtionPassYear.Text,
        //        CGP = txtUndergraduateCGP.Text,
        //        Specialization = txtBoxUnderGradSpecilization.Text
        //    };
        //    School _schoolingdetails = new School
        //    {
        //        InstituteName = txtSchooling.Text,
        //        PassYear = txtYearofSchoolingPass.Text,
        //        CGP = txtSchoolingCGP.Text,
        //        Specialization = txtBoxSchoolSpecilization.Text
        //    };

        //    EducationDetails _educationdetails = new EducationDetails
        //    {
        //        GraduationDetails = _graduationDetails,
        //        UndergraduateDetails = _underGraduateDetails,
        //        SchoolDetails = _schoolingdetails
        //    };
        //    return _educationdetails;
        //}
        //private WorkExperience FetchWorkExperienceDetailsFromUI()
        //{
        //    Company _firstCompanyDetails = new Company
        //    {
        //        Name = txt1stCompanyName.Text,
        //        WorkStartDate = Convert.ToDateTime(txt1stCompanyWorkYearStarted),
        //        WorkEndDate = Convert.ToDateTime(txt1stCompanyEndWorkYear),
        //        SkillSet = txt1stCompanySpecilisation.Text
        //    };

        //    Company _secondCompanyDetails = new Company
        //    {
        //        Name = txt2ndCompanyName.Text,
        //        WorkStartDate = Convert.ToDateTime(txt2ndCompanyWorkYearStarted),
        //        WorkEndDate = Convert.ToDateTime(txt2ndCompanyEndWorkYear),
        //        SkillSet = txt2ndCompanySpecilisation.Text
        //    };
        //    Company _thirdCompanyDetails = new Company
        //    {
        //        Name = txt3rdCompanyName.Text,
        //        WorkStartDate = Convert.ToDateTime(txt3rdCompanyWorkYearStarted),
        //        WorkEndDate = Convert.ToDateTime(txt3rdCompanyEndWorkYear),
        //        SkillSet = txt3rdCompanySpecilisation.Text
        //    };

        //    var _companies = new List<Company>();
        //    _companies.Add(_firstCompanyDetails);
        //    _companies.Add(_secondCompanyDetails);
        //    _companies.Add(_thirdCompanyDetails);
        //    WorkExperience _workexperince = new WorkExperience
        //    {
        //        Companies = _companies,
        //    };

        //    return _workexperince;
        //}

        void GrpboxEducationDetails_Enter()
        {

        }
    }
}
