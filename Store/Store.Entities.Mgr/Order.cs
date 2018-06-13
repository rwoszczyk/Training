using System;

namespace Store.Entities.Mgr
{
  public class Order
  {
    public int Id { get; set; }

    public DateTime SubmitDate { get; set; }

    public string Details { get; set; }
  }
}