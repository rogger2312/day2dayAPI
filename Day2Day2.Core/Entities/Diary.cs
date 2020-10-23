using System;
using System.Collections.Generic;

namespace Day2Day.Core.Entities
{
    public partial class Diary
    {
        public int DiaryId { get; set; }
        public string Text { get; set; }
        public string Result { get; set; }
        public int? IsDone { get; set; }
        public string DateTime { get; set; }
        public int PacientId { get; set; }

        public virtual Pacient Pacient { get; set; }
    }
}
