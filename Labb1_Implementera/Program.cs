namespace Labb1_Implementera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBank bank = new BankAdapter();
            bank.StartBank();
        }
    }
}

// Jag använder mig i den här koden av Factory, Singleton Och Adapter.