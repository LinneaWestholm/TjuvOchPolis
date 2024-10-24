﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public virtual char Title { get; }
        public List<string> inventory { get; set; }

        public Person(int positionY, int positionX, int directionX, int directionY, char title)
        {
            PositionY = positionY;
            PositionX = positionX;
            DirectionX = directionX;
            DirectionY = directionY;
            Title = title;

        }
        public virtual void Name(char title)
        {
            title = 'c';
        }
        //static void RandomXY()
        //{
        //    Random rnd = new Random(99);
        //    int positionX = rnd.Next(1, 99);

        //    Random rnd2 = new Random(24);
        //    int positionY = rnd2.Next(1, 24);
        //}

        static void PlacePerson()
        {
            for (int i = 0; i < 10; i++)
            {

            }
        }
        public void Move()
        {
            PositionX += DirectionX;
            PositionY += DirectionY;


            if (PositionX < 0) PositionX = 0;
            if (PositionX >= Console.WindowWidth) PositionX = Console.WindowWidth - 2;
            if (PositionY < 0) PositionY = 0;
            if (PositionY >= Console.WindowHeight) PositionY = Console.WindowHeight - 3;
        }


        public void Movement()
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(Title);
        }
        public void CreatePerson()
        {
            List<string> names = new List<string>()
    {
        "Erik Eriksson", "Fardhe Magnusson","Velam Johannesson","Julian Sjöholm","Albert Almqvist","Eric Forslund","Lucas Lindroth","Leif Ohly","Locis Svensson",
        "Alex Öberg", "John Lagerkvist","Christian Lötvall","Åke Liljeström","Oskar Björk","Kjell Afzelius","Elliot Sjöberg","Sverker Sundström","Stella Englund",
        "Per Fornberg", "Viggo Forslund","Gösta Sundström","Valter Aspelund","Håkan Sparv","Jack Jansson","Isac Hagelin","Folke Adelsköld","Elin Augustsson",
        "Fardhe Stenström","Calle Rehnquist","Vincent Holm","Johan Lindeman","Hans Fornberg","Spjälle Malmkvist","Leif Bloch","Ella Lagerlöf"

    };
            Random random = new Random();
            string randomName = names[random.Next(names.Count)];
        }

    }
}

