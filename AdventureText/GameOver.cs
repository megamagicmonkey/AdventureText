using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdventureText
{
    class GameOver
    {
        public static void Failure()
        {
            Console.WriteLine("Your life ebbs from your vessel, no closer to leaving this place.");
            Console.WriteLine("No closer to answers.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" _______  _______  _______  _______  ");
            Console.WriteLine("(  ____ |(  ___  )(       )(  ____ | ");
            Console.WriteLine("| (    |/| (   ) || () () || (    |/ ");
            Console.WriteLine("| |      | (___) || || || || (__     ");
            Console.WriteLine("| |  ___ |  ___  || |(_)| ||  __)    ");
            Console.WriteLine("| | /_  )| (   ) || |   | || (       ");
            Console.WriteLine("| (___) || )   ( || )   ( || (____ /|");
            Console.WriteLine("(_______)|/     (||)     (|(________|");
            Console.WriteLine();
            Console.WriteLine(" _______          _______   _______  ");
            Console.WriteLine("(  ___  )|)    (|(  ____ | (  ____  )");
            Console.WriteLine("| (   ) || )  ( || (    |/ | (    ) |");
            Console.WriteLine("| |   | || |  | || (__     | (____) |");
            Console.WriteLine("| |   | || |  ) )|  __)    |      __)");
            Console.WriteLine("| |   | || |_/ / | (       | ()  (   ");
            Console.WriteLine("| (___) ||    /  | (____ /|| ) (  (__");
            Console.WriteLine("(_______)|___/   (________||/   (__ /");
            Console.WriteLine();

   
            Console.ReadLine();
            Console.WriteLine("P.S. Please note any bugs or errors you encountered and let me know about them!"); //TODO: remove when game is complete.
            Console.ReadLine();
            System.Environment.Exit(0);

        }
    }
}
