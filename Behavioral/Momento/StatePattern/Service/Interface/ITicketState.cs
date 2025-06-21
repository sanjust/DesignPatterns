using System;
using StatePattern.Enum;

namespace StatePattern.Service.Interface
{
	public interface ITicketState
	{
		State state { get; }
		void Next(Ticket ticket, State sate);
	}
}

