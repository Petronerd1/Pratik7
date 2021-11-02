using System;
using System.Timers;

namespace TrafficL
{
    class Program
    {
        static int counter;
        static void Main(string[] args)
        {
            Timer tm = new Timer();
            tm.Interval = 1000;
            tm.Enabled = true;
            tm.Elapsed += new ElapsedEventHandler(tm_Elapsed);
            Console.ReadLine();
        }
        static void tm_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (counter <=15)
            {
                Console.WriteLine("STOP!");
            }
            if(counter >15 && counter<=20)
            {
                Console.WriteLine("GET READY...");
            }
            if(counter >20 && counter <=35)
            {
                Console.WriteLine("GO ^");
            }
            counter++;
        }
              
    }
}
