﻿using System;
using System.Collections.Generic;

namespace DIMS.Models.Tables
{
    public partial class Livingschool
    {
        public int Lno { get; set; }
        public string Sno { get; set; }
        public DateTime? Llivingdate { get; set; }
        public DateTime? Lreturndate { get; set; }
        public string Bno { get; set; }

        public virtual Studentbuilding BnoNavigation { get; set; }
        public virtual Student SnoNavigation { get; set; }
    }
}
