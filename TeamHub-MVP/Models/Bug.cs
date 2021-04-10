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
        public virtual User ReportedBy { get; set; }
        public virtual User ResolvedBy { get; set; }
        public virtual User UserWokringOn { get; set; }
        public bool IsResolved { get; set; }
        public bool DebuggingIsInProgress { get; set; }
        public virtual Project Project { get; set; }
    }
}
