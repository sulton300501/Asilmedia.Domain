using Asilmedia.Domain.Entities;
using AsilMedia.Application.Abstractions.Repositories;
using AsilMedia.Application.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<string> InsertAsync(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> SelectAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> SelectByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateAsync(UserDTO userDTO, long id)
        {
            throw new NotImplementedException();
        }
    }
}
