namespace Startegy;

public interface IPaymentStrategy
{
    Task Pay(decimal amount);
}
