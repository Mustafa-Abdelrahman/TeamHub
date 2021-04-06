using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamHub_MVP.Models
{
    public class Area
    {
        public int ID { get; set; }
        public string Name { get; set; }
          public User AreaManager { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
