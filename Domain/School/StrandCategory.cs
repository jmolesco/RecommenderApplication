using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.School
{
    public class StrandCategory : BaseEntity
    {
        public int StrandCategoryID { get; set; }
        public string StrandCode { get; set; }
        public string StrandName { get; set; }
        public string Description { get; set; }

        public string NationalCertificate { get; set; }
        //Foreign Key
        public int TrackCategoryID { get; set; }
    }
}
