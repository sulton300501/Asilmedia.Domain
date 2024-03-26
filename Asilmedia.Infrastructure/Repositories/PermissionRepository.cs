using Asilmedia.Domain.Entities;
using AsilMedia.Application.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asilmedia.Infrastructure.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly ApplicationDbContext _context;

        public PermissionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Permission> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<Permission> InsertAsync(Permission permission)
        {
            var entry = await _context.Permissions.AddAsync(permission);
            await _context.SaveChangesAsync();

            return entry.Entity; throw new NotImplementedException();
        }

        public async Task<List<Permission>> SelectAllAsync()
        {
            return await _context.Permissions.ToListAsync();
        }

        public async Task<List<Permission>> SelectAllAsync(List<long> ids)
            => await _context.Permissions.Where(x => ids.Contains(x.Id)).ToListAsync();
    }
}
