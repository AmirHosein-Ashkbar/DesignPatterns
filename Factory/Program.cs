using Factory;

IPayment payment = PaymentFactory.Create(PaymentMethod.GooglePay);

payment.Pay(10000.00);