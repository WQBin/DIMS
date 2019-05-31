using System;
using System.Collections.Generic;

namespace DIMS.Models.Tables
{
    public partial class Studentbuilding
    {
        public Studentbuilding()
        {
            Department = new HashSet<Department>();
            Fastmail = new HashSet<Fastmail>();
            Latereturn = new HashSet<Latereturn>();
            Livingschool = new HashSet<Livingschool>();
        }

        public string Bno { get; set; }
        public string Bsex { get; set; }
        public int? Bdnum { get; set; }
        public int? Bdsnum { get; set; }
        public string Ano { get; set; }

        public virtual Administer AnoNavigation { get; set; }
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<Fastmail> Fastmail { get; set; }
        public virtual ICollection<Latereturn> Latereturn { get; set; }
        public virtual ICollection<Livingschool> Livingschool { get; set; }
    }
}
