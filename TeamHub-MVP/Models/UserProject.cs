﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamHub_MVP.Models
{
    public class UserProject
    {
        public string UserID { get; set; }
        public User User { get; set; }
        public int ProjectID { get; set; }
        public Project  Project { get; set; }
    }
}
