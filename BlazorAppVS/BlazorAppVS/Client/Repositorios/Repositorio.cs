using BlazorAppVS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppVS.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Movie> ObtenerPeliculas()
        {
            return new List<Movie>()
            {
                new Movie(){Title = "Movie 1", ReleaseDate = new DateTime(2020,2,2) },
                new Movie(){Title = "Movie 2", ReleaseDate = new DateTime(2019,9,2) },
                new Movie(){Title = "Movie 3", ReleaseDate = new DateTime(2015,1,2) },
                new Movie(){Title = "Movie 4", ReleaseDate = new DateTime(2019,2,2) },
            };
        }
    }
}
