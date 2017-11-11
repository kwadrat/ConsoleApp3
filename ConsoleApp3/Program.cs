using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        const int SIZE = 15;
        string koncowy_tekst = "Wiosna lato zima\n";
        static void Main(string[] args)
        {
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
