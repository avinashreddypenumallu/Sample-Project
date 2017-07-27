namespace RNS.Consultancy.Models
{
    public class EmployeeDetails
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public Education Education { get; set; }
        public WorkExperience WorkExperience { get; set; }
    }
}
