using System;
using StrategyPattern.Enum;
using StrategyPattern.Model;
using StrategyPattern.Service.Interface;

namespace StrategyPattern.Service
{
	public class PaypalPayment : IPaymentStrategy
    {
        public PaymentMethod paymentMethod { get; set; } = PaymentMethod.RazorPay;

        public bool IsAllowed(PaymentRequest paymentRequest)
        {
            if (paymentRequest.CountryCode != "INR" && paymentRequest.CountryCode != "USD") {
                return true;
            }

            return false;
        }

        public async Task<PaymentResponse> ProcessPaymentAsync(PaymentRequest paymentRequest)
        {
            Console.WriteLine("Processing paypal payment...");
            return new PaymentResponse()
            {
                Success = true,
                Message = "Success"
            };
        }
    }
}

