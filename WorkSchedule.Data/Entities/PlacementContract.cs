using System;
using System.Collections.Generic;

#nullable disable

namespace WorkSchedule.Data.Entities
{
    public partial class PlacementContract : BaseEntity
    {
        public PlacementContract()
        {
            Shifts = new HashSet<Shift>();
        }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LocationId { get; set; }

        public virtual Location Location { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
    }
}
