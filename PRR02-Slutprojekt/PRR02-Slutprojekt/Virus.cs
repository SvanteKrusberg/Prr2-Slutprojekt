using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRR02_Slutprojekt
{
    class Virus
    {
        int life;
        int power;
        int lifeTime;
        string name;

        public Virus(string n)
        {
            life = Utils.rng.Next(100, 200);
            name = n;
            lifeTime = Utils.rng.Next(1, 20);
            power = Utils.rng.Next(1, 20);
        }

        public void printStats()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Lifetime: " + lifeTime);
            Console.WriteLine("Power: " + power);
        }
        
        public bool isAlive(int n)
        {
            if(life > 0)
            {
                return true;

            }
            else
            {
                return false;

            }

        }
    }

}
