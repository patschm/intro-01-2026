namespace _2_Operators;

internal class Program
{
    static void Main(string[] args)
    {
        // Rekenkundige
        int res1 = (3 + 4) * 2;
        double res2 = 4 / 6D;
        Console.WriteLine(res2);
        int res3 = 10 % 4;
        Console.WriteLine(res3);

        // Vergelijkingsoperatoren
        bool isWaar = 3 > 4;
        isWaar = 3 == 4;
        isWaar = 3 != 4;

        // Logische operatoren
        // &&, ||
        isWaar = false && res1 > 10;

        isWaar = true || Test();
        Console.WriteLine();

        int a = 10;

        a = a + 10;
        a += 10;
        Console.WriteLine(a);


        a = 0;

        a = a + 1;
        a += 1;

        Console.WriteLine(a++);

        bool Test()
        {
            Console.WriteLine("Ok");
            return true;
        }

    }
}
