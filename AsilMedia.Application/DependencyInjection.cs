using AsilMedia.Application.Helpers;
using AsilMedia.Application.Services.Actors;
using AsilMedia.Application.Services.FilmMakers;
using AsilMedia.Application.Services.Films;
using AsilMedia.Application.Services.Genres;
using AsilMedia.Application.Services.Permissions;
using AsilMedia.Application.Services.Roles;
using AsilMedia.Application.Services.Users;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsilMedia.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<IFilmService, FilmService>();
            services.AddScoped<IFilmMakerService, FilmMakerService>();
            services.AddScoped<IActorService, ActorService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJWTService, JWTService>();
         //   services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IPermissionService, PermissionService>();
            return services;
        }
    }
}
