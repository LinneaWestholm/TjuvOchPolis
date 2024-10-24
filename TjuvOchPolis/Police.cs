using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class Police: Person
    {
        public Police(int positionY, int positionX, int directionX, int directionY, char title) : base(positionX, positionY, directionX, directionY, title)
        {
            
        }
        public override void Name(char title)
        {
            title = 'P';
        }
    }
}
