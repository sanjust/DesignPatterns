using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using StrategyPattern.Model;
using StrategyPattern.Service;

namespace StrategyPattern.Controller
{
	[ApiController]
	[Route("/api/payment")]
	public class PaymentController : ControllerBase
	{
		private readonly PaymentStrategy _paymentStrategy;
        public PaymentController(PaymentStrategy paymentStrategy)
		{
			_paymentStrategy = paymentStrategy;
		}

		[HttpPost("process")]
		public async Task<IActionResult> ProcessPayment([FromBody] PaymentRequest paymentRequest) {
			try
            {
                await _paymentStrategy.ProcessPaymentAsync(paymentRequest);
                return Ok();
            }
            catch (InvalidOperationException e)
            {
                return BadRequest(e.Message);
            }
            catch (Exception e)
			{
				return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
			}
		}
	}
}

