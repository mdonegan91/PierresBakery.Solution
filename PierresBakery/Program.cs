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
      Console.WriteLine("Would you like to place an order? (Yes/No):");
      string yesNo = (Console.ReadLine()).ToLower();
      if (yesNo == "yes")
      {
        Console.WriteLine("How many loaves of bread would you like?");
        int loaves = int.Parse(Console.ReadLine());
        Bread newBread = new Bread();
        Console.WriteLine("Got it, " + loaves + " loaves of bread");
      }else if (yesNo == "no")
      {
        Console.WriteLine("Thank you for visiting! Come again soon!");
      }
    }
  }
}