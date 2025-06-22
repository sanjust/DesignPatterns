using System;
using StrategyPattern.Enum;
using StrategyPattern.Model;

namespace StrategyPattern.Service.Interface
{
	public interface IPaymentStrategy
	{
		public PaymentMethod paymentMethod { get; set; }
		public bool IsAllowed(PaymentRequest paymentRequest);
		public Task<PaymentResponse> ProcessPaymentAsync(PaymentRequest paymentRequest);
    }
}

