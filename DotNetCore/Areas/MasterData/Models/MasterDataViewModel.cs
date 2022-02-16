using DotNetCore.Data.Entity.MasterData;
using System.Collections.Generic;

namespace DotNetCore.Areas.MasterData.Models
{
    public class MasterDataViewModel
    {
        public IEnumerable<DocumentCategory> documentCategories { get; set; }
    }
    public class DocumentCategoryVM
    {
        public string CategoryName { get; set; }
        public string CategoryNameBn { get; set; }
        public int? categoryStatus { get; set; }
        public int? categoryId { get; set; }
    }
}
