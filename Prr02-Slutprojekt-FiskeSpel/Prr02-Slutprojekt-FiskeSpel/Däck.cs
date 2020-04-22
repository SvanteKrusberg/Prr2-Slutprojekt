using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class Däck : Skräp
    {
        public Däck()
        {
            name = "Däck";
            size = Utils.rng.Next(2, 4);

        }

    }
}
