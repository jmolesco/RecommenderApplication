using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Taxonomy
{
    public class Region : BaseEntity
    {
        public int RegionID { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }

        public string Description { get; set; }
    }
}
