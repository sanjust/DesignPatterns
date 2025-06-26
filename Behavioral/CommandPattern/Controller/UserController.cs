using System;
using CommandPattern.Commands;
using CommandPattern.Invoker;
using Microsoft.AspNetCore.Mvc;

namespace CommandPattern.Controller
{
    [ApiController]
    [Route("/User")]
    public class UserController : ControllerBase
    {
        private readonly ICommandInvoker _commandInvoker;

        public UserController(ICommandInvoker commandInvoker)
        {
            _commandInvoker = commandInvoker;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand createUserCommand)
        {
            var result = await _commandInvoker.DispatchAsync<CreateUserCommand, CreateUserCommandResult>(createUserCommand);

            return Ok(result);
        }
    }
}

