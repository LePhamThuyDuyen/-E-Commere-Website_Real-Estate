using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareModel
{
    public class ReportExcel
    {
        public string ReportID { get; set; }

        public string RealEstateID { get; set; }

        public string Status { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public string IPAddress { get; set; }
    }
}
