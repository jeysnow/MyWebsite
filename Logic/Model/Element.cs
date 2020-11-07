using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Logic.Model
{
    public class Element
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
