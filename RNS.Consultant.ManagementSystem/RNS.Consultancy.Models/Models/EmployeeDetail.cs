using System.Collections.Generic;

namespace RNS.Consultancy.Models
{
    public class EmployeeDetail
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public EducationDetail Educationdetai { get; set; }
        public List<Company> Companies { get; set; }
    }
}
