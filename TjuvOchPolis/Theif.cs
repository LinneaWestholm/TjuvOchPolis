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
                    Newsfeed.AddMessage($"Tjuven {Name} rånar medborgaren {civilian.Name} och tar {stulenSak}.");
                    if (civilian.Inventory.Count == 0)
                    {
                        civilian.PositionX = 120;
                        civilian.PositionY = 20;
                        Console.SetCursorPosition(1, 25);
                        Newsfeed.AddMessage($"Medborgaren {civilian.Name} är pank och behöver åka till härberget för att kunna överleva.");
                        Person.poorCivilian++;         
                        Thread.Sleep(2000);
                    }
                    Thread.Sleep(2000);
                    hasStolen = true;
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
