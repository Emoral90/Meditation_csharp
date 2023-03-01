public class Display
{
    // Attributes
    private string welcome = "==================================================\nWelcome! It's great to have you here. I know starting something new can be daunting, but don't worry, everything will be okay. You've taken the first step and that's already a huge accomplishment. We're here to support you and help you every step of the way. So take a deep breath, relax, and let's get started!\n==================================================";
    private string goodJob = "Good Job!";
    private string youFail = "You Failed! Go home";
    private char backslash = (char)92;
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

    public string getWelcome()
    {
        return welcome;
    }

    public void Spacer()
    {
        Console.WriteLine("\n");
    }

    public int getTime()
    {
        Console.WriteLine("Enter the amount of time you would like for this activity to last below");
        userTime = Console.ReadLine().Int32();
        return userTime;
    }

    public void getASCII()
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