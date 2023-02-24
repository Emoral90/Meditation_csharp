public class Display
{
    // Attributes
    private string welcome = "";
    private string goodJob = "Good Job!";
    private string youFail = "You Failed! Go home";
    private char backslash = (char)92;
    // Methods
    public string getGoodJob()
    {
        return goodJob;
    }

    public string getYouFail()
    {
        return youFail;
    }

    public void Spacer()
    {
        Console.WriteLine("\n");
    }

    public void getASCII()
    {
        while (true)
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