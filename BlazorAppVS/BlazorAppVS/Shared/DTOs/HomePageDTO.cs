using BlazorAppVS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorAppVS.Shared.DTOs
{
    public class HomePageDTO
    {
        public List<Movie> PeliculasEnCartelera { get; set; }
        public List<Movie> ProximosEstrenos { get; set; }
    }
}
