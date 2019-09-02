using System;
using System.Collections.Generic;
using System.Text;

namespace Utility.Response
{
    public class ReturnErrorModel
    {
        public ReturnErrorModel()
        {
            this.Status = StatusResponse.ER;
        }

        public string Status { get; set; }

        public object Errors { get; set; }

    }
}
