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
        Task<int> SaveEmployeeInformation(EmployeeInfo employeeInfo);
        Task<EmployeeInfo> GetEmployeeInfoByEmpId(int id);
        Task<EmployeeInfo> GetEmployeeInfoByApplicationId(string userId);
        #region Document
        Task<string> GetDocumentRefNumber();
        Task<int> SaveDocumentDetails(DocumentDetails document);
        Task<int> SaveDocumentMaster(DocumentMaster documentMaster);
        Task<IEnumerable<DocumentMaster>> GetAllDocument();
        #endregion
    }
}
