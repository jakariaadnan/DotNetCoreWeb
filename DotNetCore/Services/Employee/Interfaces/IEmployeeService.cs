using DotNetCore.Data.Entity.EmployeeInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Services.Employee.Interfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeInfo> GetEmployeeInfoById(string empCode);
        Task<IEnumerable<EmployeeDocument>> GetEmployeeDocumentById(int id);
        Task<int> SaveEmployeeInformation(EmployeeInfo employeeInfo);
        Task<EmployeeInfo> GetEmployeeInfoByEmpId(int id);
        Task<EmployeeInfo> GetEmployeeInfoByApplicationId(string userId);
        #region Document
        Task<int> SaveEmployeeDocument(EmployeeDocument document);
        #endregion
    }
}
