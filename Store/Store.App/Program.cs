using System;
using System.Linq;

namespace Store.App
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Store.App");

      using (var db = new StoreDbContext())
      {
        var orders = db.Orders;

        foreach (var order in orders)
        {
          Console.WriteLine("submit date: " + order.SubmitDate);
        }
      }
      Console.ReadLine();
    }
  }
}
