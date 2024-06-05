using Microsoft.EntityFrameworkCore;
using OrderServiceDesign.Domain.Entities;

namespace OrderServiceDesign.DataAccessLayer
{
    public class OrderDBContext: DbContext
    {
        public OrderDBContext(DbContextOptions<OrderDBContext> options) : base(options)
        {
        }

        #region Database Entity Datasets
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<CustomerCart> CustomerCarts { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<ShippingDetails> ShippingDetails { get; set; }

        #endregion
    }
}
