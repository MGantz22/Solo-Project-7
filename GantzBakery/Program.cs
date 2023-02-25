using System;
using GantzBakery.Models;

namespace MyProgram
{
  public class Program 
  {
    static void Main()
    {
      Console.WriteLine();
      Console.WriteLine("Kon'nichiwa!! Welcome to Gantz, a Traditional Japanese Inspired Bakery");
      Console.WriteLine("Today our bread costs $5 (buy 2, get 1 free!) and pastries are $2 (buy 3, get 1 free)");
      Console.WriteLine("=====================================================================================");
      bool finished = false;
      //loop to reset order if a mistake is made
      while (finished == false)
      {
        Console.WriteLine("How many loaves of bread would you like?");
        int Bread = int.Parse(Console.ReadLine());
        Console.WriteLine("How many Pastries would you like?");
        int Pastry = int.Parse(Console.ReadLine());
        int customerTotal = AssembleOrder(Bread, Pastry);
        Console.WriteLine($"Your Grandtotal for {Bread} bread and {Pastry} pastries are ${customerTotal}.");
        Console.WriteLine();
        Console.WriteLine("Shall I submit your order (Y) or would you like to modify it (N) friend? Y/N");
        string done = Console.ReadLine().ToUpper();
        if (done == "Y")
        {
          finished = true;
          Console.WriteLine("Isshun, one moment please, Watashi no yūjin...");
          Console.WriteLine("============================================================================================");
          Console.WriteLine($"Your final total today for {Bread} bread and {Pastry} Pastry is ${customerTotal}, Arigatō!");
          Console.WriteLine();
        }
        else if (!IsValid(done))
        {
          Console.WriteLine ("Erāerā....You must enter Y or N only!! Try again, Watashi no yūjin");
        }
        else 
        {
          Console.WriteLine("Yoi, let's start your order over then... my friend, Watashi no yūjin ");
          Console.WriteLine();
        }
      }
      }
      public static int AssembleOrder(int orderBread, int orderPastry)
      {
        int orderTotal = ((Bread.BreadTotal(orderBread)) + (Pastry.PastryTotal(orderPastry)));
        return orderTotal;
      }
      public static bool IsValid(string done)
      {
        if (done == "Y" || done == "N")
        {
          return true;
        }
        else 
        {
          return false;
      }
    }
  }
}