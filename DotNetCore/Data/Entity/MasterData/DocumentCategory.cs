using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Data.Entity.MasterData
{
    public class DocumentCategory:Base
    {
        public string categoryName { get; set; }
        public string categoryCode { get; set; }
        public int status { get; set; } //0=Active 1=Inactive
        public string remarks { get; set; }
    }
}
