﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    public class Newsfeed
    {
        public static List<string> messages = new List<string>();

        public static void AddMessage(string message)
        {            
            messages.Add(message);
            if (messages.Count > 10) messages.RemoveAt(0);    
        }

        public static void ShowFeed()
        {
            Console.SetCursorPosition(0, 27);          
            foreach (string message in messages)
            {
                Console.WriteLine("- " + message);
            }
        }
    }
}
