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

    public string Menu()
    {
        while (userChoice != "quit")
        {
            Console.WriteLine("");
        }
    }
}