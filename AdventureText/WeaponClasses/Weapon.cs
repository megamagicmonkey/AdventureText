using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText.WeaponClasses
{
    public abstract class Weapon
    {

        public abstract int Attack();

        public abstract string Name { get; }
        public abstract int MaxDamage { get; }


    }
}
