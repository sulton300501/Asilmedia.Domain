using Asilmedia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Services.Permissions
{
    public interface IPermissionService
    {
        public Task<Permission> InsertAsync(string name);
        public Task<List<Permission>> SelectAllAsync();
        public Task<Permission> DeleteAsync(long id);
    }
}
