using System;
using System.Collections.Generic;

namespace DIMS.Models.Tables
{
    public partial class Administer
    {
        public Administer()
        {
            Studentbuilding = new HashSet<Studentbuilding>();
        }

        public string Ano { get; set; }
        public string Aname { get; set; }
        public string Apassword { get; set; }
        public string Atype { get; set; }

        public virtual ICollection<Studentbuilding> Studentbuilding { get; set; }
    }
}
