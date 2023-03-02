using System.Collections.Generic;

public class Listing
{
    // Attributes
    private string listingWelcome = "Welcome to this guided reflection activity! Reflection is a powerful tool for self-awareness and personal growth. By taking the time to reflect, we can gain insights into our thoughts, feelings, and behaviors, and make positive changes in our lives. During this activity, we'll explore a variety of prompts and questions designed to help you delve deeper into your inner world. So find a quiet space, get comfortable, and let's begin this journey of self-discovery together.";
    private string listingInstructions = "You will be shown one randomly chosen prompt, then enter an answer in as many ways as possible to that prompt";
    private string[] prompts = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private List<string> promptList = new List<string>();

    // Methods
    public void getLstWelcome()
    {
        Console.WriteLine(listingWelcome);
    }

    public void getLstInstr()
    {
        Console.WriteLine(listingInstructions);
    }

    public void initPromptList()
    {
        promptList.AddRange(prompts);

        foreach (var i in promptList)
        {
            Console.WriteLine(i);
        }
    }
}