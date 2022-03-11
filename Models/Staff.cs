using System;
using System.Collections.Generic;

namespace CheWei_Task7Practice2.Models
{
    public partial class Staff
    {
        public int Id { get; set; }
        public int? HotelId { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string Position { get; set; }
        public decimal AnnualSalary { get; set; }
    }
}
