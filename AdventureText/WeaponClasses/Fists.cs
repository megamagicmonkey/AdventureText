using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText.WeaponClasses
{
     public class Fists : Weapon
    {
        public override int MaxDamage => Player.Str - 3;
        public override string Name => "fists";

        public override int Attack()
        {
            Console.WriteLine($"You swing hard with your right fist for {MaxDamage} damage.");
            Console.WriteLine($"And you follow up with a hit from your left for {MaxDamage - 2} damage;");

            return (MaxDamage * 2) - 2;
        }
    }
}
