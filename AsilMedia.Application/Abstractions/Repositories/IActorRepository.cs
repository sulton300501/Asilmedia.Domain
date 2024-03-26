using Asilmedia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Abstractions.Repositories
{
    public interface IActorRepository
    {
        public Task<Actor> InsertAsync(Actor film);
        public Task<Actor> SelectByIdAsync(long id);
        public Task<List<Actor>> SelectAllAsync();
        public Task<Actor> UpdateAsync(long id, Actor film);
        public Task<Actor> DeleteAsync(long id);
    }
}
