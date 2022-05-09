using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Data.DataTransferObjects
{
    public class EmployeeSkillsDTO
    {
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }
        public string SkillDescription { get; set; }
    }
}
