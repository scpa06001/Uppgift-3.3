using System;

namespace uppgift_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur länge vill du hyra bilen? (Du får bara låna bilen i maximalt 11 timmar. Skriv också svaret i heltal.");
            int hyra = int.Parse(Console.ReadLine());

            switch (hyra)
            {
                case > 11:
                    Console.WriteLine("Du får inte hyra bilen så länge.");
                    break;

                default:
                    int summa = hyra * 80;
                    Console.WriteLine("Hyran är " + summa + " kr.");
                    break;
            }
            Console.ReadKey();

        }
    }
}
