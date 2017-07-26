using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetWeb.Models
{
    public class Assessment
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime hiredate { get; set; }
        public string email { get; set; }
        public int gender { get; set; }
        public string country { get; set; }
        public string technologies { get; set; }
        public string qualification { get; set; }
    }
}