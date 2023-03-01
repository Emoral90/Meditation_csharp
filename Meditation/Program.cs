using System;
using System.Threading;

// Inheirit the Display class. Creating a Program child class
class Program : Display
{
    static string userChoice;
    static void Main()
    {
        // Constructors
        Program p = new Program();
        Breathing b = new Breathing();

        // p.getASCII();

        // Main menu
        while (userChoice != "quit")
        {
            p.Spacer(); // Spacer() method inheirited from Display class
            p.getWelcome();
            Console.WriteLine("Please Enter a number to choose an activity\nOr type 'quit' to exit the program");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1) Breathing\n2) Listening\n3) Reflecting\n4) ASCII art\nQuit");
            userChoice = Console.ReadLine();
            
            if (userChoice == "1")
            {
                b.getBrWelcome();
            }           
            else if (userChoice == "2")
            {

            }
            else if (userChoice == "3")
            {

            }
            else if (userChoice == "4")
            {
                p.getASCII();
            }

        }
    }
}