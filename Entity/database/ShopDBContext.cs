using Entity.Models;
using Entity.untils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.database
{
    internal class ShopDBContext : DbContext
    {
        DbSet<Member> Members { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }
        public ShopDBContext() { }
        public ShopDBContext(DbContextOptions<ShopDBContext> options):base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MSSQL"));   
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .HasKey(a=> new { a.OrderId, a.ProductId});
        }
        
    }
}
