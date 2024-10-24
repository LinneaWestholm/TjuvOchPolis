using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class City
    {
        public static void Print()
        {
            int width = 100;
            int height = 26;

            for (int i = 0; i < height; i++)
            {
                if (i == 0)
                {
                    Console.Write("City");

                    for (int k = 4; k < width; k++)
                    {
                        Console.Write("=");
                    }
                    Console.WriteLine();
                }
                else if (i == height - 2)
                {

                    Console.Write("Fängelse");


                    for (int j = 8; j < width - 1; j++)
                    {
                        Console.Write("=");
                    }

                    Console.Write(" ");
                    Console.WriteLine();
                }
                else if (i == height - 1)
                {
                }
                else
                {
                    Console.Write("X");

                    for (int j = 1; j < width - 1; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("X");
                    Console.WriteLine();

                }
            }
            Prison.PrintPrison();
        }
    }
}
