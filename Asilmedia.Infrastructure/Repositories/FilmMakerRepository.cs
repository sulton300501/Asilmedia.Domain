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
    public class FilmMakerRepository : IFilmMakerRepository
    {
        private readonly ApplicationDbContext _context;

        public FilmMakerRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<FilmMaker> DeleteAsync(long id)
        {
            var result = await _context.FilmMaker.FirstOrDefaultAsync(x => x.Id == id);
            if(result == null)
            {
                throw new FilmMakerNotFound();
            }
             _context.Remove(result);
            await _context.SaveChangesAsync();
            return result;

        }

        public async Task<FilmMaker> InsertAsync(FilmMaker filmMaker)
        {
            var result = await _context.AddAsync(filmMaker);
            await  _context.SaveChangesAsync();
            return result.Entity;

        }

      

        public async Task<List<FilmMaker>> SelectAllAsync()
        {
           var result = await _context.FilmMaker.Include(x=>x.Films).ToListAsync();
            return result;
        }

        public async Task<FilmMaker> SelectByIdAsync(long id)
        {
          var filmMaker = await _context.FilmMaker
                .Include(x=>x.Films)
                .FirstOrDefaultAsync(x=>x.Id==id);

            if(filmMaker is null)
            {
                throw new FilmMakerNotFound();
            }
            return filmMaker;






        }

        public async Task<FilmMaker> UpdateAsync(FilmMaker NewfilmMaker, long id)
        {
            var filmMaker = await _context.FilmMaker.FirstOrDefaultAsync(x => x.Id == id);


            if (filmMaker is null)
                throw new FilmMakerNotFound();

            //mapping
            filmMaker.FirstName = NewfilmMaker.FirstName;
            filmMaker.LastName = NewfilmMaker.LastName;
            filmMaker.Gender = NewfilmMaker.Gender;
            filmMaker.Films = NewfilmMaker.Films;
            filmMaker.Description = NewfilmMaker.Description;
            filmMaker.PhotoPath = NewfilmMaker.PhotoPath;
            ///...

            var entry = _context.Update(filmMaker);
            await _context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
