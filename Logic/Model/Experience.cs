using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Model
{
    public class Experience: Element
    {
        public string Employer { get; set; }
        public string PositionTitle { get; set; }
        public string PositionDescription { get; set; }
        public int YearStart { get; set; }
        public int? YearEnd { get; set; }
        public bool CurrentJob { get; set; }
        
    }
}
