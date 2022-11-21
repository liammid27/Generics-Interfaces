using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new Platinumfactory().CreateProduct();
            if(creditCard != null)
            {
                Console.WriteLine("Card Type:" + creditCard.GetCardType());
                Console.WriteLine("Card Type:" + creditCard.GetCardLimit());
                Console.WriteLine("Card Type:" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.WriteLine("------------------");
            creditCard = new MoneyBackfactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type:" + creditCard.GetCardType());
                Console.WriteLine("Card Type:" + creditCard.GetCardLimit());
                Console.WriteLine("Card Type:" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.WriteLine("------------------");
            creditCard = new Titaniumfactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type:" + creditCard.GetCardType());
                Console.WriteLine("Card Type:" + creditCard.GetCardLimit());
                Console.WriteLine("Card Type:" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.WriteLine("------------------");
            Console.ReadLine();
        }
    }
}
