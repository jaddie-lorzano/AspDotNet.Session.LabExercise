using System;
using System.Collections.Generic;

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
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public byte NumberOfEmployees { get; set; }
        public bool Active { get; set; }
        public string Note { get; set; }
        public int PlacementContractId { get; set; }

        public virtual PlacementContract PlacementContract { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
