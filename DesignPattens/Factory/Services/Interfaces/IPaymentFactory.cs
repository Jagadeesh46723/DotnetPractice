namespace Factory;

public interface IPaymentFactory
{
    IPayment Create(string paymentType);
}
