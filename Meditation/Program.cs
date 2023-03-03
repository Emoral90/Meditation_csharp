using System;
using System.Threading;
using System.Collections.Generic;

// Inheirit the Display class. Creating a Program child class
class Program : Display
{
    // Attributes
    static string userChoice;
    static List<string> thePromptList = new List<string>();
    static List<string> theQuestionList = new List<string>();
    static void Main()
    {
        // Constructors
        Program p = new Program();
        Breathing b = new Breathing();
        Listing l = new Listing();
        Reflecting r = new Reflecting();

        // Main menu
        while (userChoice != "quit")
        {
            p.Clear();
            p.getWelcome();// getWelcome method inheirited from Display class
            Console.WriteLine("Please Enter a number to choose an activity\nOr type 'quit' to exit the program");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1) Breathing\n2) Listing\n3) Reflecting\nQuit");
            userChoice = Console.ReadLine();
            
            if (userChoice == "1") // Breathing
            {
                p.Clear();
                b.getBrWelcome();
                p.Spacer();
                b.getBrInstr();
                p.Spacer();

                int userTime = p.getTime();
                p.getASCII(userTime);

                p.Clear();
            }           
            else if (userChoice == "2") // Listing
            {
                p.Clear();
                l.getLstWelcome();
                p.Spacer();
                l.getLstInstr();
                p.Spacer();
                
                thePromptList = l.initLstPromptList();
                l.chooseRandPrompt(thePromptList);
                p.Spacer();
                l.saveResponses();

                p.Clear();

            }
            else if (userChoice == "3") // Reflecting
            {
                p.Clear();
                r.getRfWelcome();
                p.Spacer();
                r.getRfInstructions();
                p.Spacer();

                thePromptList = r.initRfPromptList();
                r.chooseRandPrompt(thePromptList);
                p.Spacer();
                theQuestionList = r.initRfQuestionList();
                r.choose3RandQuestions(theQuestionList);

                p.timer(10);

                p.Clear();
                
            }
        }
    }
}