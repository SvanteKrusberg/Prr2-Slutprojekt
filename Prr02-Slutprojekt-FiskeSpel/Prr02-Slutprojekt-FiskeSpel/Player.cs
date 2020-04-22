using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prr02_Slutprojekt_FiskeSpel
{
    class Player
    {
        public int money;
        private int fiskTräff;
        private List<Fisk> fiskLista = new List<Fisk>();
        private List<Skräp> skräpLista = new List<Skräp>();

        public void Fiska()
        {
            Console.Clear();
            int amountOfFishies = Utils.rng.Next(2, 5);
            Console.WriteLine("Skriv in ett värde mellan: 1 - " + amountOfFishies + " för att fiska!");
            string userInput = Console.ReadLine();
            int userInputSiffra;
            bool lyckad = int.TryParse(userInput, out userInputSiffra);
            while (lyckad == false || userInputSiffra > amountOfFishies || userInputSiffra < 1)
            {
                Console.WriteLine("Skriv in ett korrekt värde!");
                userInput = Console.ReadLine();
                lyckad = int.TryParse(userInput, out userInputSiffra);
            }
            fiskTräff = Utils.rng.Next(1, amountOfFishies);

            if(userInputSiffra == fiskTräff)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Du fick napp!");
                Console.ForegroundColor = ConsoleColor.White;
                fiskLista.Add(FiskSpawner.SpawnRandomFish());
                fiskLista[fiskLista.Count - 1].PrintStats();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Fisken har lagts till i din inventory!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Attans!");
                Console.ForegroundColor = ConsoleColor.White;
                skräpLista.Add(FiskSpawner.SpawnRandomTrash());
                skräpLista[skräpLista.Count - 1].PrintStats();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Skräpet har lagts till i din inventory!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }

            Console.WriteLine("Klicka på valfri knapp för att fortsätta:");
            Console.ReadLine();
            Console.Clear();

        }
        public void PrintFiskeLista()
        {
            for (int i = 0; i < fiskLista.Count; i++)
            {
                fiskLista[i].PrintStats();
            }
        }
        public void PrintSkräpLista()
        {
            for (int i = 0; i < skräpLista.Count; i++)
            {
                skräpLista[i].PrintStats();
            }
        }
        public void PrintHeader()
        {
            Console.Clear();
            Console.Write("Vad vill du göra?                Pengar: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(money + " kr");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void Sell()
        {
            Console.WriteLine();
            Console.WriteLine("Vill du sälja fisk eller skräp?");
            Console.WriteLine();
            Console.WriteLine("1: Fisk");
            Console.WriteLine("2: Skräp");
            string userInput = Console.ReadLine();
            int userInputSiffra;
            bool lyckad = int.TryParse(userInput, out userInputSiffra);
            while (lyckad == false || userInputSiffra < 1 || userInputSiffra > 2)
            {
                Console.WriteLine("Skriv in ett korrekt värde!");
                userInput = Console.ReadLine();
                lyckad = int.TryParse(userInput, out userInputSiffra);
            }

            if (userInputSiffra == 1)
            {
                PrintHeader();
                Console.WriteLine();

                Console.WriteLine("Vilken fisk vill du sälja?");
                Console.WriteLine();
                PrintFiskeLista();

                userInput = Console.ReadLine();
                lyckad = int.TryParse(userInput, out userInputSiffra);
                while (lyckad == false || userInputSiffra < 1 || userInputSiffra >  fiskLista.Count)
                {
                    Console.WriteLine("Skriv in ett korrekt värde!");
                    userInput = Console.ReadLine();
                    lyckad = int.TryParse(userInput, out userInputSiffra);
                }

                money = money + fiskLista[userInputSiffra-1].value;
                fiskLista.RemoveAt(userInputSiffra - 1);

            }
            else if (userInputSiffra == 2)
            {
                int sellAmount = 0;
                PrintHeader();
                for (int i = 0; i < skräpLista.Count; i++)
                {
                    sellAmount = sellAmount + skräpLista[i].value;
                }

                Console.WriteLine();
                Console.WriteLine("Vill du sälja allt ditt skräp för: " + sellAmount + " kr");
                Console.WriteLine("1: Ja");
                Console.WriteLine("2: Nej");

                userInput = Console.ReadLine();
                lyckad = int.TryParse(userInput, out userInputSiffra);
                while (lyckad == false || userInputSiffra < 1 || userInputSiffra > 2)
                {
                    Console.WriteLine("Skriv in ett korrekt värde!");
                    userInput = Console.ReadLine();
                    lyckad = int.TryParse(userInput, out userInputSiffra);
                }

                if (userInputSiffra == 1)
                {
                    for (int i = 0; i < skräpLista.Count; i++)
                    {
                        skräpLista.RemoveAt(skräpLista.Count-1);
                        money = money + sellAmount;
                        sellAmount = 0;

                    }
                }

                else if (userInputSiffra == 2)
                {
                    sellAmount = 0;
                }
            }

        }

        public void Buy()
        {


        }

    }
}
