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

    public int PastryOrderCost(int pastryCount)
    {
      int divisibleByThree = pastryCount / 3;
      int remainder = pastryCount % 3;

      int pastryCost = (divisibleByThree * 5) + (remainder * 2);
      return pastryCost;
    }
  }
}








