using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pulipalpula_Exam02.Models
{
 

  public class OrderDetail
  {
   
    public int OrderDetailID { get; set; }
    public int OrderID { get; set; }
    public int ProductID { get; set; }
    public int ProductQuantity { get; set; }


    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; }
  }
}
