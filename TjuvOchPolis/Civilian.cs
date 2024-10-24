using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{

    internal class Civilian : Person
    {

        public Civilian(int positionY, int positionX, int directionX, int directionY ) : base(positionX, positionY, directionX, directionY, 'C')
        {
            //inventory.Add("Nycklar");
            //inventory.Add("Mobiltelefon");
            //inventory.Add("Pengar");
            //inventory.Add("Klocka");

        }

        public override char Title => 'C';
       
       
       


            }

        }
    

