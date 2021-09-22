using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText
{
    public static class ChangeWeapons
    {
        public static void ChangeWeapon()
        {
            Console.WriteLine("You approach the weapon rack, thinking to change arms.");
            Console.WriteLine();
            Console.WriteLine($"You're currently weilding your {Player.HeldWeapon.Name}.");
            Console.WriteLine("Of the bevy of weapons in front of you, you find a few you could wield.");
            Console.WriteLine("Which do you switch out your weapon for?");
            Console.WriteLine("1] Axe, 2] Longsword, 3] Twin Daggers, 4] Spear, 5] Mace, 6]Change your mind");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                case "axe":
                    var tempAxe = new WeaponClasses.Axe();
                    if (tempAxe.Name == Player.HeldWeapon.Name)
                    {
                        Console.WriteLine("You're already using an axe.");
                    }
                    else
                    {
                        Console.WriteLine($"You switch out your {Player.HeldWeapon.Name} for an axe.");
                        Console.WriteLine("It feels good to swing, but was this a good decision?");
                        Console.WriteLine("Only one way to find out.");
                        Player.HeldWeapon = new WeaponClasses.Axe();
                    }
                    break;
                case "2":
                case "longsword":
                    var tempSword = new WeaponClasses.Longsword();
                    if (tempSword.Name == Player.HeldWeapon.Name)
                    {
                        Console.WriteLine("You're already using a longsword.");
                    }
                    else
                    {
                        Console.WriteLine($"You switch out your {Player.HeldWeapon.Name} for a longsword.");
                        Console.WriteLine("It feels good to swing, but was this a good decision?");
                        Console.WriteLine("Only one way to find out.");
                        Player.HeldWeapon = new WeaponClasses.Longsword();
                    }
                    break;
                case "3":
                case "twin daggers":
                case "daggers":
                    var tempDaggers = new WeaponClasses.Daggers();
                    if (tempDaggers.Name == Player.HeldWeapon.Name)
                    {
                        Console.WriteLine("You're already using twin daggers.");
                    }
                    else
                    {
                        Console.WriteLine($"You switch out your {Player.HeldWeapon.Name} for two daggers.");
                        Console.WriteLine("It feels good to swing them, but was this a good decision?");
                        Console.WriteLine("Only one way to find out.");
                        Player.HeldWeapon = new WeaponClasses.Daggers();
                    }
                    break;
                case "4":
                case "spear":
                    var tempSpear = new WeaponClasses.Spear();
                    if (tempSpear.Name == Player.HeldWeapon.Name)
                    {
                        Console.WriteLine("You're already using a spear.");
                    }
                    else
                    {
                        Console.WriteLine($"You switch out your {Player.HeldWeapon.Name} for a spear.");
                        Console.WriteLine("It feels good to thrust, but was this a good decision?");
                        Console.WriteLine("Only one way to find out.");
                        Player.HeldWeapon = new WeaponClasses.Spear();
                    }
                    break;
                case "5":
                case "mace":
                    var tempMace = new WeaponClasses.Mace();
                    if (tempMace.Name == Player.HeldWeapon.Name)
                    {
                        Console.WriteLine("You're already using a mace.");
                    }
                    else
                    {
                        Console.WriteLine($"You switch out your {Player.HeldWeapon.Name} for a mace.");
                        Console.WriteLine("It feels good to swing, but was this a good decision?");
                        Console.WriteLine("Only one way to find out.");
                        Player.HeldWeapon = new WeaponClasses.Axe();
                    }
                    break;
                case "6":
                case "change your mind":
                case "change mind":
                    Console.WriteLine($"On second thought, you're quite fond of your {Player.HeldWeapon.Name}.");
                    Console.WriteLine("You think you'll keep things as they are for now.");
                    break;
                default:
                    Console.WriteLine("Whatever it was you were thinking didn't make any sense to you.");
                    break;
            }
            Console.WriteLine("You disengage from the weapon rack, returning your focus to the room.");
            Console.WriteLine();
        }
    }
}
