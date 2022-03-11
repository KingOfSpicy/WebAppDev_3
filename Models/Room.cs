using System;
using System.Collections.Generic;

namespace CheWei_Task7Practice2.Models
{
    public partial class Room
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int TypeId { get; set; }
        public decimal Price { get; set; }
    }
}
