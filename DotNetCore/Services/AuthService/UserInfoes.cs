using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using DotNetCore.Data;
using DotNetCore.Data.Entity.EmployeeInfos;
using DotNetCore.Data.Entity;
using DotNetCore.Services.AuthService.Interfaces;
using DotNetCore.Areas.Auth.Models;

namespace DotNetCore.Services.AuthService
{
    public class UserInfoes: IUserInfoes
    {
        private readonly CoreWebDBContext _context;
        public UserInfoes(CoreWebDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EmployeeInfo>> GetAllUserInfo()
        {
            return await _context.employeeInfos.Where(x=>x.ApplicationUserId !=null).Include(x => x.ApplicationUser)
                .Include(x=>x.rank).ToListAsync();
        }

        public async Task<ApplicationUser> GetUserInfoByUser(string userName)
        {
            return await _context.Users.Where(x => x.UserName == userName).FirstOrDefaultAsync();
        }

        public async Task<EmployeeInfo> GetEmployeeInfoByUserName(string userName)
        {
            return await _context.employeeInfos.Where(x => x.ApplicationUser.UserName == userName).Include(x=>x.ApplicationUser).Include(x=>x.rank).FirstOrDefaultAsync();
        }

        public async Task<EmployeeInfo> GetUserInfoByUserId(string userId)
        {
            return await _context.employeeInfos.Where(x => x.ApplicationUserId == userId).Include(x=>x.ApplicationUser)
                .Include(x=>x.religion).Include(x=>x.employeeType).Include(x=>x.department).Include(x=>x.branch)
                .Include(x=>x.rank).Include(x=>x.designations).Include(x=>x.section).Include(x=>x.bCSBatch)
                .FirstOrDefaultAsync();
        }

        public async Task<AspNetUsersViewModel> GetUserInfoByUserName(string userName)
        {
            var result = await (from U in _context.Users
                                join E in _context.employeeInfos on U.Id equals E.ApplicationUserId into EE
                                from emp in EE.DefaultIfEmpty()
                                join pl in _context.sections on emp.sectionId equals pl.Id into pp
                                from PCL in pp.DefaultIfEmpty()
                                join sbu in _context.specialBranchUnits on emp.branchId equals sbu.Id into ssb
                                from sb in ssb.DefaultIfEmpty()
                                join R in _context.ranks on emp.rankId equals R.Id into DD
                                from dpt in DD.DefaultIfEmpty()
                                //join PH in _context.Photographs.Where(x => x.type == "profile").Take(1) on emp.Id equals PH.Id into PP
                                //from P in PP.DefaultIfEmpty()
                                join ur in _context.UserRoles on U.Id equals ur.UserId
                                join ar in _context.Roles on ur.RoleId equals ar.Id
                                join bh in _context.bCSBatches on emp.bCSBatchId equals bh.Id into bbc
                                from bb in bbc.DefaultIfEmpty()
                                where U.UserName == userName

                                select new AspNetUsersViewModel
                                {
                                    aspnetId = U.Id,
                                    userName = U.UserName,
                                    email = U.Email,
                                    empCode = emp.employeeCode,
                                    isActive = (U.isActive == null) ? 0 : U.isActive,
                                    empName = emp.nameEnglish,
                                    employeeId = emp.Id,
                                    sectionName = PCL.Name,
                                    rankName = dpt.rankName,
                                    rankId = emp.rankId,
                                    unitId = emp.branchId,
                                    unitName = sb.branchUnitName,
                                    roleId = ar.Id,
                                    roleName = ar.Name,
                                    batchName = bb.batchName,
                                    joiningDate = emp.joiningDateGovtService,
                                    joiningDatePresentWorkStation = emp.joiningDatePresentWorkstation,
                                    mobileNo = emp.mobileNumberPersonal,
                                    status = emp.isApproved,
                                    //imageUrl = P.url
                                }).FirstOrDefaultAsync();
            return result;
        }

        //public async Task<IEnumerable<AspNetUsersViewModel>> GetUserInfoList()
        //{
        //    var result =await (from a in _context.Users
        //                 select new AspNetUsersViewModel
        //                 {
        //                     userName = a.UserName,
        //                     email = a.Email
        //                 }).ToListAsync();
        //    return result;
        //}

        //public async Task<IEnumerable<AlphaModule>> GetAllAlphaModule()
        //{
        //    return await _context.AlphaModules.AsNoTracking().ToListAsync();
        //}
        public async Task<bool> DeleteUserRoleListByUserId(string Id)
        {
            _context.UserRoles.RemoveRange(_context.UserRoles.Where(x => x.UserId == Id).ToList());
            return 1 == await _context.SaveChangesAsync();
        }
        
        public async Task<bool> DeleteRoleById(string Id)
        {
            _context.Roles.Remove(_context.Roles.Where(x => x.Id == Id).First());
            return 1 == await _context.SaveChangesAsync();
        }

        //public async Task<IEnumerable<AspNetUsersViewModel>> GetUserInfo()
        //{
        //    var result = (from U in _context.Users
        //                  join E in _context.EmployeeInfos on U.Id equals E.ApplicationUserId
        //                  select new AspNetUsersViewModel
        //                  {
        //                      aspnetId = U.Id,
        //                      userName = U.UserName,
        //                      email = U.Email,
        //                      empCode = E.employeeCode,
        //                      isActive = U.isActive,
        //                      empName = E.nameEnglish + " - " + E.employeeCode,
        //                      employeeId = E.Id,
        //                      //DivisionName = EEE.department.deptName

        //                  }).ToListAsync();
        //    return await result;
        //}

        public async Task<IEnumerable<string>> GetRoleListByUserId(string Id)
        {
            return await _context.UserRoles.Where(x => x.UserId == Id).Select(x => x.RoleId).ToListAsync();
        }

        public async Task<IEnumerable<EmployeeInfo>> GetUserInfosFromEmployee()
        {
            var result = await _context.employeeInfos
                .Include(x => x.rank)
                .Include(x => x.designations)
                .Include(x => x.department)
                .Include(x => x.branch)
                .Include(x => x.section)
                .Include(x => x.religion)
                .Include(x => x.rank)
                .Include(x => x.bCSBatch)
                .Include(x => x.ApplicationUser)
                .Where(x=>x.ApplicationUserId != null)
                .ToListAsync();

            return result;
        }

        public async Task<ApplicationUser> GetApplicationUserByUserId(string userId)
        {
            return await _context.Users.Where(x => x.Id == userId).FirstOrDefaultAsync();
        }

        public async Task<int> UserInactiveById(string userId)
        {
            var user= await _context.Users.Where(x => x.Id == userId).FirstOrDefaultAsync();
            if(user != null)
            {
                user.isActive = 0;
                _context.Users.Update(user);
                _context.Entry(user).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public async Task<int> UserActiveById(string userId)
        {
            var user = await _context.Users.Where(x => x.Id == userId).FirstOrDefaultAsync();
            if (user != null)
            {
                user.isActive = 1;
                _context.Users.Update(user);
                _context.Entry(user).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
