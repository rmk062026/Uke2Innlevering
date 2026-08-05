namespace Uke2Innlevering;

public class Functions
{
    // public void DisplayDateTime()
    // {
    //     DateTime clockNow = DateTime.Now;
    //     Console.WriteLine($"Dato: {clockNow:dd.MM.yyyy}");
    //     Console.WriteLine($"Klokken: {clockNow:HH:mm}");
    // }
    public string GetDate()
    {
        return DateTime.Now.ToString("dd.MM.yyyy");
    }
    public string GetTime()
    {
        return DateTime.Now.ToString("HH:mm");
    }

    public string GetGreeting()
    {
        int hour = DateTime.Now.Hour;
        if (hour >= 6 && hour < 10)
            return "God morgen";
        else if (hour >= 10 && hour < 14)
            return "God formiddag";
        else if (hour >= 14 && hour < 18)
            return "God ettermiddag";
        else if (hour >= 18 && hour < 23)
            return "God kveld";
        else
            return "God natt";
    }

    // Old version (Keeping for learning)
    // public void ShowGreeting(string userName)
    // {
    //     int hour = DateTime.Now.Hour;
    //     string greeting;

    //     if (hour >= 6 && hour < 10)
    //         greeting = "God morgen";
    //     else if (hour >= 10 && hour < 14)
    //         greeting = "God formiddag";
    //     else if (hour >= 14 && hour < 18)
    //         greeting = "God ettermiddag";
    //     else if (hour >= 18 && hour < 23)
    //         greeting = "God kveld";
    //     else
    //         greeting = "God natt";

    //     Console.WriteLine($"{greeting}, {userName}");
    // }
}
