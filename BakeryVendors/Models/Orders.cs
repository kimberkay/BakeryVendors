using System.Collections.Generic

namespace BakeryVendors.Models
{

  public class Order
  {
    public string OrderTitle { get; set; } 
    public string Description { get; set; }
    public int Price  { get; set; }

    public string Date { get; set; }
  }
}