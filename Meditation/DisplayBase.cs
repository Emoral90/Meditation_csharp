using System;

public class Display
{
    // Attributes
    private string welcome = "====================================================================================================\nWelcome! It's great to have you here. I know starting something new can be daunting, but don't worry, everything will be okay. You've taken the first step and that's already a huge accomplishment. We're here to support you and help you every step of the way. So take a deep breath, relax, and let's get started!\n====================================================================================================";
    private string goodJob = "Good Job!";
    private string youFail = "You Failed! Go home";
    // private char backslash = (char)92;
    private int userTime;
    // Methods
    public string getGoodJob()
    {
        return goodJob;
    }

    public string getYouFail()
    {
        return youFail;
    }

    public void getWelcome()
    {
        Console.WriteLine(welcome);
    }

    public void Spacer()
    {
        Console.WriteLine("\n");
    }

    public void Clear()
    {
        Console.Clear();
    }

    public int getTime()
    {
        Console.WriteLine("Choose the number option of time you would like for this activity to last below");
        while (true)
        {
            Console.WriteLine("1) 30 seconds");
            Console.WriteLine("2) 1 minute");
            Console.WriteLine("3) 2 minutes");
            string userTimeStr = Console.ReadLine();
            userTime = Convert.ToInt32(userTimeStr);

            if (userTime == 1)
            {
                getASCII(5);
                break;
            }
            else if (userTime == 2)
            {
                getASCII(10);
                break;
            }
            else if (userTime == 3)
            {
                getASCII(20);
                break;
            }
            
        }
        
        return userTime;
    }

    private void timer(int seconds)
    {
        Console.WriteLine($"The timer will now run for {seconds} seconds");

        int totalTime = seconds * 1000;
        Thread.Sleep(totalTime);
        Console.WriteLine($"Thread has slept for {totalTime} milliseconds");
    }

    public void getASCII(int seconds)
    {
        for (int i=0; i<seconds; i++)
        {
            Console.Clear();

            Console.WriteLine("                   ");
            Console.WriteLine("                   ");
            Console.WriteLine("                   ");
            Console.WriteLine("         0         ");
            Console.WriteLine("                   ");
            Console.WriteLine("                   ");
            Console.WriteLine("                   ");
                        
            Thread.Sleep(1000); // Pause for 1 second before clearing the console
            Console.Clear();

            Console.WriteLine("                   ");
            Console.WriteLine("                   ");
            Console.WriteLine("        0 0        ");
            Console.WriteLine("       0   0       ");
            Console.WriteLine("        0 0        ");
            Console.WriteLine("                   ");
            Console.WriteLine("                   ");
                        
            Thread.Sleep(1000); // Pause for 1 second before clearing the console
            Console.Clear();

            Console.WriteLine("                   ");
            Console.WriteLine("         0         ");
            Console.WriteLine("       0   0       ");
            Console.WriteLine("      0     0      ");
            Console.WriteLine("       0   0       ");
            Console.WriteLine("         0         ");
            Console.WriteLine("                   ");
                        
            Thread.Sleep(1000); // Pause for 1 second before clearing the console
            Console.Clear();

            Console.WriteLine("        0 0        ");
            Console.WriteLine("      0     0      ");
            Console.WriteLine("    0         0    ");
            Console.WriteLine("   0           0   ");
            Console.WriteLine("    0         0    ");
            Console.WriteLine("      0     0      ");
            Console.WriteLine("        0 0        ");
                        
            Thread.Sleep(1000); // Pause for 1 second before clearing the console
            Console.Clear();

            Console.WriteLine("                   ");
            Console.WriteLine("         0         ");
            Console.WriteLine("       0   0       ");
            Console.WriteLine("      0     0      ");
            Console.WriteLine("       0   0       ");
            Console.WriteLine("         0         ");
            Console.WriteLine("                   ");
                        
            Thread.Sleep(1000); // Pause for 1 second before clearing the console
            Console.Clear();

            Console.WriteLine("                   ");
            Console.WriteLine("                   ");
            Console.WriteLine("        0 0        ");
            Console.WriteLine("       0   0       ");
            Console.WriteLine("        0 0        ");
            Console.WriteLine("                   ");
            Console.WriteLine("                   ");
                        
            Thread.Sleep(1000); // Pause for 1 second before clearing the console
        }

        
    }
}