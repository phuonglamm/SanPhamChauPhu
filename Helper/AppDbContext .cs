namespace SanPhamChauPhu.Helper
{
    using Microsoft.EntityFrameworkCore;
    using SanPhamChauPhu.Models;
    using System.Configuration;

     public class AppDbContext : DbContext
    
    {

        //public DbSet<Product> Products { get; set; }
        IConfiguration _config { get; set; }
        public AppDbContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var aaaa = _config.GetConnectionString("DatabaseConnection");
                optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
            }
        }
        public DbSet<Product> Products { get; set; }       

    }
}
