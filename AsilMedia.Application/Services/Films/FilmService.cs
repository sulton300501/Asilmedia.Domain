using Asilmedia.Domain.Entities;
using AsilMedia.Application.Abstractions.Repositories;
using AsilMedia.Application.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Services.Films
{
    public class FilmService : IFilmService
    {
        private readonly IFilmRepository _filmRepository;

        public FilmService(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }


        public async Task<Film> InsertAsync(FilmDTO filmDTO)
        {
            var film = new Film()
            {
                Title = filmDTO.Title,
                Description = filmDTO.Description,
                FilmMakerId = filmDTO.FilmMakerId,
                AgeRestriction = filmDTO.AgeRestriction,
                PublishedYear = filmDTO.PublishedYear,
                PhotoPath = filmDTO.PhotoPath,
                VideoPath = filmDTO.VideoPath,
              

           };

            film = await _filmRepository.InsertAsync(film);
            return film;
        }


        public async Task<List<Film>> SelectAllAsync()
            => await _filmRepository.SelectAllAsync();
      



        public async Task<Film> DeleteAsync(long id)
            => await _filmRepository.DeleteAsync(id);
     
          

       

     

        public async Task<Film> SelectByIdAsync(long id)
            => await _filmRepository.SelectByIdAsync(id);
      

        public async Task<Film> UpdateAsync(long id, FilmDTO filmDTo)
        {
            var film = new Film()
            {
                Title = filmDTo.Title,
              
            };

           return  await _filmRepository.UpdateAsync(id, film);

        }
    }
}
