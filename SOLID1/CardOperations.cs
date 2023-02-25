using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClass;

namespace Interface
{
    public interface ICardOperations
    {
         void GetMoney(double money, Card card, int pin);
         void ReplenishAccount(double money, Card card, int pin);
    }
}
