﻿using _16noyabr.Models;
using Microsoft.EntityFrameworkCore;

namespace _16noyabr.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
                
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category>  Categories { get; set;}
        public DbSet<ProductImage> ProductImages { get; set; }


    }
}
