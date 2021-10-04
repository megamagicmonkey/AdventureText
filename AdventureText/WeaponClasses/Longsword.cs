using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText.WeaponClasses
{
    public class Longsword : Weapon
    {
        public override int MaxDamage => (int)Math.Ceiling((Player.Str * 1.3) + 3);
        public override string Name => "longsword";

        public override int Attack()
        {
            int damage;
            Random rng = new Random();

            damage = rng.Next(Player.MinDmg + 3, MaxDamage + 1);

            if (damage == MaxDamage)
            {
                Console.WriteLine($"You swing your blade true for a massive {damage} damage!");
            }
            else
            {
                Console.WriteLine($"You slash your enemy for {damage} damage.");
            }

            return damage;
        }
    }
}
