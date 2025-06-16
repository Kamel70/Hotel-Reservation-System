using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.DataAccess.Models
{
    public class HotelReservationDBContext:IdentityDbContext<ApplicationUser>
    {
        public HotelReservationDBContext(DbContextOptions<HotelReservationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<RoomImages> RoomImages { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Payment> Payment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional model configuration can go here
        }
    }
}
