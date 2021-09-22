using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText.WeaponClasses
{
    public class Axe : Weapon
    {
        public override int MaxDamage => (Player.Str * 2) - 5;
        public override string Name => "axe";

        public override int Attack()
        {
            int damage;
            Random rng = new Random();

            damage = rng.Next(Player.MinDmg , MaxDamage + 1);

            if (damage == MaxDamage)
            {
                Console.WriteLine($"You bury your axe into the enemy for a massive {damage} damage!");
            }
            else
            {
                Console.WriteLine($"You level your axe against your enemy for {damage} damage.");
            }

            return damage;
            
        }
    }
}
