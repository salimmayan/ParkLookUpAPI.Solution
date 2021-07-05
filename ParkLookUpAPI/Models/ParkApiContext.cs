using Microsoft.EntityFrameworkCore;
using System;

namespace ParkLookUpAPI.Models
{
    public class ParkLookUpAPIContext : DbContext
    {
        public ParkLookUpAPIContext(DbContextOptions<ParkLookUpAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
            .HasData(new Park { ParkId = 1, Name = "Yellow Stone", State = "Wyoming", Area = 2219789, City = "West Yellowstone", IsOpen = true },
                     new Park { ParkId = 2, Name = "Rocky Moutain", State = "Colorado", Area = 265461, City = "Estes Park", IsOpen = true },
                     new Park { ParkId = 2, Name = "Crater Lake", State = "Oregon", Area = 183224, City = "Klamath Falls", IsOpen = false },
                     new Park { ParkId = 2, Name = "Mount Rainier", State = "Washington", Area = 236381, City = "Tacoma", IsOpen = true }            );
        }
    }
}