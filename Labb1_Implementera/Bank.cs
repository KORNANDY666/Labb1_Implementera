using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Labb1_Implementera
{

    public class Bank : IBank
    {
        private static Bank? NewBank;
        public int sum;

        private Bank()      // Singleton Genom att använder mig av en privat konstruktor och den statiska metoden CreateBank.
        {                   // Och ser då till att det bara skapas en instans av Bank.
            
        }

        public static Bank CreateBank() 
        {
            if (NewBank == null)
            {
                NewBank = new Bank();
            }
            return NewBank;
        }


        public void StartBank()
        {
            int UserInput;

            Console.WriteLine("Vad vill du göra idag \n" +
                "\n" +
                "1. Insättning \n" +
                "2. Uttag \n" +
                "3. Saldo \n" +
                "4. Avsluta");
            Console.WriteLine("");

            UserInput = int.Parse(Console.ReadLine());
            switch (UserInput) 
            {
                case 1: Insättning();
                    break;
                case 2: Uttag();
                    break;
                case 3: Saldo();
                    break;
            
            }


        }

        public void Insättning()
        {
            int UserValue;
            Console.Write("Hur mycket vill du sätta in? ange i SEK : ");
            UserValue = int.Parse(Console.ReadLine());

            sum = UserValue + sum;


            Console.Clear();
            StartBank();
            
            
            

        }

        public void Uttag()
        {
            int UserValue;
            Console.Write("Summa för uttag : ");
            UserValue = int.Parse(Console.ReadLine());

            if (UserValue > sum) 
            {
                Console.WriteLine($"Du kan inte ta ut din angivna summa på : {UserValue} eftersom du har {sum} Sek på kontot");
            }
            else
            {
                sum -= UserValue;
            }
           
            Console.WriteLine($"Resterande konto saldo : {sum} Skr");
            Console.WriteLine("Tryck på Enter för att fortsätta...");
            Console.ReadLine();
            Console.Clear();
            StartBank();

        }
        
        public void Saldo()
        {
            Console.WriteLine($"Saldo : {sum} Sek");

            Console.WriteLine("Tryck på Enter för att fortsätta...");
            Console.ReadLine();

            Console.Clear();
            StartBank();

        }

    }


}
