using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCore.Data.Entity.AddressData
{
    public class Division : Base
    {
        
        [Column(TypeName = "NVARCHAR(20)")]
        public string divisionCode { get; set; }        
        [Column(TypeName = "NVARCHAR(120)")]
        public string divisionName { get; set; }
        public string divisionNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string shortName { get; set; }
        [Column(TypeName = "NVARCHAR(10)")]
        public string isActive { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string latitude { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string longitude { get; set; }
        

    }
}
