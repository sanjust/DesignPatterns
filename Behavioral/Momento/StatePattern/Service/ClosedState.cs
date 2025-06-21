using System;
using StatePattern.Enum;
using StatePattern.Service.Interface;

namespace StatePattern.Service
{
    public class ClosedState : ITicketState
    {
        public State state { get; set; } = State.Closed;

        public void Next(Ticket ticket, State state)
        {
            if (state != State.Open)
            {
                throw new InvalidOperationException();
            }

            ticket.SetState(new OpenState());
        }
    }
}

