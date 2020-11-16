using BlazorAppVS.Server.Helpers;
using BlazorAppVS.Shared.DTOs;
using BlazorAppVS.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppVS.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorDeArchivos almacenadorDeArchivos;

        public MoviesController(ApplicationDbContext context, IAlmacenadorDeArchivos almacenadorDeArchivos)
        {
            this.context = context;
            this.almacenadorDeArchivos = almacenadorDeArchivos;
        }

        [HttpGet]
        public async Task<ActionResult<HomePageDTO>> Get()
        {
            var limite = 3;
            var peliculasEnCartelera = await context.Movies
                .Where(x => x.EnCartelera).Take(limite)
                .OrderByDescending(x => x.ReleaseDate)
                .ToListAsync();

            var fechaActual = DateTime.Today;
            var proximosEstrenos = await context.Movies
                .Where(x => x.ReleaseDate > fechaActual)
                .OrderBy(x => x.ReleaseDate).Take(limite)
                .ToListAsync();

            var response = new HomePageDTO()
            {
                PeliculasEnCartelera = peliculasEnCartelera,
                ProximosEstrenos = proximosEstrenos
            };

            return response;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie)
        {
            if (!string.IsNullOrWhiteSpace(movie.Poster))
            {
                var posterMmovie = Convert.FromBase64String(movie.Poster);
                movie.Poster = await almacenadorDeArchivos.GuardarArchivo(posterMmovie, "jpg", "peliculas");
            }
            context.Add(movie);
            await context.SaveChangesAsync();
            return movie.Id;
        }
    }
}
