using EventEaseSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EventEaseSystem.Data
{
    public class EaseEventDbContext : DbContext 
    {
        public EaseEventDbContext(DbContextOptions<EaseEventDbContext> options) : base(options) { }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .HasIndex(b => new { b.VenueId, b.BookingDate })
                .IsUnique();
        }
    }
}
