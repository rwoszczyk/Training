using System.Data.Entity;
using Store.Entities.Mgr.Migrations;

namespace Store.Entities.Mgr
{
  public class StoreDbContext : DbContext
  {
    public StoreDbContext() : base("Store")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      //Database.SetInitializer(new MigrateDatabaseToLatestVersion<StoreDbContext, Configuration>());
    }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }
  }
}