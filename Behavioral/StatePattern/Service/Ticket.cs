using System;
using StatePattern.Enum;
using StatePattern.Service.Interface;

namespace StatePattern.Service
{
	public class Ticket
	{
        public Guid Id { get; } = Guid.NewGuid();
        public string _title;
        private ITicketState _ticket;

        public Ticket(string title)
        {
            _title = title;
            _ticket = new OpenState();
        }

        public void SetState(ITicketState ticket)
        {
            _ticket = ticket;
        }

        public void ApplyTransaction(State state)
        {
            _ticket.Next(this, state);
        }

        public State GetState()
        {
            return _ticket.state;
        }
    }
}

