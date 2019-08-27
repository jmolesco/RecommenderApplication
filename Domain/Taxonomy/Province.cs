using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Taxonomy
{
    public class Province : BaseEntity
    {
        public int ProvinceID { get; set; }
        public string ProvinceCode { get; set;}
        public string ProvinceName { get; set; }
        public string Description { get; set; }

        //Foreign Key
        public int RegionID { get; set; }

    }
}
