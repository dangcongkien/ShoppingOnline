using Microsoft.EntityFrameworkCore;
using ShoppingOnlineWeb.Models;

namespace ShoppingOnlineWeb.DataContext
{
    public class ShoppingOnlineContext : DbContext
    {
        public ShoppingOnlineContext(DbContextOptions<ShoppingOnlineContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(local);Database=ShoppingOnlineDb;Trusted_Connection=True;TrustServerCertificate=true");
            }
        }
    }
}
