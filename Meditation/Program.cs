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
            p.Clear();
            p.getWelcome();// getWelcome method inheirited from Display class
            Console.WriteLine("Please Enter a number to choose an activity\nOr type 'quit' to exit the program");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1) Breathing\n2) Listing\n3) Reflecting\nQuit");
            userChoice = Console.ReadLine();
            
            if (userChoice == "1")
            {
                p.Clear();
                b.getBrWelcome();
                p.Spacer();
                b.getBrInstr();
                p.Spacer();

                int userTime = p.getTime();
                // p.timer(userTime);
                p.getASCII(userTime);

                p.Clear();
            }           
            else if (userChoice == "2")
            {

            }
            else if (userChoice == "3")
            {

            }
        }
    }
}