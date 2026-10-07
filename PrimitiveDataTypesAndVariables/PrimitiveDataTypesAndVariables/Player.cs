using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveDataTypesAndVariables
{
    public class Player
    {
        private int health;
        private string name;
        private int ammo;
        private int bullet_damage = 1000;

        public Player(int health, string name, int ammo)
        {
            this.health = health;
            this.name = name;
            this.ammo = ammo;
        }

        public int Health { get { return health; } }
        // or
        public int getHealth() { return health; }
        public void setHealth(int newHealth) { health = newHealth; }
        public string Name { get { return name; } }

        public void shoot()
        {
            ammo = ammo - 1;
            Console.WriteLine(ammo);
        }
    }
}
