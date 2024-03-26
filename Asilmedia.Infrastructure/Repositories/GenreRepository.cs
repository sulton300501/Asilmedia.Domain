using Asilmedia.Domain.Entities;
using AsilMedia.Application.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asilmedia.Domain.Exceptions.Films;

namespace Asilmedia.Infrastructure.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Genre> DeleteAsync(long id)
        {
            var storedGenre = await _context.Genres.FirstOrDefaultAsync(x => x.Id == id);

            if (storedGenre is null)
                throw new GenreNotFoundExeption();

            var entry = _context.Remove(storedGenre);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async Task<Genre> InsertAsync(Genre genre)
        {
            EntityEntry<Genre> entry = await _context.Genres.AddAsync(genre);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        public async Task<List<Genre>> SelectAllAsync()
           => await _context.Genres.ToListAsync();

        public async Task<List<Genre>> SelectAllAsync(List<long> ids)
         => await _context.Genres.Where(x => ids.Contains(x.Id)).ToListAsync();

        public async Task<Genre> SelectByIdAsync(long id)
        {
            var model = await _context.Genres.FirstOrDefaultAsync(x => x.Id == id);

            if (model is null)
                throw new GenreNotFoundExeption();

            return model;
        }

        public async Task<Genre> UpdateAsync(Genre genre, long id)
        {
            var storedGenre = await _context.Genres.FirstOrDefaultAsync(x => x.Id == id);

            if (storedGenre is null)
                throw new GenreNotFoundExeption();

            storedGenre.Name = genre.Name;

            EntityEntry<Genre> entry = _context.Genres.Update(storedGenre);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
