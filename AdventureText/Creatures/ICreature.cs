using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText.Creatures
{
    public interface ICreature
    {
        public string Name { get; }
        public string Won { get; }
        public string Lost { get; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }

        public int Attack();
      

       
    }
}
