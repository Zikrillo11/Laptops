using Laptops.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Laptops.DAL.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Laptop> Laptops { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<LaptopImage> LaptopImages { get; set; }
    public DbSet<Review> Reviews { get; set; }
}