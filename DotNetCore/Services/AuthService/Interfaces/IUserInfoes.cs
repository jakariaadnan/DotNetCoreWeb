using DotNetCore.Areas.Auth.Models;
using DotNetCore.Data.Entity;
using DotNetCore.Data.Entity.EmployeeInfos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCore.Services.AuthService.Interfaces
{
    public interface IUserInfoes
    {
        Task<IEnumerable<EmployeeInfo>> GetAllUserInfo();
        Task<ApplicationUser> GetUserInfoByUser(string userName);
        Task<ApplicationUser> GetApplicationUserByUserId(string userId);
        Task<EmployeeInfo> GetEmployeeInfoByUserName(string userName);
        Task<AspNetUsersViewModel> GetUserInfoByUserName(string userName);
        //Task<IEnumerable<AspNetUsersViewModel>> GetUserInfoList();
        //Task<IEnumerable<AlphaModule>> GetAllAlphaModule();
        Task<bool> DeleteUserRoleListByUserId(string Id);
        Task<bool> DeleteRoleById(string Id);
        Task<EmployeeInfo> GetUserInfoByUserId(string userId);
        //Task<IEnumerable<AspNetUsersViewModel>> GetUserInfo();
        Task<IEnumerable<string>> GetRoleListByUserId(string Id);
        Task<IEnumerable<EmployeeInfo>> GetUserInfosFromEmployee();
        Task<int> UserInactiveById(string userId);
        Task<int> UserActiveById(string userId);
    }
}
