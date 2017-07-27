using System;

namespace RNS.Consultancy.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string SkillSet { get; set; }
        public DateTime WorkStartDate { get; set; }
        public DateTime WorkEndDate { get; set; }
    }
}
