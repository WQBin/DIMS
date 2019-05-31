using System;
using System.Collections.Generic;

namespace DIMS.Models.Tables
{
    public partial class Student
    {
        public Student()
        {
            Fastmail = new HashSet<Fastmail>();
            Latereturn = new HashSet<Latereturn>();
            Livingschool = new HashSet<Livingschool>();
        }

        public string Sno { get; set; }
        public string Sname { get; set; }
        public string Spassword { get; set; }
        public string Smajor { get; set; }
        public string Ssex { get; set; }
        public string Dno { get; set; }
        public string Bno { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Fastmail> Fastmail { get; set; }
        public virtual ICollection<Latereturn> Latereturn { get; set; }
        public virtual ICollection<Livingschool> Livingschool { get; set; }
    }
}
