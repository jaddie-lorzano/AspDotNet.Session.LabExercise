using System;
using System.Collections.Generic;

#nullable disable

namespace WorkSchedule.Data.Entities
{
    public partial class Employee : BaseEntity
    {
        public Employee()
        {
            EmployeeSkills = new HashSet<EmployeeSkill>();
            Schedules = new HashSet<Schedule>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
