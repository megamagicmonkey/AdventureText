using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText.WeaponClasses
{
    public class Mace : Weapon
    {
        public override int MaxDamage => (int)Math.Ceiling(Player.Str * 1.8);
        public override string Name => "mace";

        public override int Attack()
        {
            int damage;
            Random rng = new Random();

            damage = rng.Next(Player.MinDmg, MaxDamage + 1);

            if (damage == MaxDamage)
            {
                Console.WriteLine($"You crush your enemy with your mace for a massive {damage} damage!");
            }
            else
            {
                Console.WriteLine($"You swing your mace onto your enemy for {damage} damage.");
            }

            return damage;
        }
    }
}
