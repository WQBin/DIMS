using System;
using System.Collections.Generic;

namespace DIMS.Models.Tables
{
    public partial class Repairpaper
    {
        public int Rno { get; set; }
        public string Dno { get; set; }
        public string Bno { get; set; }
        public string Rreasion { get; set; }
        public string Rstate { get; set; }
        public int? Pno { get; set; }

        public virtual Department Department { get; set; }
        public virtual Property PnoNavigation { get; set; }
    }
}
