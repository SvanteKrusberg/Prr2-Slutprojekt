using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class Skräp : Fiskbar
    {

        public Skräp()
        {
            value = Utils.rng.Next(10, 20);
            
        }

    }
}
