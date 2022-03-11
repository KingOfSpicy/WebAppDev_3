using System;
using System.Collections.Generic;

namespace CheWei_Task7Practice2.Models
{
    public partial class Booking
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public DateTime ArrivalDt { get; set; }
        public DateTime? DepartureDt { get; set; }
    }
}
