using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMonitoringAndTaskDesignationSystem
{
    interface IUserRepository
    {
        Task<bool> Insert(coachUsers user);
    }
}
