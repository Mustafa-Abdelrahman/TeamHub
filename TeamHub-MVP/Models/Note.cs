using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamHub_MVP.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public User CreatedBy { get; set; }
        public Project Project { get; set; }
        public Task Task { get; set; }
    }
}
