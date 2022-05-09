using System;
using System.Collections.Generic;

#nullable disable

namespace WorkSchedule.Data.Entities
{
    public partial class Skill : BaseEntity
    {
        public Skill()
        {
            EmployeeSkills = new HashSet<EmployeeSkill>();
        }
        public string Description { get; set; }
        public bool? RequiresTicket { get; set; }

        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
