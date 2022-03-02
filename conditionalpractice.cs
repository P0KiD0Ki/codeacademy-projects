using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      /*  
      //number guesser program
      Console.WriteLine("Guess a Number");
      int number = Int32.Parse(Console.ReadLine());
      int min = 2;
      int max = 10;

      if (number > max || number < 1) {
        Console.WriteLine("Invalid Entry");
      } else if (number <= min) {
        Console.WriteLine("Too low!");
      } else if (number == 4 || number <= max) {
        Console.WriteLine("Too high!");
      } else { 
        Console.WriteLine("You got it!");
      }

      //fave fast food quiz
      Console.WriteLine("Tell us your favorite fast food restarurant, and we'll tell you what kind of dog you are! \n\n1. McDonald's \n2. Burger King \n3. Chick-Fil-A \n4. Popeye's \n5. In-N-Out \n6. Shake Shack \n\nEnter a number.");

      string favFastFood = Console.ReadLine();
      string prefix = "You are a...";

      switch (favFastFood) {
        case "1":
          Console.WriteLine($"{prefix} Chinese Crested");
          break;
        case "2":
          Console.WriteLine($"{prefix} Chihuahua");
          break;
        case "3":
          Console.WriteLine($"{prefix} Golden Retriever");
          break;
        case "4":
          Console.WriteLine($"{prefix} Pitbull");
          break;
        case "5":
          Console.WriteLine($"{prefix} Shiba Inu");
          break;
        case "6":
          Console.WriteLine($"{prefix} Cavapoo");
          break;
        default:
          Console.WriteLine("Invalid input"); 
          break;
      }*/

      //birthday check
      string myBDay = "12/02";
      string today = "12/02";

      if (today == myBDay) {
        Console.WriteLine(@" _   _                                ___           _   _          _               _ ");
        Console.WriteLine(@"( ) ( )                              (  _`\  _     ( )_( )        ( )             ( )");
        Console.WriteLine(@"| |_| |   _ _ _ _    _ _    _   _    | (_) )(_)_ __| ,_) |__     _| |   _ _  _   _| |");
        Console.WriteLine(@"|  _  | /'_` | '_`\ ( '_`\ ( ) ( )   |  _ <'| ( '__) | |  _ `\ /'_` | /'_` )( ) ( ) |");
        Console.WriteLine(@"| | | |( (_| | (_) )| (_) )| (_) |   | (_) )| | |  | |_| | | |( (_| |( (_| || (_) | |");
        Console.WriteLine(@"(_) (_)`\__,_) ,__/'| ,__/'`\__, |   (____/'(_|_)  `\__|_) (_)`\__,_)`\__,_)`\__, (_)");
        Console.WriteLine(@"             | |    | |    ( )_| |                                          ( )_| (_)");
        Console.WriteLine(@"             (_)    (_)    `\___/'                                          `\___/'  ");
      } else {
        Console.WriteLine("There are 275 days till your birthday");
      }
      }
    }
  }
