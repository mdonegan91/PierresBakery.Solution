using System;
using PierresBakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(@"    (  )   (   )  )");
      Console.WriteLine(@"     ) (   )  (  (");
      Console.WriteLine(@"     ( )  (    ) )");
      Console.WriteLine(@"     _____________");
      Console.WriteLine(@"    <_____________> ___");
      Console.WriteLine(@"    |             |/ _ \");
      Console.WriteLine(@"    |               | | |");
      Console.WriteLine(@"    |               |_| |");
      Console.WriteLine(@" ___|             |\___/");
      Console.WriteLine(@"/    \___________/    \");
      Console.WriteLine(@"\_____________________/");
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("Prices:");
      Console.WriteLine($"Loaf of Bread: $5");
      Console.WriteLine($"Pastry: $2");
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("Today's specials:");
      Console.WriteLine("Bread: Buy 2, get 1 free.");
      Console.WriteLine("Pastry: Buy 3, get 1 free.");
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("Would you like to place an order? [Yes/No]:");
      string placeOrder = (Console.ReadLine()).ToLower();
      if (placeOrder == "yes")
      {
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("How many loaves of bread would you like?");
        int loaf = int.Parse(Console.ReadLine());
        Bread newBread = new Bread();
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Got it, " + loaf + " bread.");
        int breadTotal = newBread.TotalCost(loaf);
        Console.WriteLine("Would you like to order pastries, too? [Yes/No]");
        string pastriesToo = (Console.ReadLine()).ToLower();
        if (pastriesToo == "no")
        {
          Console.WriteLine("-------------------------------------------");
          Console.WriteLine("Your total today is: $" + breadTotal);
          Console.WriteLine("Thank you for stopping by! Come again soon!");
          Console.WriteLine("-------------------------------------------");
        }
        if (pastriesToo == "yes")
        {
          Console.WriteLine("-------------------------------------------");
          Console.WriteLine("How many pastries would you like?");
          int fritter = int.Parse(Console.ReadLine());
          Pastry newPastry = new Pastry();
          Console.WriteLine("-------------------------------------------");
          Console.WriteLine("Got it, " + fritter + " pastry.");
          int pastryTotal = newPastry.TotalCost(fritter);
          Console.WriteLine("-------------------------------------------");
          Console.WriteLine("Your total today is: $" + (breadTotal + pastryTotal));
        }
      }
      else if (placeOrder == "no")
      {
        Console.WriteLine("Thank you for visiting! Come again soon!");
        Console.WriteLine("-------------------------------------------");
      }
    }
  }
}