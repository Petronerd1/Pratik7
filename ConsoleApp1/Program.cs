using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            ArrayList oddN = new ArrayList();
            ArrayList evenN = new ArrayList();
            int average = 0, sum = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int number = rnd.Next(1, 100);
                Console.Write(number + "   ");
                sum += number;
                if (number % 2 == 0)
                {
                    evenN.Add(number);
                }
                else
                {
                    oddN.Add(number);
                }

            }
            Console.WriteLine();
            Console.WriteLine("============================================================");
            average = sum / 10;

            Console.WriteLine("Number Average : {0}", average);
            Console.WriteLine("Odd Numbers Amount : {0}", oddN.Count);
            Console.WriteLine("Even Numbers Amount : {0}", evenN.Count);
            Console.ReadKey();
        }
    }
}

