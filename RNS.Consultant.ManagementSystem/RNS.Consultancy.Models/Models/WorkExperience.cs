using System.Collections.Generic;

namespace RNS.Consultancy.Models
{
    public class WorkExperience
    {
        public WorkExperience() { }
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public List<Company> Companies { get; set; }
    }
}
