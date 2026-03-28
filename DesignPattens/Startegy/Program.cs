using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Startegy;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.AddKeyedTransient<IPaymentStrategy, CreditCardPayment>("CreditCard");
        services.AddKeyedTransient<IPaymentStrategy, UpiPayment>("UPI");
        services.AddTransient<IPaymentFactory, PaymentFactory>();
        services.AddTransient<IPayment, PaymentService>();
    })
    .Build();

var paymentService = host.Services.GetRequiredService<IPayment>();
await paymentService.Pay("CreditCard", 100);