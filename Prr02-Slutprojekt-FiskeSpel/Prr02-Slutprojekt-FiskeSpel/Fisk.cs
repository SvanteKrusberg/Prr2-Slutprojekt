using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class Fisk : Fiskbar
    {

        protected int rarity;
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

        public override void PrintStats()
        {
            Console.WriteLine("Fångst: " + name);
            Console.Write("Rarity: ");

            if(rarity == 0)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (rarity == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (rarity == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (rarity == 3)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (rarity == 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.WriteLine(rarityLabel[rarity]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Vikt: " + size + " kg");
            Console.WriteLine("Värde: " + value + " kr");
            Console.WriteLine();

        }

    }
}
