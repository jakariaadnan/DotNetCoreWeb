﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCore.Data.Entity.MasterData
{
    public class Rank:Base
    {
        [Column(TypeName = "nvarchar(50)")]
        public string rankCode { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string rankName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string rankNameBN { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string shortName { get; set; }
        public int? shortOrder { get; set; }
    }
}
