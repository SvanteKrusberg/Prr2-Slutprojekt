using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class Toffla : Skräp
    {
        public Toffla()
        {
            name = "Toffla";
            size = Utils.rng.Next(1, 2);

        }

    }
}
