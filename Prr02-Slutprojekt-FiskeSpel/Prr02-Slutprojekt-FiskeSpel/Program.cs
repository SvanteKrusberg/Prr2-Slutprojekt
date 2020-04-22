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
            Console.ForegroundColor = ConsoleColor.White;
            Player p1 = new Player();

            bool gameIsRunning = true;
            while (gameIsRunning == true){
                Console.Write("Vad vill du göra?                Pengar: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(p1.money + " kr");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
                Console.WriteLine("1: Fiska");
                Console.WriteLine("2: Kolla din inventory");
                Console.WriteLine("3: Avsluta spelet");

                string userInput = Console.ReadLine();
                int userInputSiffra;
                bool lyckad = int.TryParse(userInput, out userInputSiffra);
                while (lyckad == false || userInputSiffra < 1 || userInputSiffra > 3)
                {
                    Console.WriteLine("Skriv in ett korrekt värde!");
                    userInput = Console.ReadLine();
                    lyckad = int.TryParse(userInput, out userInputSiffra);
                }

                if(userInputSiffra == 1)
                {
                    p1.Fiska();

                }
                else if(userInputSiffra == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Fiskar:");
                    Console.ForegroundColor = ConsoleColor.White;

                    p1.PrintFiskeLista();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Skräp:");
                    Console.ForegroundColor = ConsoleColor.White;

                    p1.PrintSkräpLista();
                    Console.WriteLine();

                    Console.WriteLine("Klicka på valfri knapp för att gå tillbaka:");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(userInputSiffra == 3)
                {
                    gameIsRunning = false;
                    Console.Clear();
                    
                    Console.WriteLine("Hejdå! :)");
                    Console.ReadLine();
                }
            }

        }
    }
}
