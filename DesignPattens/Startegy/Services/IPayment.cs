namespace Startegy;

public interface IPayment
{
    Task Pay(string paymentType, decimal amount);
}
