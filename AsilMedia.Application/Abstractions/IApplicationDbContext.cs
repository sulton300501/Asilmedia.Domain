﻿using Asilmedia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application.Abstractions
{
    public interface IApplicationDbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<FilmMaker> FilmMakers { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        public ValueTask<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
