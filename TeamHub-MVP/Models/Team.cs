using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamHub_MVP.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public virtual User Manager { get; set; }
        //public virtual ICollection<User> Members { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
