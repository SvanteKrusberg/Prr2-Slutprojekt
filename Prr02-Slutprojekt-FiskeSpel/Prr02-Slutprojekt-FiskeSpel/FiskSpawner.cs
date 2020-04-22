using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class FiskSpawner
    {
        /*
        Fisk[] fiskBibliotek = { new Lax(), new Karp()};
        Skräp[] skräpBibliotek = { new Toffla(), new Däck() };
        */

        public static Fisk SpawnRandomFish()
        {
            if(Utils.rng.Next(100) > 50)
            {
                return new Lax();
            }
            else
            {
                return new Karp();
            }
            
        }

        public static Skräp SpawnRandomTrash()
        {
            if (Utils.rng.Next(100) > 50)
            {
                return new Toffla();
            }
            else
            {
                return new Däck();
            }

        }
    }
}
