using Asilmedia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Abstractions.Repositories
{
    public interface IUserRepository
    {

        public Task<User> InsertAsync(User user);
        public Task<User> SelectByIdAsync(long id);
        public Task<User> SelectByIdAsync(string passwordHash, string email);
        public Task<List<User>> SelectAllAsync();
        public Task<User> UpdateAsync(User user, long id);
        public Task<User> DeleteAsync(long id);

    }
}
