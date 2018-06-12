using System.Data.Entity;
using System.Linq;

namespace Store
{
  public partial class StoreDbContext : DbContext
  {
    public StoreDbContext() : base("Store")
    {
    }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }
  }
}