using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.School
{
    public class School : BaseEntity
    {
        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize255)]
        public int SchoolID { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize25)]
        public string SchoolCode { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize255)]
        public string SchoolName { get; set; }

        [MaxLength(DbMaxLengthHelper.FieldSize255)]
        public string ImageFileName { get; set; }

        public string HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string StreetType { get; set; }
        //Foreign Key
        public int RegionID { get; set; }
        public int ProvinceID { get; set; }

        public int CityMunicipalityID { get; set; }
    }
}
