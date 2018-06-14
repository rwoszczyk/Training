using System;
using System.Data.Entity;
using System.Linq;
using Store.Queryable;
using Z.EntityFramework.Plus;

namespace Store.App.TipsTricks
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var db = new StoreDbContext())
      {
        // CREATE a pending list of future queries
        var futureCustomers = db.Customers
          .Where(x => x.Name != null)
          .Future();

        var futureOrders = db.Orders
          .Where(x => x.SubmitDate >= new DateTime(2018, 1, 1))
          .Future();

        var customers = futureCustomers.ToList();
        
        foreach (var customer in customers)
        {
          Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}");
        }


        var orders = futureOrders.ToList();

        foreach (var order in orders)
        {
          Console.WriteLine($"Id: {order.Id}, submit date: {order.SubmitDate}");
        }

      }

      Console.ReadLine();
    }
  }
}
