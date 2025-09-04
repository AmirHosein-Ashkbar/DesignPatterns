using Strategy.Interfaces;

namespace Strategy.Context;
public class ShoppingCart
{
    private IPaymentStrategy _paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void Checkout(int amount)
    {
        _paymentStrategy.Pay(amount);
    }
}
