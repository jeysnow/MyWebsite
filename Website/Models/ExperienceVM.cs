using Logic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
    public class ExperienceVM
    {
        //the tipes and name cases must match database tables
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TagVM> Tags { get; set; }
        public string Employer { get; set; }
        public string PositionTitle { get; set; }
        public string PositionDescription { get; set; }
        public int YearStart { get; set; }
        public int? YearEnd { get; set; }
        public bool CurrentJob { get; set; }
    }
}
