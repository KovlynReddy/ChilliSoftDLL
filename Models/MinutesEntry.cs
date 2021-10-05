using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChilliSoftDLL.Models
{
    public class MinutesEntry
    {
        [Key]
        public int id { get; set; }
        public string MinutesId { get; set; }
        public string ItemId { get; set; }
        public string Notes { get; set; }
        public string Remarks { get; set; }
        public string EmployeeId { get; set; }
        public string MinutesMasterId { get; set; }
    }
}
