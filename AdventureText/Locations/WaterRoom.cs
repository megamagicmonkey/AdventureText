using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText.Locations
{
    class WaterRoom
    {
        public static void Start()
        {
            bool unanswered = true;
            int path = 0;
            if (Flags.VisitedWaterRoom == false)
            {
                Console.WriteLine("This room has water flowing through it!");
                Flags.VisitedWaterRoom = true;
            }
            Console.WriteLine("Cracks in the wall let water from some unknown source");
            Console.WriteLine("drain into the room. It pools into sections large enough");
            Console.WriteLine("to even bathe in. The water then rushes off to who");
            Console.WriteLine("knows where. The water is clear and looks refreshing.");
            if (Flags.FirstPotDrunk == false)
            {
                Console.WriteLine("A brittle chair by the door contains a bottle");
                Console.WriteLine("of some red, semi-transparent liquid. It has a ");
                Console.WriteLine("medicinal scent to it, but you cannot identify it.");
            }

            do
            {
                Console.WriteLine("What do you do?");
                if (Flags.FirstPotDrunk == false) { 
                    Console.WriteLine("1] Take a bath, 2] Head back out, 3] Examine yourself, 4] Drink the red fluid");
                }
                else
                {
                    Console.WriteLine("1] Take a bath, 2] Head back out, 3] Examine yourself");
                }
                string answer = Console.ReadLine().ToLower();

                switch (answer)
                {
                    case "1":
                    case "take a bath":
                    case "bath":
                    case "take bath":
                        if(Flags.CanRest == true)
                        {
                            Console.WriteLine("You disrobe and rest in the pooling water.");
                            Console.WriteLine("The muck and grime washes off you, dragged downstream.");
                            Console.WriteLine("Your body feels rejuvenated.");
                            Console.WriteLine("Your mind is no clearer for it though...");
                            Console.WriteLine();
                            Player.Health = Player.MaxHealth;
                            Console.WriteLine($"Your health is restored! {Player.Health}/{Player.MaxHealth} HP!");
                            Flags.CanRest = false;
                        }
                        else
                        {
                            Console.WriteLine("You've not worked so hard as to need such a rest.");
                        }
                        break;
                    case "2":
                    case "head back out":
                    case "head out":
                    case "out":
                    case "back out":
                        unanswered = false;
                        break;
                    case "3":
                    case "examine yourself":
                    case "examine myself":
                    case "examine self":
                        Player.GetTraits();
                        break;
                    case "4":
                    case "drink the red fluid":
                    case "drink":
                    case "drink the fluid":
                    case "the red fluid":
                    case "red fluid":
                    case "drink red fluid":
                    case "drink fluid":
                    case "fluid":
                        if (Flags.FirstPotDrunk == false)
                        {
                            Console.WriteLine("You cautiously drink the strange liquid.");
                            Console.WriteLine("Your stomach burns as if fire were in it!");
                            Console.ReadLine();
                            Console.WriteLine("But it quickly calms and after you feel... stronger.");
                            Console.WriteLine("Old strength once lost suffuses through your body.");
                            Player.Str += 5;
                            Console.WriteLine();
                            Console.WriteLine($"You gained 5 strength! Current strength is {Player.Str}!");
                            Console.WriteLine();
                            Flags.FirstPotDrunk = true;
                        }
                        else
                        {
                            Console.WriteLine("You go to drink the concoction before remembering it's empty-");
                            Console.WriteLine("Wait. There's more? You're sure you downed the whole bottle.");
                            Console.WriteLine("Unsure, you take another swig, the effects once more enacting themselves.");
                            Player.Str += 5;
                            Console.WriteLine();
                            Console.WriteLine($"You gained 5 strength! Current strength is {Player.Str}!");
                            Console.WriteLine();
                            Console.WriteLine("You hear whispers enter your mind, \"Dev feature.\"");
                            Console.WriteLine("Your confusion worsens. You check the bottle and confirm its");
                            Console.WriteLine("contents truly depleted. ");
                        }
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
