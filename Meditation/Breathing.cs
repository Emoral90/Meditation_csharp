using System;

public class Breathing : Display // Inheiritance
{    
    // Constructors
    Breathing br = new Breathing();

    // Attributes
    private string breathingWelcome = "Welcome to this guided breathing activity! I'm so glad you're here. Take a moment to settle into a comfortable position, and let's begin. By focusing on your breath, you can cultivate a sense of calm and relaxation, which can be incredibly beneficial for both your physical and mental wellbeing. So let's take a few deep breaths together and allow yourself to fully immerse in this experience.";

    // Methods
    public string getBrWelcome()
    {
        return breathingWelcome;
    }

}