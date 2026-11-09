using Microsoft.EntityFrameworkCore;
using SchoolAdmissionSystem.Data_Models;

namespace SchoolAdmissionSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Seat> Seats => Set<Seat>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Seat>()
                .HasIndex(s => s.SeatNumber)
                .IsUnique();

            modelBuilder.Entity<Seat>().HasData(
                Enumerable.Range(1, 20).Select(i => new Seat
                {
                    Id = i,
                    SeatNumber = $"A{i:00}",
                    IsAvailable = true
                })
            );
        }
    }


}
