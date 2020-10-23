﻿using System;
using System.Collections.Generic;

namespace Day2Day.Core.Entities
{
    public partial class Specialist
    {
        public Specialist()
        {
            Pacients = new HashSet<Pacient>();
        }

        public int SpecialistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocType { get; set; }
        public string DocNumber { get; set; }
        public string Birthday { get; set; }
        public string CollegeNumber { get; set; }
        public string Speciality { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Company { get; set; }
        public string Job { get; set; }
        public int? Status { get; set; }
        public string StatusDescription { get; set; }

        public virtual ICollection<Pacient> Pacients { get; set; }
    }
}
