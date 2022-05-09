using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required(ErrorMessage = "This field is required. Please enter your First Name."), Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required. Please enter your Last Name."), Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }
        [Column(TypeName = "char(12)")]
        [MaxLength(12)]
        [RegularExpression(@"((^(\d){12}$)|(^\d{11}$))", ErrorMessage = "Please enter a valid phone number. (E.g. 639123456789)")]
        public string HomePhone { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
