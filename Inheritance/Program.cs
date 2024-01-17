using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy slime = new Enemy();
            Item sword = new Item();
            

            player.position.y = 0;
            player.position.x = 0;
            
            slime.position.y = 10;
            slime.position.x = 10;

            sword.position.y = 5;
            sword.position.x = 5;

            Console.ReadKey(true);
        }
    }
}
