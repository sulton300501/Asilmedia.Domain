using AsilMedia.Application.DataTransferObject;
using Asilmedia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Services.Actors
{
    public interface IActorService
    {
        public Task<Actor> InsertAsync(ActorDTO filmDTO);
        public Task<Actor> SelectByIdAsync(long id);
        public Task<List<Actor>> SelectAllAsync();
        public Task<Actor> UpdateAsync(ActorDTO filmDTO, long id);
        public Task<Actor> DeleteAsync(long id);
    }
}
