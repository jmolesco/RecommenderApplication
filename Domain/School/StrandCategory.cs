using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.School
{
    public class StrandCategory : BaseEntity
    {
        public int StrandCategoryID { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize25)]
        public string StrandCode { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize255)]
        public string StrandName { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize255)]
        public string Description { get; set; }

        [Required]
        [MaxLength(DbMaxLengthHelper.FieldSize25)]
        public string NationalCertificate { get; set; }
        //Foreign Key
        public int TrackCategoryID { get; set; }

        public TrackCategory TrackCategory { get; set; } 
    }
}
