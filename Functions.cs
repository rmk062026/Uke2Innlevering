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
    public string GetMessageOfDay()
    {
        Dictionary<DayOfWeek, string> dayMessage =
        new Dictionary<DayOfWeek, string>()
        {
            {DayOfWeek.Monday, "Ha en fin Mandag"},
            {DayOfWeek.Tuesday, "Nyt Tirsdagen"},
            {DayOfWeek.Wednesday, "Halveis til helg nå. Ha en fin Onsdag"},
            {DayOfWeek.Thursday, "Straks helg."},
            {DayOfWeek.Friday, "Idag er det endelig Fredag. Nyt helgen!"},
            {DayOfWeek.Saturday, "Lørdagssnop"},
            {DayOfWeek.Sunday, "Slapp av idag. Nyt Søndagen før uken begynner igjen."}
        };
        DayOfWeek today = currentDateTime.DayOfWeek;
        return dayMessage[today];
    }
}