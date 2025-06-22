using System;
namespace StrategyPattern.Model
{
	public class PaymentResponse
    {
		public string Message { get; set; } = string.Empty;
		public bool Success { get; set; }
	}
}

