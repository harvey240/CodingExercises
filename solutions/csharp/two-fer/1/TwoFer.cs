using System;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.
    public static string Speak(string name = "")
    {
        // throw new NotImplementedException("You need to implement this method.");
        
        string nameToSpeak = string.IsNullOrEmpty(name) ? "you" : name;

        string dialogue = $"One for {nameToSpeak}, one for me.";

        return dialogue;
        
    }
}
