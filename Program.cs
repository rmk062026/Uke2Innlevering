using Uke2Innlevering;
// bool programRunning = true;
// bool userNameEmpty = true;
Functions functions = new Functions();
functions.ClockOfDay();
Console.WriteLine("Min innleverings oppgave\n");


Console.WriteLine("*********************");
Console.WriteLine("Skriv ditt navn:");
string userName = Console.ReadLine() ?? "";

if (string.IsNullOrWhiteSpace(userName))
{
    while (string.IsNullOrWhiteSpace(userName))
    {
        Console.WriteLine("");
        Console.WriteLine("Navnet kan ikke være tomt.");
        Console.WriteLine("1. Skriv navnet på nytt.");
        Console.WriteLine("2. Avslutt programmet.");
        Console.WriteLine("Velg mellom 1-2:");

        string menuChoice = Console.ReadLine() ?? "";

        if (menuChoice == "1")
        {
            Console.WriteLine("Skriv navnet ditt:");
            userName = Console.ReadLine() ?? "";
        }
        else if (menuChoice == "2")
        {
            Console.WriteLine("Avslutter programmet...");
            return;
        }
        else
        {
            Console.WriteLine("Ugyldig valg... Prøv igjen...");
        }
        functions.GreetingText(userName);
    }
}
else
{
    functions.GreetingText(userName);
}