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
    }
}
