using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClass;
using ATMClass;
using ChequeClass;

namespace SOLID1
{
    internal class Program
    {
        static void Main()
        {
            Card card = new Card(10000, "hrn", 345, 1234567890123456, 1234);
            ATM atm = new ATM();

            while (true)
            {
                Console.WriteLine("1.Replenish account\n2.Get money\n3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter money value;");
                            double money = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter PIN");
                            int pin = Convert.ToInt32(Console.ReadLine());

                            atm.ReplenishAccount(money, card, pin);
                            Console.WriteLine( atm.GetCheque().GetCheque());
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter money value;");
                            double money = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter PIN");
                            int pin = Convert.ToInt32(Console.ReadLine());

                            atm.GetMoney(money, card, pin);
                            Console.WriteLine(atm.GetCheque().GetCheque());
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Wrong choice.");
                        break;
                }
            }
        }
    }
}
