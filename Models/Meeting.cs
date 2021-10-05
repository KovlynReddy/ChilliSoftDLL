using ChilliSoftDLL.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChilliSoftDLL.Models
{
    public class Meeting
    {
        [Key]
        public int id { get; set; }
        public string MeetingId { get; set; }
        public string Caption { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public DateTime TimeElapsed { get; set; }
        public int HoursDuration { get; set; }
        public string MinutesMaster { get; set; }
        public string Type { get; set; }
        public MeetingTypes mt { get; set; }
    }
}
