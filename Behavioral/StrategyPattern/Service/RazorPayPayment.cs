using System;
using StrategyPattern.Enum;
using StrategyPattern.Model;
using StrategyPattern.Service.Interface;

namespace StrategyPattern.Service
{
	public class RazorPayPayment : IPaymentStrategy
    {
        public PaymentMethod paymentMethod { get; set; } = PaymentMethod.RazorPay;

        public bool IsAllowed(PaymentRequest paymentRequest)
        {
            if (paymentRequest.CountryCode == "INR") {
                return true;
            }

            return false;
        }

        public async Task<PaymentResponse> ProcessPaymentAsync(PaymentRequest paymentRequest)
        {
            Console.WriteLine("Processing razor pay payment...");
            return new PaymentResponse()
            {
                Success = true,
                Message = "Success"
            };
        }
    }
}

