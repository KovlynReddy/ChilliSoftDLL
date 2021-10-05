using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChilliSoftDLL.Models
{
    public class Report
    {
        [Key]
        public int Id { get; set; }
        public string ReportsId { get; set; }
        public string ReportName { get; set; }
        public string ReportDescription { get; set; }
        public string Rateing { get; set; }
        public string Remarks { get; set; }
    }
}
