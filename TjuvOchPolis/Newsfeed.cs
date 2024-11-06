using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    public class Newsfeed    
    {
        public static int nr = 1;
        public static List<string> messages = new List<string>();

        public static void AddMessage(string message)
        {
   
            messages.Add(nr + " " + message);
            
            nr++;
            if (messages.Count > 10) messages.RemoveAt(0);
        }
        public static void ShowFeed()
        {
            Console.SetCursorPosition(0, 26);
            foreach (string message in messages)
            {
                Console.WriteLine($"                                                                                                    ");
            }

            Console.SetCursorPosition(0, 26);
            foreach (string message in messages.ToList().AsEnumerable().Reverse())
            {
                Console.WriteLine($"{message}");           
            }         
        }
    }
}
