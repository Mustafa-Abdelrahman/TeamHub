using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamHub_MVP.Models
{
    public class Bug
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public DateTime FoundDate { get; set; }
        public DateTime DebuggingStartDate { get; set; }
        public DateTime DebuggingEndDate { get; set; }
        public User ReportedBy { get; set; }
        public User ResolvedBy { get; set; }
        public bool IsResolved { get; set; }
        public bool DebuggingIsInProgress { get; set; }
        public Project Project { get; set; }
    }
}
