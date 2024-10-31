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
                    Console.SetCursorPosition(110, 0);
                    for (int k = 0; k < width; k++)
                    {

                        Console.Write("=");
                    }
                    Console.WriteLine();
                }
                else if (i == height - 1)
                {
                    Console.SetCursorPosition(110, 9);
                    Console.Write("Fängelse");

                    for (int j = 7; j < width - 1; j++)
                    {
                        Console.Write("=");
                    }

                    Console.Write(" ");
                    Console.WriteLine();
                }
                else
                {
                    Console.SetCursorPosition(110, i);
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
