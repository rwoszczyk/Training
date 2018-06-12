using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Store.TrackChanges
{
  public class StoreDbContext : DbContext
  {

    public StoreDbContext() : base("Store")
    {
    }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }


    public override int SaveChanges()
    {
      var modifiedEntities = ChangeTracker
        .Entries()
        .Where(p => p.State == EntityState.Modified)
        .ToList();

      //var now = DateTime.UtcNow;

      foreach (DbEntityEntry entityEntry in modifiedEntities)
      {
        //var entityName = change.Entity.GetType().Name;
        var primaryKey = GetPrimaryKeyValue(entityEntry);

        foreach (var prop in entityEntry.OriginalValues.PropertyNames)
        {
          var originalValue = entityEntry.OriginalValues[prop].ToString();
          var currentValue = entityEntry.CurrentValues[prop].ToString();

          if (originalValue != currentValue) //Only create a log if the value changes
          {
            var log = $"Entity with Id {primaryKey}, old value: {originalValue}, current value: {currentValue}";

            Console.WriteLine(log);
          }
        }
      }

      return base.SaveChanges();
    }

    object GetPrimaryKeyValue(DbEntityEntry entry)
    {
      var objectStateEntry = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager.GetObjectStateEntry(entry.Entity);
      return objectStateEntry.EntityKey.EntityKeyValues[0].Value;
    }
  }
}