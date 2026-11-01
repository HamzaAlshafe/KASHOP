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
        public DbSet<CategoryTranslation> Translations { get; set; }

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }
    }
}