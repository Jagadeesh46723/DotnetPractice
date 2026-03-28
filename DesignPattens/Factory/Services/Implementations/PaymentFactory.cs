using Microsoft.Extensions.DependencyInjection;

namespace Factory;

public class PaymentFactory : IPaymentFactory
{
    private readonly IServiceProvider _serviceProvider;

    public PaymentFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IPayment Create(string paymentType)
    {
        return _serviceProvider.GetRequiredKeyedService<IPayment>(paymentType);
    }
}
