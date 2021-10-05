using System;
using System.Collections.Generic;
using System.Text;

namespace ChilliSoftDLL.Models
{
    public class Room
    {
        public int id { get; set; }
        public string RoomId { get; set; }
        public string CreatorId { get; set; }
        public DateTime TimeStarted { get; set; }
        public DateTime TimeEnded { get; set; }
    }
}
