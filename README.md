# Meditation_csharp
Consider an app that provides three different kinds of mindfulness opportunities. It could give some guidance and structure to users in the following activities: breathing, reflecting, listening

## Design requirements
1. Use inheritance by having a separate class for each kind of activity with a base class to contain any shared attributes or behaviors.
2. Avoid duplicating code in classes where it could instead be placed in a base class.
3. Follow the principles of encapsulation and abstraction by having private member variables and putting related items in the same class.

## Functional requirements
1. Have a menu system to allow the user to choose an activity.
2. Each activity should start with a common starting message that provides the name of the activity, a description, and asks for and sets the duration of the activity in seconds. Then, it should tell the user to prepare to begin and pause for several seconds.
3. Each activity should end with a common ending message that tells the user they have done a good job, and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
4. Whenever the application pauses it should show some kind of animation to the user, such as a spinner, a countdown timer, or periods being displayed to the screen.
5. The interface for the program should remain generally true to the one shown in the video demo.
6. Provide activities for reflection, breathing, and enumeration, as described below

## Total classes
* 5 total classes?
    * Program
    * DisplayBase
    * Breathing
    * Listening
    * Reflecting