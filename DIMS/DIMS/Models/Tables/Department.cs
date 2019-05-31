using System;
using System.Collections.Generic;

namespace DIMS.Models.Tables
{
    public partial class Department
    {
        public Department()
        {
            Property = new HashSet<Property>();
            Repairpaper = new HashSet<Repairpaper>();
            Student = new HashSet<Student>();
        }

        public string Dno { get; set; }
        public string Bno { get; set; }
        public int? Dlivednum { get; set; }

        public virtual Studentbuilding BnoNavigation { get; set; }
        public virtual ICollection<Property> Property { get; set; }
        public virtual ICollection<Repairpaper> Repairpaper { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
