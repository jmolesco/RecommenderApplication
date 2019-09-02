using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP_ADMIN.DataModel.School.StrandCategory
{
    public class StrandCategoryInsertModel
    {
        public string StrandCode { get; set; }

        public string StrandName { get; set; }

        public string Description { get; set; }

        public string NationalCertificate { get; set; }
     
        //Foreign Key
        public int TrackCategoryID { get; set; }
    }
}
