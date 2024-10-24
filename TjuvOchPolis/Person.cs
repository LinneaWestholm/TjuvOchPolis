using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    internal class Person
    {
        public int PositionY { get; set; }
        public int PositionX { get; set; }
        public int DirectionY { get; set; }
        public int DirectionX { get; set; }
        public string Title { get; set; }
        public List<Property> inventory { get; set; }

        public Person(int positionY, int positionX,int directionX, int directionY, string title)
        {
            PositionY = positionY;
            PositionX = positionX;
            Title = title;
        }
    }
}

