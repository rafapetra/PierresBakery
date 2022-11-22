namespace Bakery.Models
{
  public class Bread
  {
    public int Amount { get; }

    public Bread(int amount)
    {
      Amount = amount;
      
    }

    public int BreadOrderCost(int Amount)
    {
      int divisibleByThree = Amount / 3;
      int remainder = Amount % 3;

      int breadTotal = (divisibleByThree * 10) + (remainder * 5);
      return breadTotal;
    }
    
  }

    public class Pastry
  {
    public int Amount { get; }

    public Pastry(int amount)
    {
      Amount = amount;
      
    }
  }
}








