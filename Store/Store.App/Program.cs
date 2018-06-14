using System;
using System.Linq;
using Store.QuickStart;

namespace Store.App
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var db = new StoreDbContext())
      {
        var orders = db.Orders;

        Console.WriteLine("Orders");

        foreach (var order in orders)
        {
          Console.WriteLine(@"Id: {0}, submit date: {1}", order.Id, order.SubmitDate);
        }


        var customer = db.Customers.FirstOrDefault();

        var entity = new Order()
        {
          SubmitDate = DateTime.Now,
          Customer = customer
        };

        db.Orders.Add(entity);
        
        db.SaveChanges();
      }

      Console.ReadLine();
    }
  }
}
