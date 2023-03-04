using System;

public class Breathing 
{    
    // Attributes
    private string breathingWelcome = "Welcome to this guided breathing activity! Controlled breathing exercises can offer several benefits for our physical and mental well-being, including reduced stress and anxiety, improved focus and concentration, lowered blood pressure, increased energy levels, and better sleep. By activating the relaxation response in our bodies, controlled breathing exercises can help to reduce stress and anxiety levels.";
    private string breatingInstructions = "Inhale for 3 seconds, following the expansion of the animated circle. Then exhale for the next 3 seconds, following the contraction of the circle";

    // Methods
    public void getBrWelcome()
    {
        Console.WriteLine(breathingWelcome);
    }

    public void getBrInstr()
    {
        Console.WriteLine(breatingInstructions);
    }

}