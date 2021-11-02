using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    Console.Write("{0}*{1}={2}	", b, a, (b * a));
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
