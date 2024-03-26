using AsilMedia.Application.DataTransferObject;
using Asilmedia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Services.Genres
{
    public interface IGenreService
    {
        public Task<Genre> InsertAsync(GenreDTO genreDTO);
        public Task<Genre> SelectByIdAsync(long id);
        public Task<List<Genre>> SelectAllAsync();
        public Task<Genre> UpdateAsync(GenreDTO genreDTO, long id);
        public Task<Genre> DeleteAsync(long id);
    }
}
