using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText.Locations
{
    class FirstHall
    {
        public static Creatures.Badneugh badneugh = new Creatures.Badneugh();

        public static void Start()
        {
            
            int path = 0;
            bool unanswered = true;

            Console.WriteLine("You enter the hallway.");
            if (Flags.BadneughDead == false)
            {
                Console.WriteLine("You see a vicious badneugh feasting on something by a door to the east.");
                Console.WriteLine("It's too distracted by the meal to notice you.");
                if (Player.Health == 10)
                {
                    Console.WriteLine("Fighting it now is probably a bad idea.");
                }
            }
            else
            {
                Console.WriteLine("The badneugh you slew lies by a door to the east.");
            }
            Console.WriteLine("A door to the south leads to the dark room you woke up in.");
            Console.WriteLine("You hear the sound of water to the west.");

            do
            {
                Console.WriteLine("What do you do?");
                if (Flags.BadneughDead == false)
                {
                    Console.WriteLine("1] Attack the badneugh, 2] Take the southern door, 3] Take the west door, 4] Examine yourself");
                }
                else
                {
                    Console.WriteLine("1] Take the east door, 2] Take the southern door, 3] Take the west door, 4] Examine yourself"); ;
                }
                string input = Console.ReadLine().ToLower();
                
                switch (input)
                {
                    case "1":
                        if (Flags.BadneughDead == false)
                        {
                            goto case "attack";
                        }
                        else
                        {
                            goto case "east door";
                        }
                        
                    case "attack":
                    case "attack the badneugh":
                    case "badneugh":
                    case "attack badneugh":
                        if (Flags.BadneughDead == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"You approach the badneugh, your {Player.HeldWeapon.Name} at the ready.");
                            Console.WriteLine("The creature notices you and forgets about its meal,");
                            Console.WriteLine("a fresher one having just presented itself.");
                            Console.WriteLine();
                            Combat.Battle(badneugh);
                            if (badneugh.Health <= 0)
                            {
                                Flags.BadneughDead = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("The badneugh is already slain.");
                        }
                        break;
                    case "east door":
                    case "take east door":
                    case "take the east door":
                    case "east":
                        if (Flags.BadneughDead == false)
                        {
                            Console.WriteLine("You cannot reach the door. A vicious badneugh blocks it.");
                        }
                        else
                        {
                            path = 1;
                            unanswered = false;
                            break;
                        }
                        break;
                    case "2":
                    case "south":
                    case "south door":
                    case "southern door":
                    case "take the southern door":
                    case "the southern door":
                    case "take southern door":
                    case "take the south door":
                    case "the south door":
                        path = 2;
                        unanswered = false;
                        break;
                    case "3":
                    case "west":
                    case "west door":
                    case "western door":
                    case "take the western door":
                    case "the western door":
                    case "take western door":
                    case "take the west door":
                    case "the west door":
                        path = 3;
                        unanswered = false;
                        break;
                    case "4":
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
            switch (path)
            {
                case 1:
                    StorageRoom.Start();
                    break;
                case 2:
                    FirstRoom.Start();
                    break;
                case 3:
                    WaterRoom.Start();
                    break;
                default:
                    Console.WriteLine("You see somethign you shouldn't have.");
                    Console.WriteLine("You mind implodes from eldritch terror.");
                    GameOver.Failure();
                    break;
            }
        }
    }
}
