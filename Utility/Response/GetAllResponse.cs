using System;
using System.Collections.Generic;
using System.Text;

namespace Utility.Response
{
    public class GetAllResponse
    {
        public GetAllResponse(int total)
        {
            this.Total = total;
            this.List = new List<object>();
            this.CurrentPage = 1;
            this.TotalPage = 1;
        }

        public GetAllResponse(int total, int currentPage, int recordDisplayPerPage)
        {
            this.Total = total;
            this.CurrentPage = currentPage;
            this.TotalPage = ((total - 1) / recordDisplayPerPage) + 1;
            this.List = new List<object>();
        }

        public int Total { get; }

        public int CurrentPage { get; }

        public int TotalPage { get; }

        public List<object> List { get; set; }
    }
}
