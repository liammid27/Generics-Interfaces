﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Platinum : CreditCard
    {
        public string GetCardType()
        {
            return "Platinum Plus";
        }

        public int GetCardLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}