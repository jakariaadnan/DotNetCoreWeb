using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Data.Entity.EmployeeInfos
{
    public class EmployeeDocument:Base
    {
        public int? employeeId { get; set; }
        public EmployeeInfo employee { get; set; }
        public DateTime? date { get; set; }
        public string documentName { get; set; }
        public string documentType { get; set; }
        public string fileUrl { get; set; }
        public int status { get; set; }
        public string remarks { get; set; }
        public string description { get; set; }
    }
}
