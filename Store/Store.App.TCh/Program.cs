using System;
using System.Linq;
using Store.TrackChanges;

namespace Store.App.TCh
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var db = new StoreDbContext())
      {
        var orders = db.Orders.ToList();

        Console.WriteLine("Orders");

        foreach (var order in orders)
        {
          Console.WriteLine($"Id: {order.Id}, submit date: {order.SubmitDate}");
        }

        var firstOrder = orders.First();

        firstOrder.SubmitDate = firstOrder.SubmitDate.AddDays(2);

        db.SaveChanges();
      }

      Console.ReadLine();
    }
  }
}
