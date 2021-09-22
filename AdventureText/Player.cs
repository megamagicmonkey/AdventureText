using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureText.WeaponClasses;

namespace AdventureText
{
    public static class Player
    {
        public static string Name = "Hero";
        public static int Str = 10;
        public static Weapon HeldWeapon;
        public static int MinDmg = Str/2;
        public static int Health = 10;
        public static int MaxHealth = 100;
    
        public static void GetTraits()
        {
            Console.WriteLine($"You're fairly sure your name is {Name}.");
            Console.WriteLine($"Your health is {Health}/{MaxHealth}.");
            Console.WriteLine($"Your strength is {Str}.");
            Console.WriteLine($"You're weilding your {HeldWeapon.Name}.");
            Console.WriteLine();

        }

        

    }
}
