using BeveragesAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BeveragesAPI.Data;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
        
    }
    public DbSet<Beverage> Beverages { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Beverage>()
            .Property(b => b.ImageUrl)
            .HasDefaultValue("/images/default-beverage.jpg");
    }
}
