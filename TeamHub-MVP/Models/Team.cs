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
        public User Manager { get; set; }
        public ICollection<User> Members { get; set; }
        public Area Area { get; set; }
    }
}
