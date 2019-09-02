using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Taxonomy
{
    public class Region : BaseEntity
    {
        public int RegionID { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize25)]
        public string RegionCode { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize255)]
        public string RegionName { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize255)]
        public string Description { get; set; }
    }
}
