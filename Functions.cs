namespace Uke2Innlevering;

public class Functions
{
    public void ClockOfDay()
    {
        DateTime clockNow = DateTime.Now;

        Console.WriteLine($"Klokken er: {clockNow:HH:mm}");
    }

    public void GreetingText(string userName)
    {
        int hour = DateTime.Now.Hour;
        string greeting = "";

        if (hour >= 6 && hour < 10)
            greeting = "God morgen";
        else if (hour >= 10 && hour < 14)
            greeting = "God formiddag";
        else if (hour >= 14 && hour < 18)
            greeting = "God ettermiddag";
        else if (hour >= 18 && hour < 23)
            greeting = "God kveld";
        else
            greeting = "God natt";

        Console.WriteLine($"{greeting}, {userName}");
    }
}
