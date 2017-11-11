using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 15;
            string koncowy_tekst = "Wiosna lato zima\n";
            int liczba = 2048;
            double frac = 3.12;
            Console.WriteLine(liczba);
            char znak = 'x';
            Console.WriteLine(frac);
            int[] Tab = new int[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                Tab[i] = i * 8;
            }
            for (int i = SIZE - 1; i >= 0; i--)
            {
                Console.WriteLine(Tab[i]);

            }
            Console.WriteLine(koncowy_tekst);
            Console.ReadKey();


        }
    }
}
