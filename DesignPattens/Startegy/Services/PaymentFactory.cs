using Microsoft.Extensions.DependencyInjection;
namespace Startegy;

public class PaymentFactory : IPaymentFactory
{
    private readonly IServiceProvider _serviceProvider;

    public PaymentFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IPaymentStrategy Create(string paymentType)
    {
        return _serviceProvider.GetRequiredKeyedService<IPaymentStrategy>(paymentType);
    }

}
