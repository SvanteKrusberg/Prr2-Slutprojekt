using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Fisk f1 = new Fisk();
            Player p1 = new Player();

            f1.PrintStats();
            userInput = p1.Input();

            Console.ReadLine();

        }
    }
}
