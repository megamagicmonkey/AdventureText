using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText
{
    public static class Flags
        //A series of booleans to track what has or hasn't been done on a permanent level.
    {
        public static bool BadneughDead = false;
        public static bool FirstPotDrunk = false;
        public static bool SecondPotDrunk = false;
        public static bool Varslip1Dead = false;
        public static bool Varslip2Dead = false;
        public static bool BragaborDead = false;
        public static bool CanRest = true; //Turns to false if the player rests. Returns to true if the player enters combat.
        public static bool VisitedWaterRoom = false;
        public static bool IsVeteran = false;
    }
}
