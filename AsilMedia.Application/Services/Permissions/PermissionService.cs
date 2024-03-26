using Asilmedia.Domain.Entities;
using AsilMedia.Application.Abstractions.Repositories;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Services.Permissions
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;

        public PermissionService(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        public async Task<Permission> DeleteAsync(long id)
        {
         var result = await _permissionRepository.DeleteAsync(id);
            return result;
        }

        public async Task<Permission> InsertAsync(string name)
        {
            var result = await _permissionRepository
                .InsertAsync(new Permission { Name = name });
            return result;
        }

        public Task<List<Permission>> SelectAllAsync()
        {
            return _permissionRepository.SelectAllAsync();
        }
    }
}
