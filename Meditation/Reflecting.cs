using System.Collections.Generic;

public class Reflecting
{
    // Attributes
    private string reflectingWelcome = "Welcome to this guided reflection activity! Reflection is a powerful tool for self-awareness and personal growth. By taking the time to reflect, we can gain insights into our thoughts, feelings, and behaviors, and make positive changes in our lives. During this activity, we'll explore a variety of prompts and questions designed to help you delve deeper into your inner world. So find a quiet space, get comfortable, and let's begin this journey of self-discovery together.";
    private string reflectingInstructions = "You will be shown one randomly chosen prompt, then you will be given a few seconds reflect on that prompt with supplemental questions";
    private string[] prompts = {"Think of a time when you stood up for someone else", 
    "Think of a time when you did something really difficult", 
    "Think of a time when you helped someone in need", 
    "Think of a time when you did something truly selfless"};
    private string[] suppQuestions = {"Why was this experience meaningful to you?", 
    "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", 
    "What made this time different than other times when you were not as successful?", 
    "What is your favorite thing about this experience?", 
    "What could you learn from this experience that applies to other situations?", 
    "What did you learn about yourself through this experience?", 
    "How can you keep this experience in mind in the future?"};
    private List<string> promptList = new List<string>();
    private List<string> questionList = new List<string>();
    private int index;
    private string randPrompt;

    // Methods
    public List<string> initRfPromptList() // Duplicated. Use polymorphism
    {
        promptList.AddRange(prompts);

        // foreach (var i in promptList)
        // {
        //     Console.WriteLine(i);
        // }

        return promptList;
    }

    public List<string> initRfQuestionList()
    {
        questionList.AddRange(suppQuestions);

        return questionList;
    }

    public void chooseRandPrompt(List<string> aList) // Duplicated. Use polymorphism
    {
        Random rand = new Random();

        index = rand.Next(aList.Count());

        randPrompt = aList[index];
        Console.WriteLine(randPrompt);
    }

    public void choose3RandQuestions(List<string> bList)
    {
        Random rand = new Random();
        List<int> indexList = new List<int>();

        for (int i=0; i<3; i++)
        {
            index = rand.Next(bList.Count());
            indexList.Add(index);
        }
        
        // foreach (var item in indexList)
        // {
        //     Console.WriteLine(item);
        // }

        foreach (var j in indexList)
        {
            Console.WriteLine(bList[j]);
        }
    }

    public void getRfWelcome()
    {
        Console.WriteLine(reflectingWelcome);
    }

    public void getRfInstructions()
    {
        Console.WriteLine(reflectingInstructions);
    }
}