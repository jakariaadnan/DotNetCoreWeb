using DotNetCore.Data;
using DotNetCore.Services.Employee.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Services.Employee
{
    public class EmployeeService: IEmployeeService
    {
        private readonly CoreWebDBContext _context;

        public EmployeeService(CoreWebDBContext context)
        {
            _context = context;
        }
    }
}
