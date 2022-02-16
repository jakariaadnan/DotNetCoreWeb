using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Data.Entity.EmployeeInfos
{
    public class UserLog : Base
    {
        public int? employeeId { get; set; }
        public EmployeeInfo employee { get; set; }
        public DateTime? date { get; set; }
        public int? status { get; set; }
        public string remarks { get; set; }
        public string description { get; set; }
    }
}
