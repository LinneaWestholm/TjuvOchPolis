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
        public virtual char Title { get;}
        public List<string> inventory { get; set; }

        public Person(int positionY, int positionX, int directionX, int directionY, char title)
        {
            PositionY = positionY;
            PositionX = positionX;
            Title = title;

        }
        public virtual void Name(char title)
        {
            title = 'c';
        }
        static void RandomXY()
        {
            Random rnd = new Random(99);
            int positionX = rnd.Next(1, 99);

            Random rnd2 = new Random(24);
            int positionY = rnd2.Next(1, 24);
        }

        static void PlacePerson()
        {
            for (int i = 0; i < 10; i++)
            {

            }
        }
    }
}

