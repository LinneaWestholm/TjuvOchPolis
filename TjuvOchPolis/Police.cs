using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TjuvOchPolis
{
    internal class Police : Person
    {
        public Police(int positionY, int positionX, int directionX, int directionY) : base(positionX, positionY, directionX, directionY, 'P')
        {
           
        }
        public void Confiscate(Police police, Theif theif)
        {
            if (theif.Inventory.Count > 0)
            {

                int itemIndex = theif.Inventory.Count;
                string stulenSak = theif.Inventory[itemIndex];
                Inventory.Add(stulenSak);
                theif.Inventory.RemoveAt(itemIndex);
                Console.WriteLine($"{police} tar {stulenSak} som {theif} har stulit.");

            }
        }
        public override char Title => 'P';

    }
}

