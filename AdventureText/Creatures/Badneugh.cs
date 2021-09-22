using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText.Creatures
{
    public class Badneugh : ICreature
    {


        //TODO: Find a way to restore half a creature's missing health if the player flees.
        public string Name => "Badneugh";
        public string Lost => "The badneugh breathes its last, its hideous form slumping to the ground.";
        public string Won => "Your body gives out and the badneugh lunges. Your consciousness fades as it begins to make you its new meal.";
        public int Health { get; set; } = 65;
        public int MaxHealth { get; set; } = 65;


        public int Attack()
        {
            var rng = new Random();
            int dmg = ((rng.Next() % 8) + 9);

            switch (rng.Next() % 3)
            {
                case 0:
                    Console.WriteLine("The badneugh brings its terrible fangs down upon you!");
                    break;
                case 1:
                    Console.WriteLine("The badneugh swipes a brutal claw at you!");
                    break;
                case 2:
                    Console.WriteLine("The badneugh slams its body onto yours!");
                    break;
                default:
                    Console.WriteLine("You shouldn't read this.");
                    break;
            }

            return dmg;
        }
    }
}
