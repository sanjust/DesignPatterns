using System;
using CommandPattern.Services.Interface;

namespace CommandPattern.Invoker
{
    public interface ICommandInvoker
    {
        Task<TResult> DispatchAsync<TCommand, TResult>(TCommand command)
            where TCommand : ICommand
            where TResult : class;

        Task DispatchAsync<TCommand>(TCommand command) where TCommand : ICommand;
    }
}

