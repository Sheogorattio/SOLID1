using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequeClass
{
   abstract public class Cheque
    {
        private protected double money;
        private protected string currency;
        public Cheque()
        {
            money = 0;
            currency = null;
        }
        public Cheque(double money, string currency)
        {
            this.money = money;
            this.currency = currency;
        }
        abstract public string GetCheque();
    }

    public class NoCheque : Cheque
    {
        public NoCheque(double money, string currency) : base(money, currency)
        {
        }

        public override string GetCheque()
        {
            return null;
        }
    }

    public class PaperCheque : Cheque
    {
        public PaperCheque(double money, string currency) : base(money, currency)
        {
        }

        public override string GetCheque()
        {
            return $"------CHEQUE------\nTotal:{money} {currency}";
        }
    }

    public class ECheque : Cheque
    {
        public ECheque(double money, string currency) : base(money, currency)
        {
        }

        public override string GetCheque()
        {
           Console.WriteLine("Enter email.");
            string mail = Console.ReadLine();
            return $"------CHEQUE------\nTotal:{money} {currency}\nCopy was sent to {mail}";
        }
    }
}
