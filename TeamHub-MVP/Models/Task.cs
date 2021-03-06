using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamHub_MVP.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<UserTask> Users { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual User FinishedBy { get; set; }
        public virtual User UpdatedBy { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public bool IsInProgress { get; set; }
        public bool IsFinished { get; set; }
        public bool IsOnHold { get; set; }
        public int Precentage { get; set; }
        public DateTime StartedOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public DateTime FinishedOn { get; set; }
        public  TimeSpan ElapsedTime { get; set; }
    }
}
