using System.Collections.Generic;

public class Listing
{
    // Attributes
    private string listingWelcome = "Welcome to this guided reflection activity! Reflection is a powerful tool for self-awareness and personal growth. By taking the time to reflect, we can gain insights into our thoughts, feelings, and behaviors, and make positive changes in our lives. During this activity, we'll explore a variety of prompts and questions designed to help you delve deeper into your inner world. So find a quiet space, get comfortable, and let's begin this journey of self-discovery together.";
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