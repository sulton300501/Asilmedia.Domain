using Asilmedia.Domain.Entities;
using AsilMedia.Application.Abstractions.Repositories;
using AsilMedia.Application.DataTransferObject;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Services.Actors
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }
        public async Task<Actor> DeleteAsync(long id)
        {
            var result = await _actorRepository.DeleteAsync(id);
            return result;
        }

        public async Task<Actor> InsertAsync(ActorDTO filmDTO)
        {
            var result =  filmDTO.Adapt<Actor>();

            return await _actorRepository.InsertAsync(result);
        }

        public async Task<List<Actor>> SelectAllAsync()
            => await _actorRepository.SelectAllAsync();
        

        public async Task<Actor> SelectByIdAsync(long id)
              => await _actorRepository.SelectByIdAsync(id);

        public async Task<Actor> UpdateAsync(ActorDTO filmDTO, long id)
        {
            var result = filmDTO.Adapt<Actor>();
            return await _actorRepository.UpdateAsync(id, result);
        }
    }
}
