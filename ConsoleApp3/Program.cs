﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int SIZE = 14;
            string koncowy_tekst = "Wiosna lato zima\n";
            int liczba = 2048;
            double frac = 3.13;
            Console.WriteLine(liczba);
            char znak = 'x';
            Console.WriteLine(frac);
            int[] Tab = new int[SIZE];
            if(false)
            {
                StreamWriter zz = new StreamWriter(@"e:\abc.txt");
                zz.WriteLine("inne");
                zz.Close();
            }
            Console.WriteLine("Zadanie 1");
            for (int i = 0; i < SIZE; i++)
            {
                Tab[i] = SIZE - i;
            }
            if(true)
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
            if(true)
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
            Console.WriteLine("Zadanie 2");
            int ROW = 3;
            int COL = 5;
            int cell_value;
            int [, ] rect_a = new int [ROW, COL];
            for (int row_nr = 0; row_nr < ROW; row_nr++)
            {
                for (int col_nr = 0; col_nr < COL; col_nr++)
                {
                    cell_value = col_nr + 1 + row_nr * COL;
                    rect_a[row_nr, col_nr] = cell_value;
                }
            }
            if(true)
            {
                for (int row_nr = 0; row_nr < ROW; row_nr++)
                {
                    for (int col_nr = 0; col_nr < COL; col_nr++)
                    {
                        Console.Write(rect_a[row_nr, col_nr]);
                        if(col_nr == COL - 1)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
            Console.WriteLine("Zadanie 3");
            int IR_ROWS = 4;
            int [][] irreg = new int [IR_ROWS][];
            irreg[0] = new int [4] {1, 2, 3, 4};
            irreg[1] = new int [2] {5, 6};
            irreg[2] = new int [3] {7, 8, 9};
            irreg[3] = new int [1] {10};
            if(true)
            {
                for (int row_nr = 0; row_nr < irreg.Length; row_nr++)
                {
                    for (int col_nr = 0; col_nr < irreg[row_nr].Length; col_nr++)
                    {
                        Console.Write(irreg[row_nr][col_nr]);
                        if(col_nr == irreg[row_nr].Length - 1)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
            if(true)
            {
                foreach(int[] one_row in irreg)
                {
                    foreach(int one_elem in one_row)
                    {
                        Console.Write(one_elem);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Zadanie 4");
            int RAND_ROW = 6;
            int RAND_COL = 4;
            int [, ] rand_a = new int [RAND_ROW, RAND_COL];
            Random rnd = new Random();
            int rand_value;
            for (int row_nr = 0; row_nr < RAND_ROW; row_nr++)
            {
                for (int col_nr = 0; col_nr < RAND_COL; col_nr++)
                {
                    rand_value = rnd.Next(10, 13);
                    rand_a[row_nr, col_nr] = rand_value;
                }
            }
            if(true)
            {
                for (int row_nr = 0; row_nr < RAND_ROW; row_nr++)
                {
                    for (int col_nr = 0; col_nr < RAND_COL; col_nr++)
                    {
                        Console.Write(rand_a[row_nr, col_nr]);
                        if(col_nr == RAND_COL - 1)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
            /* Koniec zadan */
            Console.WriteLine("{1} A: {1,3} B: {1,3:F} C: {1,3:e} D: {0} E: {2} F: {3}", "end", 1e-5 / 3.0, sizeof(char), znak);
            Console.WriteLine(Tab);
            Console.WriteLine(koncowy_tekst);
            Console.ReadKey();
        }
    }
}
