using System;
using System.Collections.Generic;
using System.Linq;
using Store.Queryable;

namespace Store.App.Qrbl
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var db = new StoreDbContext())
      {
        Console.WriteLine("Orders");


        var ordersOfToday = db
          .Orders
          .ToList()
          .Where(x => x.SubmitDate == new DateTime(2018, 06, 15));

        PrintOrders(ordersOfToday);


        var ordersOfToday_2 = db
          .Orders
          .Where(x => x.SubmitDate == new DateTime(2018, 06, 15))
          .ToList();

        PrintOrders(ordersOfToday_2);
      }

      Console.ReadLine();
    }

    private static void PrintOrders(IEnumerable<Order> orders)
    {
      foreach (var order in orders)
      {
        Console.WriteLine(@"Id: {0}, submit date: {1}", order.Id, order.SubmitDate);
      }
    }
  }
}
