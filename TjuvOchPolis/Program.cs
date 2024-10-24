using System.Threading.Channels;

namespace TjuvOchPolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

                    people.Add(new Civilian(posY, posX, dirX, dirY));
                }
                for (int i = 0; i < 5; i++)
                {
                    int posX = rnd.Next(1, 24);
                    int posY = rnd.Next(1, 99);
                    int dirX = rnd.Next(-1, 2);
                    int dirY = rnd.Next(-1, 2);

                    people.Add(new Police(posY, posX, dirX, dirY));
                }
                for (int i = 0; i < 10; i++)
                {
                    int posX = rnd.Next(1, 24);
                    int posY = rnd.Next(1, 99);
                    int dirX = rnd.Next(-1, 2);
                    int dirY = rnd.Next(-1, 2);

                    people.Add(new Theif(posY, posX, dirX, dirY));
                }

                    while (true)
                    {
                        Console.Clear();

                        City.Print();
                        foreach (Person person in people)
                        {
                            person.Move();
                            person.Movement();
                        }
                        Thread.Sleep(500);
                    }

                }
            }
        }
    }

