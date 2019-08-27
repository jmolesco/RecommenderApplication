using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Taxonomy
{
    public class CityMunicipality : BaseEntity
    {
        public int CityMunicipalityID { get; set; }
        public string CityMunicipalityCode { get; set; }
        public string CityMunicipalityName { get; set; }
        public string Description { get; set; }

        public string ZipCode { get; set; }
        //Foreign Key
        public int RegionID { get; set; }
        public int ProvinceID { get; set; }
    }
}
