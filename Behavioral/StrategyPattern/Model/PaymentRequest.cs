using System;
namespace StrategyPattern.Model
{
	public class PaymentRequest
	{
		public decimal Price { get; set; }
		public string CountryCode { get; set; } = String.Empty;
	}
}

