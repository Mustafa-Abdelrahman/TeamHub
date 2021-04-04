using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamHub_MVP.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SPOC { get; set; }
        public int Percentage { get; set; }

        //Navigation Props
        public ICollection<Team> TeamsInvolved { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<Note> Notes { get; set; }
        public ICollection<User> Assignees { get; set; }
        public ICollection<Bug> Bugs { get; set; }
        public User ProjectOwner { get; set; }
        public Department Department { get; set; }

        //Planned 
        public DateTime PlannedStartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }
        public DateTime PlannedDeliveryDate { get; set; }
        public int EstimatedEffort { get; set; }

        //Actual
        public DateTime ActualStartDate { get; set; }
        public DateTime ActualEndDate { get; set; }
        public DateTime ActualDeliveryDate { get; set; }
        public int ActualEffort { get; set; }

        //Flags
        public bool IsDone { get; set; }
        public bool IsUAT { get; set; }
        public bool IsPPT { get; set; }
        public bool IsProduction { get; set; }
        public bool IsOnHold { get; set; }
        public bool IsInProgress { get; set; }





    }
}
