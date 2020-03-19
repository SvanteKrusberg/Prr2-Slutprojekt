using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRR02_Slutprojekt
{
    class Human
    {
        bool isInfected = false;
        int lifeStrength;
        
        public bool infection(int p)
        {
            if(p > lifeStrength || isInfected == true)
            {
                isInfected = true;
                return true;
            }
            else
            {
                isInfected = false;
                return false;

            }

        }

        public void quarantine(int d)
        {
            lifeStrength = lifeStrength + d;

        }

    }
}
