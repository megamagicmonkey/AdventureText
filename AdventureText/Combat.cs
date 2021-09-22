using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureText.Creatures;

namespace AdventureText
{
    public static class Combat
    {
        
        public static void Battle(ICreature baddie)
        {
            bool block = false;
            bool dodge = false;
            bool run = false;
            int dmg;
            if (Flags.IsVeteran == false)
            {
                Console.WriteLine("You run through your mind the basics of combat.");
                Console.WriteLine("Old lessons run through your body, refreshing your mind.");
                Console.WriteLine("You recall combat essentially comes down to a few basic things:");
                Console.WriteLine("You can attack, of course. Harming your opponent is the only way to win, but...");
                Console.WriteLine("You can also block. It won't stop the attack, but it'll weaken blows.");
                Console.WriteLine("Riskier though is dodging. If it works, attacks will miss you,");
                Console.WriteLine("but if it fails, you're taking the full brunt of their damage.");
                Console.WriteLine("And of course, the coward's option to run is available, and not all");
                Console.WriteLine("cowards are fools... But it will give your opponent time to strike you");
                Console.WriteLine("as well as recover after you've fled....");
                Console.WriteLine("Time to put those options to use. The struggle for life and death begins.");
                Console.WriteLine();
                Flags.IsVeteran = true;
            }
            Console.WriteLine($"You enter battle with a { baddie.Name }.");
            do
            {
                Console.WriteLine("What will you do?");
                Console.WriteLine("1] attack, 2] block, 3] dodge, 4] run");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                    case "attack":
                        dmg = Player.HeldWeapon.Attack();
                        baddie.Health -= dmg;
                        break;
                    case "2":
                    case "block":
                        Console.WriteLine("You adopt a defensive posture.");
                        block = true;
                        break;
                    case "3":
                    case "dodge":
                        Console.WriteLine("You ready yourself to dodge.");
                        dodge = true;
                        break;
                    case "4":
                    case "run":
                        Console.WriteLine("You move to flee the encounter.");
                        run = true;
                        break;
                    default:
                        Console.WriteLine("Your mind swirls. In your confusion, your quarry makes a move.");
                        break;
                }

                if (baddie.Health > 0 && Player.Health > 0)
                {
                    dmg = baddie.Attack();

                    if (block)
                    {
                        Console.WriteLine("You prevent some of the damage with your guard.");
                        Console.WriteLine($"You take {dmg /2} damage.");
                        Player.Health -= dmg / 2;
                    }
                    else if (dodge)
                    {
                        Console.WriteLine("You see the attack coming and move to avoid it!");
                        var rng = new Random();
                        if (rng.Next() % 2 == 0)
                        {
                            Console.WriteLine("The attack misses!");
                        }
                        else
                        {
                            Console.WriteLine("But your timing was off! The attack strikes you in full force.");
                            Console.WriteLine($"You take {dmg} damage!");
                            Player.Health -= dmg;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"You receive {dmg} damage!");
                        Player.Health -= dmg;
                    }

                    Console.WriteLine();
                    Console.WriteLine($"You have {Player.Health} HP remaining.");
                    if (baddie.Health < baddie.MaxHealth / 10)
                    {
                        Console.WriteLine($"The {baddie.Name} is bloodied. It's nearing the end.");
                    }
                    else if (baddie.Health < baddie.MaxHealth / 2)
                    {
                        Console.WriteLine($"The {baddie.Name} is looking worse for wear.");
                    }
                    else if (baddie.Health >= baddie.MaxHealth / 2 && baddie.Health != baddie.MaxHealth)
                    {
                        Console.WriteLine($"The {baddie.Name} looks fresh and ready to fight.");
                    }
                    else
                    {
                        Console.WriteLine($"The {baddie.Name} is unharmed.");
                    }
                }



                block = false;
                dodge = false;
            } while (Player.Health > 0 && baddie.Health > 0 && run == false);

            if (Player.Health <= 0)
            {
                Console.WriteLine(baddie.Won);
                GameOver.Failure();
            }
            else if(run == true)
            {
                Console.WriteLine("You retreat! Your enemy goes back to their business,");
                Console.WriteLine("tending to any wounds it may have received.");
                baddie.Health += ((baddie.MaxHealth - baddie.Health) / 2);
            }
            else
            {
                Console.WriteLine(baddie.Lost);
                Console.WriteLine("The victory revives strength within you.");
                Console.WriteLine();
                Player.Str += 3;
                Console.WriteLine($"You gain 3 strength. Current strength is {Player.Str}.");
                
            }
            Flags.CanRest = true;
        }
        public static void Battle(ICreature baddie1, ICreature baddie2)
        {

        }
    }
}
