﻿using System;
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

            //En bool som bestämmer varesig spelet körs eller inte
            bool gameIsRunning = true;
            while (gameIsRunning == true)
            {
                p1.PrintHeader();
                Console.WriteLine();
                Console.WriteLine("1: Fiska");
                Console.WriteLine("2: Kolla din inventory");
                Console.WriteLine("3: Gå till butiken");
                Console.WriteLine("4: Avsluta spelet");

                int userInputSiffra = Utils.Userinput(4, 1);
                if (userInputSiffra == 1)
                {
                    p1.Fiska();

                }
                else if(userInputSiffra == 2)
                {
                    p1.PrintHeader();

                    Console.WriteLine();
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

                    Console.Write("Klicka på valfri knapp för att gå tillbaka:");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(userInputSiffra == 3)
                {
                    p1.PrintHeader();

                    Console.WriteLine();
                    Console.WriteLine("1: Köpa");
                    Console.WriteLine("2: Sälja");

                    userInputSiffra = Utils.Userinput(2, 1);

                    if (userInputSiffra == 1)
                    {
                        Console.Clear();
                        p1.PrintHeader();
                        p1.Buy();
                    }
                    else if (userInputSiffra == 2)
                    {
                        Console.Clear();
                        p1.PrintHeader();
                        p1.Sell();

                    }
                }
                else if (userInputSiffra == 4)
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
