using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WorkSchedule.Data.Entities
{
    public partial class Location : BaseEntity
    {
        public Location()
        {
            PlacementContracts = new HashSet<PlacementContract>();
        }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Street { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string City { get; set; }
        [Column(TypeName = "nchar(2)")]
        public string Province { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Contact { get; set; }
        [Column(TypeName = "char(12)")]
        public string Phone { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<PlacementContract> PlacementContracts { get; set; }
    }
}
