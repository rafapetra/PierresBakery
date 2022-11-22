using System;
using Bakery.Models;

namespace Bakery
{
  public class Bakery
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery. We offer bread and pastries. Our prices are: $5 for bread, buy 2 get one free. Pastries are 1 for $2 and 3 for $5. Thanks for visiting! Would you like to start your order?");
      string stringUserInput = Console.ReadLine();

      if (stringUserInput == "yes" || stringUserInput == "Yes")
      {
        Console.WriteLine("Great, let's get started. First, how many bread would you like?");
        string stringUserBreadInput = Console.ReadLine();
        int intUserBreadInput = int.Parse(stringUserBreadInput);

        Console.WriteLine("Next, how many pastries would you like");
        string stringUserPastryInput = Console.ReadLine();
        int intUserPastryInput = int.Parse(stringUserPastryInput);

        int breadAmount = intUserBreadInput;
        Bread newBread = new Bread(breadAmount);

        int pastryAmount = intUserPastryInput;
        Pastry newPastry = new Pastry(pastryAmount);

        Console.WriteLine(" ");
        Console.WriteLine("Your order is:");
        Console.WriteLine("Breads: " + newBread.Amount);
        Console.WriteLine("Pastries: " + newPastry.Amount);
        Console.WriteLine(" ");
        Console.WriteLine("Your total is: ");


      }
      else
      {
        Console.WriteLine("Thank you, please come back later! Have a nice day.");
      }
    }
  }
}

// user input equals list item
// a method for each list item for each bread into tomes 5 except divisible byb3