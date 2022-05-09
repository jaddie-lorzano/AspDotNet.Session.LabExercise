using System;
using System.Collections.Generic;

#nullable disable

namespace WorkSchedule.Data.Entities
{
    public partial class EmployeeSkill
    {
        public int Id { get; set; }
        public int? Level { get; set; }
        public int? YearsOfExperience { get; set; }
        public decimal? HourlyWage { get; set; }
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
