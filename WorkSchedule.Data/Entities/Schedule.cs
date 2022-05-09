using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WorkSchedule.Data.Entities
{
    public partial class Schedule : BaseEntity
    {
        [Column(TypeName = "date")]
        public DateTime Day { get; set; }
        [Column(TypeName = "money")]
        public decimal HourlyWage { get; set; }
        public bool OverTime { get; set; }
        public int ShiftId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
