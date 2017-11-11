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
            int[] Tab = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Tab[i] = i * 7;
            }
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(Tab[i]);

            }
            Console.WriteLine("Wiosna lato zima\n");
            Console.ReadKey();


        }
    }
}
