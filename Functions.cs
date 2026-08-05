namespace Uke2Innlevering;

public class Functions
{
    private readonly DateTime currentDateTime = DateTime.Now;
    public string GetDate()
    {
        return currentDateTime.ToString("dd.MM.yyyy");
    }
    public string GetTime()
    {
        return currentDateTime.ToString("HH:mm");
    }

    public string GetGreeting()
    {
        int hour = currentDateTime.Hour;
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
}
