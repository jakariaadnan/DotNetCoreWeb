using DotNetCore.Data;
using DotNetCore.Data.Entity.EmployeeInfos;
using DotNetCore.Data.Entity.MasterData;
using DotNetCore.Services.Employee.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly CoreWebDBContext _context;

        public EmployeeService(CoreWebDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Rank>> GetRankWiseCount()
        {
            var result = await (from rank in _context.Ranks
                                join emp in _context.EmployeeInfos on rank.Id equals emp.rankId
                                select rank).ToListAsync();

            return result;
        }

        public async Task<IEnumerable<EmployeeInfo>> GetEmployeeForChartJs()
        {
            var result = await _context.EmployeeInfos
                .Include(x => x.rank)
                .Include(x => x.section.specialBranchUnit)
                ///.Where(x => x.servicePeriod >)
                .ToListAsync();
            return result;
        }

        public void UpdateEmployeeInfoStatusById(int empId, int status)
        {
            var user = _context.EmployeeInfos.Find(empId);
            user.isApproved = status;
            user.updatedAt = DateTime.Now;
            _context.Entry(user).State = EntityState.Modified;

            _context.SaveChanges();
        }
        public async Task<int> SaveEmployeeInformation(EmployeeInfo employeeInfo)
        {
            try
            {
                if (employeeInfo.Id != 0)
                {
                    _context.EmployeeInfos.Update(employeeInfo);
                }
                else
                {
                    _context.EmployeeInfos.Add(employeeInfo);
                }

                await _context.SaveChangesAsync();
                return employeeInfo.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<EmployeeInfo> GetEmployeeInfoById(string empCode)
        {
            var result = await _context.EmployeeInfos
                .Include(x => x.rank)
                .Include(x => x.designations)
                .Include(x => x.branch)
                .Include(x => x.section)
                .Include(x => x.religion)
                .Include(x => x.rank)
                .Include(x => x.bCSBatch)
                .Where(x => x.employeeCode == empCode).AsNoTracking().FirstOrDefaultAsync();
            return result;
        }

        public async Task<EmployeeInfo> GetEmployeeInfoSingleById(string empCode)
        {
            var result = await _context.EmployeeInfos
                .Where(x => x.employeeCode == empCode).AsNoTracking().FirstOrDefaultAsync();
            return result;
        }
        public async Task<EmployeeInfo> GetEmployeeProfileInfoById(int id)
        {
            var result = await _context.EmployeeInfos
                .Include(x => x.rank)
                .Include(x => x.designations)
                .Include(x => x.branch)
                .Include(x => x.section)
                .Include(x => x.religion)
                .Include(x => x.rank)
                .Include(x => x.bCSBatch)
                .Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public EmployeeInfo GetBasicEmployeeInfoById(int id)
        {
            var result = _context.EmployeeInfos.Find(id);
            return result;
        }
        public async Task<EmployeeInfo> GetEmployeeInfosByEmpId(int empId)
        {
            var result = await _context.EmployeeInfos
                .Include(x => x.rank)
                .Include(x => x.designations)
                .Include(x => x.department)
                .Include(x => x.branch)
                .Include(x => x.section)
                .Include(x => x.religion)
                .Include(x => x.rank)
                .Include(x => x.bCSBatch)
                .Where(x => x.Id == empId)
                .FirstOrDefaultAsync();

            return result;
        }

        public async Task<IEnumerable<EmployeeInfo>> GetEmployeeInfos()
        {
            var result = await _context.EmployeeInfos
                .Include(x => x.rank)
                .Include(x => x.designations)
                .Include(x => x.department)
                .Include(x => x.branch)
                .Include(x => x.section)
                .Include(x => x.religion)
                .Include(x => x.rank)
                .Include(x => x.bCSBatch)
                .ToListAsync();

            return result;
        }

        public async Task<IEnumerable<EmployeeInfo>> GetEmployeeInfoList(int statusId)
        {
            if (statusId == 0) // All Employee
            {
                return await _context.EmployeeInfos
                .Include(x => x.rank)
                .Include(x => x.designations)
                .Include(x => x.department)
                .Include(x => x.branch)
                .Include(x => x.section)
                .Include(x => x.religion)
                .Include(x => x.rank)
                .Include(x => x.bCSBatch)
                .ToListAsync();
            }
            else if (statusId == 1)
            {
                return await _context.EmployeeInfos
              .Include(x => x.rank)
              .Include(x => x.designations)
              .Include(x => x.department)
              .Include(x => x.branch)
              .Include(x => x.section)
              .Include(x => x.religion)
              .Include(x => x.rank)
              .Include(x => x.bCSBatch)
              .Where(x => x.isApproved == 1 || x.isApproved == 2)
              .ToListAsync();
            }
            else
            {
                return await _context.EmployeeInfos
              .Include(x => x.rank)
              .Include(x => x.designations)
              .Include(x => x.department)
              .Include(x => x.branch)
              .Include(x => x.section)
              .Include(x => x.religion)
              .Include(x => x.rank)
              .Include(x => x.bCSBatch)
              .Where(x => x.isApproved == statusId)
              .ToListAsync();
            }



        }

        public async Task<IEnumerable<EmployeeInfo>> GetCheckedEmployeeInfoList()
        {
            var result = await _context.EmployeeInfos
          .Include(x => x.rank)
          .Include(x => x.designations)
          .Include(x => x.department)
          .Include(x => x.branch)
          .Include(x => x.section)
          .Include(x => x.religion)
          .Include(x => x.rank)
          .Include(x => x.bCSBatch)
          .ToListAsync();

            return result;
        }

        public async Task<IEnumerable<EmployeeInfo>> GetCheckedUpdatedEmployeeInfoList()
        {
            return await _context.EmployeeInfos
          .Include(x => x.rank)
          .Include(x => x.designations)
          .Include(x => x.department)
          .Include(x => x.branch)
          .Include(x => x.section)
          .Include(x => x.religion)
          .Include(x => x.rank)
          .Include(x => x.bCSBatch)
          .ToListAsync();
        }

        public async Task<IEnumerable<EmployeeInfo>> LoadCheckedUpdatedEmployeeInfoList(int rankId, int unitId, int batchId)
        {
            return await _context.EmployeeInfos.Where(x => x.rankId == (rankId == 0 ? x.rankId : rankId) && x.branchId == (unitId == 0 ? x.branchId : unitId) && x.bCSBatchId == (batchId == 0 ? x.bCSBatchId : batchId))
          .Include(x => x.rank)
          .Include(x => x.designations)
          .Include(x => x.department)
          .Include(x => x.branch)
          .Include(x => x.section)
          .Include(x => x.religion)
          .Include(x => x.rank)
          .Include(x => x.bCSBatch)
          .Where(x => x.isApproved == 8)
          .ToListAsync();
        }

        public async Task<IEnumerable<EmployeeInfo>> GetCheckedUpdatedEmployeeInfoListUpdate()
        {
            return await _context.EmployeeInfos
          .Include(x => x.rank)
          .Include(x => x.designations)
          .Include(x => x.department)
          .Include(x => x.branch)
          .Include(x => x.section)
          .Include(x => x.religion)
          .Include(x => x.rank)
          .Include(x => x.bCSBatch)
          .ToListAsync();
        }

        public async Task<IEnumerable<EmployeeInfo>> GetOverDueEmployeeInfoList()
        {
            return await _context.EmployeeInfos
          .Include(x => x.rank)
          .Include(x => x.branch)
          .Include(x => x.section)
          .Include(x => x.bCSBatch)
          .Where(x => Convert.ToDateTime(x.joiningDatePresentWorkstation).Date < DateTime.Now.AddYears(-2))
          .Where(x => x.joiningDatePresentWorkstation != null)
          .Where(x => x.employeeTypeId == 1)
          .OrderBy(x => x.joiningDatePresentWorkstation)
          .ToListAsync();
        }

        public async Task<IEnumerable<EmployeeInfo>> GetOverDueEmployeeInfoListFilter(int rank, int unit, int batch)
        {
            return await _context.EmployeeInfos
          .Include(x => x.rank)
          .Include(x => x.branch)
          .Include(x => x.section)
          .Include(x => x.bCSBatch)
          .Where(x => Convert.ToDateTime(x.joiningDatePresentWorkstation).Date < DateTime.Now.AddYears(-2))
          .Where(x => x.branchId == (unit == 0 ? x.branchId : unit) && x.rankId == (rank == 0 ? x.rankId : rank) && x.bCSBatchId == (batch == 0 ? x.bCSBatchId : batch))
          .Where(x => x.joiningDatePresentWorkstation != null)
          .OrderBy(x => x.joiningDatePresentWorkstation)
          .ToListAsync();
        }

        public async Task<IEnumerable<EmployeeInfo>> GetOverDueEmployeeInfoList(int rank, int unit, int batch)
        {
            return await _context.EmployeeInfos
          .Include(x => x.rank)
          .Include(x => x.branch)
          .Include(x => x.section)
          .Include(x => x.bCSBatch)
          .Where(x => Convert.ToDateTime(x.joiningDatePresentWorkstation).Date < DateTime.Now.AddYears(-2))
          .Where(x => x.branchId == (unit == 0 ? x.branchId : unit) && x.rankId == (rank == 0 ? x.rankId : rank) && x.bCSBatchId == (batch == 0 ? x.bCSBatchId : batch))
          .Where(x => x.joiningDatePresentWorkstation != null)
          .OrderBy(x => x.joiningDatePresentWorkstation)
          .ToListAsync();
        }
    }
}
