using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.School
{
    public class TrackCategory : BaseEntity
    {
        public int TrackCategoryID { get; set; }
        public string TrackCode { get; set; }
        public string TrackName { get; set; }
        public string Description { get; set; }

    }
}
