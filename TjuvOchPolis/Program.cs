using System.Threading.Channels;

namespace TjuvOchPolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tjuv och Polis";

            List<string> inventory = new List<string>();
            {
                Random rnd = new Random();

                List<Person> people = new List<Person>();

                for (int i = 0; i < 20; i++)
                {
                    string randomName = Person.CreatePerson();
                    int posX = rnd.Next(1, 24);
                    int posY = rnd.Next(1, 99);
                    int dirX = rnd.Next(-1, 2);
                    int dirY = rnd.Next(-1, 2);

                    if (dirX == 0 && dirY == 0)
                    {
                        dirX = rnd.Next(-1, 2);
                        dirY = rnd.Next(1, 2);
                    }
                    people.Add(new Civilian(posY, posX, dirX, dirY, randomName));
                }
                for (int i = 0; i < 5; i++)
                {
                    string randomName = Person.CreatePerson();
                    int posX = rnd.Next(1, 24);
                    int posY = rnd.Next(1, 99);
                    int dirX = rnd.Next(-1, 2);
                    int dirY = rnd.Next(-1, 2);

                    if (dirX == 0 && dirY == 0)
                    {
                        dirX = rnd.Next(-1, 2);
                        dirY = rnd.Next(1, 2);
                    }
                    people.Add(new Police(posY, posX, dirX, dirY, randomName));
                }
                for (int i = 0; i < 10; i++)
                {
                    string randomName = Person.CreatePerson();
                    int posX = rnd.Next(1, 24);
                    int posY = rnd.Next(1, 99);
                    int dirX = rnd.Next(-1, 2);
                    int dirY = rnd.Next(-1, 2);
                    if (dirX == 0 && dirY == 0)
                    {
                        dirX = rnd.Next(-1, 2);
                        dirY = rnd.Next(1, 2);
                    }
                    people.Add(new Theif(posY, posX, dirX, dirY, randomName));
                }
                while (true)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;

                    City.Print();
                    foreach (Person person in people)
                    {
                        if (person.Title == 'P')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        if (person.Title == 'T')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        if (person.Title == 'C')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        person.Move();
                        person.Movement();
                    }
                    foreach (var thief in people.OfType<Theif>())
                    {
                        thief.Stolen();
                    }
                    foreach (var civilian in people.OfType<Civilian>())
                    {
                        foreach (var police in people.OfType<Police>())
                        {
                            foreach (var thief in people.OfType<Theif>())
                            {
                                if (civilian.PositionX == thief.PositionX && civilian.PositionY == thief.PositionY)
                                {
                                    ColideHelper.Colide(civilian, police, thief);
                                }
                                else if (police.PositionX == thief.PositionX && police.PositionY == thief.PositionY)
                                {
                                    ColideHelper.Colide(civilian, police, thief);
                                }
                            }
                        }
                    }
                    Thread.Sleep(500);
                }
            }
        }
    }
}

