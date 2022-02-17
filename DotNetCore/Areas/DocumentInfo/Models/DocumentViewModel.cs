using DotNetCore.Data.Entity.EmployeeInfos;
using DotNetCore.Data.Entity.MasterData;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Areas.DocumentInfo.Models
{
    public class DocumentViewModel
    {
        public IEnumerable<DocumentMaster> documents { get; set; }
        public IEnumerable<DocumentCategory> documentCategory { get; set; }
        public IEnumerable<Department> departments { get; set; }
        public string documentName { get; set; }
        public string documentType { get; set; }
        public string documentDescription { get; set; }
        public int? departmentId { get; set; }
        public int? documentCategoryId { get; set; }
        public string keywords { get; set; }
        public string subject { get; set; }
        public IFormFile document { get; set; }
    }
}
