using System.Data.Entity;

namespace Store.Queryable
{
  public class StoreDbContext : DbContext
  {
    public StoreDbContext() : base("Store")
    {
#if DEBUG
      this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
#endif
    }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }
  }
}