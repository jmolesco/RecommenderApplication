using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Taxonomy
{
    public class Address : BaseEntity
    {
        public int AddressID { get; set; }
        public string HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string StreetType { get; set; }


        //Foreign Key
        public int RegionID { get; set; }
        public int ProvinceID { get; set; }

        public int CityMunicipalityID { get; set; }
    }
}
