using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movies> films = new List<Movies> {
               new Movies("john wick", "action"),
               new Movies("john wick 2", "action"),
               new Movies("john wick 3", "action"),
               new Movies("Scream", "horror"),
               new Movies("The shining", "horror"),
               new Movies("star wars", "scifi"),
               new Movies("startrek", "scifi"),
               new Movies("batman", "action"),
               new Movies("Avengers", "action"),
               new Movies("Scarface", "drama")
            };
            bool yes = true;
            while (yes)
            {
                Menu(films);
            }
            
        }
        public static void Menu(List<Movies> filmList)
        {

            Console.WriteLine("What type of movie would you like to watch? \r\n action \r\n drama \r\n scifi \r\n horror \r\n quit");

            string userInput = Console.ReadLine().ToLower();

            foreach (Movies item in filmList)
            {
                if (item.Genre == userInput)
                {
                    Console.WriteLine(item.Title);
                }
                
            }
            if (userInput == "quit")
            {
                Console.WriteLine("Have a great day");
                System.Environment.Exit(0);
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey(true);
        }

    }
}
