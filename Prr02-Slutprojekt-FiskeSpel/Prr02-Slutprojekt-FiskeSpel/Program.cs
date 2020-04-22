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

            
            Fisk f1 = new Fisk();
            Player p1 = new Player();

            f1.PrintStats();

            string userInput;
            List<Fisk> fiskeLista = new List<Fisk>();

            Fisk l1 = new Lax();
            Fisk k1 = new Karp();
            Player p1 = new Player();

            l1.PrintStats();
            k1.PrintStats();


            Console.ReadLine();

        }
    }
}
