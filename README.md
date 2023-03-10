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

### Breathing activity
* The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
* The description of this activity should be something like: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
* After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
* After each message, the program should pause for several seconds and show a countdown.
* It should continue until it has reached the number of seconds the user specified for the duration.
* The activity should conclude with the standard finishing message for all activities.

### Listing activity
* The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
* The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
* The description of this activity should be something like: "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
* After the starting message, select a random prompt to show the user such as:

    * Who are people that you appreciate?
    * What are personal strengths of yours?
    * Who are people that you have helped this week?
    * When have you felt the Holy Ghost this month?
    * Who are some of your personal heroes?

* After displaying the prompt, the program should give them a countdown of several seconds to begin thinking about the prompt. Then, it should prompt them to keep listing items.
* The user lists as many items as they can until they they reach the duration specified by the user at the beginning.
* The activity them displays back the number of items that were entered.
* The activity should conclude with the standard finishing message for all activities.

### Reflecting activity
* The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
* The description of this activity should be something like: "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
* After the starting message, select a random prompt to show the user such as:

    * Think of a time when you stood up for someone else.
    * Think of a time when you did something really difficult.
    * Think of a time when you helped someone in need.
    * Think of a time when you did something truly selfless.

* After displaying the prompt, the program should ask the to reflect on questions that relate to this experience. These questions should be pulled from a list such as the following:

    * Why was this experience meaningful to you?
    * Have you ever done anything like this before?
    * How did you get started?
    * How did you feel when it was complete?
    * What made this time different than other times when you were not as successful?
    * What is your favorite thing about this experience?
    * What could you learn from this experience that applies to other situations?
    * What did you learn about yourself through this experience?
    * How can you keep this experience in mind in the future?

* After each question the program should pause for several seconds before continuing to the next one. While the program is paused it should display a kind of spinner.
* It should continue showing random questions until it has reached the number of seconds the user specified for the duration.
* The activity should conclude with the standard finishing message for all activities.

### Total classes
* 5 total classes
    * Program
    * DisplayBase
    * Breathing
    * Listening
    * Reflecting