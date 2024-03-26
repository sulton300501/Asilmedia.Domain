using Asilmedia.Domain.Entities;
using Asilmedia.Domain.Entities;
using Asilmedia.Domain.Exceptions.Films;
using AsilMedia.Application.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asilmedia.Infrastructure.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private readonly ApplicationDbContext _context;

        public ActorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Actor> DeleteAsync(long id)
        {
           var result = await _context.Actors.FirstOrDefaultAsync(x=>x.Id == id);

          
            if(result is null)
            {
                throw new ActorNotFoundException();
            }

            var entry = _context.Remove(result);
            await _context.SaveChangesAsync();
            return entry.Entity;




        }

        public async Task<Actor> InsertAsync(Actor film)
        {
          var result = await _context.AddAsync(film);
          await _context.SaveChangesAsync();
            return result.Entity;
        }
        

        public Task<List<Actor>> SelectAllAsync()
        {
           return _context.Actors.ToListAsync();
        }

        public async Task<Actor> SelectByIdAsync(long id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);


            if (result is null)
            {
                throw new ActorNotFoundException();
            }

            return result;
          
        }

        public async Task<Actor> UpdateAsync(long id, Actor film)
        {

            var result = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);


            if (result is null)
            {
                throw new ActorNotFoundException();
            }

            var actor = new Actor()
            {
                FirstName = film.FirstName,
                LastName = film.LastName,
            };

            var result2 =  _context.Update(actor);
            await _context.SaveChangesAsync();
            return result2.Entity;
        }
    }
}
