using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText.WeaponClasses
{
    public class Daggers : Weapon
    {
        public override int MaxDamage => (int)Math.Ceiling((Player.Str * 0.6));

        public override string Name => "twin daggers";

        public override int Attack()
        {
            Random rng = new Random();

            int damage1 = rng.Next(Player.MinDmg, MaxDamage + 1);
            int damage2 = rng.Next(Player.MinDmg, MaxDamage + 1);

            if (damage1 == MaxDamage)
            {
                damage1 += Player.MinDmg;
                Console.WriteLine($"Your first strike hits a weakspot for {damage1} damage!");
            }
            else
            {
                Console.WriteLine($"Your first dagger stings the enemy for {damage1} damage.");
            }

            if (damage2 == MaxDamage)
            {
                damage2 += Player.MinDmg;
                Console.WriteLine($"Your second strike hits unfettered for {damage2} damage!");
            }
            else
            {
                Console.WriteLine($"Your second dagger flashes and hits the enemy for {damage2} damage.");
            }

            return damage1 + damage2;

        }
    }
}
