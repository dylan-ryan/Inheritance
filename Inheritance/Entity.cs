using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Entity : GameObject
    {
        public HealthSystem healthSystem;

        public Entity()
        {
            Console.WriteLine("entity class constructed");
            healthSystem = new HealthSystem();
        }
    }
}
