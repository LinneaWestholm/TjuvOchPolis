using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    public class Theif : Person
    {
        public Theif(int positionY, int positionX, int directionX, int directionY, string nameGiver) : base(positionX, positionY, directionX, directionY, 'T', nameGiver)
        {
            

        }
        public void StjälFrån(Civilian civilian)
        {
            if (civilian.Inventory.Count > 0)
            {
                Random rand = new Random();
                int itemIndex = rand.Next(civilian.Inventory.Count);
                string stulenSak = civilian.Inventory[itemIndex];
                Inventory.Add(stulenSak);
                civilian.Inventory.RemoveAt(itemIndex);
                Console.WriteLine($"Tjuv rånar medborgare och tar {stulenSak}.");
                Thread.Sleep(10000);
            }
        }

        public override char Title => 'T';
    }
}
