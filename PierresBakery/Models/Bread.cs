namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price { get; set; } = 5;
    public int TotalCost(int quantity)
    {
      int finalCost = 0;
        if (quantity < 3)
        {
          finalCost += Price * quantity;
        } else if (quantity >= 3)
        {
          finalCost = Price * (quantity - quantity / 3);
        }
      return finalCost;
      }
    }
  }