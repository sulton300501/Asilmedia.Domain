using Asilmedia.Domain.Entities;
using AsilMedia.Application.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Services.Users
{
    public interface IUserService
    {
        public Task<string> InsertAsync(UserDTO userDTO);
        public Task<User> SelectByIdAsync(long id);
        public Task<List<User>> SelectAllAsync();
        public Task<User> UpdateAsync(UserDTO userDTO, long id);
        public Task<User> DeleteAsync(long id);
    }
}
