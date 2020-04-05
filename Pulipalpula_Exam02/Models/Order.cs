using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pulipalpula_Exam02.Models
{
  public class Order
  {
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int OrderID { get; set; }
    public DateTime OrderDate { get; set; }
    public int HeadquatersID { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
  }
}
