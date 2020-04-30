using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class Utils
    {
        public static Random rng = new Random();

        public static int Userinput(int s, int b)
        {
            string userInput = Console.ReadLine();
            int userInputSiffra;
            bool lyckad = int.TryParse(userInput, out userInputSiffra);
            while (lyckad == false || userInputSiffra > s || userInputSiffra < b)
            {
                Console.WriteLine("Skriv in ett korrekt värde!");
                userInput = Console.ReadLine();
                lyckad = int.TryParse(userInput, out userInputSiffra);
            }
            return userInputSiffra;

        }

    }
}
