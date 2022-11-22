namespace Bakery.Models
{
  public class Bread
  {
    public int Amount { get; }

    public Bread(int amount)
    {
      Amount = amount;
      
    }

    public int BreadOrderCost(int breadAmount)
    {
      int divisibleByThree = breadAmount / 3;
      int remainder = breadAmount % 3;

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








