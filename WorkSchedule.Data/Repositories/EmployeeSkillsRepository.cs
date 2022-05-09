using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSchedule.Data.Data;
using WorkSchedule.Data.DataTransferObjects;
using WorkSchedule.Data.Entities;

namespace WorkSchedule.Data.Repositories
{
    public interface IEmployeeSkillsRepository : IBaseRepository<EmployeeSkill>
    {
        IEnumerable<EmployeeSkillsDTO> GetEmployeeSkillsByEmployeeId(int employeeId);
        Boolean checkExistingSkill(int employeeId, int skillId);
    }
    public class EmployeeSkillsRepository : GenericRepository<EmployeeSkill>, IEmployeeSkillsRepository
    {
        public EmployeeSkillsRepository(WorkScheduleContext context) : base(context)
        {
        }

        public IEnumerable<EmployeeSkillsDTO> GetEmployeeSkillsByEmployeeId(int employeeId)
        {
            var employeeSkills = from e in this.Context.Employees
                                join es in this.Context.EmployeeSkills on e.Id equals es.EmployeeId
                                join s in this.Context.Skills on es.SkillId equals s.Id
                                 where e.Id == employeeId
                                 select new EmployeeSkillsDTO
                                {   
                                    EmployeeId = e.Id,
                                    SkillId = s.Id,
                                    SkillDescription = s.Description
                                };
            if (employeeSkills != null)
            {
                return employeeSkills.ToList();
            }
            return null;
        }

        public Boolean checkExistingSkill(int employeeId, int skillId)
        {
            EmployeeSkill exists = this.Context.EmployeeSkills.Where(x => x.EmployeeId == employeeId && x.SkillId == skillId).FirstOrDefault();
            if(exists != null)
            {
                return true;
            }
            return false;
        }
    }

}
