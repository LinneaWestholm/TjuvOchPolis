using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{

    public class Person
    {
        public string Name { get; private set; }
        public int PositionY { get; set; }
        public int PositionX { get; set; }
        public int DirectionY { get; set; }
        public int DirectionX { get; set; }
        public virtual char Title { get; }
        public List<string> Inventory { get; set; } = new List<string>();

        public Person(int positionY, int positionX, int directionX, int directionY, char title, string nameGiver)
        {
            PositionY = positionY;
            PositionX = positionX;
            DirectionX = directionX;
            DirectionY = directionY;
            Title = title;
            Name = nameGiver;

        }
        public virtual void NameTitle(char title)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            title = 'Q';
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
            if (PositionX < 100)
            {
                   if (PositionX >= 98)     PositionX = 1;
                   if (PositionX <= 0)      PositionX = 98;
                   if (PositionY <= 0)      PositionY = 23;
                   if (PositionY >= 24)     PositionY = 1;
            }
            if (PositionX > 100)  
            {
                if (PositionX >= 134)       PositionX = 111;
                if (PositionX <= 110)       PositionX = 133;
                if (PositionY < 10)
                {                    
                    if (PositionY <= 0)     PositionY = 8;
                    if (PositionY >= 9)     PositionY = 1;
                }
                if (PositionY > 10)
                {                    
                    if (PositionY <= 13)    PositionY = 23;
                    if (PositionY >= 24)    PositionY = 14;
                }
            }
            
            

            
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(Title);
        }
        private static List<string> names = new List<string>()
        {


        "Erik Eriksson", "Fardhe Magnusson","Velam Johannesson","Julian Sjöholm","Albert Almqvist","Eric Forslund","Lucas Lindroth","Leif Ohly","Locis Svensson",
        "Alex Öberg", "John Lagerkvist","Christian Lötvall","Åke Liljeström","Oskar Björk","Kjell Afzelius","Elliot Sjöberg","Sverker Sundström","Stella Englund",
        "Per Fornberg", "Viggo Forslund","Gösta Sundström","Valter Aspelund","Håkan Sparv","Jack Jansson","Isac Hagelin","Folke Adelsköld","Elin Augustsson",
        "Fardhe Stenström","Calle Rehnquist","Vincent Holm","Johan Lindeman","Hans Fornberg","Spjälle Malmkvist","Leif Bloch","Ella Lagerlöf"

    };
        private static Random rnd = new Random();
        public static string CreatePerson()
        {
            int ind = rnd.Next(names.Count);
            string name = names[ind];

            names.RemoveAt(ind);
            return name;
        }
    }

}


