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
                    int posX = rnd.Next(1, 24);
                    int posY = rnd.Next(1, 99);
                    int dirX = rnd.Next(-1, 2);
                    int dirY = rnd.Next(-1, 2);

                    if (dirX == 0 && dirY == 0)
                    {
                        dirX = rnd.Next(-1, 2);
                        dirY = rnd.Next(1, 2);
                    }

                    people.Add(new Civilian(posY, posX, dirX, dirY));
                }
                for (int i = 0; i < 5; i++)
                {
                    int posX = rnd.Next(1, 24);
                    int posY = rnd.Next(1, 99);
                    int dirX = rnd.Next(-1, 2);
                    int dirY = rnd.Next(-1, 2);

                    if (dirX == 0 && dirY == 0)
                    {
                        dirX = rnd.Next(-1, 2);
                        dirY = rnd.Next(1, 2);
                    }


                    people.Add(new Police(posY, posX, dirX, dirY));
                }
                for (int i = 0; i < 10; i++)
                {
                    int posX = rnd.Next(1, 24);
                    int posY = rnd.Next(1, 99);
                    int dirX = rnd.Next(-1, 2);
                    int dirY = rnd.Next(-1, 2);
                    if (dirX == 0 && dirY == 0)
                    {
                        dirX = rnd.Next(-1, 2);
                        dirY = rnd.Next(1, 2);
                    }


                    people.Add(new Theif(posY, posX, dirX, dirY));
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
                        Thread.Sleep(500);
                    }

                }
            }
        }
    }

