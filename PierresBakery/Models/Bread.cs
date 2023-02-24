namespace PierresBakery.Models
{
  public class Bread
  {
    public static int Price { get; set; } = 5;

    public static int TotalCost(int quantity)
    {
      int finalCost = 0;
      if (quantity == 1){
        finalCost += Price;
      }
      return finalCost;
    }
  }
}