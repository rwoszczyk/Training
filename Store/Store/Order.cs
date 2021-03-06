﻿using System;

namespace Store
{
  public class Order
  {
    public int Id { get; set; }

    public DateTime SubmitDate { get; set; }

    public int CustomerId { get; set; }
    
    public virtual Customer Customer { get; set; }
  }
}