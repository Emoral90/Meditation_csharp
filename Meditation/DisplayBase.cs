public class Display
{
    // Attributes
    private string welcome = "";
    private string goodJob = "Good Job!";
    private string youFail = "You Failed! Go home";
    public string userChoice;

    // Methods
    public string getGoodJob()
    {
        return goodJob;
    }

    public string getYouFail()
    {
        return youFail;
    }

    private void Spacer()
    {
        Console.WriteLine("\n");
    }

    public string Menu()
    {
        while (userChoice != "quit")
        {
            Spacer();
            Console.WriteLine("");
        }
    }
}