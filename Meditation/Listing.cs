using System.Collections.Generic;

public class Listing
{
    // Attributes
    private string listingWelcome = "Welcome to this guided listing activity! Listing out daily occurrences can have several benefits, including increased mindfulness, improved memory, better perspective, reduced stress, and increased gratitude. By paying attention to what happens in our day-to-day lives, we become more aware of the present moment and our experiences in it.";
    private string listingInstructions = "You will be shown one randomly chosen prompt, then enter an answer in as many ways as possible to that prompt";
    private string[] prompts = {"Who are people that you appreciate?", 
    "What are personal strengths of yours?", 
    "Who are people that you have helped this week?", 
    "When have you felt the Holy Ghost this month?", 
    "Who are some of your personal heroes?"};
    private List<string> promptList = new List<string>();
    private List<string> userResponseList = new List<string>();
    private string userResponse;
    private int index;
    private string randPrompt;

    // Methods
    public void getLstWelcome()
    {
        Console.WriteLine(listingWelcome);
    }

    public void getLstInstr()
    {
        Console.WriteLine(listingInstructions);
    }

    public List<string> initLstPromptList()
    {
        promptList.AddRange(prompts);

        return promptList;        
    }

    public void chooseRandPrompt(List<string> aList)
    {
        Random rand = new Random();

        index = rand.Next(aList.Count());

        randPrompt = aList[index];
        Console.WriteLine(randPrompt);

    }

    public void saveResponses()
    {
        Console.WriteLine("Enter your response below. Type 'done' when you have finished answering");
        
        while (userResponse != "done")
        {
            userResponse = Console.ReadLine();
            userResponseList.Add(userResponse);
        }

        // Console.WriteLine();
        // foreach (var i in userResponseList)
        // {
        //     Console.WriteLine(i);
        // }
    }
}