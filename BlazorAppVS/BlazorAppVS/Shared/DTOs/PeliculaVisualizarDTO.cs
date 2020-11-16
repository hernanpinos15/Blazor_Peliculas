using BlazorAppVS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorAppVS.Shared.DTOs
{
    public class PeliculaVisualizarDTO
    {
        public Movie Movie { get; set; }
        public List<Gender> Genders { get; set; }
        public List<People> Actores { get; set; }
        public int VotoUsuario { get; set; }
        public double PromedioVotos { get; set; }
    }
}
