
using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2.Contexts
{
    public class ShopDbContext : DbContext
    {
        private protected string connectionString = "Server=DESKTOP-6QH0HT5;Database=Shop;Trusted_Connection=True;TrustServerCertificate=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
    }
}
