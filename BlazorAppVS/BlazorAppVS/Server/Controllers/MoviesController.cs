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

        [HttpGet("{id}")]
        public async Task<ActionResult<PeliculaVisualizarDTO>> Get(int id)
        {
            var pelicula = await context.Movies.Where(x => x.Id == id)
                .Include(x => x.GenderMovie).ThenInclude(x => x.Gender)
                .Include(x => x.MoviesActor).ThenInclude(x => x.People)
                .FirstOrDefaultAsync();

            if (pelicula == null)
            {
                return NotFound();
            }
            var promedioVotos = 4;
            var votoUusario = 5;

            pelicula.MoviesActor = pelicula.MoviesActor.OrderBy(x => x.Orden).ToList();

            var model = new PeliculaVisualizarDTO();
            model.Movie = pelicula;
            model.Genders = pelicula.GenderMovie.Select(x => x.Gender).ToList();
            model.Actores = pelicula.MoviesActor.Select(x =>
            new People
            {
                Nombre = x.People.Nombre,
                Foto = x.People.Foto,
                Personaje = x.Personaje,
                Id = x.PeopleId
            }).ToList();

            model.PromedioVotos = promedioVotos;
            model.VotoUsuario = votoUusario;
            return model;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie)
        {
            if (!string.IsNullOrWhiteSpace(movie.Poster))
            {
                var posterMmovie = Convert.FromBase64String(movie.Poster);
                movie.Poster = await almacenadorDeArchivos.GuardarArchivo(posterMmovie, "jpg", "peliculas");
            }

            if (movie.MoviesActor != null)
            {
                for (int i = 0; i < movie.MoviesActor.Count; i++)
                {
                    movie.MoviesActor[i].Orden = i + 1;
                }
            }
            context.Add(movie);
            await context.SaveChangesAsync();
            return movie.Id;
        }
    }
}
