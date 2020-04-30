using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class Rod : Equipment
    {
        int rarityIncrease;

        public Rod()
        {
            durability = 0;
            rarityIncrease = 20;
        }

        public int RarityIncrease()
        {
            if(durability > 0)
            {
                durability = durability - 1;
                return rarityIncrease;

            }
            else
            {
                return 0;
            }

        }

    }
}
