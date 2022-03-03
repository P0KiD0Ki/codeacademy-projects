using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      //storing story strings as variables to make code more readable
      string startStory = "\nIt begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?";
      string firstNo = "\nNot much of an adventure if we don't leave our room!\n\nTHE END.";
      string firstYes = "\nYou walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?";
      string theRiddle = "\nA voice behind the door speaks. It says \"Answer this riddle: \"Poor people have it. Rich people need it. If you eat it you die. What is it?\"";
      string theRiddleAnswer = "\nThe door opens and NOTHING is there.\nYou turn off the light and run back to your room and lock the door.\nTHE END.";
      string wrongRiddleAnswer = "\nYou answered incorrectly. The door doesn't open.\nTHE END.";
      string lockedDoor = "\nThe door is locked! See if one of your three keys will open it.";
      string firstKey = "\nYou choose the first key. Lucky choice!\nThe door opens and NOTHING is there. Strange...\nTHE END.";
      string secondKey = "\nYou choose the second key. The door doesn't open.\nTHE END.";
      string thirdKey = "\nYou choose the second key. The door doesn't open.\nTHE END.";


      // Start by asking for the user's name:
      Console.WriteLine("CHOOSE YOUR OWN ADVENTURE!");
      Console.Write("\nWhat is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"\nHello, {name}! Welcome to our story.");

      //prints the story to the console
      Console.WriteLine(startStory);

      //gather player input
      Console.WriteLine("\nType YES or NO:");

      string noiseChoice = Console.ReadLine();
      noiseChoice = noiseChoice.ToUpper();

      //user paths
      if (noiseChoice == "YES") 
      {
        Console.WriteLine(firstYes);
        Console.WriteLine("\nType OPEN or KNOCK:");
      }
      if (noiseChoice == "NO")
      {
        Console.WriteLine(firstNo);
      } 

      //gather player input
      string doorChoice = Console.ReadLine();
      doorChoice = doorChoice.ToUpper();

      //knock on door path
      if (doorChoice == "KNOCK") 
      {
        Console.WriteLine(theRiddle);

      string riddleAnswer = Console.ReadLine();
      riddleAnswer = riddleAnswer.ToUpper();
      
      if (riddleAnswer == "NOTHING") 
      {
        Console.WriteLine(theRiddleAnswer);
      } else 
      {
        Console.WriteLine(wrongRiddleAnswer);  
      }
      } 
      //open door path
      else if (doorChoice == "OPEN") 
      {
        Console.WriteLine(lockedDoor);
        Console.Write("\nEnter a number (1-3): "); 
      }

      string keyChoice = Console.ReadLine();
      keyChoice = keyChoice.ToUpper();  

      switch (keyChoice) 
      {
        case "1":
          Console.WriteLine(firstKey);
          break;
        case "2":
          Console.WriteLine(secondKey);
          break;
        case "3":
          Console.WriteLine(thirdKey);
          break;
        default:
          Console.WriteLine("Invalid input");
          break;
      }
    }
  }
}



