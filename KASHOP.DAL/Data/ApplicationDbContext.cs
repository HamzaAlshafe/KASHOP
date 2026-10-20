using KASHOP.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KASHOP.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        base.OnConfiguring(optionsBuilder);
    //        optionsBuilder.UseSqlServer("Data Source=.;Database=KASHOP15;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        base.OnModelCreating(modelBuilder);

    //        modelBuilder.Entity<Category>().HasData(
    //            new Category { Id = 1, Name = "Electronics", Status = true },
    //            new Category { Id = 2, Name = "Clothing", Status = true },
    //            new Category { Id = 3, Name = "Sports", Status = true },
    //            new Category { Id = 4, Name = "Home & Kitchen", Status = true },
    //            new Category { Id = 5, Name = "Books", Status = false }
    //        );

    //        modelBuilder.Entity<Brand>().HasData(
    //            new Brand { Id = 1, Name = "Samsung", Image = "samsung.png" },
    //            new Brand { Id = 2, Name = "Apple", Image = "apple.png" },
    //            new Brand { Id = 3, Name = "Nike", Image = "nike.png" },
    //            new Brand { Id = 4, Name = "Adidas", Image = "adidas.png" },
    //            new Brand { Id = 5, Name = "Sony", Image = "sony.png" }
    //        );
    //    }
    }
}