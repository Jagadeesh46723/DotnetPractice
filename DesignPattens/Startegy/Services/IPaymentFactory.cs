namespace Startegy;

public interface IPaymentFactory
{
    IPaymentStrategy Create(string paymentType);
}
