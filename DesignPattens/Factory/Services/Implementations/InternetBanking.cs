namespace Factory;

public class InternetBanking : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment made using Internet Banking");
    }
}
