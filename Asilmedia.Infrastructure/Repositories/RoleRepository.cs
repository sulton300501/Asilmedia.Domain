using Asilmedia.Domain.Entities;
using AsilMedia.Application.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.EntityFrameworkCore;

namespace Asilmedia.Infrastructure.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Role> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<Role> InsertAsync(Role role)
        {
            var entry = await _context.AddAsync(role);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async Task<List<Role>> SelectAllAsync()
              => await _context.Roles.ToListAsync();

        public async Task<Role> SelectByIdAsync(long id)
            => await _context.Roles.FirstOrDefaultAsync(x => x.Id == id);
        public Task<Role> UpdateAsync(Role role, long id)
        {
            throw new NotImplementedException();
        }
    }
}
