using Asilmedia.Domain.Entities;
using AsilMedia.Application.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Services.Films
{
    public interface IFilmService
    {
        public Task<Film> InsertAsync(FilmDTO filmDTO);
        public Task<Film> SelectByIdAsync(long id);
        public Task<List<Film>> SelectAllAsync();
        public Task<Film> UpdateAsync(long id, FilmDTO filmDTO);
        public Task<Film> DeleteAsync(long id);

    }
}
