using Melgueira.ProductApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Melgueira.ProductApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    //Fluent API

    protected override void OnModelCreating(ModelBuilder mBuilder)
    {
        //category
        mBuilder.Entity<Category>().HasKey(c => c.CategoryId);
        mBuilder.Entity<Category>().Property(c => c.CategoryName).HasMaxLength(100).IsRequired();

        //product
        mBuilder.Entity<Product>().HasKey(c => c.ProductId);
        mBuilder.Entity<Product>().Property(p => p.ProductName).HasMaxLength(100).IsRequired();
        mBuilder.Entity<Product>().Property(p => p.Description).HasMaxLength(255).IsRequired();
        mBuilder.Entity<Product>().Property(p => p.ImageURL).HasMaxLength(255).IsRequired();
        mBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(12, 2).IsRequired();
        mBuilder.Entity<Category>().HasMany(g => g.Products).WithOne(c => c.Category).IsRequired().OnDelete(DeleteBehavior.Cascade);

        mBuilder.Entity<Category>().HasData(
            new Category
            {
                CategoryId = 1,
                CategoryName = "Honey",
            },

            new Category
            {
                CategoryId = 2,
                CategoryName = "Beverage",
            }
      );
    }
}

