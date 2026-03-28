namespace Startegy;

public class PaymentService(IPaymentFactory paymentFactory) : IPayment
{
    private readonly IPaymentFactory _paymentFactory = paymentFactory;

    public async Task Pay(string paymentType, decimal amount)
    {
        var payment = _paymentFactory.Create(paymentType) ?? throw new InvalidOperationException($"Payment type {paymentType} is not supported."); //Factory pattern is used here to create the appropriate payment method based on the payment type
        await payment.Pay(amount); //strategy pattern is used here to call the appropriate payment method based on the payment type
    }

}
