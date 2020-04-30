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
        private int fiskTräffBete;

        //Listor med fiskar och skräp
        private List<Fisk> fiskLista = new List<Fisk>();
        private List<Skräp> skräpLista = new List<Skräp>();

        //En stack med bete
        public Stack<Bait> betesHög = new Stack<Bait>();
        Rod fiskespö = new Rod();

        //En metod som körs varje gång spelaren vill fiska
        public void Fiska()
        {
            Console.Clear();
            int amountOfFishies = Utils.rng.Next(3, 6);
            Console.WriteLine("Skriv in ett värde mellan: 1 - " + amountOfFishies + " för att fiska!");

            int userInputSiffra = Utils.Userinput(amountOfFishies, 1);
            fiskTräff = Utils.rng.Next(1, amountOfFishies + 1);
            Console.WriteLine(fiskTräff);

            if (betesHög.Count > 0)
            {
                fiskTräffBete = Utils.rng.Next(1, amountOfFishies + 1);
                while (fiskTräffBete == fiskTräff)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(fiskTräffBete);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(fiskTräff);

                    fiskTräffBete = Utils.rng.Next(1, amountOfFishies + 1);
                    if (fiskTräffBete != fiskTräff)
                    {
                        break;
                    }
                }
                betesHög.Pop();
            }
            else
            {
                fiskTräffBete = 0;
            }
            

            if (userInputSiffra == fiskTräff || userInputSiffra == fiskTräffBete)
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

        //En metod som printar alla fiskars stats i fiskelistans
        public void PrintFiskeLista()
        {
            for (int i = 0; i < fiskLista.Count; i++)
            {
                fiskLista[i].PrintStats();
            }
        }

        //En metod som printar alla skräpbitars stats i skrälistan
        public void PrintSkräpLista()
        {
            for (int i = 0; i < skräpLista.Count; i++)
            {
                skräpLista[i].PrintStats();
            }
        }

        //En metod som körs för att skriva ut "huvud-UI"
        public void PrintHeader()
        {
            Console.Clear();
            Console.WriteLine("Bete: " + betesHög.Count);
            Console.Write("Vad vill du göra?                Pengar: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(money + " kr");
            Console.ForegroundColor = ConsoleColor.White;

        }

        //En metod som körs varje gång spelaren ska sälja något
        public void Sell()
        {
            Console.WriteLine();
            Console.WriteLine("Vill du sälja fisk eller skräp?");
            Console.WriteLine();

            Console.WriteLine("1: Fisk (Endast om du faktiskt har fisk)");
            Console.WriteLine("2: Skräp");

            int userInputSiffra = Utils.Userinput(2, 1);

            if (userInputSiffra == 1 && fiskLista.Count >= 1)
            {
                PrintHeader();
                Console.WriteLine();

                Console.WriteLine("Vilken fisk vill du sälja? (1 - " + fiskLista.Count + ")");
                Console.WriteLine();
                PrintFiskeLista();

                userInputSiffra = Utils.Userinput(fiskLista.Count, 1);

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

                userInputSiffra = Utils.Userinput(2, 1);

                if (userInputSiffra == 1)
                {
                    int loops = skräpLista.Count;
                    for (int i = 0; i <= loops - 1; i++)
                    {
                        skräpLista.RemoveAt(skräpLista.Count-1);

                    }
                    money = money + sellAmount;
                    sellAmount = 0;
                }

                else if (userInputSiffra == 2)
                {
                    sellAmount = 0;
                }
            }

        }

        //En metod som körs varje gång spelaren ska köpa något
        public void Buy()
        {
            Console.WriteLine();
            Console.WriteLine("Vad vill du köpa?");
            Console.WriteLine();
            Console.WriteLine("1: Bete");
            Console.WriteLine("2: Fiskespö (wip)");
            Console.WriteLine("3: Fiskedrag (wip)");

            int userinputSiffra = Utils.Userinput(3, 1);

            if(userinputSiffra == 1)
            {
                PrintHeader();
                Console.WriteLine();
                Console.WriteLine("Vill du lägga till 5 beten till din hög för 50 kr?");
                Console.WriteLine("1: Ja");
                Console.WriteLine("2: Nej");
                userinputSiffra = Utils.Userinput(2, 1);
                if(userinputSiffra == 1)
                {
                    if(money >= 50)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            betesHög.Push(new Bait());
                            money = money - 10;
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Du har inte råd med det där!");
                        Console.ReadLine();
                    }
                    
                }
                else if(userinputSiffra == 2)
                {
                    Console.WriteLine("Okej, kom tillbaka när du ångrat dig!");
                    Console.ReadLine();
                }

            }
            else if (userinputSiffra == 2)
            {
                Console.WriteLine("Du kan inte göra det här ännu!");
                Console.ReadLine();

            }
            else if (userinputSiffra == 3)
            {
                Console.WriteLine("Du kan inte göra det här ännu!");
                Console.ReadLine();

            }

        }

    }
}
