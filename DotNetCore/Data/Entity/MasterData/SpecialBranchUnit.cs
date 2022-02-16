using DotNetCore.Data.Entity.AddressData;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCore.Data.Entity.MasterData
{
    public class SpecialBranchUnit: Base
    {
        [Column(TypeName = "nvarchar(250)")]
        public string branchUnitName { get; set; }
        [Column(TypeName = "nvarchar(350)")]
        public string branchUnitNameBN { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string branchCode { get; set; }

        public int? isParent { get; set; }

        public int? specialBranchUnitId { get; set; }
        public SpecialBranchUnit specialBranchUnit { get; set; }

        public int? districtsId { get; set; }
        public District districts { get; set; }


        public int? shortOrder { get; set; }
        public int? isdefault { get; set; }
    }
}
