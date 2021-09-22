using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText.Locations
{
    class FirstRoom
    {
        public static void Start()
        {

            bool unanswered = true;
            Console.WriteLine("You're in the room you woke up in.");
            Console.WriteLine("There's nothing here, save the doorway leading to a hall to the north.");

            Console.WriteLine();
            Console.WriteLine();

            do
            {
                Console.WriteLine("What will you do?");
                Console.WriteLine("1] Take the lone door, 2] Examine yourself");
                string answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "1":
                    case "take the lone door":
                    case "take door":
                    case "take the door":
                    case "doorway":
                    case "door":
                    case "lone door":
                    case "take lone door":
                    case "the lone door":
                    case "lone doorway":
                    case "the lone doorway":
                    case "the door":
                    case "the doorway":
                        unanswered = false;
                        break;
                    case "2":
                    case "examine yourself":
                    case "examine myself":
                    case "examine self":
                        Player.GetTraits();
                        break;


                    default:
                        Console.WriteLine("Your mind throbs. You think on what to do again.");
                        break;
                }
            } while (unanswered);
            FirstHall.Start();
        }
    }
}
