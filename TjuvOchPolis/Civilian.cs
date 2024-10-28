using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{

    internal class Medborgare : Person
    {

        public Medborgare(int positionY, int positionX, int directionX, int directionY ) : base(positionX, positionY, directionX, directionY, 'C')
        {
    

        }

        public override char Title => 'C';
       
       
       


            }

        }
    

