using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pulipalpula_Exam02.Models
{
  public class Product
  {
    public int ProductID { get; set; }
    public string SupplierID { get; set; }

    

    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
  }
}
