using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      //global variables
      int minLength = 8;
      string uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
      string lowercase = "qwertyuiopasdfghjklzxcvbnm";
      string digits = "1234567890";
      string specialChars = "!@#$%^&*()";

      Console.WriteLine("Please enter a password...");
      string input = Console.ReadLine();

      //increases password score
      int score = 0;

      if (input.Length >= minLength) 
      {
        score++;
      }
      if (Tools.Contains(input, uppercase))
      {
        score++;
      }
      if (Tools.Contains(input, lowercase))
      {
        score++;
      }
      if (Tools.Contains(input, digits))
      {
        score++;
      }
      if (Tools.Contains(input, specialChars))
      {
        score++;
      }

      //print the password score
      Console.WriteLine($"\nYour password score is {score}.");

      //let user know strength of password -- These instructions are doing too much. 
      string message = score.ToString();

      switch (message) {
        case "5":
          Console.WriteLine("Password strength is very strong!");
          break;
        case "4":
          Console.WriteLine("Password strength is strong!");
          break;
        case "3":
          Console.WriteLine("Password strength is average.");
          break;
        case "2":
          Console.WriteLine("Password strength is weak.");
          break;
        case "1":
          Console.WriteLine("Password strength is very weak.");
          break;
        default:
          Console.WriteLine("Password meets none of the standards.");
          break;
      }
    }
  }
}