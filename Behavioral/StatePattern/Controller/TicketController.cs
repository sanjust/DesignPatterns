using System;
using Microsoft.AspNetCore.Mvc;
using StatePattern.Enum;
using StatePattern.Model;
using StatePattern.Service;
using StatePattern.Service.Interface;

namespace StatePattern.Controller
{
	[ApiController]
	[Route("api/tickets")]
	public class TicketController : ControllerBase
	{
        public TicketController()
		{
		}

		[HttpPost("create")]
        public IActionResult CreateTicket([FromBody] CreateTicket createTicket) {
			var ticket = TicketStore.CreateTicket(createTicket.Title);
            TicketStore.Update(ticket);
            return Ok(new {
				id = ticket.Id,
				message = "Ticket created"
			});
		}

        [HttpPost("{id}/update/{state}")]
        public IActionResult CreateTicket([FromRoute] Guid id, [FromRoute] State state)
        {
            var ticket = TicketStore.Get(id);
			if (ticket == null) {
				return NotFound("Ticket not found");
			}

			try
			{
                ticket.ApplyTransaction(state);
				TicketStore.Update(ticket);

				return Ok($"Ticket successfully updated to {state}");
            }
			catch (Exception e) {
				return BadRequest(e.Message);
			}
        }

        [HttpGet("{id}/state")]
        public IActionResult GetState([FromRoute] Guid id)
        {
            var ticket = TicketStore.Get(id);
            if (ticket == null)
            {
                return NotFound("Ticket not found");
            }

            try
            {
                return Ok($"Ticket Name: {ticket._title}, Status: {ticket.GetState()}");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}

