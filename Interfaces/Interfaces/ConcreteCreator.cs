using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class MoneyBackfactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new MoneyBack();
            return product;
        }
     
    }

    public class Titaniumfactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Titanium();
            return product;
        }

    }
    public class Platinumfactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Platinum();
            return product;
        }

    }
}
