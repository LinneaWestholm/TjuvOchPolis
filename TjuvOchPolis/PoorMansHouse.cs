using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    public class PoorMansHouse
    {
        public static void PrintPoorMansHouse()
        {
            int width = 25;
            int height = 13;

            for (int i = 0; i < height; i++)
            {
                if (i == 0)
                {
                    Console.SetCursorPosition(110, 12);
                    for (int k = 0; k < width; k++)
                    {

                        Console.Write("=");
                    }
                    Console.WriteLine();
                }
                else if (i == height - 1)
                {
                    Console.SetCursorPosition(110, 24);
                    Console.Write("Härberge");

                    for (int j = 7; j < width - 1; j++)
                    {
                        Console.Write("=");
                    }

                    Console.Write(" ");
                    Console.WriteLine();
                }
                else
                {
                    Console.SetCursorPosition(110, i+12);
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

