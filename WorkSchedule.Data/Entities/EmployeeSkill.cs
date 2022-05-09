using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WorkSchedule.Data.Entities
{
    public partial class EmployeeSkill : BaseEntity
    {
        public int? Level { get; set; }
        public int? YearsOfExperience { get; set; }
        [Column(TypeName = "money")]
        public decimal? HourlyWage { get; set; }
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
