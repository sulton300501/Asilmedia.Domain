using Asilmedia.Domain.Entities;
using AsilMedia.Application.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Services.Roles
{
    public interface IRoleService
    {
        public Task<Role> InsertAsync(RoleDTO roleDTO);
        public Task<Role> SelectByIdAsync(long id);
        public Task<List<Role>> SelectAllAsync();
        public Task<Role> UpdateAsync(string name, long id);
        public Task<Role> DeleteAsync(long id);
    }
}
