using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.Enum.Common;

namespace APP_ADMIN.DataModel.Common
{
    public class Pager
    {
        public Pager()
        {
            CurrentPage = 1;
        }
        /// <summary>
        /// Holds current page position.
        /// Default is 1.
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// True to display all records, otherwise false.
        /// </summary>
        public bool ShowAll { get; set; }
        /// <summary>
        /// Define order by column
        /// </summary>


        /// <summary>
        /// Define order type (ASC or DESC)
        /// </summary>
        public EnumOrderType? OrderType { get; set; }

        /// <summary>
        /// Search records by keyword. 
        /// Keyword should be at least 3 characters
        /// </summary>
        public string Keyword { get; set; }
    }
}
