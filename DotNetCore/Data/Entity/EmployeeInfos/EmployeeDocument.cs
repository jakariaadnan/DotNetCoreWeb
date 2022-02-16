using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Data.Entity.EmployeeInfos
{
    public class DocumentDetails:Base
    {
        public int? documentMasterId { get; set; }
        public DocumentMaster documentMaster { get; set; }
        public string fileUrl { get; set; }
        public int status { get; set; }
        public string remarks { get; set; }
        public string description { get; set; }
    }
}
