using System;
using CommandPattern.Services.Interface;

namespace CommandPattern.CommandHandler
{
    public interface ICommandHandler<TCommand, TResult> where TCommand : ICommand
    {
        Task<TResult> HandleAsync(TCommand command);
    }

    // For commands that don't return any result
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        Task HandleAsync(TCommand command);
    }
}

