namespace _3_Branching;

internal class Program
{
    static void Main(string[] args)
    {
        int rnd = Random.Shared.Next(1, 3);

        if (rnd == 2)
        {
            Console.WriteLine($"{rnd} is een even getal");
        }
        else
        {
            Console.WriteLine("{0} is een oneven getal", rnd);
        }


        rnd = Random.Shared.Next(1, 6);
        switch (rnd)
        {
            case 1:
                Console.WriteLine("Een");
                break;
            case 2:
                Console.WriteLine("Twee");
                break;
            case 3:
                Console.WriteLine("Drie");
                break;
            case 4:
                Console.WriteLine("Vier");
                break;
            default:
                Console.WriteLine($"{rnd} is iets anders");
                break;
        }
    }
}
