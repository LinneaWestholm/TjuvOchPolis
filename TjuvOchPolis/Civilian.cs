using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{

    public class Civilian : Person
    {

        public Civilian(int positionY, int positionX, int directionX, int directionY, string nameGiver ) : base(positionX, positionY, directionX, directionY, 'C', nameGiver)
        {

            Inventory.AddRange(new List<string> { "Nycklar", "Klocka", "Mobiltelefon", "Pengar" });

        }

        public override char Title => 'C';
       
       
       


            }

        }
    

