using System;
using CommandPattern.DataModel;

namespace CommandPattern.Services.Interface
{
    public interface IUserRepository
    {
        public Task<Guid> AddAsync(User user);
    }
}

