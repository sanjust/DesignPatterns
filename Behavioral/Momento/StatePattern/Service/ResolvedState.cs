using System;
using StatePattern.Enum;
using StatePattern.Service.Interface;

namespace StatePattern.Service
{
    public class ResolvedState : ITicketState
    {
        public State state { get; set; } = State.Resolved;

        public void Next(Ticket ticket, State state)
        {
            if (state != State.Closed)
            {
                throw new InvalidOperationException();
            }

            ticket.SetState(new ClosedState());
        }
    }
}

