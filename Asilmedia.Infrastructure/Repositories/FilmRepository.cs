using Asilmedia.Domain.Entities;
using Asilmedia.Domain.Exceptiona.Films;
using AsilMedia.Application.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asilmedia.Infrastructure.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private readonly ApplicationDbContext _context;

        public FilmRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Film> DeleteAsync(long id)
        {
            var storedFilm = await _context.Films.FirstOrDefaultAsync(x => x.Id == id);
            if (storedFilm is null)
            {
                throw new FilmNotFoundExeption();
            }
            var entry = _context.Remove(storedFilm);
            await _context.SaveChangesAsync();
            return entry.Entity;
           

        }

        public async Task<Film> InsertAsync(Film film)
        {


            EntityEntry<Film> entry = await _context.AddAsync(film);
            await _context.SaveChangesAsync();
            return entry.Entity;

           
        }

        public async  Task<List<Film>> SelectAllAsync()
            => await _context.Films.ToListAsync();
       

        public async Task<Film> SelectByIdAsync(long id)
        {
            var storedFilm = await _context.Films.FirstOrDefaultAsync(x => x.Id == id);

            if (storedFilm is null)
                throw new FilmNotFoundExeption();

            return storedFilm;





        }

        public async Task<Film> UpdateAsync(long id, Film film)
        {
            var storedFilm = await _context.Films.FirstOrDefaultAsync(x => x.Id == id);

            if (storedFilm is null)
                throw new FilmNotFoundExeption();

            storedFilm.Title = film.Title;
            storedFilm.Description = film.Description;

            var entry = _context.Update(storedFilm);
            await _context.SaveChangesAsync();
            return entry.Entity;

        }
    }
}
