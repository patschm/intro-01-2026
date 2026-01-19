namespace _5_FuncProcs;

internal class Program
{
    static void Main(string[] args)
    {
       ShowWelcomeScreen();
       string fullName = QueryName();
        ShowTheName(fullName);
    }

    // Procedures geven niks terug
    static void ShowWelcomeScreen()
    {
        Console.WriteLine("Welkom user");
    }
    
    static void ShowTheName(string name)
    {
        Console.WriteLine($"De naam is {name}");
    }

    // Functions geven altijd wat terug
    static string QueryName()
    {
        Console.Write("Geeft voornaam: ");
        string voornaam = Console.ReadLine();
        Console.Write("Geef achternaam: ");
        string achternaam = Console.ReadLine();

        return TelOp(voornaam, achternaam);
    }

    static string TelOp(string first, string last)
    {
        return $"{first} {last}";
    }

    // Overload
    static int TelOp(int a, int b)
    {
        return a + b;
    }

}
