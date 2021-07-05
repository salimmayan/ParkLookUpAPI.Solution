using Microsoft.EntityFrameworkCore;

namespace ParkLookUpAPI.Models
{
    public class ParkLookUpAPIContext : DbContext
    {
        public ParkLookUpAPIContext(DbContextOptions<ParkLookUpAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Contestants { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
            .HasData(new Park { ParkId = 1, Name = "Yellow Stone", State = "Wyoming", Area = 2219789, City = "West Yellowstone" },
                     new Park { ParkId = 2, Name = "Rocky Moutain", State = "Colorado", Area = 265461, City = "Estes Park" }
            );
        }
    }
}