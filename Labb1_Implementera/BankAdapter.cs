using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera
{
    public class BankAdapter : IBank // Adapter mellan Bank och IBank för att anpassa befintlig klass till annat gränssnitt. 
    {
        private Bank _bank;

        public BankAdapter()
        {
            _bank = Bank.CreateBank(); // Använder Factory-mönstret för att abstrahera skapandet av objektet och ge en flexibel lösning.
        }

        public void StartBank()
        {
            _bank.StartBank();
        }

        public void Insättning()
        {
            _bank.Insättning();
        }

        public void Uttag()
        {
            _bank.Uttag();
        }

        public void Saldo()
        {
            _bank.Saldo();
        }
    }
}
