using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Project
    {
        public int PID { get; set; }
        public string  PNAME { get; set; }
        public string P_MGR { get; set; }
        public DateTime P_START { get; set; }
        public DateTime P_END { get; set; }

    }
}