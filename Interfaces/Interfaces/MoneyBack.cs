using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class MoneyBack : CreditCard
    {
        public string GetCardType()
        {
            return "Money Back";
        }

        public int GetCardLimit()
        {
            return 42000;
        }
        public int GetAnnualCharge()
        {
            return 5000;
        }
    }
}
