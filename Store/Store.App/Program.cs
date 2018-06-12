using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.App
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Store.App");

      using (var db = new StoreDbContext())
      {
        var orders = db.Orders.Select(x => x.SubmitDate);

        foreach (var order in orders)
        {
          Console.WriteLine("submit date: " + order.SubmitDate);
        }
        
            db.Entry(orders.First());

      }



      Console.ReadLine();
    }
  }
}
