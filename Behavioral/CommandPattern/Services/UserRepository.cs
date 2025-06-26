using System;
using CommandPattern.DataModel;
using CommandPattern.Services.Interface;

namespace CommandPattern.Services
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
        }

        public async Task<Guid> AddAsync(User user)
        {
            Console.WriteLine("Added user to database...");
            return Guid.NewGuid();
        }
    }
}

