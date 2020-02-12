using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {

        //Users name
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! Welcome to our story.");
        
        Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
        
        Console.Write("Type YES or NO: ");
        
        string noiseChoice = Console.ReadLine();
        string upperNoiseChoice = noiseChoice.ToUpper();
        
        if(upperNoiseChoice == "NO")
        {
          Console.WriteLine("Not much of an adventure if we don't leave our room!");
          Console.WriteLine("THE END.");
        }
        else if(upperNoiseChoice == "YES")
        {
          Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
        }
        
        Console.WriteLine("Type OPEN or KNOCK: ");
        
        string doorChoice = Console.ReadLine();
        string upperDoorChoice = doorChoice.ToUpper();
        
         if(upperDoorChoice == "KNOCK")
        {
          Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \" \"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
          Console.WriteLine("Type your answer: ");
          string riddleAnswer = Console.ReadLine();
          string upperRiddleAnswer = riddleAnswer.ToUpper();
           
           if(upperRiddleAnswer == "NOTHING")
           {
             Console.WriteLine("The door opens and NOTHING is there.You turn off the light and run back to your room and lock the door.");
             Console.WriteLine("THE END.");    
           }
           
           else
           {
             Console.WriteLine("You answered incorrectly. The door doesn't open.");
             Console.WriteLine("THE END.");
           }
          
        }
        else if(upperDoorChoice == "OPEN")
        {
          Console.WriteLine("The door is locked! See if one of your three keys will open it.");
          
          Console.Write("Enter a number (1-3): ");
          string keyChoice = Console.ReadLine();
          string upperKeyChoice = keyChoice.ToUpper();
          
          switch(upperKeyChoice)
          {
            case "1":
              Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange...");
              Console.WriteLine("THE END.");
              break;
            case "2":
              Console.WriteLine("You choose the second key. The door doesn't open.");
              Console.WriteLine("THE END.");
              break;
            case "3":
              Console.WriteLine("You choose the third key. The door doesn't open.");
              Console.WriteLine("THE END.");
              break;
            
              
          }
          
        } 

     
    }
  }
}



