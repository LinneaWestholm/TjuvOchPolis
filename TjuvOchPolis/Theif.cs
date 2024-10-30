using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    public class Theif : Person
    {
        private bool hasStolen = false;
        public Theif(int positionY, int positionX, int directionX, int directionY, string name) : base(positionX, positionY, directionX, directionY, 'T', name)
        {
            

        }
        public void StjälFrån(Civilian civilian)
        {
            if (!hasStolen)
            {
                if (civilian.Inventory.Count > 0)
                {
                    Random rand = new Random();
                    int itemIndex = rand.Next(civilian.Inventory.Count);
                    string stulenSak = civilian.Inventory[itemIndex];
                    Inventory.Add(stulenSak);
                    civilian.Inventory.RemoveAt(itemIndex);

                    Console.SetCursorPosition(1, 25);
                    Console.WriteLine($"{Name} rånar {civilian.Name} och tar {stulenSak}.");
                    civilian.PositionX = 120;
                    civilian.PositionY = 5;
                    Thread.Sleep(2000);
                    hasStolen = true;

                }
                else
                {
                    Console.SetCursorPosition(1, 25);
                    Console.WriteLine($"{civilian.Name} har inga saker kvar.");
                    Thread.Sleep(2000);
                }
            }
        }
        public void Stolen()
        {
            hasStolen = false;
        }

        public override char Title => 'T';
    }
}
