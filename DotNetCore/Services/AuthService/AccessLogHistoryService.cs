using DotNetCore.Data;
using DotNetCore.Data.Entity.EmployeeInfos;
using DotNetCore.Services.AuthService.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCore.Services.AuthService
{
    public class AccessLogHistoryService: IAccessLogHistoryService
    {
        private readonly CoreWebDBContext _context;

        public AccessLogHistoryService(CoreWebDBContext context)
        {
            _context = context;
        }

        public async Task<int> SaveUserLogHistory(UserLog userLogHistory)
        {
            try
            {
                if (userLogHistory.Id != 0)
                {
                    _context.UserLogs.Update(userLogHistory);
                }
                else
                {
                    _context.UserLogs.Add(userLogHistory);
                }

                await _context.SaveChangesAsync();
                return userLogHistory.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<UserLog>> GetAllUserLogHistory()
        {
            //return await _context.UserLogs.Select(x => new UserLog { userId = x.userId, logTime = x.logTime, ipAddress = x.ipAddress, statusName = x.status == 1 ? "Logged In" : x.status == 0 ? "Logged Out" : "Logged Off" }).ToListAsync();
            return await _context.UserLogs.ToListAsync();
        }

        public async Task<IEnumerable<UserLog>> GetUserLogHistoryByUser(string userName)
        {
            return await _context.UserLogs.Where(x => x.createdBy == userName).ToListAsync();
        }

    }
}
