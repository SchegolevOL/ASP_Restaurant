using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace ASP_Restaurant.Models
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MenuNamePosition>()
        //        .HasOne(mnp => mnp.menuPosition)
        //        .WithMany(mp => mp.menuNamePositions)
        //        .HasForeignKey(mp => mp.MenuNameId);
        //    modelBuilder.Entity<MenuNamePosition>()
        //        .HasOne(mnp => mnp.menuPosition)
        //        .WithMany(mp => mp.menuNamePositions)
        //        .HasForeignKey(mp => mp.MenuPositionId);
        //}

        
        public DbSet<MenuPosition>menuPositions { get; set; }
        public DbSet<MenuName>menuNames { get; set; }
        public DbSet<MenuNamePosition> menuNamePositions { get; set; }
    }
}
