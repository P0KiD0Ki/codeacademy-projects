using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!\n");
      Console.WriteLine("Enter an amount to convert to coins:");
      string amount = Console.ReadLine();
      double amountAsDouble = Convert.ToDouble(amount);

      Console.WriteLine($"{amountAsDouble} cents is equal to...");

      double gold = 10;
      double silver = 5;
  
  
  //Console.WriteLine($"{gold} \n {silver}");
      
    }
  }
}
