using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Titanium : CreditCard
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }

        public int GetCardLimit()
        {
            return 12000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
