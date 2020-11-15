using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorAppVS.Shared.Entities
{
    public class People
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Biografia { get; set; }
        public string Foto { get; set; }
        [Required]
        public DateTime? FechaNacimiento { get; set; }
        public List<MovieActor> MoviesActor { get; set; }

    }
}
