using Asilmedia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Abstractions.Repositories
{
    public interface IRoleRepository
    {
        public Task<Role> InsertAsync(Role role);
        public Task<Role> SelectByIdAsync(long id);
        public Task<List<Role>> SelectAllAsync();
        public Task<Role> UpdateAsync(Role role, long id);
        public Task<Role> DeleteAsync(long id);
    }
}
