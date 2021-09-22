using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureText.WeaponClasses;

namespace AdventureText.Locations
{
    public static class Beginning
    {
        static public void Start()
        {
            bool unanswered = true;
            string input;

            Console.WriteLine("You wake up lying on cold stone in a room underground, \nall light gone save for a singular lit torch by a doorway. \nYour mind reels. \nHow did you get here? \nWhere is here? \n.....Who are you? (Enter your name)");
            Player.Name = Console.ReadLine();
            Console.WriteLine($"{Player.Name}... {Player.Name}..... Yes, that's right, you think. You hope. \nYour mind is still a fog, but you know you shouldn't be here, wherever it is. \nYou bring yourself to your feet. Nearby you notice your favored weapon:");
            Console.WriteLine("1] Axe, 2] Longsword, 3] Twin Daggers, 4] Spear, 5] Mace");
            do
            {
                input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "1":
                    case "axe":
                        Console.WriteLine("You pick your axe up, its heft feeling proper in your hand. \nYou deliver a few practice swings. This is definitely yours.");
                        Player.HeldWeapon = new Axe();
                        unanswered = false;
                        break;
                    case "2":
                    case "longsword":
                        Console.WriteLine("You retrieve your blade and draw it from its scabbard. \nYour muscles recall battles your mind does not. This is yours.");
                        Player.HeldWeapon = new Longsword();
                        unanswered = false;
                        break;
                    case "3":
                    case "twin daggers":
                    case "daggers":
                        Console.WriteLine("You wield the daggers, one in each hand. You remember the world is dangerous, \nbut perhaps not as dangerous as you.\nYou slash at the air a few times. It feels right.");
                        Player.HeldWeapon = new Daggers();
                        unanswered = false;
                        break;
                    case "4":
                    case "spear":
                        Console.WriteLine("You raise the spear and stab at the empty air. \nYou can tell it'll do the work you need it to nicely.");
                        Player.HeldWeapon = new Spear();
                        unanswered = false;
                        break;
                    case "5":
                    case "mace":
                        Console.WriteLine("You swing the mace you find a few times. \nYou can practically hear the sounds of crushing and smashing coming from deep in your memories.\nYou nod in aprroval.");
                        Player.HeldWeapon = new Mace();
                        unanswered = false;
                        break;
                    case "0":
                    case "unarmed":
                    case "hands":
                    case "fists":
                        Console.WriteLine("You shake your head. You don't use any weapons. When you look again, \nyou can't find whatever it was you mistook as yours.\nYou worry you might be worse off than you thought,\nbut it's diminished by the reassuring crack of your knuckles.");
                        Player.HeldWeapon = new Fists();
                        unanswered = false;
                        break;
                    default:
                        Console.WriteLine("You must be more dazed than you thought. Whatever it was you were thinking didn't make any sense to you.\nYou shake your head and try again.");
                        break;
                }


            } while (unanswered);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The fog on your mind begins to lift, if only slightly. You examine yourself.\nYou groan as you move, joints and muscles aching.\nYou're in pretty bad shape.");
            Console.WriteLine($"{Player.Health} / {Player.MaxHealth} HP. {Player.Str} Strength. Press any key to continue.");
            Console.ReadLine();
            Console.WriteLine("You've defnitely felt better. Stronger. At least you're pretty sure.\nAs it stands, you don't think you could defend yourself very well.");
            Console.WriteLine($"You'll need to avoid any trouble going forward in your state.\nAt least not until you can rest up properly.");

            FirstRoom.Start();

            /*Console.WriteLine("Suddenly the game devs destroy reality so you can test hitting stuff. \nThere's a dummy in front of you. Best get to whacking.");
            Console.WriteLine("This is probably going to take a while....");
            Console.ReadLine();
            
            int dummyHP = 1000000;
            int attacks = 0;
            while (dummyHP > 0)
            {
                dummyHP = dummyHP - Player.HeldWeapon.Attack();
                attacks++;
                Console.WriteLine($"Dummy has {dummyHP} HP left.");
            }
            Console.WriteLine($"You defeated the dummy in {attacks} attacks. Is that good? We'll need to check the numbers.");
            Console.WriteLine("You're ready to rest after that onslaught when....");
            Console.ReadLine();
            Console.WriteLine("The devs aren't done with you! The dummy reappears! However, you feel much stronger!\n90 arbitrary units of strength stronger!\nYou renew your assault!");
            dummyHP = 1000000;
            attacks = 0;
            Player.Str += 90;
            while (dummyHP > 0)
            {
                dummyHP = dummyHP - Player.HeldWeapon.Attack();
                attacks++;
                Console.WriteLine($"Dummy has {dummyHP} HP left.");
            }
            Console.WriteLine($"You defeated the dummy in {attacks} attacks. Is that good? We'll need to check the numbers.");
            Console.WriteLine("You're ready to rest after that onslaught when....");
            Console.ReadLine();
            Console.WriteLine("Wait. It's over? Oh, right, this is just a testing section. \nYou sigh in relief knowing the game isn't actually about pummeling dummies.\nYou dissolve into non-existance, excited for the real thing.");
            */
        }

    }
}
