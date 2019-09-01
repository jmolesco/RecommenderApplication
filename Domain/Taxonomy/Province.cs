using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Taxonomy
{
    public class Province : BaseEntity
    {
        public int ProvinceID { get; set; }
        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize25)]
        public string ProvinceCode { get; set;}

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize255)]
        public string ProvinceName { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize255)]
        public string Description { get; set; }

        //Foreign Key
        public int RegionID { get; set; }

    }
}
