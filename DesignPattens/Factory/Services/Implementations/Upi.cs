namespace Factory;

public class Upi : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment made using UPI");
    }
}
