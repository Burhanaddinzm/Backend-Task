﻿
using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2.Contexts
{
    public class ShopDbContext : DbContext
    {
        private protected string connectionString = "Server=JUPITER01;Database=Shop;Trusted_Connection=True;TrustServerCertificate=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

       public DbSet<Category> Categories { get; set; }
       public DbSet<Product> Products { get; set; }
    }
}