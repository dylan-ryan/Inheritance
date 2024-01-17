using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Player : Entity //read: player inherits entity
    {
        public int xp;
        public int lvl;
        public int score;

        public Player()
        {
            Console.WriteLine("player class constructed");
        }
    }
}
