using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class Lax : Fisk
    {
        public Lax()
        {
            name = "Lax";
            size = Utils.rng.Next(7, 12);
            value = size * (rarity + 1) * 2;

        }


    }
}
