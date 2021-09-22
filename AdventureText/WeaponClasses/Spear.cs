using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText.WeaponClasses
{
    public class Spear : Weapon
    {
        public override int MaxDamage => (Player.Str + 10);
        public override string Name => "spear";

        public override int Attack()
        {
            int damage;
            Random rng = new Random();

            damage = rng.Next(Player.MinDmg + 5, MaxDamage + 1);

            if (damage == MaxDamage)
            {
                Console.WriteLine($"You lunge through the enemy with your spear for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"You stab the enemy for {damage} damage.");
            }

            return damage;
        }
    }
}

