using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program ... Mad Lib Project
      Author: ... Perla Oki
      */


      // Let the user know that the program is starting:
      string greeting = "Welcome to Mad Libs!";
      
      Console.WriteLine($"{greeting} Let the wackiness begin!\n");

      // Give the Mad Lib a title:
      string title = "A Wild Day";

      Console.WriteLine(title);
      // Define user input and variables:


      // The template for the story:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();

      Console.Write("Enter an adjective: ");
      string adjective = Console.ReadLine();
      
      Console.Write("Enter an adjective: ");
      string adjective2 = Console.ReadLine();

      Console.Write("Enter an adjective: ");
      string adjective3 = Console.ReadLine();

      Console.Write("Enter a verb: ");
      string verb = Console.ReadLine();

      Console.Write("Enter a noun: ");
      string noun = Console.ReadLine();

      Console.Write("Enter a noun: ");
      string noun2 = Console.ReadLine();

      Console.Write("Now an animal: ");
      string animal = Console.ReadLine();

      Console.Write("A food item: ");
      string food = Console.ReadLine();

      Console.Write("A fruit: ");
      string fruit = Console.ReadLine();

      Console.Write("A superhero: ");
      string hero = Console.ReadLine();

      Console.Write("A country you'd like to visit: ");
      string country = Console.ReadLine();

      Console.Write("Your favorite dessert: ");
      string dessert = Console.ReadLine();

      Console.Write("A random year: ");
      string year = Console.ReadLine();

      string story = $"This morning {name} woke up feeling {adjective}. 
                    \"It is going to be a {adjective2} day!\" Outside, a bunch of 
                    {animal}s were protesting to keep {food} in stores. They began 
                    to {verb} to the rhythm of the {noun}, which made all the {fruit}s 
                    very {adjective3}. Concerned, {name} texted {hero}, who flew {name} 
                    to {country} and dropped {name} in a puddle of frozen {dessert}. {name} 
                    woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
      
    }
  }
}
