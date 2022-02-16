using DotNetCore.Data.Entity.EmployeeInfos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Areas.DocumentInfo.Models
{
    public class DocumentViewModel
    {
        public IEnumerable<EmployeeDocument> documents { get; set; }
        public string documentName { get; set; }
        public string documentType { get; set; }
        public string documentDescription { get; set; }
        public IFormFile document { get; set; }
    }
}
