using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class Fisk : Fiskbar
    {

        protected string name;
        protected int size;
        protected int value;
        protected int rarity;
        protected int rarityValue;

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
            }
            else if(r > 30 && r < 60)
            {
                rarity = 1;
            }
            else if(r > 10 && r < 30)
            {
                rarity = 2;
            }
            else if(r < 10)
            {
                rarity = 3;
            }
            else
            {
                rarity = 4;
            }

        }

        public void PrintStats()
        {
            Console.WriteLine(name);
            Console.WriteLine("Rarity: " + rarityLabel[rarity]);
            Console.WriteLine("Size: " + size);
            Console.WriteLine("Value: " + value);
            Console.WriteLine();

        }

    }
}
