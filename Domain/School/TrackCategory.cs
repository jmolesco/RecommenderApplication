using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.School
{
    public class TrackCategory : BaseEntity
    {
        public int TrackCategoryID { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize25)]
        public string TrackCode { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize255)]
        public string TrackName { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize255)]
        public string Description { get; set; }

    }
}
