using System;
using StatePattern.Enum;
using StatePattern.Service.Interface;

namespace StatePattern.Service
{
    public class OpenState : ITicketState
    {
        public State state { get; set; } = State.Open;

        public void Next(Ticket ticket, State state)
        {
            if (state != State.InProgress) {
                throw new InvalidOperationException();
            }

            ticket.SetState(new InProgressState());
        }
    }
}

