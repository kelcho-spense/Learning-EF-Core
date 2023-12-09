using ecommerceDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ecommerceDemo.Data
{
    public class EcommerceContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; } = null!; // match the name of the table in the database
        public DbSet<Order> Order { get; set; } = null!; // match the name of the table in the database
        public DbSet<Product> Product { get; set; } = null!; // match the name of the table in the database
        public DbSet<OrderDetail> OrderDetail { get; set; } = null!; // match the name of the table in the database

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:teach2giveserver.database.windows.net,1433;Initial Catalog=ecommercedb;Persist Security Info=False;User ID=teach2giveadmin;Password=YourStrong!Passw0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

    }
}
