using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Enemy : Entity // reads: enemy inherits entity
    {
        public int scoreValue;
        public int xpValue;
        public int goldDrop;

        public Enemy()
        {
            Console.WriteLine("enemy class constructed");
        }
    }
}
