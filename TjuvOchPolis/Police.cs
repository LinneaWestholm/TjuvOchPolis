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
        private bool hasConfiscated = false;
        public Police(int positionY, int positionX, int directionX, int directionY, string name) : base(positionX, positionY, directionX, directionY, 'P', name)
        {
        }
        public void Confiscate(Police police, Theif theif)
        {
            if (!hasConfiscated)
            {


                if (theif.Inventory.Count > 0)
                {
                    foreach (var item in theif.Inventory)
                    {
                        police.Inventory.Add(item);
                        Newsfeed.AddMessage($"Polisen {police.Name} tar {item} som tjuven {theif.Name} har stulit.");
                        theif.PositionX = 120;
                        theif.PositionY = 5;
                        Thread.Sleep(2000);
                    }
                    Person.theifInPrison++;
                    theif.Inventory.Clear();
                }
                else
                {
                    Newsfeed.AddMessage($"Polisen {police.Name} träffar på tjuven {theif.Name} som är laglydig.");
                }
                hasConfiscated=true;
            }
        }
        public void HasConfiscated()
        {
            hasConfiscated = false;
        }
        public override char Title => 'P';
    }
}


