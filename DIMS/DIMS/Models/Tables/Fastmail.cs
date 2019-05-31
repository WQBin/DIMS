using System;
using System.Collections.Generic;

namespace DIMS.Models.Tables
{
    public partial class Fastmail
    {
        public int Fno { get; set; }
        public string Sno { get; set; }
        public int? Fnum { get; set; }
        public DateTime? Farrivedate { get; set; }
        public DateTime? Freceivedate { get; set; }
        public string Fstate { get; set; }
        public string Bno { get; set; }

        public virtual Studentbuilding BnoNavigation { get; set; }
        public virtual Student SnoNavigation { get; set; }
    }
}
