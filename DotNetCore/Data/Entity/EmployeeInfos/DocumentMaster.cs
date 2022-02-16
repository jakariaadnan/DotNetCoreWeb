using DotNetCore.Data.Entity.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Data.Entity.EmployeeInfos
{
    public class DocumentMaster:Base
    {
        public int? employeeId { get; set; }
        public EmployeeInfo employee { get; set; }
        public string documentNumber { get; set; }
        public string subject { get; set; }
        public int? departmentId { get; set; }
        public Department department { get; set; }
        public string keywords { get; set; }
        public DateTime? date { get; set; }
        public int? documentCategoryId { get; set; }
        public DocumentCategory documentCategory { get; set; }
        public string documentName { get; set; }
        public string documentType { get; set; }
    }
}
