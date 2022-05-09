using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WorkSchedule.Data.Entities
{
    public partial class Skill : BaseEntity
    {
        public Skill()
        {
            EmployeeSkills = new HashSet<EmployeeSkill>();
        }
        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }
        public bool? RequiresTicket { get; set; }

        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
