using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChilliSoftDLL.Models
{
    public class Message
    {
        [Key]
        public int id { get; set; }
        public string MessageId { get; set; }
        public string MeetingId { get; set; }
        public string Type { get; set; }
        public DateTime TimeSent { get; set; }
        public string ItemId { get; set; }
        public string SenderId { get; set; }
        public string RoomId { get; set; }
        public string MinutesMaster { get; set; }
        public string Body { get; set; }
    }
}
