using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText.Locations
{
    class StorageRoom
    {
        public static void Start()
        {
            string potString;
            bool unanswered = true;
            int path = 0;
            Console.WriteLine();
            Console.WriteLine("This room is covered wall to wall in storage containers,");
            Console.WriteLine("though most have rotted through. Whatever unspeakable mess");
            Console.WriteLine("once oozed through these containers is long gone. Only stains");
            Console.WriteLine("remain of their former contents. There is a weapon rack on a wall, however.");
            if (Flags.SecondPotDrunk == false)
            {
                Console.WriteLine("Furthermore, a strange phial of murky, green liquid lies");
                Console.WriteLine("undisturbed on an old crate. Discolorations billow inside it,");
                Console.WriteLine("as if stirred by some invisible force.");
            }
            Console.WriteLine("A door lies to the west, and stairs ascend in front of you to the north.");
            
            do
            {
                Console.WriteLine();
                Console.WriteLine("What do you do?");
                if (Flags.SecondPotDrunk == false)
                {
                    potString = ", 5] Drink the green fluid";
                }
                else
                {
                    potString = "";
                }
                Console.WriteLine($"1] Take the stairs, 2] Take the door, 3] Change weapons 4] Examine yourself{potString}");
                string answer = Console.ReadLine().ToLower();

                switch (answer)
                {
                    case "1":
                    case "take the stairs":
                    case "take stairs":
                    case "the stairs":
                    case "stairs":
                        path = 1;
                        unanswered = false;
                        break;
                    case "2":
                    case "take the door":
                    case "the door":
                    case "take door":
                    case "door":
                        path = 2;
                        unanswered = false;
                        break;
                    case "3":
                    case "change weapons":
                    case "change weapon":
                    case "change":
                    case "weapon":
                    case "weapons":
                        ChangeWeapons.ChangeWeapon();
                        break;
                    case "4":
                    case "examine yourself":
                    case "examine myself":
                    case "examine self":
                        Player.GetTraits();
                        break;
                    case "5":
                    case "drink the green substance":
                    case "the green substance":
                    case "drink green substance":
                    case "drink the substance":
                    case "drink substance":
                    case "the substance":
                    case "green substance":
                    case "drink":
                    case "substance":
                        if (Flags.SecondPotDrunk == false)
                        {
                            Console.WriteLine("You grab the phial and uncork it. Your senses immediately assualted.");
                            Console.WriteLine("You can't tell if it smells rotten, sugary, rosy, like sweat, or");
                            Console.WriteLine("if it's somehow switching among them rapidly. You lose your");
                            Console.WriteLine("composure and grow dizzy from the fumes.");
                            Console.WriteLine("Are you sure you want to drink this? Y/N");
                            string drink = Console.ReadLine().ToLower();
                            switch (drink)
                            {
                                case "y":
                                    Console.WriteLine("Whatever madness has possessed you, you decide to drink the");
                                    Console.WriteLine("concoction. You pinch your nose, hold it to your lips and tilt");
                                    Console.WriteLine("your head back, downing it as quickly as your throat will let you.");
                                    Console.ReadLine();
                                    Console.WriteLine("You blink. Suprisingly its horrid smell belied its utter lack of flavor.");
                                    Console.WriteLine("You feel no effects either, perhaps it was-");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.ReadLine();
                                    Console.ReadLine();
                                    Console.ReadLine();
                                    Console.WriteLine("You gasp! What happened?");
                                    Console.WriteLine("You're on the floor, a puddle of discolored drool touches your face.");
                                    Console.WriteLine("You right yourself, feeling oddly sprier than memory, for what it is,");
                                    Console.WriteLine("properly recalls. In fact, you feel great, if not slightly nauseated from the experience.");
                                    Console.WriteLine();
                                    Player.Str += 7;
                                    Player.MaxHealth += 25;
                                    Flags.CanRest = true;
                                    Flags.SecondPotDrunk = true;
                                    Console.WriteLine($"Strength increased by 7! Current strength is now {Player.Str}.");
                                    Console.WriteLine($"Maximum health increased by 25! You now have {Player.Health}/{Player.MaxHealth} HP.");
                                    Console.WriteLine("You resolve to resist drinking strange contents of bottles from now on.");
                                    Console.WriteLine("You're quite certain you only get that lucky once.");
                                    break;
                                case "n":
                                    Console.WriteLine("Curiosity killed the cat, and you don't feel half as sharp at the moment.");
                                    Console.WriteLine("You decide to reseal the phial and carefully place it back.");
                                    break;
                                default:
                                    Console.WriteLine("Fearing your own mind, you decide not to tempt fate.");
                                    Console.WriteLine("You recork the phial and place it back.");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Are you concussed? This confusion is beginning to annoy");
                            Console.WriteLine("you. You already drank that! Not that you'd risk it if you could.");
                        }
                        break;
                }

            } while (unanswered);

            switch (path)
            {
                case 1:
                    Console.WriteLine("You head up the stairs, your senses alert."); //TODO: Link to next room
                    Console.WriteLine("A strange, nerdish figure approaches you and speaks:");
                    Console.WriteLine("'Unfortunately, this is as far as the game goes for now.");
                    Console.WriteLine("The next room is designed to have you fight two enemies at once!");
                    Console.WriteLine("But.....");
                    Console.WriteLine("Gotta make deadlines! Thanks for playing!'");
                    Console.WriteLine("The man speaks madness, but then he drops a planet on you.");
                   
                    GameOver.Failure();
                    break;
                case 2:
                    Locations.FirstHall.Start();
                    break;
                default:
                    Console.WriteLine("The infamous 'You shouldn't be reading this' message arrives!");
                    Console.WriteLine("It kills you mercilessly.");
                    GameOver.Failure();
                    break;
            }
        }
    }
}
