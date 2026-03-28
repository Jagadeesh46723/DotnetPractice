namespace Startegy;

public class UpiPayment : IPaymentStrategy
{
    public async Task Pay(decimal amount)
    {
        Console.WriteLine($"Payment of {amount} made using UPI");
        await Task.CompletedTask;
    }
}
