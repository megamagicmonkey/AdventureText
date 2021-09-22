using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText.Creatures
{
    class GrandBragabor : ICreature
    {
        public string Name => "grand bragabor";
        public string Won { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Lost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Health { get; set; }
        public int MaxHealth { get; set; }

        public int Attack()
        {
            throw new NotImplementedException();
        }
    }
}
