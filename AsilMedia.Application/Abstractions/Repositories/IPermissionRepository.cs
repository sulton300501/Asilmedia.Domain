using Asilmedia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Abstractions.Repositories
{
    public interface IPermissionRepository
    {
        public Task<Permission> InsertAsync(Permission permission);
        public Task<List<Permission>> SelectAllAsync();
        public Task<List<Permission>> SelectAllAsync(List<long> ids);
        public Task<Permission> DeleteAsync(long id);
    }
}
