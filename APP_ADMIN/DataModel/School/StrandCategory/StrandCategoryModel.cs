using APP_ADMIN.DataModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.Enum.Common;
using Utility.Enum.School;

namespace APP_ADMIN.DataModel.School.StrandCategory
{
    public class StrandCategoryModel : Pager
    {
        public EnumOrderBy? OrderBy { get; set; }
        public EnumSchoolSearchBy? SearchBy { get; set; }
        public EnumFilterBy? FilterBy { get; set; }
    }
}
