namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Price { get; set; } = 2;
    public int TotalCost(int quantity)
    {
      int finalCost = 0;
        if (quantity < 4)
        {
          finalCost += Price * quantity;
        } else if (quantity >= 4)
        {
          finalCost = Price * (quantity - quantity / 4);
        }
      return finalCost;
      }
    }
  }