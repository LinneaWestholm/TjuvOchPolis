﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    public class ColideHelper
    {
        
        public void Colide(Civilian civilian, Police police, Theif theif)
        {
            if (civilian.PositionY == theif.PositionY && civilian.PositionX == theif.PositionX)
            {
                theif.StjälFrån(civilian);
            }
            else if (police.PositionY == theif.PositionY && police.PositionX == theif.PositionX)

            {
                police.Confiscate(police, theif);
            }
            else
            {

            }
        }

    }
}
