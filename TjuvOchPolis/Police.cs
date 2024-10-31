using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TjuvOchPolis
{
    public class Police : Person
    {
        public Police(int positionY, int positionX, int directionX, int directionY, string name) : base(positionX, positionY, directionX, directionY, 'P', name)
        {

        }
        public void Confiscate(Police police, Theif theif)
        {
            if (theif.Inventory.Count > 0)
            {
                foreach (var item in theif.Inventory)
                {
                    police.Inventory.Add(item);
                    Console.SetCursorPosition(1, 26);
                    Console.WriteLine($"Polisen {police.Name} tar {item} som tjuven {theif.Name} har stulit.");
                    theif.PositionX = 120;
                    theif.PositionY = 5;
                    Thread.Sleep(2000);
                }
                theif.Inventory.Clear();
            }
            else
            {

                Console.SetCursorPosition(1, 26);
                Console.WriteLine($"{theif.Name} har inga stulna föremål att ta.");
            }
        }
    public override char Title => 'P';
    }
}


