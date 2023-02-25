using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChequeClass;
using CardClass;
using Interface;

namespace ATMClass
{
    public class ATM:ICardOperations
    {
        double moneyDifference;
        string currency;

        public void GetMoney(double money, Card card, int pin)
        {
            if (card.CheckPIN(pin) == true)
            {
                currency = card.Currency;
                moneyDifference = money;
                card.Money -= money;
            }
            else { Console.WriteLine("Wrong PIN."); }
        }

        public void ReplenishAccount(double money, Card card, int pin)
        {
            if (card.CheckPIN(pin) == true)
            {
                currency = card.Currency;
                moneyDifference = money;
                card.Money += money;
            }
            else { Console.WriteLine("Wrong PIN."); }
        }

        public Cheque GetCheque()
        {
            Console.WriteLine("1.Paper cheque\n2.E-cheque\n3.No cheque");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    return new PaperCheque(moneyDifference, currency);
                case 2:
                    return new ECheque(moneyDifference, currency);
                case 3:
                    return new NoCheque(moneyDifference, currency);
                default:
                    return null;

            }
        }
    }
}
