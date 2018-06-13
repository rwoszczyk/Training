using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Entities.Mgr;

namespace Store.App.Mgr
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

 
      }

      Console.ReadLine();
    }
  }
}
