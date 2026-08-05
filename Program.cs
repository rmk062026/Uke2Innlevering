using Uke2Innlevering;
Functions functions = new Functions();

Console.WriteLine("===============================");
Console.WriteLine("Min innleveringsoppgave");
Console.WriteLine("===============================\n");
Console.WriteLine("Skriv ditt navn:\n");

string userName = Console.ReadLine() ?? "";

// Runs while the user name is empty or contains only whitespace
while (string.IsNullOrWhiteSpace(userName))
{
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
}

Console.WriteLine($"{functions.GetGreeting()}, {userName}.\nI dag er det {functions.GetDate()} og klokken er {functions.GetTime()}.\n{functions.GetMessageOfDay()} :)");