namespace Factory;

public class CreditCard : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment made using Credit Card");
    }
}
