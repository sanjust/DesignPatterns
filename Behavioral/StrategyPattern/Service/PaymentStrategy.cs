using System;
using StrategyPattern.Model;
using StrategyPattern.Service.Interface;

namespace StrategyPattern.Service
{
	public class PaymentStrategy
	{
		private readonly IEnumerable<IPaymentStrategy> _paymentStrategies;

		public PaymentStrategy(IEnumerable<IPaymentStrategy> paymentStrategies)
		{
			_paymentStrategies = paymentStrategies;
        }

		public async Task<PaymentResponse> ProcessPaymentAsync(PaymentRequest request) {
			var result = _paymentStrategies
					.Where(s => s.IsAllowed(request))
					.FirstOrDefault();

			if (request == null) {
				throw new InvalidOperationException("No supported payment method for given request");
			}

			return await result!.ProcessPaymentAsync(request);
        }
	}
}

