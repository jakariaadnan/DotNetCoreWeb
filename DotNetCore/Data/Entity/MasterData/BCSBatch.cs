using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCore.Data.Entity.MasterData
{
    public class BCSBatch:Base
    {
        [Column(TypeName = "nvarchar(150)")]
        public string batchName { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string batchNameBn { get; set; }
        public int? shortOrder { get; set; }
       
    }
}
