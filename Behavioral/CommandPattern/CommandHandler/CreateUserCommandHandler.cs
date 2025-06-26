using System;
using CommandPattern.Commands;
using CommandPattern.DataModel;
using CommandPattern.Services.Interface;

namespace CommandPattern.CommandHandler
{
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, CreateUserCommandResult>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<CreateUserCommandResult> HandleAsync(CreateUserCommand command)
        {
            var result = await _userRepository.AddAsync(new User() {
                Username = command.Username,
                Email = command.Email,
                Password = command.Password
            });

            return new CreateUserCommandResult() {
                Id = result
            };
        }
    }
}

