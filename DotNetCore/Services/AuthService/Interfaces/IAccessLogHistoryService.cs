using DotNetCore.Data.Entity.EmployeeInfos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCore.Services.AuthService.Interfaces
{
    public interface IAccessLogHistoryService
    {
        Task<int> SaveUserLogHistory(UserLog userLogHistory);

        Task<IEnumerable<UserLog>> GetAllUserLogHistory();

        Task<IEnumerable<UserLog>> GetUserLogHistoryByUser(string userName);
    }
}
