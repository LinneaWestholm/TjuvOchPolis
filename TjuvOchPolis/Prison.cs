using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class Prison
    {
        public static void PrintPrison()
        {
            int width = 25;
            int height = 10;

            for (int i = 0; i < height; i++)
            {

                if (i == 0)
                {
                    //Console.Write("Fängelse");

                    for (int k = 0; k < width; k++)
                    {
                        Console.Write("=");
                    }
                    Console.WriteLine();
                }
                else if (i == height - 1)
                {

                    Console.Write("Status");


                    for (int j = 6; j < width - 1; j++)
                    {
                        Console.Write("=");
                    }

                    Console.Write(" ");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("|");

                    for (int j = 1; j < width - 1; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("|");

                    Console.WriteLine();
                }
            }
        }
    }
}
