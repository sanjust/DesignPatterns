using System;
using CommandPattern.Services.Interface;

namespace CommandPattern.Commands
{
    public class CreateUserCommand : ICommand
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class CreateUserCommandResult
    {
        public Guid Id { get; set; }
    }
}

