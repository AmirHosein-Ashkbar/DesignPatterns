﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.PaymentMethods;
internal class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Successfully paid ${amount} using Credit Payment");
    }
}
