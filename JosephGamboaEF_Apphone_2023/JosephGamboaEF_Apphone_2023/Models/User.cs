﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JosephGamboaEF_Apphone_2023.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string UserPassword { get; set; } = null!;
        public int StrikeCount { get; set; }
        public string BackUpEmail { get; set; } = null!;
        public string? JobDescription { get; set; }
        public int UserStatusId { get; set; }
        public int CountryId { get; set; }
        public int UserRoleId { get; set; }

        //public int UserId { get; set; }
        //public string UserName { get; set; } = null!;
        //public string FirstName { get; set; } = null!;
        //public string LastName { get; set; } = null!;
        //public string? PhoneNumber { get; set; }
        //public string UserPassword { get; set; } = null!;
        //public int StrikeCount { get; set; }
        //public string BackUpEmail { get; set; } = null!;
        //public string? JobDescription { get; set; }
        //public int UserStatusId { get; set; }
        //public int CountryId { get; set; }
        //public int UserRoleId { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual UserRole UserRole { get; set; } = null!;
        public virtual UserStatus UserStatus { get; set; } = null!;
    }
}
