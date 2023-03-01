using System;

public class Breathing // Inheiritance
{    
    // // Constructors
    // Breathing br = new Breathing();

    // Attributes
    private string breathingWelcome = "Welcome to this guided breathing activity! I'm so glad you're here. Take a moment to settle into a comfortable position, and let's begin. By focusing on your breath, you can cultivate a sense of calm and relaxation, which can be incredibly beneficial for both your physical and mental wellbeing. So let's take a few deep breaths together and allow yourself to fully immerse in this experience.";
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