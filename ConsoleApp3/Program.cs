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
            double frac = 3.13;
            Console.WriteLine(liczba);
            char znak = 'x';
            Console.WriteLine(frac);
            int[] Tab = new int[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                Tab[i] = SIZE - i;
            }
            if(1)
            {
                for (int i = 0; i < SIZE; i++)
                {
                    Console.Write(Tab[i]);
                    if(i == SIZE - 1)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            for (int i = 0; i < SIZE; i++)
            {
                Tab[i] = SIZE - i - 1;
            }
            if(1)
            {
                for (int i = 0; i < SIZE; i++)
                {
                    Console.Write(Tab[i]);
                    if(i == SIZE - 1)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine("{1}A{1,3}B{1,3:F}C{1,3:e}D{0}E{2}", "end", 1e-7 / 3.0, sizeof(znak));
            Console.WriteLine(Tab);
            Console.WriteLine(koncowy_tekst);
            Console.ReadKey();
        }
    }
}
