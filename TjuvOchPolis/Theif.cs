﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class Theif: Person
    {
        public Theif(int positionY, int positionX, int directionX, int directionY) : base(positionX, positionY,directionX,directionY, 'T')
        {



        }
        public override char Title => 'T';
    }
}
