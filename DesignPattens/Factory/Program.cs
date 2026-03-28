using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Factory;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.AddKeyedTransient<IPayment, CreditCard>("CreditCard");
        services.AddKeyedTransient<IPayment, InternetBanking>("InternetBanking");
        services.AddKeyedTransient<IPayment, Upi>("UPI");
        services.AddTransient<IPaymentFactory, PaymentFactory>();
    })
    .Build();

var paymentFactory = host.Services.GetRequiredService<IPaymentFactory>();
var payment = paymentFactory.Create("UPI");
payment.Pay();