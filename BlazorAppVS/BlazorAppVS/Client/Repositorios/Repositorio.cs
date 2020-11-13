﻿using BlazorAppVS.Shared.Entities;
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
                new Movie(){
                    Title = "Spider-Man: un nuevo universo", 
                    ReleaseDate = new DateTime(2020,2,2),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjMwNDkxMTgzOF5BMl5BanBnXkFtZTgwNTkwNTQ3NjM@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Movie(){
                    Title = "Ammonite", 
                    ReleaseDate = new DateTime(2019,9,2),
                    Poster = "https://m.media-amazon.com/images/M/MV5BZmM3ZGZlMWUtMjY1OS00NjBkLWE4MjQtODJkMmQ1MzdjYzhkXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Movie(){
                    Title = "Los Croods: Una nueva era", 
                    ReleaseDate = new DateTime(2015,1,2),
                    Poster = "https://m.media-amazon.com/images/M/MV5BNjUwNjdhM2UtYTcxZC00NTI4LTlhZWMtMGEzNjBiZWI1NzJiXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Movie(){
                    Title = "Monsters of Man", 
                    ReleaseDate = new DateTime(2019,2,2),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDlkYzRmODAtZjczMy00ODdjLWE4MDUtMzA5YmYwNTVlMTEyXkEyXkFqcGdeQXVyNDQ0MDAxNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg"},
            };
        }
    }
}