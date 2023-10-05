using System;
using System.Diagnostics.SymbolStore;

namespace ConsoleApp26
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är låten?");
            string x = Console.ReadLine();
            int mellanslagsindex = x.IndexOf(' ');

            string tal1 = x[..mellanslagsindex];
            int minuter = int.Parse(tal1);
            string tal2 = x[(mellanslagsindex + 1)..];
            int sekunder = int.Parse(tal2);

            int sum = minuter * 60;
            int längd = sum + sekunder;

            if (längd >= 165 && längd <= 260)
            {
                Console.WriteLine("Din låt får spelas på radio");
            }
            else
            {
                Console.WriteLine("Din låt får inte spelas");
            }
           Console.ReadKey();


        }

    }
}
