using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      //Data gathering
      Console.WriteLine("Welcome to Money Maker!\n");
      Console.WriteLine("Enter an amount to convert to coins:");
      string amountAsString = Console.ReadLine();
      double amount = Math.Floor(Convert.ToDouble(amountAsString));

      Console.WriteLine($"\n{amount} cents is equal to...\n");

      //TODO: add logic that converts any input over 99 cents to dollars.

      //quarter conversion and remainder
      double quarter = 25;
      double quarters = Math.Floor(amount / quarter);
      double remainder = amount % quarter;

      //dime conversion and remainder
      double dime = 10;
      double dimes = Math.Floor(remainder / dime);
      remainder = remainder % dime;

      //nickle conversion and remainder
      double nickle = 5;
      double nickles = Math.Floor(remainder / nickle);

      //pennies
      remainder = remainder % nickle;
  
  
  Console.WriteLine($"Quarters: {quarters}\nDimes: {dimes}\nNickles: {nickles}\nPennies: {remainder}");
      
    }
  }
}
