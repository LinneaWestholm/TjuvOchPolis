using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
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
        public int PreviousX { get; set; }
        public int PreviousY { get; set; }
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
                if (PositionX >= 98) PositionX = 1;
                if (PositionX <= 0) PositionX = 98;
                if (PositionY <= 0) PositionY = 23;
                if (PositionY >= 24) PositionY = 1;
            }
            if (PositionX > 100)
            {
                if (PositionX >= 134) PositionX = 111;
                if (PositionX <= 110) PositionX = 133;
                if (PositionY < 10)
                {
                    if (PositionY <= 0) PositionY = 8;
                    if (PositionY >= 9) PositionY = 1;
                }
                if (PositionY > 10)
                {
                    if (PositionY <= 13) PositionY = 23;
                    if (PositionY >= 24) PositionY = 14;
                }
            }
            Console.SetCursorPosition(PositionX, PositionY);
            
            Console.Write(Title);
            Console.SetCursorPosition(PreviousX, PreviousY);
            Console.Write(' ');
            PreviousX = PositionX;
            PreviousY = PositionY;
        }
        private static List<string> names = new List<string>()
        {
        "Erik Eriksson", "Fardhe Magnusson","Velam Johannesson","Julian Sjöholm","Albert Almqvist","Eric Forslund","Lucas Lindroth","Leif Ohly","Locis Svensson",
        "Alex Öberg", "John Lagerkvist","Christian Lötvall","Åke Liljeström","Oskar Björk","Kjell Afzelius","Elliot Sjöberg","Sverker Sundström","Stella Englund",
        "Per Fornberg", "Viggo Forslund","Gösta Sundström","Valter Aspelund","Håkan Sparv","Jack Jansson","Isac Hagelin","Folke Adelsköld","Elin Augustsson",
        "Fardhe Stenström","Calle Rehnquist","Vincent Holm","Johan Lindeman","Hans Fornberg","Spjälle Malmkvist","Leif Bloch","Ella Lagerlöf", "Theo Åström",
        "Hjalmar Granestrand","Gert Pettersson", "Viktor Berglund", "Elliot Samuelsson", "Filip Ask", "Mio Fredriksson", "Nicklas Berglund", "Eve Söderström",
         "Emanuel Ström", "Carola Sandell", "Terese Lindholm", "Nora Magnusson", "Maj-Lis André", "Herta Ericsson", "Jessica Johansson", "Katrin Hansson",
         "Ida Sundberg","Lovis Persson","Christin Gustavsson"
    };
        private static Random rnd = new Random();
        public static string CreatePerson()
        {
            int ind = rnd.Next(names.Count);
            string name = names[ind];

            names.RemoveAt(ind);
            return name;
        }

        public static int theifInPrison = 0;
        public static int poorCivilian = 0;
        public static void Status(List<Person> people)
        {
            
            int policeCount = people.OfType<Police>().Count();
            int thiefCount = people.OfType<Theif>().Count();
            int civilianCount = people.OfType<Civilian>().Count();

            Console.SetCursorPosition(110, 26);
            Console.WriteLine($"Antal poliser: {policeCount}");
            Console.SetCursorPosition(110, 27);
      
            Console.WriteLine($"Antal tjuvar: {thiefCount}");
            Console.SetCursorPosition(110, 28);
            Console.WriteLine($"Antal medborgare: {civilianCount}");
            Console.SetCursorPosition(110, 29);
            Console.WriteLine($"Antal tjuvar i staden: {thiefCount-theifInPrison} ");
            Console.SetCursorPosition(110, 30);
            Console.WriteLine($"Antal medborgare i staden: {civilianCount - poorCivilian} ");
        }
    }
}


