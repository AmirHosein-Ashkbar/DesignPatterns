using Strategy.Context;
using Strategy.Implementations;

var cart = new ShoppingCart();

// Pay with Credit Card
cart.SetPaymentStrategy(new CreditCardPayment());
cart.Checkout(100);

// Switch to PayPal
cart.SetPaymentStrategy(new PayPalPayment());
cart.Checkout(200);