using System.Data.Entity;

namespace Store.Entities.Mgr
{
  public class StoreDbContext : DbContext
  {
    public StoreDbContext() : base("Store")
    {
    }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }
  }
}