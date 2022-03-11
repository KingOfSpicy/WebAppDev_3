using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CheWei_Task7Practice2.Models;

namespace CheWei_Task7Practice2.Data
{
    public class CheWei_Task7Practice2Context : DbContext
    {
        public CheWei_Task7Practice2Context (DbContextOptions<CheWei_Task7Practice2Context> options)
            : base(options)
        {
        }

        public DbSet<CheWei_Task7Practice2.Models.Booking> Booking { get; set; }

        public DbSet<CheWei_Task7Practice2.Models.Guest> Guest { get; set; }

        public DbSet<CheWei_Task7Practice2.Models.Hotel> Hotel { get; set; }

        public DbSet<CheWei_Task7Practice2.Models.Room> Room { get; set; }

        public DbSet<CheWei_Task7Practice2.Models.Staff> Staff { get; set; }

        public DbSet<CheWei_Task7Practice2.Models.TypeOfRoom> TypeOfRoom { get; set; }
    }
}
