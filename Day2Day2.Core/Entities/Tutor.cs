using System;
using System.Collections.Generic;

namespace Day2Day.Core.Entities
{
    public partial class Tutor
    {
        public Tutor()
        {
            Pacients = new HashSet<Pacient>();
        }

        public int TutorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocType { get; set; }
        public string DocNumber { get; set; }
        public string Birthday { get; set; }
        public int? Mobilephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Relation { get; set; }
        public int? Status { get; set; }
        public string StatusDescription { get; set; }

        public virtual ICollection<Pacient> Pacients { get; set; }
    }
}
