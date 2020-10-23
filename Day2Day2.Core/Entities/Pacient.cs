using System;
using System.Collections.Generic;

namespace Day2Day.Core.Entities
{
    public partial class Pacient
    {
        public Pacient()
        {
            Diaries = new HashSet<Diary>();
            Tests = new HashSet<Test>();
        }

        public int PacientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocType { get; set; }
        public string DocNumber { get; set; }
        public string Birthday { get; set; }
        public int? StudyLevel { get; set; }
        public string StudyLevelDescription { get; set; }
        public string Ocupation { get; set; }
        public int? Mobilephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string Department { get; set; }
        public int? Status { get; set; }
        public string StatusDescription { get; set; }
        public int? SpecialistId { get; set; }
        public int? TutorId { get; set; }

        public virtual Specialist Specialist { get; set; }
        public virtual Tutor Tutor { get; set; }
        public virtual ICollection<Diary> Diaries { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
