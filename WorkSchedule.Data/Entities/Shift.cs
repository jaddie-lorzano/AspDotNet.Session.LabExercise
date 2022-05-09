using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WorkSchedule.Data.Entities
{
    public partial class Shift : BaseEntity
    {
        public Shift()
        {
            Schedules = new HashSet<Schedule>();
        }
        public int DayOfWeek { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan StartTime { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan EndTime { get; set; }
        [Column(TypeName = "tinyint")]
        public byte NumberOfEmployees { get; set; }
        public bool Active { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? Note { get; set; }
        public int PlacementContractId { get; set; }

        public virtual PlacementContract PlacementContract { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
