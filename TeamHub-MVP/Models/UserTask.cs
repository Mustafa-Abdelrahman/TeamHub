using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamHub_MVP.Models
{
    public class UserTask
    {
        public string UserID { get; set; }
        public User User { get; set; }
        public int TaskID { get; set; }
        public Task Task { get; set; }
    }
}
