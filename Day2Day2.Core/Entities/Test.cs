using System;
using System.Collections.Generic;

namespace Day2Day.Core.Entities
{
    public partial class Test
    {
        public int TestId { get; set; }
        public string TestName { get; set; }
        public string Result { get; set; }
        public int? IsDone { get; set; }
        public string DateTime { get; set; }
        public int PacientId { get; set; }

        public virtual Pacient Pacient { get; set; }
    }
}
