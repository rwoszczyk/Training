using System;
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
        
        var entity = new Order()
        {
          SubmitDate = DateTime.Now
        };

        db.Orders.Add(entity);
        
        db.SaveChanges();
      }

      Console.ReadLine();
    }
  }
}
