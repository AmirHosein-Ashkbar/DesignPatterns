using Strategy.Interfaces;

namespace Strategy.Implementations;
public class PayPalPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal.");
    }
}
