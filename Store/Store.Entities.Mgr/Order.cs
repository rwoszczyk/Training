using System;

namespace Store.Entities.Mgr
{
  public class Order
  {
    public int Id { get; set; }

    public DateTime SubmitDate { get; set; }
    
    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; }


    public string Details { get; set; }
  }
}