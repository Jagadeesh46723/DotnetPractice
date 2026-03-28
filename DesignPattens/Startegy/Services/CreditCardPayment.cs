namespace Startegy;

public class CreditCardPayment : IPaymentStrategy
{
    public async Task Pay(decimal amount)
    {
        Console.WriteLine($"Payment of {amount} made using Credit Card");
        await Task.CompletedTask;
    }
}
