using Uke2Innlevering;
// bool programRunning = true;
bool userNameEmpty = true;
Functions functions = new Functions();
functions.ClockOfDay();
Console.WriteLine("Min innleverings oppgave\n");


Console.WriteLine("*********************");
Console.WriteLine("Skriv ditt navn:");
string userName = Console.ReadLine() ?? "";

functions.GreetingText(userName);