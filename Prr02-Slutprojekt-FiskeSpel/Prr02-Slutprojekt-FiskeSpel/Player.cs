using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class Player
    {
        public string Input()
        {
            string userInput;
            bool correctInput = false;

            while(correctInput == false)
            {
                
                userInput = Console.ReadLine();
                userInput.ToLower().Trim();
                if(userInput == "a"|| userInput == "b")
                {
                    return userInput;
                    

                }
                else
                {
                    
                }

                return userInput;
            }

        }

    }
}
