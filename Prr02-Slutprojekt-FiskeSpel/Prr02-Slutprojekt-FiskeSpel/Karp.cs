using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class Karp : Fisk
    {
        
        public Karp()
        {
            name = "Karp";
            size = Utils.rng.Next(5, 8);
            value = size * (rarity + 1) * 4;

        }
        

    }
}
