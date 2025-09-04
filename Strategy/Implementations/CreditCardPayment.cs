using Strategy.Interfaces;

namespace Strategy.Implementations;
public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card.");
    }
}
