using System;
using StatePattern.Enum;
using StatePattern.Service.Interface;

namespace StatePattern.Service
{
    public class InProgressState : ITicketState
    {
        public State state { get; set; } = State.InProgress;

        public void Next(Ticket ticket, State sate)
        {
            if (state != State.Resolved)
            {
                throw new InvalidOperationException();
            }

            ticket.SetState(new ResolvedState());
        }
    }
}

