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
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> DeleteAsync(long id)
        {
          var result = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            _context.Users.Remove(result);
            await _context.SaveChangesAsync();
            return result;
        }

        public async Task<User> InsertAsync(User user)
        {
            var result = await _context.Users.AddAsync(user);
             _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<List<User>> SelectAllAsync()
        {
          return await _context.Users
                .Include(x=>x.Role)
                .ToListAsync();
        }

        public async Task<User> SelectByIdAsync(long id)
        {

            return await _context.Users
                .Include(x => x.Role)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User> SelectByIdAsync(string passwordHash, string email)
          => await _context.Users
            .Include(x => x.Role)
            .FirstOrDefaultAsync(x=>x.PasswordHash==passwordHash && x.Email==email);
      
        
        public Task<User> UpdateAsync(User user, long id)
        {
            throw new NotImplementedException();
        }
    }
}
