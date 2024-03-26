using Asilmedia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Abstractions.Repositories
{
    public interface IFilmRepository
    {
        public Task<Film> InsertAsync(Film film);
        public Task<Film> SelectByIdAsync(long id);
        public Task<List<Film>> SelectAllAsync();
        public Task<Film> UpdateAsync(long id , Film film);
        public Task<Film> DeleteAsync(long id);


    }
}
