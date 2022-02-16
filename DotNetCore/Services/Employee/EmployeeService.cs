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
            var result = await (from rank in _context.ranks
                                join emp in _context.employeeInfos on rank.Id equals emp.rankId
                                select rank).ToListAsync();

            return result;
        }

        public async Task<IEnumerable<EmployeeInfo>> GetEmployeeForChartJs()
        {
            var result = await _context.employeeInfos
                .Include(x => x.rank)
                .Include(x => x.section.specialBranchUnit)
                ///.Where(x => x.servicePeriod >)
                .ToListAsync();
            return result;
        }

        public void UpdateEmployeeInfoStatusById(int empId, int status)
        {
            var user = _context.employeeInfos.Find(empId);
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
                    _context.employeeInfos.Update(employeeInfo);
                }
                else
                {
                    _context.employeeInfos.Add(employeeInfo);
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
            var result = await _context.employeeInfos
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
        public async Task<EmployeeInfo> GetEmployeeInfoByEmpId(int id)
        {
            var result = await _context.employeeInfos
                .Include(x => x.rank)
                .Include(x => x.designations)
                .Include(x => x.branch)
                .Include(x => x.section)
                .Include(x => x.religion)
                .Include(x => x.rank)
                .Include(x => x.bCSBatch)
                .Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
            return result;
        }
        public async Task<EmployeeInfo> GetEmployeeInfoByApplicationId(string userId)
        {
            var result = await _context.employeeInfos
                .Include(x => x.rank)
                .Include(x => x.designations)
                .Include(x => x.branch)
                .Include(x => x.section)
                .Include(x => x.religion)
                .Include(x => x.rank)
                .Include(x => x.bCSBatch)
                .Where(x => x.ApplicationUserId == userId).AsNoTracking().FirstOrDefaultAsync();
            return result;
        }

        public async Task<EmployeeInfo> GetEmployeeInfoSingleById(string empCode)
        {
            var result = await _context.employeeInfos
                .Where(x => x.employeeCode == empCode).AsNoTracking().FirstOrDefaultAsync();
            return result;
        }
        public async Task<EmployeeInfo> GetEmployeeProfileInfoById(int id)
        {
            var result = await _context.employeeInfos
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
            var result = _context.employeeInfos.Find(id);
            return result;
        }
        public async Task<EmployeeInfo> GetEmployeeInfosByEmpId(int empId)
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
                .Where(x => x.Id == empId)
                .FirstOrDefaultAsync();

            return result;
        }

        public async Task<IEnumerable<EmployeeInfo>> GetEmployeeInfos()
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
                .ToListAsync();

            return result;
        }

        #region Document
        public async Task<string> GetDocumentRefNumber()
        {
            var count = await _context.documentMaster.CountAsync();
            var refNo = "PHQ/Doc/" + count;
            return refNo;
        }
        public async Task<int> SaveDocumentDetails(DocumentDetails document)
        {
            try
            {
                if (document.Id != 0)
                {
                    _context.documentDetails.Update(document);
                }
                else
                {
                    _context.documentDetails.Add(document);
                }

                await _context.SaveChangesAsync();
                return document.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<int> SaveDocumentMaster(DocumentMaster documentMaster)
        {
            try
            {
                if (documentMaster.Id != 0)
                {
                    _context.documentMaster.Update(documentMaster);
                }
                else
                {
                    _context.documentMaster.Add(documentMaster);
                }

                await _context.SaveChangesAsync();
                return documentMaster.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<DocumentMaster>> GetAllDocument()
        {
            return await _context.documentMaster.Include(x=>x.documentCategory).Include(x=>x.department).ToListAsync();
        }
        #endregion
    }
}
