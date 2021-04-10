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
        public virtual User CreatedBy { get; set; }
        public virtual Project Project { get; set; }
        public virtual Task Task { get; set; }
    }
}
