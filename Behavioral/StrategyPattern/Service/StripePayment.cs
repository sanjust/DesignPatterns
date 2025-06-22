using System;
using StrategyPattern.Enum;
using StrategyPattern.Model;
using StrategyPattern.Service.Interface;

namespace StrategyPattern.Service
{
	public class StripePayment : IPaymentStrategy
    {
        public PaymentMethod paymentMethod { get; set; } = PaymentMethod.Stripe;

        public bool IsAllowed(PaymentRequest paymentRequest)
        {
            if (paymentRequest.CountryCode == "USD") {
                return true;
            }

            return false;
        }

        public async Task<PaymentResponse> ProcessPaymentAsync(PaymentRequest paymentRequest)
        {
            Console.WriteLine("Processing stripe payment...");
            return new PaymentResponse()
            {
                Success = true,
                Message = "Success"
            };
        }
    }
}

