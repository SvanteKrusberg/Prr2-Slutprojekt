using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class Fiskbar
    {
        protected string name;
        protected int size;
        public int value;

        public virtual void PrintStats()
        {
            Console.WriteLine("Fångst: " + name);
            Console.WriteLine("Vikt: " + size + " kg");
            Console.WriteLine("Värde: " + value + " kr");
            Console.WriteLine();

        }

    }
}
