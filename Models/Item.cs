using ChilliSoftDLL.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChilliSoftDLL.Models
{
    public class Item
    {
        [Key]
        public int id { get; set; }
        public string ItemId { get; set; }
        public string Categorey { get; set; }
        public MeetingStatus ms { get; set; }
        public string meetingstatus { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string EmployeeResponsible { get; set; }
        public string ItemTalker { get; set; }
        public string LastMeetingId { get; set; }
    }
}
