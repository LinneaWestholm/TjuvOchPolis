using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class Theif : Person
    {
        public Theif(int positionY, int positionX, int directionX, int directionY) : base(positionX, positionY, directionX, directionY, 'T')
        {
            

        }

        public void StjälFrån(Medborgare medborgare)
        {
            if (medborgare.Inventory.Count > 0)
            {
                Random rand = new Random();
                int itemIndex = rand.Next(medborgare.Inventory.Count);
                string stulenSak = medborgare.Inventory[itemIndex];
                Inventory.Add(stulenSak);
                medborgare.Inventory.RemoveAt(itemIndex);
                Console.WriteLine($"Tjuv rånar medborgare och tar {stulenSak}.");
                Thread.Sleep(2000);
            }
        }


        public override char Title => 'T';
    }
}
