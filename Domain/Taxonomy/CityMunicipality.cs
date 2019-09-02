using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Taxonomy
{
    public class CityMunicipality : BaseEntity
    {
        public int CityMunicipalityID { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize25)]
        public string CityMunicipalityCode { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize255)]
        public string CityMunicipalityName { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize255)]
        public string Description { get; set; }


        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize25)]
        public string ZipCode { get; set; }
        //Foreign Key
        public int RegionID { get; set; }
        public int ProvinceID { get; set; }
    }
}
