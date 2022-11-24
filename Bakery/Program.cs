using System;
using Bakery.Models;

namespace Bakery
{
  public class Bakery
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery. Our prices are: $5 for bread, buy 2 get one free. Pastries are 1 for $2 and 3 for $5. Would you like to start your order?");
      string stringUserInput = Console.ReadLine();

      if (stringUserInput == "yes" || stringUserInput == "Yes")
      {
        Console.WriteLine("Great, let's get started. First, how many bread would you like?");
        string stringUserBreadInput = Console.ReadLine();
        int intUserBreadInput = int.Parse(stringUserBreadInput);

        Console.WriteLine("Next, how many pastries would you like");
        string stringUserPastryInput = Console.ReadLine();
        int intUserPastryInput = int.Parse(stringUserPastryInput);

        Bread newBread = new Bread(intUserBreadInput);
        int breadTotalCost = newBread.BreadOrderCost(intUserBreadInput);

        Pastry newPastry = new Pastry(intUserPastryInput);
        int pastryTotalCost = newPastry.PastryOrderCost(intUserPastryInput);

        int orderTotal = pastryTotalCost + breadTotalCost;

        Console.WriteLine(" ");
        Console.WriteLine("Your order is:");
        Console.WriteLine("Breads: " + newBread.Amount);
        Console.WriteLine("Pastries: " + newPastry.Amount);
        Console.WriteLine(" ");
        Console.WriteLine("Your total is: " + orderTotal);


      }
      else
      {
        Console.WriteLine("Thank you, please come back later! Have a nice day.");
      }
    }
  }
}