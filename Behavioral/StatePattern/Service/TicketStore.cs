using System;
using StatePattern.Enum;
using StatePattern.Service.Interface;

namespace StatePattern.Service
{
	public static class TicketStore
	{
		public static readonly Dictionary<Guid, Ticket> _tickets = new();

        public static Ticket? Get(Guid id) => _tickets.TryGetValue(id, out var ticket) ? ticket : null;

        public static Ticket CreateTicket(string title) {
			var ticket = new Ticket(title);
			_tickets[ticket.Id] = ticket;
			return ticket;
        }

		public static void Update(Ticket ticket) => _tickets[ticket.Id] = ticket;
    }
}

