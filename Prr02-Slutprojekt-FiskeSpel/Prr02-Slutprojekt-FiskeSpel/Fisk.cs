using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class Fisk : Fiskbar
    {
        
        string[] rarityLabel = { "common", "uncommon", "rare", "epic", "legendary" };

        public Fisk()
        {
            DeclareRarity();
        }

        public void DeclareRarity()
        {
            int r = Utils.rng.Next(100);
            if(r > 60)
            {
                rarity = 0;
                Console.WriteLine(r);
            }
            else if(r > 30 && r < 60)
            {
                rarity = 1;
                Console.WriteLine(r);
            }
            else if(r > 10 && r < 30)
            {
                rarity = 2;
                Console.WriteLine(r);
            }
            else if(r < 10)
            {
                rarity = 3;
                Console.WriteLine(r);
            }
            else
            {
                rarity = 4;
                Console.WriteLine(r);
            }

        }

        public void PrintStats()
        {
            Console.WriteLine(rarityLabel[rarity]);
            Console.WriteLine(rarity);

        }

    }
}
