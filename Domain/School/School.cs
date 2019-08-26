using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.School
{
    public class School : BaseEntity
    {
        public int SchoolID { get; set; }
        public string SchoolCode { get; set; }
        public string SchoolName { get; set; }
        
        //Foreign Key
        public int AddressID { get; set; }
    }
}
