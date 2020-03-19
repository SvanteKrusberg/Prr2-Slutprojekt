using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRR02_Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Virus> virusLista = new List<Virus>();

            Console.WriteLine("Välkommen till corona-manager");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Ge ditt virus ett namn!");
                Virus v1 = new Virus(Console.ReadLine());
                virusLista.Add(v1);
            }
            
            for (int i = 0; i < virusLista.Count; i++)
            {
                virusLista[i].printStats();
            }

            Console.ReadLine();

        }

    }
}
