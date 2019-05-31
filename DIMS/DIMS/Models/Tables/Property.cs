using System;
using System.Collections.Generic;

namespace DIMS.Models.Tables
{
    public partial class Property
    {
        public Property()
        {
            Repairpaper = new HashSet<Repairpaper>();
        }

        public int Pno { get; set; }
        public string Dno { get; set; }
        public string Pname { get; set; }
        public int? Pnum { get; set; }
        public string Pstate { get; set; }
        public string Bno { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Repairpaper> Repairpaper { get; set; }
    }
}
