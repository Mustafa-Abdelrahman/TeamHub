using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamHub_MVP.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public User Manager { get; set; }
        //public ICollection<Project> Projects { get; set; }
        //public ICollection<Task> Tasks { get; set; }    
        //public ICollection<Note> Notes { get; set; }
        //public Team Team { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsManager { get; set; }
    }
}
