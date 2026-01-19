namespace _4_Loopings;

internal class Program
{
    static void Main(string[] args)
    {

        // De for loop gebruik als je precies weet hoe vaak iets herhaald moet worden.
        int teller = 0;
        for (teller = 0; teller < 10 ; teller++ )
        {
            //if (++teller == 5) continue;
            Console.WriteLine($"Iteratie {teller}");
            
        }
        Console.WriteLine(teller);

        int nummer = 0;
        while(nummer < 10 )
        {
            Console.WriteLine($"{nummer++}");
        }

        int nr = 20;
        do
        {
            Console.WriteLine($"do {nr++} while");
        }
        while (nr < 10);
    }
}
